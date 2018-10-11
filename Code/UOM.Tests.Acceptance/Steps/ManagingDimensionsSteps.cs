using System;
using TechTalk.SpecFlow;
using UOM.Tests.Acceptance.Model;
using UOM.Tests.Acceptance.Tasks;

namespace UOM.Tests.Acceptance.Steps
{
    [Binding]
    public class ManagingDimensionsSteps
    {
        [Given(@"I have a dimension called '(.*)'")]
        public void GivenIHaveADimensionCalled(string dimension)
        {
            var model = new DimensionTestModel() { Name = dimension };
            ScenarioContext.Current.Add("Dimension", model);
        }
        
        [Given(@"I have already defined a dimension called '(.*)'")]
        public void GivenIHaveAlreadyDefinedADimensionCalled(string p0)
        {
        }
        
        [When(@"I register the dimension")]
        public void WhenIRegisterTheDimension()
        {
            var model = ScenarioContext.Current.Get<DimensionTestModel>("Dimension");
            var task = new DimensionTasks();
            task.DefineDimension(model);
        }
        
        [Then(@"It should be appear in the list of dimensions")]
        public void ThenItShouldBeAppearInTheListOfDimensions()
        {
            //TODO:just for the test cause
            var task = new DimensionTasks();
            var dimension = task.GetDimension(Guid.Parse("98B87D78-37DA-4876-8742-21997BFF93C9"));
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
