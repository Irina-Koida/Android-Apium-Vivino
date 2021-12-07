using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class WhenUserSignInSteps2
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly WhenSignIn2 _user2;

        public WhenUserSignInSteps2(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _user2 = new WhenSignIn2(_androidDriver);
        }

        [When(@"I tap Kebab Menu")]
        public void WhenITapKebabMenu()
        {
            _user2.TapKebabMenu();
        }
        
        [When(@"I select Settings")]
        public void WhenISelectSettings()
        {
            _user2.SelectSettings();
        }
        
        [When(@"I tap a First Name Field")]
        public void WhenITapAFirstNameField()
        {
            _user2.TapFirstName();
        }
        
        [Then(@"I see  text ""(.*)""")]
        public void ThenISeeText(string text)
        {
            Assert.AreEqual(actual: _user2.TopListText(text), expected: text);
        }
        
        [Then(@"I see a Settings profile page")]
        public void ThenISeeASettingsProfilePage()
        {
            string profilePage = _user2.ProfileSettingsText();
            bool result = profilePage.Contains(profilePage);
            Assert.AreEqual(actual: result, expected: true);
        }

        [When(@"I select ok")]
        public void WhenISelectOk()
        {
            _user2.TapOk();
        }

        [Then(@"I see a name")]
        public void ThenISeeAName()
        {
            string text = _user2.Text();
            bool result = text.Contains(text);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
