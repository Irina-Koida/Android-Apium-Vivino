using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium
{
    [Binding]
    public class PairingWineSteps
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly PairingBrowseWinesPage _pairingBrowseWinesPage;
        public PairingWineSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _pairingBrowseWinesPage = new PairingBrowseWinesPage(_driver);
        }

        [When(@"I tap Pairing item")]
        public void WhenITapPairingItem()
        {
            _pairingBrowseWinesPage.PairingItemHeaderMenu();
        }

        [When(@"I tap Beef type")]
        public void WhenITapBeefType()
        {
            _pairingBrowseWinesPage.BeefTypeChoose();
        }

        [When(@"I tap first wine product card")]
        public void WhenITapFirstWineProductCard()
        {
            _pairingBrowseWinesPage.FirstProductClick();
        }

        [Then(@"Product card with vino name ""([^""]*)"" opens")]
        public void ThenProductCardWithVinoNameOpens(string nameOfWine)
        {
            Assert.AreEqual(actual: _pairingBrowseWinesPage.WineTextInfo(nameOfWine), expected: nameOfWine);
        }

        [When(@"I tap on Buy button")]
        public void WhenITapOnBuyButton()
        {
            _pairingBrowseWinesPage.BuyButtonClick();
        }

        [Then(@"Message with title ""([^""]*)"" opens")]
        public void ThenMessageWithTitleOpens(string title)
        {
            Assert.AreEqual(actual: _pairingBrowseWinesPage.CountProductText(title), expected: title);
        }

        [When(@"I tap to minus button")]
        public void WhenITapToMinusButton()
        {
            _pairingBrowseWinesPage.MinusButtonClick();
        }

        [Then(@"Message  with title ""([^""]*)"" opens")]
        public void ThenMessageWithtitleOpens(string title)
        {
            Assert.AreEqual(actual: _pairingBrowseWinesPage.CountProductText(title), expected: title);
        }

        [When(@"I tap to plus button")]
        public void WhenITapToPlusButton()
        {
            _pairingBrowseWinesPage.PlusButtonClick();
        }
    }
}
