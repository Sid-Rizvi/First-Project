using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.Pages;
using Project1.Utilities;
using System;
using System.Threading;

namespace Project1
{ [TestFixture]
    class TM_Tests:CommonDriver

    {       
       
        [Test]
        public void CreateTMTest(IWebDriver driver)
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);
        }

       /*[Test]
        public void EditTMTest(IWebDriver driver)
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest(IWebDriver driver)
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }*/

       
    }
}

   
    
    

