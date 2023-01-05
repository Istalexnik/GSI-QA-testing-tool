using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_010_IndividualPage
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Individual Page"))
            {
                Data.StopAtDialog();
            }


            if(Data._Staff == true)
            {
                Finder.SendText(driver, "//input[@id='txtUserName']", Data._StaffLogin);
                Finder.SendText(driver, "//input[@id='txtPassword']", Data._StaffPass);
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_cmdLoginButt']");
            }
            else
            {
                Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']");
                Finder.ClickIt(driver, "//button[@id='btnguestlogina']");
                Finder.ClickIt(driver, "//input[@id='btnIndRegistration']");
            }




            //if (driver.FindElements(By.XPath("//a[@id='ctl00_hlNotRegistered']")).Count != 0)
            //{
            //    driver.FindElement(By.XPath("//a[@id='ctl00_hlNotRegistered']")).Click();
            //}
            //else if (driver.FindElements(By.XPath("//button[@id='btnguestlogina']")).Count != 0)
            //{
            //    driver.FindElement(By.XPath("//button[@id='btnguestlogina']")).Click();
            //}
            //else
            //{
            //    driver.FindElement(By.XPath("//input[@id='btnIndRegistration']")).Click();
            //}
        }
    }
}
