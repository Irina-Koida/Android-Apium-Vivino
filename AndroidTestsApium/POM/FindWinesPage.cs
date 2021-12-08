using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AndroidTestsApium.POM
{
    internal class FindWinesPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public FindWinesPage(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _searchField = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.TextView");
        private readonly By _searchFieldMain = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText");
        private readonly By _searchButton = By.XPath("(//android.widget.ImageView[@content-desc='Content Description'])[1]");
        private readonly By _secondProductCard = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.LinearLayout");
        private readonly By _searchResult = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.TextView[2]");

        public void SearchFieldClick() =>
           _driver.FindElement(_searchField).Click();

        public FindWinesPage SerchFieldInput(string inputTetx)
        {
            _driver
                .FindElement(_searchFieldMain)
                .SendKeys(inputTetx);
            return this;
        }

        public void SearchButtonClick() =>
           _driver.FindElement(_searchButton).Click();

        public void SecondProductCardClick() =>
           _driver.FindElement(_secondProductCard).Click();

        public string NameProductText(string title) =>
         _driver.FindElement(_searchResult).Text;
    }
}
