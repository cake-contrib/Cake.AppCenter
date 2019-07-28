using NUnit.Framework;

namespace Cake.AppCenter.Tests.Test.Run.Uitest
{
    [TestFixture]
    public class AppCenterTestRunUitestTest
    {
        [Test]
		public void WhenTwoIncludeCategoriesAreUsed_IncludeBothInCommandLine()
        {
            var fixture = new AppCenterTestRunUitestFixture
            {
                Settings = new AppCenterTestRunUitestSettings { IncludeCategory = new[] { "one", "two" } }
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("test run uitest --include-category \"one\" --include-category \"two\""));
        }
    }
}
