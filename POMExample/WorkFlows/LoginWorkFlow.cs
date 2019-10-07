using NUnit.Framework;
using OpenQA.Selenium;
using POMExample.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.WorkFlows
{
    public class LoginWorkFlow :BaseScenario
    {
        private IWebDriver driver;

        public LoginWorkFlow(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ValidLoginAsAdminFlow()
        {
            LoginPage loginPage = new LoginPage(Driver);
            DashboardPage dashboardPage = new DashboardPage(Driver);
            loginPage.TypeUsername("Tatjana");
            loginPage.TypePassword("Tatjana93.");
            loginPage.ClickOnLoginButton();
            Assert.IsTrue(dashboardPage.IsDashboardPageDisplayed());


        }
    }

}