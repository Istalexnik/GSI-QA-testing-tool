Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Security.Claims
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_035_WorkHistoryVerification
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Work History Verification") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']") Then
                Debug.WriteLine("WorkHistoryVerification is On")
            Else
                Debug.WriteLine("WorkHistoryVerification is Off")
                Return
            End If

            If Data._Site.Contains("PUA") Then
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1']")
            Else

                If Data._BasePeriod Then
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']")
                Else
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1']")
                End If
            End If

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
        End Sub
    End Class
End Namespace
