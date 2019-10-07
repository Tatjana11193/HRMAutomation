using NUnit.Framework;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.Scenarios
{
    class ResetYourPasswordScenario : BaseScenario
    {
        [Test]

        public void ResetYourForgottenPasswordThroughLoginPageNoSuccess()
        {
            LoginPage loginPage = new LoginPage(Driver);
            ReseetYourPasswordPage resetYourPasswordPage = new ReseetYourPasswordPage(Driver);

            //arrange 

            string usernameforRessetingPass = "Tatjana";
            string message = "Password reset email could not be sent\r\nClose";

            //act
            loginPage.ClickOnForgotYourPassword();

            //Assert
            Assert.IsTrue(resetYourPasswordPage.IsResetYourPasswordPageDisplayed());

            //act 
            resetYourPasswordPage.EnterUsernameForRessetingPassword(usernameforRessetingPass);
            resetYourPasswordPage.ClickOnResetButton();

            //Assert

            Assert.AreEqual(message, resetYourPasswordPage.GetTemporaryWarningMessage());
        }
    }
}
