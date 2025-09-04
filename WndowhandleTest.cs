using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumPractise
{
    public class WndowhandleTest
    {
        public IWebDriver driver;

        [SetUp]
        public void WndowTest()
        {
            driver = new ChromeDriver();
            // driver.Navigate().GoToUrl("https://englishpartner.com/blog/english/how-to-learn-english-through-tamil-a-step-by-step-guide/");
            driver.Navigate().GoToUrl("https://www.grtjewels.com/");
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='header-logo']")));

           // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);



        }

        //[Test]
        //public void WindowTest1()
        //{
        //   // string name = "Shashi Tharoor's";
        //    driver.FindElement(By.XPath("//h2")).Click();

        //    //if (name.Contains("Shashi Tharoor's"))
        //    //{
        //    //    Console.WriteLine("Found that name:" + name);
        //    //}

        //    string parentwindow = driver.CurrentWindowHandle;
        //    IList<string> childwindow = driver.WindowHandles;

        //    foreach (string child in childwindow)
        //    {
        //        if (child != parentwindow)
        //        {
        //            driver.SwitchTo().Window(child);
        //            string pageTile = driver.Title;
        //            Console.WriteLine("pageTitle ");
        //            driver.Close();
        //            break;
        //        }
        //        driver.SwitchTo().Window(parentwindow);



        //        //driver.Navigate().Back();
        //        //Thread.Sleep(5000);
        //    }


        //}

        //[Test]
        //public void WindowTest()
        //{
        //    String expectedname = "GRT logo";
        //   String actualname = driver.FindElement(By.XPath("//div[@class='header-logo']")).Text;
        //    Assert.That(actualname, Is.EqualTo (expectedname), "name is not matching");

        //}

        [Test]
        public void Test3()
        {
            ITakesScreenshot shot = (ITakesScreenshot)driver;
            shot.GetScreenshot().SaveAsFile("C:\\Users\\muthu\\source\\repos\\saleniumPractise\\seleniumPractise.csproj\\test.png", ScreenshotImageFormat.Png.png);
            
                
            

        }
        
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
