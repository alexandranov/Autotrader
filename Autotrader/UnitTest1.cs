using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Autotrader
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"/Users/aleksandra/Documents/chromedrivers/");
            wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 20));
            MainPage mainPage= new MainPage(driver,wait);
            driver.Navigate().GoToUrl(mainPage.baseURL);
            
        }

        [Test(Description = "Go to autotrader and find cars")]
        public void Test1()
        {
            MainPage mainPage = new MainPage(driver, wait);
            mainPage.WaitModalMessageDidsplayed();
            mainPage.ClickOnCloseModalMessage();
            mainPage.EnterZipCode();

            Assert.Pass();
        }
    }
}