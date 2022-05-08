using BuggyCarsRatingUIAutomation.Managers;
using System;
using TechTalk.SpecFlow;

namespace BuggyCarsRatingUIAutomation.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps
    {
        PageObjectManager pageObjectManager;

        public UserRegistrationSteps()
        {
            pageObjectManager = new PageObjectManager();

        }

        [When(@"I try to register my self")]
        public void WhenITryToRegisterMySelf()
        {
            pageObjectManager.getMainPage().ClickRegisterBtn();
            pageObjectManager.getRegistrationPage().NewUserRegistration(pageObjectManager.getRegistrationPage().UserName());
        }
        
        [Then(@"I should be able to successfully registered as a valid user\.")]
        public void ThenIShouldBeAbleToSuccessfullyRegisteredAsAValidUser_()
        {
            pageObjectManager.getRegistrationPage().SuccessfullRegistration();
            pageObjectManager.quitDriver();
        }
    }
}
