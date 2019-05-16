using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_Tutorial_classLib_newFramework.StepDefinitions
{
    [Binding]
    public sealed class UserLogin_scopeBinding_demo
    {
        [Given(@"I login to application")]
        //[Scope(Feature = "User_Login_ScopeBinding_Demo")]
        //[Scope(Scenario = "Login for user portal")]
        [Scope(Tag = "userLogin")]
        public void GivenILoginToApplication()
        {
            Console.WriteLine("Login in to the user login portal");
        }
    }
}
