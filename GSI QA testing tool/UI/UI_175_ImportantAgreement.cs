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
    internal class UI_175_ImportantAgreement
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Important Agreement (FFF)"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']"))
            {
                Debug.WriteLine("ImportantAgreement is On");
            }
            else
            {
                Debug.WriteLine("ImportantAgreement is Off");
                return;
            }

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_chkSelfCertification']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblAcceptTerms_0']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']");
        }
    }
}
