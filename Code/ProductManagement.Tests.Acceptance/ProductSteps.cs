using System;
using TechTalk.SpecFlow;

namespace ProductManagement.Tests.Acceptance
{
    [Binding]
    public class ProductSteps
    {
        [Given(@"I have a product called '(.*)'")]
        public void GivenIHaveAProductCalled(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I register the product")]
        public void WhenIRegisterTheProduct()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should be available in the list of system Product Management")]
        public void ThenItShouldBeAvailableInTheListOfSystemProductManagement()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
