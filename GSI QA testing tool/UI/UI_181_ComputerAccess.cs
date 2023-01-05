using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    class UI_181_ComputerAccess
    {
        public static void GoTo(IWebDriver driver)
        {
            if (Data._StopAt.Contains("Computer Access"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblClaimantHasComputerAccess_1']"))
            {
                Debug.WriteLine("Computer Access is On");
            }
            else
            {
                Debug.WriteLine("Computer Access is Off");
                return;
            }




            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblClaimantHasComputerAccess_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton']");


        }
    }
}
