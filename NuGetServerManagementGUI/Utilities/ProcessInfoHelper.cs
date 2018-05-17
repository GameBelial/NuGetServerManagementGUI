using System;
using System.Diagnostics;
using System.IO;

namespace NuGetServerManagementGUI.Utilities
{
    /// <summary>
    /// NuGet 进程创建辅助类
    /// </summary>
    public static class ProcessHelper
    {
        private static readonly string _nugetFilePath = Path.Combine(Environment.CurrentDirectory, "nuget.exe");

        /// <summary>
        /// 生成一个新的 NuGet 启动进程信息
        /// </summary>
        /// <param name="args">提交的参数</param>
        /// <param name="handler">输出流处理委托</param>
        /// <returns>创建成功的进程信息</returns>
        public static Process GenerateNuGetProcess(string args, DataReceivedEventHandler handler)
        {
            var newProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _nugetFilePath,
                    Arguments = args,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };

            newProcess.ErrorDataReceived += handler;
            newProcess.OutputDataReceived += handler;

            return newProcess;
        }
    }
}