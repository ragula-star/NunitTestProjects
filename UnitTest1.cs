using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace saleniumPractise
{
    public class Tests
    {
         public IWebDriver driver; //global variable/method

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); //for update versions
            driver = new ChromeDriver();
            Test1();
        }

       // [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}