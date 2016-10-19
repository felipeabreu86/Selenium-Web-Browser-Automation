using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace ExercicioTripAdvisor
{
    class Program
    {
        private static readonly int timeout = 10;

        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            TripAdvisorIndexMap TripAdvisorIndexPage = new TripAdvisorIndexMap(driver, timeout);
            Actions builder = new Actions(driver);

            driver.Navigate().GoToUrl("http://www.tripadvisor.com.br/");

            TripAdvisorIndexPage.RadioButtonVoo.Click();

            TripAdvisorIndexPage.SearchBoxFrom.Clear();
            TripAdvisorIndexPage.SearchBoxFrom.SendKeys("gig");
            TripAdvisorIndexPage.AutoCompleteFrom.Click();

            TripAdvisorIndexPage.SearchBoxTo.Clear();
            TripAdvisorIndexPage.SearchBoxTo.SendKeys("heat");
            TripAdvisorIndexPage.AutoCompleteTo.Click();
        }
    }
}
