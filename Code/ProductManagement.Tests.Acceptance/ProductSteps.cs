using System;
using TechTalk.SpecFlow;

namespace ProductManagement.Tests.Acceptance
{
    [Binding]
    public class ProductSteps
    {
        [Given(@"I have already defined the following constraints")]
        public void GivenIHaveAlreadyDefinedTheFollowingConstraints(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have define a generic product '(.*)'")]
        public void WhenIHaveDefineAGenericProduct(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have defined the following constraint for it :")]
        public void WhenIHaveDefinedTheFollowingConstraintForIt(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should be available in the list of generic products")]
        public void ThenItShouldBeAvailableInTheListOfGenericProducts()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
