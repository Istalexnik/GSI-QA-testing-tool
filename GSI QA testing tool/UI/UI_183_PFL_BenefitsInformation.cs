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
    class UI_183_PFL_BenefitsInformation
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("PFL Unemployment Claim Confirmation"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton']"))
            {
                Debug.WriteLine("PFL_BenefitsInformation is On");
            }
            else
            {
                Debug.WriteLine("PFL_BenefitsInformation is Off");
                return;
            }
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_rblBRIPrintView_1']");

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton']");
        }
    }
}
