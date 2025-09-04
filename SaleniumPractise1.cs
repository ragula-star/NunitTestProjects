
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saleniumPractise 
{
    public class SaleniumPractise1:Tests
    {
        [Test]

        public void productTest()
        {
            driver.FindElement(By.Name("q")).SendKeys("mobile phone");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Return);
            Thread.Sleep(2000);

            String phoneName = driver.FindElement(By.XPath("//*[@id='container']/div/div[3]/div[1]/div[2]/div[2]/div/div/div/a/div[2]/div[1]/div[2]")).Text;
            Console.WriteLine("Get the first product of phone" + phoneName);
        }

        [Test]
        public void Navigatetowebsite()
        {
            driver.Navigate().GoToUrl("https://www.asianctv.co/#login");
            driver.FindElement(By.Id("search-key")).SendKeys("Revenged Love");
             driver.FindElement(By.Id("search-key")).SendKeys(Keys.Return);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);

            string dramaName = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div/div/ul[1]/li[3]/a/h3")).Text;
            Console.WriteLine(dramaName);

        }
    }
}
