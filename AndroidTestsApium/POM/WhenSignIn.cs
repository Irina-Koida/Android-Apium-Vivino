using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class WhenSignIn
    {
        private readonly AppiumDriver<AndroidElement> _driver;
        private readonly Actions _action;

        public WhenSignIn (AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
            _action = new Actions(_driver);
        }

        private readonly By _friends = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.view.ViewGroup/android.widget.LinearLayout/android.widget.HorizontalScrollView/" +
            "android.widget.LinearLayout/android.widget.LinearLayout[3]");
        private readonly By _text = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android" +
            ".widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx." +
            "viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/androidx.recyclerview.widget." +
            "RecyclerView/android.widget.FrameLayout[1]/android.widget.FrameLayout/android.view.ViewGroup/android.widget." +
            "TextView[2]");

        public void FriendsPage()
        {
            _driver.FindElement(_friends).Click();
        }

        public string SomeText(string text) =>
         _driver.FindElement(_text).Text;
    }
}
