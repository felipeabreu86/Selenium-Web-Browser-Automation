using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace ExercicioIMDB
{
    class AdvancedSearchMap
    {
        IWebDriver _driver;

        public AdvancedSearchMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public SelectElement ComboTitleSearch 
        { 
            get 
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='main']/div[2]/form/select")));

                return new SelectElement(_driver.FindElement(By.XPath("//div[@id='main']/div[2]/form/select")));            
            } 
        }

        public IWebElement TextBoxTitleSearch 
        { 
            get 
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='main']/div[2]/form/input[@name='q']")));

                return _driver.FindElement(By.XPath("//div[@id='main']/div[2]/form/input[@name='q']")); 
            } 
        }

        public IWebElement BtSubmitTitleSearch 
        { 
            get 
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[@id='main']/div[2]/form/input[@type='submit']")));

                return _driver.FindElement(By.XPath("//div[@id='main']/div[2]/form/input[@type='submit']")); 
            } 
        }
    }
}
