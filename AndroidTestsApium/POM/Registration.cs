using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace AndroidTestsApium.POM
{
    class Registration
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public Registration(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _getStartedButton = By.Id("vivino.web.app:id/getstarted_layout");
        private readonly By _gall = By.Id("com.google.android.gms:id/cancel");
        private readonly By _emailFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "FrameLayout[2]/android.widget.ScrollView/android.widget.RelativeLayout/android.widget." +
            "LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[1]");
        private readonly By _emailField2 = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/" +
            "android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/" +
            "android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText");
        private readonly By _passwordFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "RelativeLayout/android.widget.LinearLayout/android.widget." +
            "LinearLayout[1]/android.view.ViewGroup/android.widget.LinearLayout[2]");
        private readonly By _passwordField2 = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/" +
            "android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/" +
            "android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText");
        private readonly By _nextButton = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/" +
            "androidx.appcompat.widget.LinearLayoutCompat/android.widget.TextView");
        private readonly By _firstNameFiel = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "LinearLayout/android.widget.RelativeLayout/android.widget.EditText[1]");
        private readonly By _lastNameFiel = By.XPath("vivino.web.app:id/edtUserSurname");
        private readonly By _asseptPolicy = By.Id("vivino.web.app:id/new_profile_agree_terms");
        private readonly By _newProfile = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.TextView");
        private readonly By _doneButton = By.Id("vivino.web.app:id/action_done");
        private readonly By _selectStateCountry = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.ScrollView/android.widget." +
            "LinearLayout/android.widget.RelativeLayout/android.widget.TextView[5]");
        private readonly By _selectState = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget." +
            "LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget." +
            "RelativeLayout[4]/android.widget.TextView");
        private readonly By _forYou = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView");

        public void ClickGetStartButton()
        {
            _driver.FindElement(_getStartedButton).Click();
        }

        public void ClosedGooglemail()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.FindElement(_gall).Click();
        }

        public Registration InputEmailField(string textEmail)
        {
            _driver.FindElement(_emailFiel).Click();
            _driver.FindElement(_emailField2).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public Registration InputPasswordField(string textPassword)
        {
            _driver.FindElement(_passwordFiel).Click();
            _driver.FindElement(_passwordField2).SendKeys(Helper.RandomEmailUser());
            return this;
        }

        public void ClickNextButton()
        {
            _driver.FindElement(_nextButton).Click();
        }

        public Registration InputFirstNameField(string text)
        {
            _driver.FindElement(_firstNameFiel).Click();
            _driver.FindElement(_firstNameFiel).SendKeys("Dev");
            return this;
        }
        public Registration InputLastNameField(string text)
        {
            _driver.FindElement(_lastNameFiel).Click();
            _driver.FindElement(_lastNameFiel).SendKeys("Deva");
            return this;
        }

        public void ClickAcceptPolicy()
        {
            _driver.FindElement(_asseptPolicy).Click();
        }

        public string ClickNewProfile() =>
           _driver.FindElement(_newProfile).Text;

        public void ClickDoneButton()
        {
            _driver.FindElement(_doneButton).Click();
        }

        public void ClickSelectStateCountry()
        {
            _driver.FindElement(_selectStateCountry).Click();
        }

        public void ClickSelectStateButton()
        {
            _driver.FindElement(_selectState).Click();
        }

        public string ClickUserPage()
        {
          return _driver.FindElement(_forYou).Text;
        }
    }
}
