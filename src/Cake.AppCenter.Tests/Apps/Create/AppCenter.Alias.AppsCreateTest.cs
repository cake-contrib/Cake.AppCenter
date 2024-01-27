using Cake.AppCenter;

namespace Cake.MobilityCenter.Tests.Apps.Create
{
    [TestFixture]
    public class AppCenter
    {
        [Test]
        public void WhenTokenAndPlatformAreSet_CommandLineIsCorrect()
        {
            var fixture = new AppCenterAppsCreateFixture
            {
                Settings = new AppCenterAppsCreateSettings { Platform = "x86", Token = "AlfaBeta" }
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("apps create --platform \"x86\" --token \"AlfaBeta\""));
        }

        [Test]
        public void WhenArgumentCustomizationIsUsed_CommandLineIsCorrect()
        {
            var fixture = new AppCenterAppsCreateFixture
            {
                Settings = new AppCenterAppsCreateSettings { Platform = "x86", Token = "AlfaBeta", 
                    ArgumentCustomization = args => args.Append("--debug")
                }
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("apps create --platform \"x86\" --token \"AlfaBeta\" --debug"));
        }
    }
}
