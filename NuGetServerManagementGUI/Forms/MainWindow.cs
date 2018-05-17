using Newtonsoft.Json;
using NuGetServerManagementGUI.Configuration;
using NuGetServerManagementGUI.Utilities;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuGetServerManagementGUI.Forms
{
    public partial class MainWindow : Form
    {
        private readonly IGlobalConfiguration _configuration;
        private readonly ICommandGenerateHelper _commandGenerateHelper;

        public MainWindow(IGlobalConfiguration configuration, ICommandGenerateHelper commandGenerateHelper)
        {
            _configuration = configuration;
            _commandGenerateHelper = commandGenerateHelper;
            InitializeComponent();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            await InitializeConfiguration();
        }

        /// <summary>
        /// 初始化配置项
        /// </summary>
        private async Task InitializeConfiguration()
        {
            var settingFilePath = Path.Combine(Environment.CurrentDirectory, "settings.json");
            var nugetFilePath = Path.Combine(Environment.CurrentDirectory, "NuGet.exe");

            if (!File.Exists(settingFilePath))
            {
                using (var file = File.Create(settingFilePath))
                {
                    using (var writer = new StreamWriter(file))
                    {
                        var jsonStr = JsonConvert.SerializeObject(_configuration);
                        await writer.WriteAsync(jsonStr);
                    }
                }
            }
            else
            {
                using (var file = File.Open(settingFilePath, FileMode.Open))
                {
                    using (var reader = new StreamReader(file))
                    {
                        // TODO: why readtoendasync is block ?
                        string jsonStr = await reader.ReadToEndAsync();
                        var jsonObj = JsonConvert.DeserializeObject<GlobalConfiguration>(jsonStr);

                        _configuration.NuGetServerAddress = jsonObj.NuGetServerAddress;
                        _configuration.NuGetServerApiKey = jsonObj.NuGetServerApiKey;
                    }
                }
            }

            // NuGet 文件拷贝
            if (!File.Exists(nugetFilePath))
            {
                using (var file = File.Create(nugetFilePath))
                {
                    #region Code
                    //const int bufferSize = 4 * 1024;
                    //for (int i = 0; i < Properties.Resources.nuget.Length; i += bufferSize)
                    //{
                    //    if (Properties.Resources.nuget.Length - i < bufferSize)
                    //    {
                    //        var copyIndex = Properties.Resources.nuget.Length - bufferSize;
                    //        var copyCount = Properties.Resources.nuget.Length - i;

                    //        await file.WriteAsync(Properties.Resources.nuget, copyIndex, copyCount);
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        await file.WriteAsync(Properties.Resources.nuget, i, bufferSize);
                    //    }
                    //}
                    #endregion

                    await file.WriteAsync(Properties.Resources.nuget, 0, Properties.Resources.nuget.Length);
                }
            }
        }

        private void button_UpdateNuGetList_Click(object sender, EventArgs e)
        {
            listView_NuGetPackages.Items.Clear();
            textBox_ConsoleWindow.Text = string.Empty;

            var args = _commandGenerateHelper.GenerateGetListCommand();
            var process = ProcessHelper.GenerateNuGetProcess(args, Process_OutputDataReceived);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            // 填充 ListView
            string[] packages = textBox_ConsoleWindow.Text.Split(new[] { "\r\n" }, StringSplitOptions.None).Where(z => !string.IsNullOrWhiteSpace(z)).ToArray();

            foreach (var package in packages)
            {
                string[] packageInfo = package.Split(' ');
                listView_NuGetPackages.Items.Add(new ListViewItem(new[] { packageInfo[0], packageInfo[1] }));
            }

            process.Close();
        }

        private void TopMenu_ServerSettings_Click(object sender, EventArgs e)
        {
            Program.IocContainer.Resolve<SettingWindow>().ShowDialog();
        }

        private void button_deleteSelectPackages_Click(object sender, EventArgs e)
        {
            textBox_ConsoleWindow.Text = string.Empty;

            progressBar1.Maximum = listView_NuGetPackages.SelectedItems.Count;
            foreach (ListViewItem package in listView_NuGetPackages.SelectedItems)
            {
                var args = _commandGenerateHelper.GenerateDeleteCommand(package.SubItems[0].Text,
                    package.SubItems[1].Text);
                var process = ProcessHelper.GenerateNuGetProcess(args, Process_OutputDataReceived);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.StandardInput.WriteLine("y");
                process.WaitForExit();
                process.Close();
                progressBar1.Value += 1;
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            textBox_ConsoleWindow.AppendText($"{e.Data}\r\n");
        }

        private void button_UploadPackages_Click(object sender, EventArgs e)
        {
            textBox_ConsoleWindow.Text = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog { Multiselect = true };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Maximum = fileDialog.FileNames.Length;

                foreach (var filePath in fileDialog.FileNames)
                {
                    var args = _commandGenerateHelper.GeneratePushCommand(filePath);
                    var process = ProcessHelper.GenerateNuGetProcess(args, Process_OutputDataReceived);

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();
                    process.Close();

                    progressBar1.Value += 1;
                }
            }
        }
    }
}