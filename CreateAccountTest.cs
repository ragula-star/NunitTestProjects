using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumPractise
{
    
    public class CreateAccountTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);


        }

        [Test]
        public void login()
        {
            driver.FindElement(By.XPath("//input[@name='user-name']")).SendKeys("standard_user");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");
            Thread.Sleep(2000);

            driver.FindElement(By.CssSelector("[id='login-button']")).Click();
            Thread.Sleep(3000);

        }
        [Test]
        public void Successmsg()
        {
            string expectedText = "Swag Labs";
            
            string actualText = driver.FindElement(By.CssSelector("[class='app_logo']")).Text;
            
            Assert.AreEqual(expectedText, actualText);

            Console.WriteLine("successmsg=" +actualText, "successmsg ="+ expectedText);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();

        }
        
    }
}
