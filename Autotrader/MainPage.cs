using System;
using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace Autotrader
{
    public class MainPage: Base
    {
        public MainPage(IWebDriver driver , WebDriverWait wait): base(driver,wait)
        {
        }

        public string baseURL = @"https://www.autotrader.com/";
        public string closeModalMessage = "//button[@class ='close ae-button']";
        public string modalMessage = "//div[@class= 'modal-dialog']";
        public string fieldZipCode = "//input[@class ='form-control']";


        public string zipCode = "99501"; 

        public void ClickOnCloseModalMessage()
        {
            ClickButton(closeModalMessage);
        }

        public void WaitModalMessageDidsplayed()
        {
            WaitElementClickable(modalMessage);
        }

        public void EnterZipCode()
        {
            WriteText(fieldZipCode,zipCode);

        }
    }

   
}
