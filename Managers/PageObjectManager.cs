using BuggyCarsRatingUIAutomation.Base;
using BuggyCarsRatingUIAutomation.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarsRatingUIAutomation.Managers
{
    class PageObjectManager : UiBase
    {
        WebDriver driver;
        MainPage mainPage;
        RegistrationPage registrationPage;

        public PageObjectManager()
        {
           this.driver = getDriver();        

        }

        public MainPage getMainPage()
        {
            return (mainPage == null) ? mainPage = new MainPage(driver) : mainPage;
        }

        public RegistrationPage getRegistrationPage()
        {
            return (registrationPage == null) ? registrationPage = new RegistrationPage(driver) : registrationPage;
        }

        
        public void quitDriver()
        {
            driver.Close();
            driver.Quit();


        }

    }
}
