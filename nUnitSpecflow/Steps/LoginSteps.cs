using nUnitSpecflow.Hooks;
using nUnitSpecflow.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace nUnitSpecflow.Steps
{
    internal class LoginSteps : BaseSteps
    {
        public LoginSteps(MyDriverManager myDriverManager) : base(myDriverManager) { }

        [Given(@"user opens the login page")]
        public void GivenUserOpensTheLoginPage()
        {
            CurrentPage = new LoginPage(DriverManager);
        }

        [When(@"user logins with username ""([^""]*)"" and password ""([^""]*)""")]
        public void WhenUserLoginsWithUsernameAndPassword(string username, string password)
        {
            CurrentPage = ((LoginPage)CurrentPage).LoginAndGetInventoryPage(username, password);
        }

        [Then(@"the inventory page is displayed")]
        public void ThenTheInventoryPageIsDisplayed()
        {
        }

    }
}
