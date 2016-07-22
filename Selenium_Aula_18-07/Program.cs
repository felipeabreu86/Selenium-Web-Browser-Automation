using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Aula_19_07_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver ffox = new FirefoxDriver();
            ffox.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            ffox.Navigate().GoToUrl("https://github.com/join");

            ffox.FindElement(By.Name("user[login]")).SendKeys("teste");
            ffox.FindElement(By.Name("user[email]")).SendKeys("teste");
            ffox.FindElement(By.Name("user[password]")).SendKeys("teste");

            ffox.FindElement(By.XPath("//button[@type='submit']")).Click();

            Console.WriteLine("=================================================================");
            Console.WriteLine(ffox.FindElement(By.XPath("//input[@id='user_login']/../../../dd[@class='error']")).Text);
            Console.WriteLine(ffox.FindElement(By.XPath("//input[@id='user_email']/../../dd[@class='error']")).Text);
            Console.WriteLine(ffox.FindElement(By.XPath("//input[@id='user_password']/../../../dd[@class='error']")).Text);
            Console.WriteLine("=================================================================");

            Console.Read();
        }
    }
}
