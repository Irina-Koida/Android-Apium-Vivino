using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class WhenUserSignInSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly WhenSignIn _user;

        public WhenUserSignInSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _user = new WhenSignIn(_androidDriver);
        }

        [When(@"Tap the Friends icon, it looks like a people avatar")]
        public void WhenTapTheFriendsIconItLooksLikeAPeopleAvatar()
        {
            _user.FriendsPage();
        }
        
        [Then(@"I see  a text ""(.*)""")]
        public void ThenISeeAText(string text)
        {
            Assert.AreEqual(actual: _user.SomeText(text), expected: text);
        }
    }
}
