using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;
using System.Collections.Generic;

namespace Cake.AppCenter
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSettings"></typeparam>
    public class GenericRunner<TSettings> : AppCenterTool<TSettings>
        where TSettings : AutoToolSettings, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileSystem"></param>
        /// <param name="environment"></param>
        /// <param name="processRunner"></param>
        /// <param name="tools"></param>
        public GenericRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools)
        {
        }

        /// <summary>
        /// Runs given <paramref name="command"/> using given <paramref name=" settings"/> and <paramref name="additional"/>.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="additional">Additional arguments.</param>
        public void Run(string command, TSettings settings, string[] additional)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }
            if (additional == null)
            {
                throw new ArgumentNullException(nameof(additional));
            }
            Run(settings, GetArguments(command, settings, additional));
        }
        /// <summary>
        /// Runs given <paramref name="command"/> using given <paramref name=" settings"/> and <paramref name="additional"/> and returns the exit code and output.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="additional">Additional arguments.</param>
        /// <returns>A <see cref="ValueTuple"/> containing ExitCode, Output and Errors.</returns>
        public IEnumerable<string> RunWithResult(string command, TSettings settings, string[] additional)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException(nameof(command));
            }
            if (settings == null)
            {
                throw new ArgumentNullException(nameof(settings));
            }
            if (additional == null)
            {
                throw new ArgumentNullException(nameof(additional));
            }
            var process  = RunProcess(settings, GetArguments(command, settings, additional), new ProcessSettings { RedirectStandardError = false, RedirectStandardOutput = true });
            process.WaitForExit();
            ProcessExitCode(process.GetExitCode());
            return process.GetStandardOutput(); ;
        }

        private ProcessArgumentBuilder GetArguments(string command, TSettings settings, string[] containers)
        {
            var builder = new ProcessArgumentBuilder();
            builder.AppendAll(command, settings, containers);
            return builder;
        }
    }
}
