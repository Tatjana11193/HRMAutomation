using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{
    class PIMPage
    {
        IWebDriver driver;
        By pimTab = By.Id("menu_pim_viewPimModule");
        By addEmployeeSection = By.Id("menu_pim_addEmployee");
        By firstNameField = By.Id("firstName");
        By lastNameField = By.Id("lastName");
        By saveButton = By.Id("btnSave");
        By personalDetailsBar = By.Id("pdMainContainer");
        By PIMTabOptions = By.XPath("//*[@id='wrapper']/div[2]/ul/li[2]/ul");
        By addEmployeeTable = By.Id("addEmployeeTbl");
      


        public PIMPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddEmployee(string firstName, string lastName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(addEmployeeSection));
            driver.FindElement(addEmployeeSection).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(addEmployeeTable));
            driver.FindElement(firstNameField).SendKeys(firstName);
            driver.FindElement(lastNameField).SendKeys(lastName);
            driver.FindElement(saveButton).Click();
        }
        public void SelectPIMTab()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(pimTab));
            driver.FindElement(pimTab).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PIMTabOptions));
        }

        public void SelectAddEmployeeSection()
        {
            driver.FindElement(addEmployeeSection).Click();
        }
        public void EnterFirstName(string firstName)
        {
            driver.FindElement(firstNameField).SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            driver.FindElement(lastNameField).SendKeys(lastName);
        }
        public void SaveNewEmployee()
        {
            driver.FindElement(saveButton).Click();
        }

       

        public bool ArePersonalDetailsDisplayed()
        {
           
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(personalDetailsBar)).Displayed;
        }


    }
}

