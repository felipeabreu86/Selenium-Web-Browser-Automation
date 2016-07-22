using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using System.Collections.Generic;

namespace ExercicioTripAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5)); 
            TripAdvisorIndexMap TripAdvisorIndexPage = new TripAdvisorIndexMap(driver);
            Actions builder = new Actions(driver);

            driver.Navigate().GoToUrl("http://www.tripadvisor.com.br/");

            TripAdvisorIndexPage.RadioButtonVoo.Click();
            TripAdvisorIndexPage.SearchBox.Clear();
            TripAdvisorIndexPage.SearchBox.SendKeys("gig");
            
            TripAdvisorIndexPage.AutoComplete.Click();
        }
    }
}
