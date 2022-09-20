using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_035_WorkHistoryVerification
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Work History Verification"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']")) 
            {
                Debug.WriteLine("WorkHistoryVerification is On");
            }
            else
            {
                Debug.WriteLine("WorkHistoryVerification is Off");
                return;
            }





            if (Data._Site.Contains("PUA"))
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1']");
            }
            else
            {
                if (Data._BasePeriod)
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']");
                }
                else
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1']");
                }
            }
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

        }

    }
    
}
