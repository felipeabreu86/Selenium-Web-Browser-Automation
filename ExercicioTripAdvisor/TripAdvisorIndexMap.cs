using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ExercicioTripAdvisor
{
    class TripAdvisorIndexMap
    {
        IWebDriver _driver;
        WebDriverWait wait;

        public TripAdvisorIndexMap(IWebDriver driver, int timeout)
        {
            _driver = driver;
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
        }

        public IWebElement RadioButtonVoo
        {
            get
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[@id='rdoFlights']/span")));
                return _driver.FindElement(By.XPath("//span[@id='rdoFlights']/span"));
            }
        }

        public IWebElement SearchBoxFrom 
        { 
            get
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id("metaFlightFrom")));
                return _driver.FindElement(By.Id("metaFlightFrom"));
            }        
        }

        public IWebElement AutoCompleteFrom
        {
            get
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='autocompleter-choices flights']/li[contains(.,'Rio de Janeiro')]")));
                return _driver.FindElement(By.XPath("//ul[@class='autocompleter-choices flights']/li[contains(.,'Rio de Janeiro')]"));
            }
        }

        public IWebElement SearchBoxTo
        {
            get
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id("metaFlightTo")));
                return _driver.FindElement(By.Id("metaFlightTo"));
            }
        }

        public IWebElement AutoCompleteTo
        {
            get
            {
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//ul[@class='autocompleter-choices flights']/li[contains(.,'Londres')]")));
                return _driver.FindElement(By.XPath("//ul[@class='autocompleter-choices flights']/li[contains(.,'Londres')]"));
            }
        }
    }
}
