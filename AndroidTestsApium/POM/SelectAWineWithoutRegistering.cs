using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class SelectAWineWithoutRegistering
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public SelectAWineWithoutRegistering(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _search = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view." +
            "ViewGroup/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout" +
            "/android.widget.LinearLayout[2]");
        private readonly By _selectRed = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android" +
            ".widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx." +
            "viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android." +
            "widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]/android.widget." +
            "TextView");
        private readonly By _redText = By.XPath("hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.TextView");
        private readonly By _countText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout/" +
            "android.widget.LinearLayout[2]/android.widget.TextView");

        public void SearchPage()
        {
            _driver.FindElement(_search).Click();
        }

        public void RedWineSelect(string red) =>
         _driver.FindElement(_selectRed).Click();

        public string RedTextInfo(string redWineText) =>
        _driver.FindElement(_redText).Text;

        public string RedWineCountText(string count) =>
            _driver.FindElement(_countText).Text;
    }
}
