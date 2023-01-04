using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    internal class UI_045_FederalService
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("Federal Service"))
            {
                Data.StopAtDialog();
            }





            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']"))
            {
                Debug.WriteLine("FederalService is On");
            }
            else
            {
                Debug.WriteLine("FederalService is Off");
                return;
            }





            if (Data._claimType == 3)
            {

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_0']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeHostState_0']");
                Finder.ClickIt(driver, "//button[@id='btn-dialog-save']");

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeAnotherState_1']");
                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_rblHasOtherStateWages_1']");
                if (!Data._Site.Contains("TN"))
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblLastOfficialDutyStationOutsideUS_1']");
                }
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_txtLastOfficialDutyStationLocation']", Data._State);
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");


                // Federal Work
                if (Data._StopAt.Contains("Federal Service Federal Work 1"))
                {
                    Data.StopAtDialog();
                }

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_0']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

                // Federal Civilian Work History
                if (Data._StopAt.Contains("Federal Service Federal Work History"))
                {
                    Data.StopAtDialog();
                }


                Thread.Sleep(500);


                if (Data._Site.Contains("TN"))
                {

                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtEmpName']", "US Senate");
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_ddlCountry_ddlCountry']", "US");
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtAddress1']", "1010 Street");
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtCity']", "Nashville");
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_ddlState']", "TN");
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtZip']", "37243");

                }


                if (Data._Site.Contains("PR"))
                {
                    Finder.ActionsSendText(driver, "//*[@id='cmbCustomFIC']", "AD");
                    Thread.Sleep(3000);
                }
                else
                {
                    Finder.ActionsSendText(driver, "//*[@id='cmbCustomFIC']", Data._FIC);
                    Thread.Sleep(3000);
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlDestCodes']", "0001");
                }


                Finder.WaitClickableClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblInterveningEmploymentSinceSeparation_1']", wait);
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
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblSepDueToGovShutdown_1']");

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

                if (Data._StopAt.Contains("Federal Service Federal Work 2"))
                {
                    Data.StopAtDialog();
                }


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
