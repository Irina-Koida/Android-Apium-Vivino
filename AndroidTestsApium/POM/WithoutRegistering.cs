using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Appium.Interfaces;

namespace AndroidTestsApium.POM
{
    class WithoutRegistering
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;
        private readonly MultiAction _multiAction;

        public WithoutRegistering(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
            _multiAction = new MultiAction(_driver);
        }

        private readonly By _buttonNext = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget" +
            ".LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.widget.RelativeLayout/androidx.viewpager.widget.ViewPager/android.widget." +
            "LinearLayout/android.widget.LinearLayout/android.widget.TextView[2]");
        private readonly By _buttonTryUsOut = By.Id("vivino.web.app:id/txtTryUsOut");
        private readonly By _openProfile = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget." +
            "LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget." +
            "FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.view." +
            "ViewGroup/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android." +
            "view.ViewGroup/android.widget.TextView[2]");
        private readonly By _buttonNextNext = By.Id("vivino.web.app:id/next");
        private readonly By _next = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/" +
            "androidx.viewpager.widget.ViewPager/android.widget.LinearLayout/android.widget.LinearLayout/android.widget." +
            "TextView[2]");
        private readonly By _button = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android" +
            ".widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/androidx" +
            ".viewpager.widget.ViewPager/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.Button[2]");

        public void TapATryUsOut(string tryUsOut) =>
         _driver.FindElement(_buttonTryUsOut).Click();

        public void TapNext(string next) =>
        _driver.FindElement(_buttonNext).Click();

        public void TapNextNext(string nextNext)
        {
            _action.MoveToElement(_driver.FindElement(_buttonNextNext)).Click().Perform();
        }

        public void TapNextNextNext(string nextNextNext)
        {
            //_action.SendKeys(Keys.Tab).MoveToElement(_driver.FindElement(_next)).Click().Build().Perform();
            //_action.MoveToElement(_driver.FindElement(_next)).Click().Perform();
            _action.SendKeys(Keys.Enter).MoveToElement(_driver.FindElement(_next)).Click().Perform();
            _multiAction.Add((ITouchAction)_action).Perform();
        }

        public void TapContiueWithoutAccount(string contiueWithoutAccount)
        {
            _driver.FindElement(_button);
            _action.MoveToElement(_driver.FindElement(_button)).Click().Perform();
        }
     
        public string OpenProfilePage() =>
            _driver.FindElement(_openProfile).Text;
    }
}
