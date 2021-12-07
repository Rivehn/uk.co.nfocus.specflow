using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace uk.co.nfocus.specflow.StepDefinitions
{
    [Binding]
    public class SecurityStepDefinition
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "https://www.edgewordstraining.co.uk/webdriver2/sdocs/auth.php";
            driver.Url = url;

        }

        [When(@"I enter a valid username and password")]
        public void WhenIEnterAValidUsernameAndPassword()
        {
            throw new PendingStepException();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            throw new PendingStepException();
        }
    }
}
