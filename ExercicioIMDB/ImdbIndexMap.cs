using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ExercicioIMDB
{
    class ImdbIndexMap
    {
        IWebDriver _driver;

        public ImdbIndexMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public SelectElement ComboQuickSearch { get { return new SelectElement(_driver.FindElement(By.Id("quicksearch"))); } }
    }
}
