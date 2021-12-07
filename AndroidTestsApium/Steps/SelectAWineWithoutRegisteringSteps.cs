using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class SelectAWineWithoutRegisteringSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly SelectAWineWithoutRegistering _selectAWineWithoutRegistering;

        public SelectAWineWithoutRegisteringSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _selectAWineWithoutRegistering = new SelectAWineWithoutRegistering(_androidDriver);
        }

        [When(@"I tap Search section")]
        public void WhenITapSearchSection()
        {
            _selectAWineWithoutRegistering.SearchPage();
        }

        [When(@"I tap ""(.*)"" type")]
        public void WhenITapType(string red)
        {
            _selectAWineWithoutRegistering.RedWineSelect(red);
        }
        
        [Then(@"I see a info text ""(.*)""")]
        public void ThenISeeAInfoText(string redWineText)
        {  
            Assert.AreEqual(actual: _selectAWineWithoutRegistering.RedTextInfo(redWineText), expected: redWineText);
        }

        [Then(@"I see text with the count of wines ""(.*)""")]
        public void ThenISeeTextWithTheCountOfWines(string count)
        {
            Assert.AreEqual(actual: _selectAWineWithoutRegistering.RedWineCountText(count), expected: count);
        }
    }
}
