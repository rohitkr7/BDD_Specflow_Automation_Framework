using BDD_Tutorial_classLib_newFramework.Objects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD_Tutorial_classLib_newFramework.StepDefinitions
{
    [Binding]
    public class Scenario_OutlineDemoSteps
    {
        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            EmployeeDetails details = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Age);
            Console.WriteLine(details.Phone);
            Console.WriteLine(details.Email);
        }

        [When(@"I fill all the mandatory details in form with multiple Data")]
        public void WhenIFillAllTheMandatoryDetailsInFormWithMultipleData(Table table)
        {
            var details = table.CreateSet<EmployeeDetails>();
            foreach (var emp in details)
            {
                Console.WriteLine("Details of Employee: "+emp.Name);
                Console.WriteLine("*******************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Email);
            }
        }

        [When(@"I fill all the mandatory details in form with multiple Data using Specflow_Assist_Dynamics")]
        public void WhenIFillAllTheMandatoryDetailsInFormWithMultipleDataUsingSpecflow_Assist_Dynamics(Table table)
        {
            //we need to add Specflow.Assist.Dynamics from nuget package to use the following
            var details = table.CreateDynamicSet();
            foreach (var emp in details)
            {
                Console.WriteLine("Details of Employee: " + emp.Name);
                Console.WriteLine("*******************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Email);
            }
        }

        [When(@"I fill all the mandatory details in form (.*),(.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInForm(string name, int age, Int64 phone)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone: " + phone);
        }
    }
}
