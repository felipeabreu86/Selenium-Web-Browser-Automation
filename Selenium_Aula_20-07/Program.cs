using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace Selenium_Aula_20_07
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));            
            Actions builder = new Actions(driver);
            RegistrationMap registrationPage = new RegistrationMap(driver);

            driver.Navigate().GoToUrl("http://demoqa.com/");

            IAction action = 
                builder
                .MoveToElement(driver.FindElement(By.LinkText("Services")))
                .MoveToElement(driver.FindElement(By.LinkText("About us")))
                .Build();
            action.Perform();

            IWebElement registrationLink = wait.Until(ExpectedConditions.ElementExists(By.LinkText("Registration")));
            registrationLink.Click();

            registrationPage.FirstName.SendKeys("Felipe");
            registrationPage.Country.SelectByText("Brazil");
        }
    }
}
