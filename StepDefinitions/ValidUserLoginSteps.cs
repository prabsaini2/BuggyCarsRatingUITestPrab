using BuggyCarsRatingUIAutomation.Managers;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BuggyCarsRatingUIAutomation.StepDefinitions
{
    [Binding]
    public class ValidUserLoginSteps
    {
        PageObjectManager pageObjectManager;

        public ValidUserLoginSteps()
        {
            pageObjectManager = new PageObjectManager();

        }

        [Given(@"I am on Buggy Rating Website")]
        public void GivenIAmOnBuggyRatingWebsite()
        {
            pageObjectManager.getMainPage().Launch();
        }
        
        [When(@"I enter my valid credentials")]
        public void WhenIEnterMyValidCredentials()
        {
            //Ideally values should be picked from app.config
            pageObjectManager.getMainPage().Login("PrabSaini","Monday@10");
        }
        
        [Then(@"I should be able to login")]
        public void ThenIShouldBeAbleToLogin()
        {
            Assert.IsTrue(pageObjectManager.getMainPage().IsUserLoggedIn("Prab"));
            pageObjectManager.getMainPage().ClickLogout();
            pageObjectManager.quitDriver();
        }
    }
}
