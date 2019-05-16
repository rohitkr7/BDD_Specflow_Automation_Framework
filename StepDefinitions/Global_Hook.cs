using System;
using TechTalk.SpecFlow;

namespace BDD_Tutorial_classLib_newFramework.StepDefinitions
{
    [Binding]
    public sealed class Global_Hook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public void BeforeFeature()
        {
            Console.WriteLine("Before Feature Hook");
        }

        [AfterFeature]
        public void AfterFeature()
        {
            Console.WriteLine("After Feature Hook");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("This is global binding hook.... Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("This is global binding hook.... After Scenario");

        }
    }
}
