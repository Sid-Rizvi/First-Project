using OpenQA.Selenium;
using Project1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Pages
{
    public class HomePage
    {

        public void GotoTMPage(IWebDriver driver)
        {
            // Click on administrationtTab
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

           Wait.WaittobeClickalble(driver,"Xpath","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",3);


            // Select Time and material from dropdown
            IWebElement Tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            Tmoption.Click();

        }


    }
}
