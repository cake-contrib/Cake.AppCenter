using System;
using Cake.Testing.Fixtures;
using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.AppCenter;
using Cake.Core.IO;
using Cake.Core.Tooling;
using NSubstitute;
using Cake.Core.Configuration;

namespace Cake.AppCenter.Tests.Test.Run.Uitest
{
    public class AppCenterTestRunUitestFixture : ToolFixture<AppCenterTestRunUitestSettings>, ICakeContext
    {
        public string[] Services { get; set; } = new string[0];
        IFileSystem ICakeContext.FileSystem => FileSystem;
        ICakeEnvironment ICakeContext.Environment => Environment;
        public ICakeLog Log => Log;
        ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
        public IRegistry Registry => Registry;
        public ICakeDataResolver Data => throw new NotImplementedException();
        ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();
        public AppCenterTestRunUitestFixture(): base("appcenter")
        {
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
        protected override void RunTool()
        {
            this.AppCenterTestRunUitest(Settings);
        }
    }
}
