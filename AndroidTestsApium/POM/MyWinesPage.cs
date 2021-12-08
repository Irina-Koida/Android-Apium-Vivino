using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AndroidTestsApium.POM
{
    internal class MyWinesPage
    {
        private readonly AppiumDriver<AndroidElement> _driver;

        public MyWinesPage(AppiumDriver<AndroidElement> appiumDriver)
        {
            _driver = appiumDriver;
        }

        private readonly By _myWinesMenuItem = By.XPath("//android.widget.LinearLayout[@content-desc='My Wines']/android.widget.TextView");
        private readonly By _addedWine = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.TextView[2]");
        private readonly By _bottleOfWine = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup[1]/android.widget.ImageView[4]");
        private readonly By _buyButtonForAddedWine = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/androidx.recyclerview.widget.RecyclerView/android.widget.FrameLayout/android.view.ViewGroup/android.widget.TextView");
        private readonly By _addToCard = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.Button[2]");
        private readonly By _nameOfWine = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.widget.TextView[2]");
        private readonly By _toralPrice = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout / android.widget.RelativeLayout/android.view.ViewGroup/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.TextView[2]");

        public void MyWinesMenuClick() =>
        _driver.FindElement(_myWinesMenuItem).Click();

        public void AddWineClick() =>
        _driver.FindElement(_addedWine).Click();

        public void BottleOfWinoClick() =>
        _driver.FindElement(_bottleOfWine).Click();

        public void ClickBuyButton() =>
        _driver.FindElement(_buyButtonForAddedWine).Click();

        public void AddToCardClick() =>
        _driver.FindElement(_addToCard).Click();

        public string NameProductText(string wineName) =>
         _driver.FindElement(_nameOfWine).Text;

        public string TotalPriceText(string money) =>
         _driver.FindElement(_toralPrice).Text;
    }
}
