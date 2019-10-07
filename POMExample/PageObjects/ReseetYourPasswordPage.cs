using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class ReseetYourPasswordPage
    {
        IWebDriver driver;
        By forgotPassUsernameField = By.Id("securityAuthentication_userName");
        By resetPasswordButton = By.Id("btnSearchValues");
        By cancelResetPass = By.Id("btnCancel");
        By message = By.ClassName("fadable");

        public ReseetYourPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public bool IsResetYourPasswordPageDisplayed()
        {
            By resetPassword = By.Id("resetPasswordForm");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(resetPassword)).Displayed;
        }

        public void EnterUsernameForRessetingPassword(string usernameforRessetingPass)

        {
            driver.FindElement(forgotPassUsernameField).Clear();
            driver.FindElement(forgotPassUsernameField).SendKeys(usernameforRessetingPass);
        }

        public void ClickOnResetButton()
        {
            driver.FindElement(resetPasswordButton).Click();
        }

        public string GetTemporaryWarningMessage()
        {
            var element = driver.FindElement(message);
            return element.Text;
        }
    }
}
