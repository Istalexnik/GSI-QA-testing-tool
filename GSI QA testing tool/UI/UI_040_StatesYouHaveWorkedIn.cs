using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_040_StatesYouHaveWorkedIn
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("States You Have Worked In"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblStatesWorkedIn_1']"))
            {
                Debug.WriteLine("StatesYouHaveWorkedIn is On");
            }
            else
            {
                Debug.WriteLine("StatesYouHaveWorkedIn is Off");
                return;
            }




            if (Data._claimType == 4)
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblStatesWorkedIn_0']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_chkStateHostState']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_chkStateList_9']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblAppliedUCPast12Months_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Credit Weeks(PA)
                if (Data._StopAt.Contains("States You Have Worked In Credit Weeks"))
                {
                    Data.StopAtDialog();
                }


                if (Finder.FindIt(driver, "//*[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ1']"))
                {
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ1']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ2']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ3']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ4']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ5']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ1']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ2']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ3']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ4']", Data._CreditWeeks);
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ5']", Data._CreditWeeks);
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
                }

                // Interstate Claim
                if (Data._StopAt.Contains("States You Have Worked In Interstate Claim"))
                {
                    Data.StopAtDialog();
                }


                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFileInHostState_0']");
                Finder.UseAlert(driver, 1500);
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            }
            else
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblStatesWorkedIn_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblAppliedUCPast12Months_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            }






        }
    }
}
