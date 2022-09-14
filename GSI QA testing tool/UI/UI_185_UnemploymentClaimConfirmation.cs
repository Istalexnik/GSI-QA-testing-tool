using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_185_UnemploymentClaimConfirmation
    {
        public static void GoTo(IWebDriver driver)
        {
            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnNext']"))
            {
                Debug.WriteLine("UnemploymentClaimConfirmation is On");
            }
            else
            {
                Debug.WriteLine("UnemploymentClaimConfirmation is Off");
                return;
            }

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
