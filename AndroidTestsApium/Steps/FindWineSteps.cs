using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium
{
    [Binding]
    public class FindWineSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly FindWinesPage _findWinesPage;

        public FindWineSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _findWinesPage = new FindWinesPage(_driver);
        }

        [When(@"I tap Search field")]
        public void WhenITapSearchField()
        {
            _findWinesPage.SearchFieldClick();
        }

        [When(@"I input ""([^""]*)""")]
        public void WhenIInput(string inputTetx)
        {
            _findWinesPage.SerchFieldInput(inputTetx);
        }

        [When(@"I tap Search button")]
        public void WhenITapSearchButton()
        {
            _findWinesPage.SearchButtonClick();
        }

        [When(@"I tap for second wine in list for search")]
        public void WhenITapForSecondWineInListForSearch()
        {
            _findWinesPage.SecondProductCardClick();
        }

        [Then(@"Search result ""([^""]*)"" opens")]
        public void ThenSearchResultOpens(string title)
        {
            Assert.AreEqual(actual: _findWinesPage.NameProductText(title), expected: title);
        }
    }
}
