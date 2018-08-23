using System;
using TechTalk.SpecFlow;

namespace UOM.Tests.Acceptance
{
    [Binding]
    public class ManagingDimensionsSteps
    {
        [Given(@"I have a dimension called '(.*)'")]
        public void GivenIHaveADimensionCalled(string p0)
        {
        }
        
        [Given(@"I have already defined a dimension called '(.*)'")]
        public void GivenIHaveAlreadyDefinedADimensionCalled(string p0)
        {
        }
        
        [When(@"I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
        }
        
        [Then(@"It should be available in the list of system dimensions")]
        public void ThenItShouldBeAvailableInTheListOfSystemDimensions()
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
