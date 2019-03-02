using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDD_Tutorial_classLib_netFramework.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        IWebDriver driver = null;

        [Given(@"I am on the google homepage")]
        public void GivenIAmOnTheGoogleHomepage()   
        {
            Console.WriteLine("Navigating to Google Homepage");
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        
        [Given(@"I entered (.*) in the search box")]
        public void GivenIEnteredInTheSearchBox(string searchText)
        {
            driver.FindElement(By.Name("q")).SendKeys(searchText);
            Console.WriteLine("Entering "+searchText+" in the google search field.");
            Thread.Sleep(2000);
        }
        
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            driver.FindElement(By.Name("btnK")).Click();
            Console.WriteLine("Clicking on the Search Button.");
            Thread.Sleep(2000);
        }
        
        [Then(@"seacrh results for (.*) should be displayed")]
        public void ThenSeacrhResultsForShouldBeDisplayed(string msgToCheck)
        {
            Assert.True(driver.FindElement(By.XPath("//h3[text()='"+ msgToCheck + "']")).Displayed,"'India - Wikipedia' link didn't show up in the UI");
        }

        [BeforeScenario]
        public void DoTheSetup()
        {
            Console.WriteLine("Inside the Before Scenario method..... Doing Setup");
            SetUp();
        }

        [AfterScenario]
        public void DoTheTearDown()
        {
            Console.WriteLine("Inside the After Scenario method..... Doing Teardown");
            Dispose();
        }

        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(2);
            Thread.Sleep(2000);
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
