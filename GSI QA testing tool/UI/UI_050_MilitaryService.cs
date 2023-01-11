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
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_050_MilitaryService
    {
        public static void GoTo(IWebDriver driver)
        {

            Thread.Sleep(500);


            if (Data._StopAt.Contains("Military Service"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_1']"))
            {
                Debug.WriteLine("MilitaryService is On");
            }
            else
            {
                Debug.WriteLine("MilitaryService is Off");
                return;
            }




            if (Data._claimType == 2)
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_0']");

                if (Finder.FindIt(driver, "//select[@id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']"))
                {
                    Finder.UseDropDownByText(driver, "//select[@id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']", Data._State);
                    Finder.ClickIt(driver, "//button[@id='btn-dialog-ok']");
                }

                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_rblPhysicallyInState_0']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Military Work
                if (Data._StopAt.Contains("Military Service Work 1"))
                {
                    Data.StopAtDialog();
                }

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_0']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Military Service Employment Information
                if (Data._StopAt.Contains("Military Service Employment Information"))
                {
                    Data.StopAtDialog();
                }

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblFiledInStateAfterSeparation_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMember4OfDD214_0']");

                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlServiceBranch']", 1);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceEntryDate']", Data._WorkedFrom1);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceSeparationDate']", Data._WorkedTo1);
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlDischargeStatus']", "01");
                Finder.UseDropDownByValue(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlReasonForSeparation']", "1");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblSepDueToGovShutdown_1']");

                
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlPayGrade']", "27");
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtAccuredDaysOfLeave']", "0");
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtLostDays']", "0");

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblDischargePhysicalDisability_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMilitaryRetiree_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblCompletedFirstFullTermDuty_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblSubsistenceVocRehabTraining_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblWarOrphanWidowsEducationAllowance_1']");

                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Military Work
                if (Data._StopAt.Contains("Military Service Work 2"))
                {
                    Data.StopAtDialog();
                }

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            }
            else
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            }













        }
    }
}
