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
    internal class UI_013_PrivacyAgreement
    {
        public static void GoTo(IWebDriver driver)
        {


            if (Data._StopAt.Contains("Privacy Agreement"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucPrivacyAgreement_btnAgree']")) 
            {
                Debug.WriteLine("PrivacyAgreement is On");
            }
            else
            {
                Debug.WriteLine("PrivacyAgreement is Off");
                return;
            }


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPrivacyAgreement_chkCertification']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPrivacyAgreement_chkAuthorization']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucPrivacyAgreement_btnAgree']");
        }
    }
}
