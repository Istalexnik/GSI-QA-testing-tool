Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
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
    Friend Class UI_050_MilitaryService
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            Thread.Sleep(500)

            If Data._StopAt.Contains("Military Service") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_1']") Then
                Debug.WriteLine("MilitaryService is On")
            Else
                Debug.WriteLine("MilitaryService is Off")
                Return
            End If

            If Data._claimType = 2 Then
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_0']")

                If Finder.FindIt(driver, "//select[@id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']") Then
                    Finder.UseDropDownByText(driver, "//select[@id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']", Data._State)
                    Finder.ClickIt(driver, "//button[@id='btn-dialog-ok']")
                End If

                Finder.ClickIt(driver, "//*[@for='ctl00_Main_content_Wizard1_rblPhysicallyInState_0']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Military Service Work 1") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_0']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Military Service Employment Information") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblFiledInStateAfterSeparation_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMember4OfDD214_0']")
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlServiceBranch']", 1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceEntryDate']", Data._WorkedFrom1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceSeparationDate']", Data._WorkedTo1)
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlDischargeStatus']", "01")
                Finder.UseDropDownByValue(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlReasonForSeparation']", "1")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblSepDueToGovShutdown_1']")
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlPayGrade']", "27")
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtAccuredDaysOfLeave']", "0")
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtLostDays']", "0")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblDischargePhysicalDisability_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblMilitaryRetiree_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblCompletedFirstFullTermDuty_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblSubsistenceVocRehabTraining_1']")
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryService_rblWarOrphanWidowsEducationAllowance_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")

                If Data._StopAt.Contains("Military Service Work 2") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
            Else
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblMilitaryService_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
            End If
        End Sub
    End Class
End Namespace
