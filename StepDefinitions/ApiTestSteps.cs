
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace BuggyCarsRatingUIAutomation.StepDefinitions
{
    [Binding]
    public class ApiTestSteps
    {
        private APIRequest aPIRequest;

        public ApiTestSteps()
        {
            this.aPIRequest = new APIRequest();

        }

        [Given(@"I send the API Resquest")]
        public void GivenISendTheAPIResquest()
        {           
          var Response = aPIRequest.GetBuggyCarsHttpWebRequest();
          var Response1 =  aPIRequest.GetBuggyCarRequest();
          var Resoinse2  =  aPIRequest.GetBuggyCarApi();

            }
        
        [When(@"I get the response")]
        public void WhenIGetTheResponse()
        {
            
        }
        
        [Then(@"I verify status is (.*)")]
        public void ThenIVerifyStatusIs(int p0)
        {
            
        }
    }
}
