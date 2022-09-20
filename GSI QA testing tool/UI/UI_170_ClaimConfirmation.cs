using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GSI_QA_testing_tool.Utilities;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_170_ClaimConfirmation
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Claim Confirmation"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnCertifyClaim']"))
            {
                Debug.WriteLine("ClaimConfirmation is On");
            }
            else
            {
                Debug.WriteLine("ClaimConfirmation is Off");
                return;
            }


            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnCertifyClaim']");
        }
    }
}
