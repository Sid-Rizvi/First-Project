using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Utilities
{
    public class CommonDriver

    {
        public static IWebDriver driver;
        
        [OneTimeSetUp]
        public void LoginActions()
        {
            // open chrome browser
              driver = new ChromeDriver();

            // LoginPage object intialization and defination
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginSteps(driver);

            // HomePage object intialization and defination
            HomePage HomePageObj = new HomePage();
            HomePageObj.GotoTMPage(driver);

        }

        [OneTimeTearDown]
        public void CloseTest()
        {
            driver.Quit();

        }


    }
}
