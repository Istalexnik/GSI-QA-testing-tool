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
    internal class UI_139_PFL_ClaimFiling
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("PFL Claim Filing"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_rblPFLClaimProceed_0']"))
            {
                Debug.WriteLine("PFL_ClaimFiling is On");
            }
            else
            {
                Debug.WriteLine("PFL_ClaimFiling is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblPFLClaimProceed_0']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
