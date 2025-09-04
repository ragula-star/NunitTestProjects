using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumPractise
{
   
    public class LocatorsPractise
    {
        public IWebDriver driver;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        [Test]
        public void Locators()
        {
            driver.FindElement(By.XPath("//input[@name='email']")).SendKeys("username");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@id='pass']")).SendKeys("password");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys("Guhan");
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//*[@name='lastname']")).SendKeys("ragu");
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("#day option:nth-child(5)")).Click();

            driver.FindElement(By.CssSelector("#month option:nth-child(5)")).Click();

            driver.FindElement(By.CssSelector("#year option:nth-child(26)")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("label[class*='_58mt']")).Click();
            Thread.Sleep(2000);

        }

        }


    }

