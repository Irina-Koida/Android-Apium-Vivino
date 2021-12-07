using AndroidTestsApium.POM;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace AndroidTestsApium.Steps
{
    [Binding]
    public class SelectedWineStyleSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        private readonly SelectedWineStyle _selectedWineStyle;

        public SelectedWineStyleSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _androidDriver = _scenarioContext.Get<AndroidDriver<AndroidElement>>("driver");
            _selectedWineStyle = new  SelectedWineStyle(_androidDriver);
        }

        [When(@"I tap subsection ""(.*)""")]
        public void WhenITapSubsection(string style)
        {
            _selectedWineStyle.TapSubsectionStyle(style);
        }

        [When(@"I tap ""(.*)"" style")]
        public void WhenITapStyle(string styleSelect)
        {
            _selectedWineStyle.TapSelectStyle(styleSelect);
        }
        
        [Then(@"I see a text ""(.*)""")]
        public void ThenISeeAText(string textStyle)
        {
            Assert.AreEqual(actual: _selectedWineStyle.StyleText(textStyle), expected: textStyle);
        }
        
        [Then(@"I see text with the count of selected wines by style ""(.*)""")]
        public void ThenISeeTextWithTheCountOfSelectedWinesByStyle(string count)
        {
            Assert.AreEqual(actual: _selectedWineStyle.WineStyleCount(count), expected: count);
        }
    }
}
