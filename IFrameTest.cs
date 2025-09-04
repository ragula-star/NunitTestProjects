using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumPractise
{
    public class IFrameTest
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
           // driver.Navigate().GoToUrl("https://www.makemytrip.global/");
           // driver.Manage().Window.Maximize();
           // driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

        }

        ////[Test]
        //public void tripTest()
        //{
        //    Actions act = new Actions(driver);
        //    act.MoveByOffset(0, 0).DoubleClick().Perform();
        //    Thread.Sleep(3000);

        //    driver.FindElement(By.XPath("//*[@class='menu_Hotels']")).Click();
        //    Thread.Sleep(3000);

        //    driver.Navigate().Back();
        //    Thread.Sleep(5000);

        //    driver.FindElement(By.XPath("//*[@class='makeFlex vrtlCenter '] ")).Click();
        //    Thread.Sleep(3000);

        //    //driver.SwitchTo().DefaultContent(); //back to Element search point

        //}

        [Test]
        public void test3()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/frames?utm_source=chatgpt.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

           // driver.SwitchTo().Frame("frame1");
            //Thread.Sleep(2000);

           // driver.FindElement(By.XPath("//div[@class='header-wrapper']")).Click();

            IList<IWebElement> frames = driver.FindElements(By.TagName("iframe"));
            Console.WriteLine("total iframe is:" + frames.Count);

            foreach (IWebElement frame in frames)
            {

                Console.WriteLine(frame.GetAttribute("name"));

            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }

}
