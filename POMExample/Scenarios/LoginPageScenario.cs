using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POMExample
{

   
    public class LoginPageScenario : BaseScenario
    {
        [Test]

        public void LoginSuccessfully()
        {
            LoginPage loginPage = new LoginPage(Driver);
            DashboardPage dashboardPage = new DashboardPage(Driver);

            //arrange 
            string userName = "Tatjana";
            string passWord = "Tatjana93.";

            //act 
            loginPage.TypeUsername(userName);
            loginPage.TypePassword(passWord);
            loginPage.ClickOnLoginButton();

            //assert 

            Assert.IsTrue(dashboardPage.IsDashboardPageDisplayed());
        }

        [Test]                                                           // this is parameterized test
        [TestCase("", "Tatjana93.", "Username cannot be empty")]
        [TestCase("Tatjana", "", "Password cannot be empty")]

        public void LoginWithEmptyMandatoryFields(string username, string password, string message)
        {
            LoginPage loginPage = new LoginPage(Driver);

            //act
            loginPage.TypeUsername(username);
            loginPage.TypePassword(password);
            loginPage.ClickOnLoginButton();

            //assert 

            Assert.AreEqual(message, loginPage.GetLoginWarningMessage());
        }
                           
    }

}
