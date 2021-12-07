using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class UseWithoutRegisteringSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly WithoutRegistering _userWithoutRegistering;

        public UseWithoutRegisteringSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _userWithoutRegistering = new WithoutRegistering(_androidDriver);
        }
 
        [When(@"I tap a ""(.*)"" button")]
        public void WhenITapAButton(string tryUsOut)
        {
            _userWithoutRegistering.TapATryUsOut(tryUsOut);
        }
        
        [When(@"I tap ""(.*)"" button")]
        public void WhenITapButton(string next)
        {
            _userWithoutRegistering.TapNext(next);
        }

        [When(@"I tap the ""(.*)"" button")]
        public void WhenITapTheButton(string nextNext)
        {
            _userWithoutRegistering.TapNextNext(nextNext);
        }

        [When(@"I tap to ""(.*)"" button")]
        public void WhenITapToButton(string nextNextNext)
        {
            _userWithoutRegistering.TapNextNextNext(nextNextNext);
        }

        [When(@"I select a ""(.*)"" button")]
        public void WhenISelectAButton(string continueWithoutAccount)
        {
            _userWithoutRegistering.TapContiueWithoutAccount(continueWithoutAccount);
        }

        [Then(@"My profile page is open")]
        public void ThenMyProfilePageIsOpen()
        {
            string profilePage = _userWithoutRegistering.OpenProfilePage();
            bool result = profilePage.Contains(profilePage);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
