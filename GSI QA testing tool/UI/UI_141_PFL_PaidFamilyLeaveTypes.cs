using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSI_QA_testing_tool.Utilities;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_141_PFL_PaidFamilyLeaveTypes
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("PFL Paid Family Leave Types"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0']"))
            {
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is On");
            }
            else
            {
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLMethod_0']");

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

        }
    }
}
