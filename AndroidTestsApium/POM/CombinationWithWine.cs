using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;

namespace AndroidTestsApium.POM
{
    class CombinationWithWine
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public CombinationWithWine(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _pairingSection = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/" +
            "androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.TextView");
        private readonly By _pairSelect = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup" +
            "/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/" +
            "android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget." +
            "RelativeLayout[3]/android.widget.TextView");
        private readonly By _pairInfoText = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout/" +
            "android.widget.LinearLayout[1]/android.widget.TextView");
        private readonly By _seeWine = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout/android.widget.LinearLayout/" +
            "android.widget.FrameLayout / android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/" +
            "android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.TextView");

        public void Pairing(string pairing) =>
            _driver.FindElement(_pairingSection).Click();

        public void SelectPair(string pair) =>
            _driver.FindElement(_pairSelect).Click();

        public string InfoAboutPair(string pairInfo) =>
            _driver.FindElement(_pairInfoText).Text;

        public string CountWine(string wine) =>
          _driver.FindElement(_seeWine).Text;
    }
}
