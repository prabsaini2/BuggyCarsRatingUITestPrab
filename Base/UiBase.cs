using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarsRatingUIAutomation.Base
{
   
    public class UiBase 
    {
       public static WebDriver driver;

        public static WebDriver createWebDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://buggy.justtestit.org");
           
            return driver;
        }
        public static WebDriver getDriver()
        {
            if (driver == null) driver = createWebDriver();
            return driver;


        }

        public static void quitDriver()
        {
            driver.Close();
            driver.Quit();


        }
    }
}
