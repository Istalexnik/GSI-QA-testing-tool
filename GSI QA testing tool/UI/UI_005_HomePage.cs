using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_005_HomePage
    {
        public static void GoTo(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//button[@id='btnguestlogina']");
            Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']");
            Finder.ClickIt(driver, "//*[contains(text(),'File a Claim')]");

            //if (driver.FindElements(By.XPath("//button[@id='btnguestlogina']")).Count != 0)
       
            //{
            //    driver.FindElement(By.XPath("//button[@id='btnguestlogina']")).Click();
            //}
            //else if (driver.FindElements(By.XPath("//a[@id='ctl00_hlNotRegistered']")).Count != 0)
            //{
            //    driver.FindElement(By.XPath("//a[@id='ctl00_hlNotRegistered']")).Click();
            //}
            //else
            //{
            //    driver.FindElement(By.XPath("//*[contains(text(),'File a Claim')]")).Click();
            //}
        }
    }
}
