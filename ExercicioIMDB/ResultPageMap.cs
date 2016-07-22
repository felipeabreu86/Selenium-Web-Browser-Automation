using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ExercicioIMDB
{
    class ResultPageMap
    {
        IWebDriver _driver;

        public ResultPageMap(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public IWebElement TotalTitles { get { return _driver.FindElement(By.Id("left")); } }
    }
}
