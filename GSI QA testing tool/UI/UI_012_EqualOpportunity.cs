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
    internal class UI_012_EqualOpportunity
    {
        public static void GoTo(IWebDriver driver, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("Equal Opportunity"))
            {
                Data.StopAtDialog();
            }



            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnAgree']"))
            {
                Debug.WriteLine("EqualOpportunity is On");
            }
            else 
            {
                Debug.WriteLine("EqualOpportunity is Off");
                return;
            }

            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnAgree']")));
          //  Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnAgree']");
        }
    }
}
