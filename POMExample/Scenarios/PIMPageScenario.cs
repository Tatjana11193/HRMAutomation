using NUnit.Framework;
using POMExample.PageObjects;
using POMExample.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.Scenarios
{
    class PIMPageScenario : BaseScenario 
    {
        [Test]

        public void AddEmployeeThoughAddEmployeeTab()
        {
            PIMPage pimPage = new PIMPage(Driver);
            LoginWorkFlow loginWorkFlow = new LoginWorkFlow(Driver);

            //arrange
            string firstName = "Mikica";
            string lastName = "Misic";
            
           //act
            loginWorkFlow.ValidLoginAsAdminFlow();                     
            pimPage.SelectPIMTab();  
            pimPage.AddEmployee(firstName, lastName);
            
            //assert
            Assert.IsTrue(pimPage.ArePersonalDetailsDisplayed());
        }
    }
}
