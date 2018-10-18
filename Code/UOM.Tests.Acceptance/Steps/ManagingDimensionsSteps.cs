using System;
using FluentAssertions;
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
            model.Id = task.DefineDimension(model);
        }
        
        [Then(@"It should be appear in the list of dimensions")]
        public void ThenItShouldBeAppearInTheListOfDimensions()
        {
            var expectedDimension = ScenarioContext.Current.Get<DimensionTestModel>("Dimension");
            var actualDimension = new DimensionTasks().GetDimension(expectedDimension.Id);
            actualDimension.Should().BeEquivalentTo(expectedDimension);
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
