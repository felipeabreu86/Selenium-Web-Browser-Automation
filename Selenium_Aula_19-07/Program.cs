using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeleniumAula
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            firefox.Navigate().GoToUrl("http://www.bing.com/");

            IWebElement campoDeBusca = firefox.FindElement(By.Name("q"));
            campoDeBusca.SendKeys("Autoit");

            firefox.FindElement(By.Id("sb_form_go")).Click();

            firefox.FindElement(By.LinkText("Imagens")).Click();

            Console.WriteLine();
        }
    }
}
