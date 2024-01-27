namespace Cake.AppCenter.Tests.Test.Run.UITest;

[TestFixture]
public class AppCenterTestRunUITestTest
{
    [Test]
		public void WhenTwoIncludeCategoriesAreUsed_IncludeBothInCommandLine()
    {
        var fixture = new AppCenterTestRunUITestFixture
        {
            Settings = new AppCenterTestRunUitestSettings { IncludeCategory = new[] { "one", "two" } }
        };

        var actual = fixture.Run();
        Assert.That(actual.Args, Is.EqualTo("test run uitest --include-category \"one\" --include-category \"two\""));
    }
}
