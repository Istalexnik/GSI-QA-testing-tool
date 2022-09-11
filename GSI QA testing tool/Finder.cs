using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls.Primitives;
using static System.Net.Mime.MediaTypeNames;

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


        public static void ClickIt(IWebDriver driver, String path, Double time)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            { 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath(path)))).Click();
            wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))));
            }
        }


        public static void WaitStaleClickIt(IWebDriver driver, String path, Double time)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))));
                wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath(path)))).Click();
            }
        }





        public static void SendText(IWebDriver driver, String path, String text)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)

            {
                driver.FindElement(By.XPath(path)).SendKeys(text);
            }
        }


        public static void WaitStaleSendText(IWebDriver driver, String path, String text, Double time)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)

            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))));
                driver.FindElement(By.XPath(path)).SendKeys(text);
            }
        }




        public static void ActionsSendText(IWebDriver driver, String path, String text)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                Actions act = new Actions(driver);
                act.MoveToElement(driver.FindElement(By.XPath(path)));
                act.Click();
                act.SendKeys(text);
                act.Pause(new TimeSpan(7000));
                act.SendKeys(Keys.Down);
                act.Pause(new TimeSpan(1000));
                act.SendKeys(Keys.Enter);
                act.Pause(new TimeSpan(1000));
                act.Build().Perform();
            }
        }



        public static void UseAlert(IWebDriver driver, int time)
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                Thread.Sleep(time);
                alert.Accept();
            }
            catch (NoAlertPresentException nap)
            {
                Debug.WriteLine(nap.Message);
            }
        }


        public static void WaitDocToLoad(IWebDriver driver, Double time)
        {
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }





        public static void UseDropDownByValue(IWebDriver driver, String path, String value)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
                select.SelectByValue(value);
            }
        }

        public static void UseDropDownByText(IWebDriver driver, String path, String value)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
                select.SelectByText(value);
            }
        }

        public static void UseDropDownByIndex(IWebDriver driver, String path, int value)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
                select.SelectByIndex(value);
            }
        }


        public static void UseDropDownByIndex(IWebDriver driver, String path, int value, Double time)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)
            {
                SelectElement select = new SelectElement(driver.FindElement(By.XPath(path)));
                select.SelectByIndex(value);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))));
            }
        }













    }
}
