using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool
{
    public class Finder
    {

        public static bool FindIt(IWebDriver driver, String path)
        {
            return driver.FindElements(By.XPath(path)).Count != 0;
           
        }


        public static void ClickIt(IWebDriver driver, String path)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)

            {
                driver.FindElement(By.XPath(path)).Click();
            }
        }



        public static void SendText(IWebDriver driver, String path, String text)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)

            {
                driver.FindElement(By.XPath(path)).SendKeys(text);
            }
        }


        public static void UseAlert(IWebDriver driver, int time)
        {
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(time);
            alert.Accept();
        }


        public static void UseDropDownByValue(IWebDriver driver, String path, String value)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
            select.SelectByValue(value);
        }

        public static void UseDropDownByText(IWebDriver driver, String path, String value)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
            select.SelectByText(value);
        }

        public static void UseDropDownByIndex(IWebDriver driver, String path, int value)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
            select.SelectByIndex(value);
        }



    }
}
