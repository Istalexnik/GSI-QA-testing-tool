using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_045_FederalService
    {
        public static void GoTo(IWebDriver driver)
        {
            if (Data._claimType == 3)
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_0']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeHostState_0']");
                Finder.ClickIt(driver, "//button[@id='btn-dialog-save']");

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeAnotherState_1']");
                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_rblHasOtherStateWages_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblLastOfficialDutyStationOutsideUS_1']");
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_txtLastOfficialDutyStationLocation']", Data._State);
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");


                // Federal Work
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_0']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Federal Civilian Work History
                Finder.ActionsSendText(driver, "//*[@id='cmbCustomFIC']", Data._FIC);
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlDestCodes']", "0001");
                Finder.WaitStaleClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblInterveningEmploymentSinceSeparation_1']", 10);
                Finder.UseDropDownByText(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlStateOfEmployment']", Data._State);
                Thread.Sleep(2000);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtOutofCountryCity']", Data._City);
                Thread.Sleep(2500);
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm8_0']");
                Thread.Sleep(2000);
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm50_0']");
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtDateBeganWork']", Data._WorkedFrom1);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtLastDayWorked']", Data._WorkedTo1);
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlReasonForSeparation']", "0001");
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlEmployerNAICS']", 1);
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlPositionOccGroupCode']", 1);

                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter1']", Data._Wages);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter2']", Data._Wages);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter3']", Data._Wages);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter4']", Data._Wages);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter5']", Data._Wages);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter6']", Data._Wages);

                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ1CreditWeeks']", Data._CreditWeeks);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ2CreditWeeks']", Data._CreditWeeks);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ3CreditWeeks']", Data._CreditWeeks);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ4CreditWeeks']", Data._CreditWeeks);

                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblWorkedInStateAfterFederalEmployment_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblOtherEmploymentLastNMonths_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");


            }
            else
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            }



        }
    }
}
