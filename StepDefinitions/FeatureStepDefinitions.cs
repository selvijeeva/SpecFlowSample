using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
        }

        [Then(@"Search for TestersTalk")]
        public void ThenSearchForTestersTalk()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            driver.Quit();
        }


    }
}