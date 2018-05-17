using NuGetServerManagementGUI.Configuration;

namespace NuGetServerManagementGUI.Utilities
{
    /// <summary>
    /// 命令生成辅助类
    /// </summary>
    public interface ICommandGenerateHelper
    {
        /// <summary>
        /// 生成推送 NuGet 包的命令
        /// </summary>
        /// <param name="filePath">待推送的 NuGet 包</param>
        /// <returns></returns>
        string GeneratePushCommand(string filePath);
        /// <summary>
        /// 生成删除 NuGet 包的命令
        /// </summary>
        /// <param name="packageName">包名</param>
        /// <param name="packageVersion">要删除的包版本</param>
        string GenerateDeleteCommand(string packageName, string packageVersion);
        /// <summary>
        /// 生成获取 NuGet 包列表的命令
        /// </summary>
        string GenerateGetListCommand();
    }

    public class CommandGenerateHelper : ICommandGenerateHelper
    {
        private readonly IGlobalConfiguration _configuration;

        public CommandGenerateHelper(IGlobalConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GeneratePushCommand(string filePath) => $"push {filePath} -source {_configuration.NuGetServerAddress} -apikey {_configuration.NuGetServerApiKey}";

        public string GenerateDeleteCommand(string packageName, string packageVersion) => $"delete {packageName} {packageVersion} -source {_configuration.NuGetServerAddress} -apikey {_configuration.NuGetServerApiKey}";

        public string GenerateGetListCommand() => $"list -source {_configuration.NuGetServerAddress}";
    }
}