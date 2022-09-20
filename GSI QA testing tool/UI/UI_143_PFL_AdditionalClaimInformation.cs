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
    internal class UI_143_PFL_AdditionalClaimInformation
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("PFL Additional ClaimInformation"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1']"))
            {
                Debug.WriteLine("PFL_AdditionalClaimInformation is On");
            }
            else
            {
                Debug.WriteLine("PFL_AdditionalClaimInformation is Off");
                return;
            }

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1']");

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingLongTermBenefits_1']");

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblSelfEmploymentIncome_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblAuthorizeDOESNotifyEmp_1']");

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

        }
    }
}
