using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AndroidTestsApium
{
    internal class SearchPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public SearchPage(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _searchItem = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]");
        private readonly By _typeItem = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.TextView");
        private readonly By _redType = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]/android.widget.ImageView[2]");
        private readonly By _firstProduct = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ImageView[2]");
        private readonly By _nameOFProduct = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.TextView[2]");
        private readonly By _personalMatch = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup[1]/android.widget.ImageView[4]");
        private readonly By _mysteryMessage = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.TextView[1]");

        public void SearchItemMenu() =>
            _driver.FindElement(_searchItem).Click();

        public void TypeItemHeaderMenu() =>
           _driver.FindElement(_typeItem).Click();

        public void RedTypeChoose() =>
           _driver.FindElement(_redType).Click();

        public void FirstProduct() =>
           _driver.FindElement(_firstProduct).Click();

        public string RedTextInfo(string nameOfWine) =>
        _driver.FindElement(_nameOFProduct).Text;

        public void PersonalMatchProduct() =>
          _driver.FindElement(_personalMatch).Click();

        public string MatchProductText(string title) =>
          _driver.FindElement(_mysteryMessage).Text;
    }
}