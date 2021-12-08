using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;
using AndroidTestsApium.POM;

namespace AndroidTestsApium
{
    [Binding]
    public class SearchSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly SearchPage _searchPage;
        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _searchPage = new SearchPage(_driver);
        }

        [When(@"I tap Search item")]
        public void WhenITapSearchItem()
        {
            _searchPage.SearchItemMenu();
        }

        [When(@"I tap Type item")]
        public void WhenITapTypeItem()
        {
            _searchPage.TypeItemHeaderMenu();
        }

        [When(@"I tap Red type")]
        public void WhenITapRedType()
        {
            _searchPage.RedTypeChoose();
        }

        [When(@"I tap first product card")]
        public void WhenITapFirstProductCard()
        {
            _searchPage.FirstProduct();
        }
        [Then(@"Product card with title ""([^""]*)"" opens")]
        public void ThenProductCardWithTitleOpens(string nameOfWine)
        {
            Assert.AreEqual(actual: _searchPage.RedTextInfo(nameOfWine), expected: nameOfWine);
        }

        [When(@"I tap on Calculate your personal match button")]
        public void WhenITapOnCalculateYourPersonalMatchButton()
        {
            _searchPage.PersonalMatchProduct();
        }

        [Then(@"Message window with title ""([^""]*)"" opens")]
        public void ThenMessageWindowWithTitleOpens(string title)
        {
            Assert.AreEqual(actual: _searchPage.MatchProductText(title), expected: title);
        }
    }
}
