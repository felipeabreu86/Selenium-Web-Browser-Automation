using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace ExercicioIMDB
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            ImdbIndexMap ImdbIndexPage = new ImdbIndexMap(driver);
            AdvancedSearchMap AdvancedSearchPage = new AdvancedSearchMap(driver);
            ResultPageMap ResultPage = new ResultPageMap(driver);

            driver.Navigate().GoToUrl("http://www.imdb.com/");

            ImdbIndexPage.ComboQuickSearch.SelectByText("Advanced Search »");

            AdvancedSearchPage.ComboTitleSearch.SelectByText("Soundtracks");
            AdvancedSearchPage.TextBoxTitleSearch.SendKeys("Miles Davis");
            AdvancedSearchPage.BtSubmitTitleSearch.Click();

            int totalTitlesMilesDavis;
            int.TryParse(ResultPage.TotalTitles.Text.ToString().Replace(" titles.",""), out totalTitlesMilesDavis);
            
            driver.Navigate().Back();

            AdvancedSearchPage.TextBoxTitleSearch.Clear();
            AdvancedSearchPage.TextBoxTitleSearch.SendKeys("Duke Ellington");
            AdvancedSearchPage.BtSubmitTitleSearch.Click();
            
            int totalTitlesDukeEllington;
            int.TryParse(ResultPage.TotalTitles.Text.ToString().Replace(" titles.", ""), out totalTitlesDukeEllington);

            driver.Navigate().Back();

            AdvancedSearchPage.TextBoxTitleSearch.Clear();
            AdvancedSearchPage.TextBoxTitleSearch.SendKeys("John Coltrane");
            AdvancedSearchPage.BtSubmitTitleSearch.Click();

            driver.Quit();
            driver.Dispose();
            
            int totalTitlesJohnColtrane;
            int.TryParse(ResultPage.TotalTitles.Text.ToString().Replace(" titles.", ""), out totalTitlesJohnColtrane);

            int maior = 0;

            if (maior < totalTitlesMilesDavis)
                maior = totalTitlesMilesDavis;
            if (maior < totalTitlesDukeEllington)
                maior = totalTitlesDukeEllington;
            if (maior < totalTitlesJohnColtrane)
                maior = totalTitlesJohnColtrane;

            Console.WriteLine("Max: " + maior.ToString());
            Console.ReadKey();
        }
    }
}
