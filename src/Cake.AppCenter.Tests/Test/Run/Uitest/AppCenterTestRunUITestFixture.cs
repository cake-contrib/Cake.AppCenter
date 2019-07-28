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
        public string Path { get; set; }
        IFileSystem fileSystem;
        ICakeEnvironment environment;
        IFileSystem ICakeContext.FileSystem => fileSystem;
        ICakeEnvironment ICakeContext.Environment => environment;
        public ICakeLog Log => Log;
        ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
        IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
        public IRegistry Registry => Registry;
        public ICakeDataResolver Data => throw new NotImplementedException();
        ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();

        public AppCenterTestRunUitestFixture(): base("appcenter")
        {
            Tools = Substitute.For<IToolLocator>();
            fileSystem = Substitute.For<IFileSystem>();
            environment = Substitute.For<ICakeEnvironment>();
            var toolPath = new FilePath("appcenter");
            var file = Substitute.For<IFile>();
            file.Exists.Returns(true);
            fileSystem.GetFile(toolPath).Returns(file);
            environment.WorkingDirectory.Returns("C:/Temp");
            Tools.Resolve("appcenter").Returns(toolPath);
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
        protected override void RunTool()
        {
            this.AppCenterTestRunUitest(Settings);
        }
    }
}
