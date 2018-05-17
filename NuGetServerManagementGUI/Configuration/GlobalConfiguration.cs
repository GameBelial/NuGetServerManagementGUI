namespace NuGetServerManagementGUI.Configuration
{
    /// <summary>
    /// 全局配置
    /// </summary>
    public interface IGlobalConfiguration
    {
        /// <summary>
        /// NuGet 服务器地址
        /// </summary>
        string NuGetServerAddress { get; set; }
        /// <summary>
        /// NuGet 服务器 APIKey
        /// </summary>
        string NuGetServerApiKey { get; set; }
    }

    /// <inheritdoc />
    public class GlobalConfiguration : IGlobalConfiguration
    {
        /// <inheritdoc />
        public string NuGetServerAddress { get; set; }

        /// <inheritdoc />
        public string NuGetServerApiKey { get; set; }
    }
}
