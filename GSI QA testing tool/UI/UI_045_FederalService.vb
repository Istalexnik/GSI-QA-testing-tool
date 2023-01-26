Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Security.Claims
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Controls.Primitives

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_045_FederalService
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("Federal Service") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']") Then
                Debug.WriteLine("FederalService is On")
            Else
                Debug.WriteLine("FederalService is Off")
                Return
            End If

            If Data._claimType = 3 Then
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_0']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeHostState_0']")
                Finder.ClickIt(driver, "//button[@id='btn-dialog-save']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeAnotherState_1']")
                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_rblHasOtherStateWages_1']")

                If Not Data._Site.Contains("TN") Then
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblLastOfficialDutyStationOutsideUS_1']")
                End If

                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_txtLastOfficialDutyStationLocation']", Data._State)
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Federal Service Federal Work 1") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_0']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Federal Service Federal Work History") Then
                    Data.StopAtDialog()
                End If

                Thread.Sleep(500)

                If Data._Site.Contains("TN") Then
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtEmpName']", "US Senate")
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_ddlCountry_ddlCountry']", "US")
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtAddress1']", "1010 Street")
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtCity']", "Nashville")
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_ddlState']", "TN")
                    Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_FedEmpManEntry_txtZip']", "37243")
                End If

                If Data._Site.Contains("PR") Then
                    Finder.ActionsSendText(driver, "//*[@id='cmbCustomFIC']", "AD")
                    Thread.Sleep(3000)
                Else
                    Finder.ActionsSendText(driver, "//*[@id='cmbCustomFIC']", Data._FIC)
                    Thread.Sleep(3000)
                    Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlDestCodes']", "0001")
                End If

                Finder.WaitClickableClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblInterveningEmploymentSinceSeparation_1']", wait)
                Finder.UseDropDownByText(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlStateOfEmployment']", Data._State)
                Thread.Sleep(2000)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtOutofCountryCity']", Data._City)
                Thread.Sleep(2500)
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm8_0']")
                Thread.Sleep(2000)
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm50_0']")
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtDateBeganWork']", Data._WorkedFrom1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtLastDayWorked']", Data._WorkedTo1)
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlReasonForSeparation']", "0001")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblSepDueToGovShutdown_1']")
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlEmployerNAICS']", 1)
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlPositionOccGroupCode']", 1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter1']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter2']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter3']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter4']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter5']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter6']", Data._Wages)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ1CreditWeeks']", Data._CreditWeeks)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ2CreditWeeks']", Data._CreditWeeks)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ3CreditWeeks']", Data._CreditWeeks)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ4CreditWeeks']", Data._CreditWeeks)
                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblWorkedInStateAfterFederalEmployment_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblOtherEmploymentLastNMonths_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Federal Service Federal Work 2") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
            Else
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
            End If
        End Sub
    End Class
End Namespace
