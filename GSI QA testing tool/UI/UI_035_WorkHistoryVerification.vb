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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Work History Verification") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "[for='ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0']") Then
                Debug.WriteLine("WorkHistoryVerification is On")
            Else
                Debug.WriteLine("WorkHistoryVerification is Off")
                Return
            End If

            If Data._Site.Contains("PUA") Then
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1", js)
            Else

                If Data._BasePeriod Then
                    Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblWorkHistoryVerify_0", js)
                Else
                    Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblWorkHistoryVerify_1", js)
                End If
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
        End Sub
    End Class
End Namespace
