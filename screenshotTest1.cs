//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace seleniumPractise
//{
//    public class screenshotTest1
//    {
//        IWebDriver driver;

//        [SetUp]
//        public void setup()
//        {
//            driver = new ChromeDriver();
//            driver.Navigate().GoToUrl("https://www.google.com/");
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

//        }
//        //[Test]
//        //public void Test1()
//        //{
//        //    ITakesScreenshot ts = (ITakesScreenshot)driver;
//        //    ts.GetScreenshot().SaveAsFile("C:\\Users\\muthu\\source\\repos\\saleniumPractise\\seleniumPractise.csproj\\test.png", ScreenshotImageFormat.Png);
//        //}

//        [TearDown]
//        public void TearDown()
//        {
//            driver.Close();

//            driver.Quit();
            
//        }
        
//    }
//}
