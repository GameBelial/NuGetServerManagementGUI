using System;
using System.IO;
using NuGetServerManagementGUI.Configuration;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NuGetServerManagementGUI.Forms
{
    public partial class SettingWindow : Form
    {
        private readonly IGlobalConfiguration _configuration;

        public SettingWindow()
        {
            _configuration = Program.IocContainer.Resolve<IGlobalConfiguration>();

            InitializeComponent();
        }

        private void button_SaveAndApplySettings_Click(object sender, System.EventArgs e)
        {
            _configuration.NuGetServerAddress = textBox_ServerAddress.Text;
            _configuration.NuGetServerApiKey = textBox_ServerApiKey.Text;

            // 保存设置
            var settingFilePath = Path.Combine(Environment.CurrentDirectory, "settings.json");
            FileStream settingFileStream;

            if (File.Exists(settingFilePath))
            {
                settingFileStream = File.Open(settingFilePath, FileMode.Open);
            }
            else
            {
                settingFileStream = File.Create(settingFilePath);
            }

            using (settingFileStream)
            {
                settingFileStream.Position = 0;
                using (var writer = new StreamWriter(settingFileStream))
                {
                    writer.Write(JsonConvert.SerializeObject(_configuration));
                    writer.Flush();
                }
            }

            Close();
        }

        private void SettingWindow_Load(object sender, System.EventArgs e)
        {
            var configuration = Program.IocContainer.Resolve<IGlobalConfiguration>();

            textBox_ServerAddress.Text = configuration.NuGetServerAddress;
            textBox_ServerApiKey.Text = configuration.NuGetServerApiKey;
        }
    }
}
