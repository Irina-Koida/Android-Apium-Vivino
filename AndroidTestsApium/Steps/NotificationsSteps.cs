using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class NotificationsSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly Notifications _notifications;

        public NotificationsSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _notifications = new Notifications(_androidDriver);
        }

        [When(@"Tap the Notifications icon, it looks like a bell in the upper right corner")]
        public void WhenTapTheNotificationsIconItLooksLikeABellInTheUpperRightCorner()
        {
            _notifications.TapABell();
        }

        [Then(@"I see text ""(.*)""")]
        public void ThenISeeText(string info)
        {
            Assert.AreEqual(actual: _notifications.InfoText(info), expected: info);
        }
    }
}
