using MicroResolver;
using NuGetServerManagementGUI.Configuration;
using NuGetServerManagementGUI.Forms;
using NuGetServerManagementGUI.Utilities;
using System;
using System.Windows.Forms;

namespace NuGetServerManagementGUI
{
    public static class Program
    {
        public static ObjectResolver IocContainer = ObjectResolver.Create();

        [STAThread]
        static void Main()
        {
            // 类型注册
            RegisterType();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(IocContainer.Resolve<MainWindow>());
        }

        static void RegisterType()
        {
            IocContainer.Register<MainWindow, MainWindow>(Lifestyle.Transient);
            IocContainer.Register<SettingWindow, SettingWindow>(Lifestyle.Transient);
            IocContainer.Register<IGlobalConfiguration, GlobalConfiguration>(Lifestyle.Singleton);
            IocContainer.Register<ICommandGenerateHelper, CommandGenerateHelper>(Lifestyle.Transient);
            IocContainer.Compile();
        }
    }
}