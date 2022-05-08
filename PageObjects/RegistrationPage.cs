using BuggyCarsRatingUIAutomation.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarsRatingUIAutomation.PageObjects
{
    class RegistrationPage : UiBase
    {
        String RegisterSuccessMsg = "Registration is successful";
        String RegisterUnSuccessMsg = "UsernameExistsException: User already exists";
        WebDriver driver;
        public RegistrationPage(WebDriver driver)
        {
            driver = getDriver();
            this.driver = driver;
            //driver = getDriver();

        }

        IWebElement user => driver.FindElement(By.CssSelector("input[id=username]"));
        IWebElement firstName => driver.FindElement(By.CssSelector("input[id=firstName]"));

        IWebElement lastName => driver.FindElement(By.CssSelector("input[id=lastName]"));
        IWebElement pwd => driver.FindElement(By.CssSelector("input[id=password]"));
        IWebElement confirmPassword => driver.FindElement(By.CssSelector("input[id=confirmPassword]"));
        IWebElement registerBtn => driver.FindElement(By.CssSelector("form button[class*=btn-default]"));
        IWebElement registerSuccessMsg => driver.FindElement(By.CssSelector("form div[class*=alert-success]"));
        IWebElement userAlreadyExist => driver.FindElement(By.XPath("//div[@class='result alert alert-danger']"));

        public String NewUserRegistration(String userName)
        {
            user.SendKeys(userName);
            firstName.SendKeys("First " + userName);
            lastName.SendKeys("Last");
            pwd.SendKeys("Random1$");
            confirmPassword.SendKeys("Random1$");

            registerBtn.Click();
            return userName;
        }

        public void SuccessfullRegistration()
        {
            String actualSuccessMsg = registerSuccessMsg.Text;
            Assert.AreEqual(RegisterSuccessMsg, actualSuccessMsg);
        }
        public void UnSuccessfullRegistration()
        {
            String actualUnSuccessMsg = userAlreadyExist.Text;
            Assert.AreEqual(RegisterUnSuccessMsg, actualUnSuccessMsg);
        }


        public String UserName()
        {
            Random ran = new Random();

            String b = "abcdefghijklmnopqrstuvwxyz";

            int length = 6;

            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }
            return random;
        }
    }

}
