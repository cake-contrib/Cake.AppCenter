using System;
using Cake.AppCenter;
using Cake.Core;
using Cake.Core.Configuration;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Testing.Fixtures;

namespace Cake.MobilityCenter.Tests.Apps.Create
{
    public class AppCenterAppsCreateFixture : ToolFixture<AppCenterAppsCreateSettings>, ICakeContext
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
        public AppCenterAppsCreateFixture(): base("appcenter")
        {
            ProcessRunner.Process.SetStandardOutput(new string[] { });
        }
        protected override void RunTool()
        {
            this.AppCenterAppsCreate(Settings);
        }
    }
}
