using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_Tutorial_classLib_newFramework.StepDefinitions
{
    [Binding]
    public sealed class User_Client_ScopeBinding_Demo_Steps
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {

        }

        [Given(@"I login to application")]
        //[Scope(Feature = "CustomerLogin_ScopeBindings_Demo")]
        //[Scope(Scenario = "Login for customer portal")]
        [Scope(Tag = "customerLogin")] //customerLogin is the hook used for the feature @tag
        public void GivenILoginToApplication()
        {
            Console.WriteLine("logging in to the Customer portal");
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {

        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {

        }


    }
}
