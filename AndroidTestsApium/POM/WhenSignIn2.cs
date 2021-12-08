using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class WhenSignIn2
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;

        public WhenSignIn2(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
        }

        private readonly By _kebab = By.XPath("//android.widget.ImageView[@content-desc='More options']");
        private readonly By _settings = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "android.widget.ListView/android.widget.LinearLayout[1]/android.widget.LinearLayout");
        private readonly By _settingsName = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.LinearLayout/" +
            "android.widget.RelativeLayout/android.widget.TextView[2]");
        private readonly By _textList = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/" +
            "androidx.viewpager.widget.ViewPager/android.widget.ViewFlipper/android.widget.ListView/" +
            "android.widget.RelativeLayout/android.widget.TextView");
        private readonly By _textSettings = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/android.widget.FrameLayout" +
            "/android.widget.LinearLayout/android.widget.FrameLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.FrameLayout[1]/android.widget.TextView");
        private readonly By _ok = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/" +
            "android.widget.Button[2]");
        private readonly By _name = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[2]/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]/android.widget.LinearLayout/" +
            "android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.TextView[2]");
        private readonly By _editName = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/" +
            "androidx.appcompat.widget.LinearLayoutCompat/" +
            "android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/" +
            "android.widget.EditText");

        public void TapKebabMenu()
        {
            _driver.FindElement(_kebab).Click();
        }

        public void SelectSettings()
        {
            _driver.FindElement(_settings).Click();
        }

        public void TapFirstName()
        {
            _driver.FindElement(_settingsName).Click();
            _action.MoveToElement(_driver.FindElement(_editName)).SendKeys("Iririna").Perform();
        }

        public string TopListText(string text) =>
         _driver.FindElement(_textList).Text;

        public string ProfileSettingsText() =>
         _driver.FindElement(_textSettings).Text;

        public void TapOk()
        {
            _driver.FindElement(_ok).Click(); 
        }

        public string Text() =>
         _driver.FindElement(_name).Text;
    }
}
