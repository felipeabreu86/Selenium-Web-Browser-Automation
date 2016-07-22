using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Aula_20_07
{
    class RegistrationMap
    {
        IWebDriver _driver;

        public RegistrationMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FirstName { get { return _driver.FindElement(By.Id("name_3_firstname")); } }

        public SelectElement Country { get { return new SelectElement(_driver.FindElement(By.Id("dropdown_7"))); } }
    }
}