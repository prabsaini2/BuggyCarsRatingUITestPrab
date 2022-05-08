using BuggyCarsRatingUIAutomation.Managers;
using System;
using TechTalk.SpecFlow;

namespace BuggyCarsRatingUIAutomation.StepDefinitions
{
    [Binding]
    public class ValidateSingleUserRegisterationSteps
    {
        PageObjectManager pageObjectManager;

        public ValidateSingleUserRegisterationSteps()
        {
            pageObjectManager = new PageObjectManager();

        }

        [When(@"I try to register my self onceagain\.")]
        public void WhenITryToRegisterMySelfOnceagain_()
        {
            pageObjectManager.getMainPage().ClickRegisterBtn();
            //Ideally value should be picked from app.config
            pageObjectManager.getRegistrationPage().NewUserRegistration("PrabSaini");
        }
        
        [Then(@"Application should not allow that\.")]
        public void ThenApplicationShouldNotAllowThat_()
        {
            pageObjectManager.getRegistrationPage().UnSuccessfullRegistration();
            pageObjectManager.quitDriver();
        }
    }
}
