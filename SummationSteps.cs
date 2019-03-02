using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDD_Tutorial_classLib_netFramework
{
    [Binding]
    public class SummationSteps
    {
        public static int sumValue = 0;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            Console.WriteLine("No passed: "+number);
            sumValue += number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Clicking on the Add Button");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, sumValue, "Expected sum: " + expectedNumber + "but actual result is:" + sumValue);
            Console.WriteLine("Result is: "+ expectedNumber);
        }
    }
}
