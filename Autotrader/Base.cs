using System;
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

        protected void ClickButton(string locator)
        {
            driver.FindElement(By.XPath(locator)).Click();
        }

        protected void WaitElementClickable(string locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }


        protected void WriteText(string locator, string text)
        {
            driver.FindElement(By.XPath(locator)).SendKeys(text);
        }
    }
}
