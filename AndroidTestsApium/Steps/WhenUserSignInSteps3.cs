using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class WhenUserSignInSteps3
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly WhenSignIn3 _user3;

        public WhenUserSignInSteps3(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _user3 = new WhenSignIn3(_androidDriver);
        }

        [When(@"I tap to the Last Name Field")]
        public void WhenITapToTheLastNameField()
        {
            _user3.TapLastName();
        }
        
        [When(@"I select a button ok")]
        public void WhenISelectAButtonOk()
        {
            _user3.TapOkLast();
        }
        
        [Then(@"I see  a shaging last name")]
        public void ThenISeeAShagingLastName()
        {
            string text = _user3.TextLast();
            bool result = text.Contains(text);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
