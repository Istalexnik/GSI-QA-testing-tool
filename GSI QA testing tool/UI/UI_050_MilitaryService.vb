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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(500)

            If Data._StopAt.Contains("Military Service") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_Wizard1_rblMilitaryService_1']") Then
                Debug.WriteLine("MilitaryService is On")
            Else
                Debug.WriteLine("MilitaryService is Off")
                Return
            End If

            If Data._claimType = 2 Then
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblMilitaryService_0", js)

                If Finder.FindItByCSS(driver, "[id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']") Then
                    Finder.UseDropDownByText(driver, "//select[@id='ctl00_Main_content_Wizard1_ddlPhysicalLocation']", Data._State)
                    Finder.JSClickIt(driver, "#btn-dialog-ok", js)
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblPhysicallyInState_0", js)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_txtMilitaryAddress1']", Data._Address)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_txtMilitaryZip']", Data._ZIP)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_txtMilitaryCity']", Data._City)

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)

                If Data._StopAt.Contains("Military Service Work 1") Then
                    Data.StopAtDialog()
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_0", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)

                If Data._StopAt.Contains("Military Service Employment Information") Then
                    Data.StopAtDialog()
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblFiledInStateAfterSeparation_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblMember4OfDD214_0", js)
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlServiceBranch']", 1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceEntryDate']", Data._WorkedFrom1)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtServiceSeparationDate']", Data._WorkedTo1)
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlDischargeStatus']", "01")
                Finder.UseDropDownByValue(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlReasonForSeparation']", "1")
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblSepDueToGovShutdown_1", js)
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucMilitaryService_ddlPayGrade']", "27")
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtAccuredDaysOfLeave']", "0")
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_Wizard1_ucMilitaryService_txtLostDays']", "0")
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblDischargePhysicalDisability_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblMilitaryRetiree_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblCompletedFirstFullTermDuty_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblSubsistenceVocRehabTraining_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryService_rblWarOrphanWidowsEducationAllowance_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)

                If Data._StopAt.Contains("Military Service Work 2") Then
                    Data.StopAtDialog()
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucMilitaryServiceHistory_rbAddNewEmp_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
            Else
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblMilitaryService_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
            End If
        End Sub
    End Class
End Namespace
