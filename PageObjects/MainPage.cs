using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BuggyCarsRatingUIAutomation.SCDriver;
using BuggyCarsRatingUIAutomation.Base;
using OpenQA.Selenium.Support.UI;

namespace BuggyCarsRatingUIAutomation.PageObjects
{
    class MainPage : UiBase
    {
        WebDriver driver;
        public MainPage(WebDriver driver)
        {
            this.driver = driver;

        }
        
        IWebElement login => getDriver().FindElement(By.CssSelector("div input[name=login]"));
        IWebElement password => driver.FindElement(By.CssSelector("div input[name=password]"));

        IWebElement loginBtn => driver.FindElement(By.CssSelector("button[class*=success]"));

        IWebElement navProfileName => driver.FindElement(By.CssSelector("li span[class*=nav-link"));

        IWebElement registerBtn => driver.FindElement(By.XPath("//form[@class='form-inline']/a[text() = 'Register']"));

        IWebElement logout => driver.FindElement(By.XPath("//li/a[text()='Logout'] "));

        public void Launch()
        {
            driver.Navigate().GoToUrl("https://buggy.justtestit.org");
        }

        public void Login(String userName, String pwd)
        {
            
            login.SendKeys(userName);
            password.SendKeys(pwd);
            loginBtn.Click();
        }

        public Boolean IsUserLoggedIn(String profileFirstName)
        {
            return navProfileName.Text.Contains(profileFirstName);
        }

        public void ClickRegisterBtn()
        {
            registerBtn.Click();
        }

        public void ClickLogout()
        {
            logout.Click();            
        }

    }
}
