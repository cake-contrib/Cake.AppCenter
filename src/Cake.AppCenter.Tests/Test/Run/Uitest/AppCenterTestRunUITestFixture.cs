using Cake.Testing;

namespace Cake.AppCenter.Tests.Test.Run.UITest;

public class AppCenterTestRunUITestFixture : ToolFixture<AppCenterTestRunUitestSettings>, ICakeContext
{
    public string[] Services { get; set; } = new string[0];
    IFileSystem ICakeContext.FileSystem => FileSystem;
    ICakeEnvironment ICakeContext.Environment => Environment;
    ICakeLog ICakeContext.Log { get; } = new FakeLog();
    ICakeArguments ICakeContext.Arguments => throw new NotImplementedException();
    IProcessRunner ICakeContext.ProcessRunner => ProcessRunner;
    public IRegistry Registry => Registry;
    public ICakeDataResolver Data => throw new NotImplementedException();
    ICakeConfiguration ICakeContext.Configuration => throw new NotImplementedException();
    public AppCenterTestRunUITestFixture(): base("appcenter")
    {
        ProcessRunner.Process.SetStandardOutput(new string[] { });
    }
    protected override void RunTool()
    {
        this.AppCenterTestRunUitest(Settings);
    }
}
