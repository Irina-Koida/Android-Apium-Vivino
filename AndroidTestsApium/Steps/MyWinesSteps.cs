using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium
{
    [Binding]
    public class MyWinesSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly MyWinesPage _myWinesPage;
        public MyWinesSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _myWinesPage = new MyWinesPage(_driver);
        }

        [When(@"I tap on My Wines item menu")]
        public void WhenITapOnMyWinesItemMenu()
        {
            _myWinesPage.MyWinesMenuClick();
        }

        [When(@"I tap on added wine")]
        public void WhenITapOnAddedWine()
        {
            _myWinesPage.AddWineClick();
        }

        [When(@"I tap on bottle of wine")]
        public void WhenITapOnBottleOfWine()
        {
            _myWinesPage.BottleOfWinoClick();
        }

        [When(@"I tap buy button")]
        public void WhenITapBuyButton()
        {
            _myWinesPage.ClickBuyButton();
        }

        [When(@"I tap Add to cart button")]
        public void WhenITapAddToCartButton()
        {
            _myWinesPage.AddToCardClick();
        }

        [Then(@"Order with name of wine ""([^""]*)"" opens")]
        public void ThenOrderWithNameOfWineOpens(string wineName)
        {
            Assert.AreEqual(actual: _myWinesPage.NameProductText(wineName), expected: wineName);
        }

        //[Then(@"Order with total price ""([^""]*)""of wine opens")]
        //public void ThenOrderWithTotalPriceOfWineOpens(string money)
        //{
        //    Assert.AreEqual(actual: _myWinesPage.TotalPriceText(money), expected: money);
        //}
    }
}