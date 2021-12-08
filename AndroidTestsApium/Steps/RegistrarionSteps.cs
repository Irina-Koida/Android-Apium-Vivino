using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class RegistrarionSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly Registration _registration;

        public RegistrarionSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _registration = new  Registration(_androidDriver);
        }

        [When(@"Tap the Get started button")]
        public void WhenTapTheGetStartedButton()
        {
            _registration.ClickGetStartButton();
        }
        
        [When(@"Enter '(.*)'")]
        public void WhenEnter(string enterEmail)
        {
            _registration.InputEmailField(enterEmail);
        }
        
        [When(@"Create '(.*)'")]
        public void WhenCreate(string createPass)
        {
            _registration.InputPasswordField(createPass);
        }
        
        [When(@"Tap Next")]
        public void WhenTapNext()
        {
            _registration.ClickNextButton();
        }
        
        [When(@"Enter your '(.*)' name")]
        public void WhenEnterYourName(string name)
        {
            _registration.InputFirstNameField(name);
        }
        
        [When(@"Enter your '(.*)' last name")]
        public void WhenEnterYourLastName(string lastName)
        {
            _registration.InputLastNameField(lastName);
        }
        
        [When(@"Select state country")]
        public void WhenSelectStateCountry()
        {
            _registration.ClickSelectStateButton();
        }
        
        [When(@"Select state")]
        public void WhenSelectState()
        {
            _registration.ClickSelectStateCountry();
        }
        
        [When(@"Accept the Terms of Use and the Privacy Policy")]
        public void WhenAcceptTheTermsOfUseAndThePrivacyPolicy()
        {
            _registration.ClickAcceptPolicy();
        }
        
        [When(@"Tap Done in the upper right corner")]
        public void WhenTapDoneInTheUpperRightCorner()
        {
            _registration.ClickDoneButton();
        }
        
        [Then(@"Open ""(.*)"" page with registration")]
        public void ThenOpenPageWithRegistration(string page)
        {
            Assert.AreEqual(actual: _registration.ClickNewProfile(), expected: page);
        }
        
        [Then(@"The you profile page opened")]
        public void ThenTheYouProfilePageOpened()
        {
            string text = _registration.ClickUserPage();
            bool result = text.Contains(text);
            Assert.AreEqual(actual: result, expected: true);
        }
    }
}
