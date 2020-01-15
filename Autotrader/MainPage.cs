using System;
using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using FluentAssertions;
using System.IO;
using System.Text;

namespace Autotrader
{
    public class MainPage : Base
    {
        public MainPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public string baseURL = @"https://www.cars.com/";
        public string closeModalMessage = "//button[@class ='close ae-button']";
        public string modalMessage = "//div[@class= 'modal-dialog']";
        public string fieldZipCode = "//input[@name ='zip']";
        public string searchButton = "//input[@value = 'Search']";
        public string modelDropdown = "//select[@aria-label = 'Select a make']";
        public string itemPorche = "//option[@value = '20081']";
        public string yearDropdown = "//select[@name ='yrId']";
        public string chooseYear = "//option[@value = '35797618']";
        public string chooseCar = "//a[@data-position ='1']";
        public string vinLocator = "//span[contains(.,'WP')]";
        public string titleOfCar = "//a[@data-position ='1']//h2[class='listing-row__title']";
        public string backButton = "//span[@ng-click='$ctrl.backToSearch()']";

        public void ClickOnCloseModalMessage()
        {
            ClickButton(closeModalMessage);
        }

        public void EnterZipCode()
        {
            WriteText(fieldZipCode, zipCode);

        }
        public void ClickSearch()
        {
            ClickButton(searchButton);
        }

        public void ClickDropDownAneMode()
        {
            ClickButton(modelDropdown);
        }

        public void ChoosePORCHE()
        {
            ClickButton(itemPorche);
        }

        public void WaitVisibleChooseYear()

        {
            WaitElementVisible(yearDropdown);

        }
        public void ClickMinYearDropdown()
        {
            ClickButton(yearDropdown);
        }

        public void ChooseMinYear()
        {
            ClickButton(chooseYear);
        }

        public void WaitListOfCar()
        {
            WaitElementVisible(chooseCar);
        }
        public string[] vins = new string[3];
        public void FindAndRememberVins()
        {
            
            for (int i = 1; i < 3; i++)
            {
                string number = Convert.ToString(i);
                string chooseCar = "//a[@data-position ='"+ number+ "']";
                ClickButton(chooseCar);
                WaitElementVisible(vinLocator);
                
                vins[i] = RememberVin(vinLocator);
                ClickButton(backButton);
                WaitElementVisible(chooseCar);
            }


        }

    }



}
