using System;
using TechTalk.SpecFlow;

namespace SpecRunTest.Steps
{
    [Binding]
    public class TestSpecRunSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine("I have entered (.*) into the calculator");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("call to when");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Console.WriteLine("call to then");
        }
    }
}
