using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace UOM.Tests.Acceptance
{
    [Binding]
    public class ManagingDimensionsSteps
    {
        private string _dimension = "";

        [Given(@"I have a dimension called '(.*)'")]
        public void GivenIHaveADimensionCalled(string dimension)
        {
            this._dimension = dimension;
        }
        
        [Given(@"I have already defined a dimension called '(.*)'")]
        public void GivenIHaveAlreadyDefinedADimensionCalled(string p0)
        {
        }
        
        [When(@"I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
            //TODO: refactor and complete these tests
            var dimension = new {Name = this._dimension};
            var client = new RestClient("http://localhost:20070/api");
            var request = new RestRequest("Dimensions", Method.POST);
            request.AddObject(dimension);
            var response = client.Execute(request);
        }
        
        [Then(@"It should be appear in the list of dimensions")]
        public void ThenItShouldBeAppearInTheListOfDimensions()
        {
        }
        
        [Then(@"The system should prevent me from registering the dimension")]
        public void ThenTheSystemShouldPreventMeFromRegisteringTheDimension()
        {
        }
        
        [Then(@"It should warned that the dimension is duplicated")]
        public void ThenItShouldWarnedThatTheDimensionIsDuplicated()
        {
        }
    }
}
