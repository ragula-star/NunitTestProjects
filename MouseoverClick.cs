using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumPractise
{
    public class MouseoverClick
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.grtjewels.com/");
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Thread.Sleep(5000);
        }

        [Test]
        public void Mouseover()
        {
            Actions act = new Actions(driver);
            IWebElement over = driver.FindElement(By.LinkText("All Jewellery"));
            IWebElement web = driver.FindElement(By.LinkText("Gold"));
            act.MoveToElement(over).Build().Perform();
            act.MoveToElement(web).Build().Perform();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("//span[@class='category-name']")).Click();
            Thread.Sleep(3000);

            //driver.FindElement(By.TagName("Gold")).Click();
            //Thread.Sleep(3000);




            // Actions act = new Actions(driver);
            IWebElement right = driver.FindElement(By.Id("dropdown-basic-button"));
            act.ContextClick(right).Build().Perform();
            Thread.Sleep(3000);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("NEW DROP"))); 
        }
        

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
