using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Autotrader
{
    public class Base
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        protected Base(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }
        protected static string[] zipCodes = { "85001", "72201", "94203", "80201", "10001", "43215", "11530", "10013", "10011", "10003", "10025", "33301", "11201", "10023" };
        protected static Random rnd = new Random();

        static int i = rnd.Next(0,13);
        protected static string zipCode = zipCodes[i];

        protected void ClickButton(string locator)
        {
            driver.FindElement(By.XPath(locator)).Click();
        }

        protected void WaitElementVisible(string locator)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        protected void WriteText(string locator, string text)
        {
            driver.FindElement(By.XPath(locator)).SendKeys(text);
        }

        protected string RememberVin(string locator)
        {
              string vin = Convert.ToString(driver.FindElement(By.XPath(locator)).GetAttribute("innerText"));
            return vin;
        }
    }
}
