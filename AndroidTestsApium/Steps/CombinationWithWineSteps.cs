using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class CombinationWithWineSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly CombinationWithWine _combinationWithWine;

        public CombinationWithWineSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _combinationWithWine = new CombinationWithWine(_androidDriver);
        }

        [When(@"I tap ""(.*)"" subsection")]
        public void WhenITapSubsection(string pairing)
        {
            _combinationWithWine.Pairing(pairing);
        }
        
        [When(@"I tap ""(.*)"" pair")]
        public void WhenITapPair(string pair)
        {
            _combinationWithWine.SelectPair(pair);
        }
        
        [Then(@"I see a information text ""(.*)""")]
        public void ThenISeeAInformationText(string pairInfo)
        {
            Assert.AreEqual(actual: _combinationWithWine.InfoAboutPair(pairInfo), expected: pairInfo);
        }
        
        [Then(@"I see a text with the count of wines ""(.*)""")]
        public void ThenISeeATextWithTheCountOfWines(string wine)
        {
            Assert.AreEqual(actual: _combinationWithWine.CountWine(wine), expected: wine);
        }
    }
}
