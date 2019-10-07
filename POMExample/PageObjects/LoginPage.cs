using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;
        By username = By.Id("txtUsername");
        By passsword = By.Id("txtPassword");
        By loginButton = By.Id("btnLogin");
        By forgotYourPasswordLink = By.XPath("//*[@id='forgotPasswordLink']/a");
        By usernameLoginMessage = By.Id("spanMessage");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername(string userName)
        {
            driver.FindElement(username).Clear();
            driver.FindElement(username).SendKeys(userName);
        }
        public void TypePassword(string passWord)
        {
            driver.FindElement(passsword).Clear();
            driver.FindElement(passsword).SendKeys(passWord);

        }

        public void ClickOnLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }

        public void ClickOnForgotYourPassword()
        {
            driver.FindElement(forgotYourPasswordLink).Click();

        }
        public string GetLoginWarningMessage()
        {
            var element = driver.FindElement(usernameLoginMessage);
            return element.Text;
        }

    }
}
