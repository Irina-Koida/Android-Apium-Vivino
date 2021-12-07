using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class SelectedWineStyle
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public SelectedWineStyle(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _styleSection = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android" +
            ".view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview." +
            "widget.RecyclerView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[3]" +
            "/android.widget.TextView");
        private readonly By _styleSelect = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/" +
            "androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.RelativeLayout[2]/android.widget.TextView");
        private readonly By _styleInfoText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout" +
            "/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout" +
            "/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout" +
            "/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.TextView");
        private readonly By _seeWineCount = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout/" +
            "android.widget.LinearLayout[2]/android.widget.TextView");

        public void TapSubsectionStyle(string tapStyle) =>
            _driver.FindElement(_styleSection).Click();

        public void TapSelectStyle(string selectStyleTap) =>
            _driver.FindElement(_styleSelect).Click();

        public string StyleText(string styleText) =>
            _driver.FindElement(_styleInfoText).Text;

        public string WineStyleCount(string wineCount) =>
          _driver.FindElement(_seeWineCount).Text;
    }
}
