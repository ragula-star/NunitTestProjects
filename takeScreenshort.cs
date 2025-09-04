//using System;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace seleniumPractise
//{
//    public class TakeScreenshot
//    {
//        IWebDriver driver;

//        [SetUp]
//        public void SetupScreenshot()
//        {
//            driver = new ChromeDriver();
//            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
//        }

//        [Test]
//        public void ScreenshotTest()
//        {
//            ITakesScreenshot screen = (ITakesScreenshot)driver;
//            screen.GetScreenshot();

//            // Save screenshot to file
//            screen.SaveAsFile(
//                "C:\\Users\\muthu\\source\\repos\\seleniumPractise\\test.png",
//                 ScreenshotImageFormat.Png
//            );
//        }

//        [TearDown]
//        public void TearDown()
//        {
//            driver.Close();
//            driver.Quit();
//        }
//    }
//}


