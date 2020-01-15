using System;
using System.Diagnostics;
using System.Threading;
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

        [Test(Description = "Go to car and find cars")]
        public void Test1()
        {
            MainPage mainPage = new MainPage(driver, wait);
            Trace.WriteLine("Start");

            mainPage.ClickDropDownAneMode();
            mainPage.ChoosePORCHE();
            mainPage.EnterZipCode();
            mainPage.ClickSearch();
            mainPage.WaitVisibleChooseYear();
            
            mainPage.ClickMinYearDropdown();
            mainPage.ChooseMinYear();
            Thread.Sleep(100);
           // mainPage.WaitListOfCar();
            mainPage.FindAndRememberVins();
            for(int i = 1; i < 3; i++)
            {
                Console.WriteLine(mainPage.vins[i]);
            }
            
           
            Assert.Pass();
        }
    }
}