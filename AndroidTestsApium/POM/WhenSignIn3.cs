using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class WhenSignIn3
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;

        public WhenSignIn3(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
        }

        private readonly By _settingsLastName = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout/" +
            "android.widget.RelativeLayout");
        private readonly By _ok = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/" +
            "android.widget.Button[2]");
        private readonly By _nameLast = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout/" +
            "android.widget.RelativeLayout/android.widget.TextView[2]");
        private readonly By _editNameLast = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "android.widget.ScrollView/android.widget.LinearLayout/android.widget.EditText");

        public void TapLastName()
        {
            _driver.FindElement(_settingsLastName).Click();
            _action.MoveToElement(_driver.FindElement(_editNameLast)).SendKeys("Koida").Perform();
        }

        public void TapOkLast()
        {
            _driver.FindElement(_ok).Click();
        }

        public string TextLast() =>
         _driver.FindElement(_nameLast).Text;
    }
}
