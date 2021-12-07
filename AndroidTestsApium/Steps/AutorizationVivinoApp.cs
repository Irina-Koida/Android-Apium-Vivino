using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium
{
    [Binding]
    public class AutorizationInVivinoApp
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly AutorizationPage _autorizationPage;

        public AutorizationInVivinoApp(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<AppiumDriver<AndroidElement>>("driver");
            _autorizationPage = new AutorizationPage(_driver);
        }

        [When(@"I tap I have an account button")]
        public void WhenITapIHaveAnAccountButton()
        {
            _autorizationPage.HaveAnAccountButtonTap();
        }

        [Then(@"Welcome Back page with text ""([^""]*)"" opens")]
        public void ThenWelcomeBackPageWithTextOpens(string textOfSignInWithEmail)
        {
            Assert.AreEqual(actual: _autorizationPage.WelcomeBackPageText(textOfSignInWithEmail), expected: true);
        }

        [When(@"I tap Email field")]
        public void WhenITapEmailField()
        {
            _autorizationPage.EmailTap();
        }

        [When(@"I put personal emai ""([^""]*)""")]
        public void WhenIPutPersonalEmai(string inputEmail)
        {
            //Thread.Sleep(300);
            _autorizationPage.EmailInput(inputEmail);
        }

        [When(@"I tap on Password field")]
        public void WhenITapOnPasswordField()
        {
            _autorizationPage.PasswordTapField();
        }

        [When(@"I put password ""([^""]*)""")]
        public void WhenIPutPassword(string inputPassword)
        {
            //Thread.Sleep(300);
            _autorizationPage.PasswordInput(inputPassword);
        }

        [When(@"I tap on Log in button")]
        public void WhenITapOnLogInButton()
        {
            _autorizationPage.LogInButtonTap();
        }

        [Then(@"For you page with title ""([^""]*)"" opens")]
        public void ThenForYouPageWithTitleOpens(string title)
        {
            Assert.AreEqual(actual: _autorizationPage.ForYouPageTitle(title), expected: title);

        }
    }
}
