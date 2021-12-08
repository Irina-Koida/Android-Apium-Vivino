using AndroidTestsApium.Drivers;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks (ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium(), "driver");
        }

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver").Dispose();
        //}
    }
}
