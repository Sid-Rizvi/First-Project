using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Project1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project1.Pages
{
    class TMPage
    {

        public void CreateTM(IWebDriver driver)
        {

            // create new recored for time and material
            IWebElement CreatenewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreatenewButton.Click();

           // Wait.WaitToBeVisible(driver,"Xpath","//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span",5);

            // click on Typecode dropdown and select Time
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();

            IWebElement slectTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));


            slectTime.Click();

            // enter the code in textbox
            IWebElement codeTxtbox = driver.FindElement(By.Id("Code"));
            codeTxtbox.SendKeys("October2021");

            // enter the description
            IWebElement descriptiontxtbox = driver.FindElement(By.Id("Description"));
            descriptiontxtbox.SendKeys("October2021");

            // enter per unit price
            IWebElement pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricetag.Click();

            IWebElement priceTxtbox = driver.FindElement(By.Id("Price"));
            priceTxtbox.SendKeys("12");


            // click save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(2000);

            // Goto the lastpage button            
            IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageButton.Click();

            // check if the time record is created and matches the entered value in typecode
            IWebElement Recordtypevalue = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (Recordtypevalue.Text == "October2021")
            {
               Assert.Pass("Time record has ben created");
            }
            else
            {
                Assert.Fail("Test has failed");
            }
        }
        /*
            public void EditTM(IWebDriver driver)
            {

                // Click the Edit button
                IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                EditButton.Click();


                // click on Typecode dropdown and select Time
                IWebElement typecodedropdownEdit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
                typecodedropdownEdit.Click();

                IWebElement slectEditTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
                slectEditTime.Click();

                //Erase the text from code textbox

                IWebElement codeTxtboxEdit = driver.FindElement(By.Id("Code"));
                codeTxtboxEdit.Clear();
                codeTxtboxEdit.SendKeys("November2021");

                // enter the description
                IWebElement descriptiontxtboxEdit = driver.FindElement(By.Id("Description"));
                descriptiontxtboxEdit.Clear();
                descriptiontxtboxEdit.SendKeys("December2021");

                // click save button
                IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
                saveButton1.Click();

                Thread.Sleep(2000);

                //  check if the time record is updated and matches the entered values 
                IWebElement gotolastpageEditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

                gotolastpageEditButton.Click();
                          
                // check if the time record is created and matches the entered value in typecode
                IWebElement RecordtypevalueEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement RecordtypedescriptionEdit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

                if (RecordtypevalueEdit.Text == "November2021" && RecordtypedescriptionEdit.Text == "December2021")
                {
                    Console.WriteLine("Time record has ben updated");
                }
                else
                {
                    Console.WriteLine("Test has failed");
                }

                }

        public void DeleteTM(IWebDriver driver)
        {

            // Deleting the updated record

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();

            IAlert confirmationAlert = driver.SwitchTo().Alert();

            confirmationAlert.Accept();

            //Goto the lastpage button
            
            IWebElement gotolastpageDeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpageDeleteButton.Click();

            // check if the time record is created and matches the entered value in typecode
            IWebElement RecordtypevalueDelete = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (RecordtypevalueDelete.Text != "November2021")
            {
                Console.WriteLine("Time record has ben deleted");
            }
            else
            {
                Console.WriteLine("Test has been failed");
            }

        }*/
    }
}
