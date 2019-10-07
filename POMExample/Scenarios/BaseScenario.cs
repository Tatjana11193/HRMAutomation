using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POMExample.PageObjects
{ 
    public class BaseScenario
    {
        public static IWebDriver Driver { get; set; }

       [SetUp]
        public void BeforeTest()
        {
           
         Driver = new ChromeDriver();
         Driver.Manage().Window.Maximize();
         Driver.Navigate().GoToUrl("https://intnstest/orangehrm-4.3.2");
        }

        [TearDown]
        public void AfterTest()
        {
            Driver.Quit();
        }

      


    }
}


