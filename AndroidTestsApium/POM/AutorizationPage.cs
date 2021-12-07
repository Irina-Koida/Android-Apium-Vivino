using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AndroidTestsApium.POM
{
    public class AutorizationPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public AutorizationPage(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _haveAnAccountButton = By.CssSelector("[id='vivino.web.app:id/txthaveaccount']");
        private readonly By _signInText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.TextView[1]");
        private readonly By _emailField = By.CssSelector("[id='vivino.web.app:id/til_email']");
        private readonly By _emailField2 = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText");
        private readonly By _passwordField = By.CssSelector("[id='vivino.web.app:id/til_password']");
        private readonly By _passwordField2 = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText");
        private readonly By _logInButton = By.CssSelector("[id='vivino.web.app:id/action_signin']");
        private readonly By _titleText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.widget.TextView");

        public AutorizationPage HaveAnAccountButtonTap()
        {
            _driver
                .FindElement(_haveAnAccountButton)
                .Click();
            return this;
        }

        public bool WelcomeBackPageText(string textOfSignInWithEmail)
        {
            if (_driver.FindElement(_signInText).Text.Contains(textOfSignInWithEmail))
            {
                return true;
            }
            return false;
        }

        public AutorizationPage EmailTap()
        {
            _driver
                .FindElement(_emailField)
                .Click();
            return this;
        }

        public AutorizationPage EmailInput(string inputEmail)
        {
            _driver
                .FindElement(_emailField2)
                .SendKeys(inputEmail);
            return this;
        }

        public AutorizationPage PasswordTapField()
        {
            _driver
                .FindElement(_passwordField)
                .Click();
            return this;
        }

        public AutorizationPage PasswordInput(string inputPassword)
        {
            _driver
                .FindElement(_passwordField2)
                .SendKeys(inputPassword);
            return this;
        }

        public AutorizationPage LogInButtonTap()
        {
            _driver
                .FindElement(_logInButton)
                .Click();
            return this;
        }

        public string ForYouPageTitle(string title) =>
            _driver.FindElement(_titleText).Text;

    }
}
