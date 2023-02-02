Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_139_PFL_ClaimFiling
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Claim Filing") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_rblPFLClaimProceed_0") Then
                Debug.WriteLine("PFL_ClaimFiling is On")
            Else
                Debug.WriteLine("PFL_ClaimFiling is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_rblPFLClaimProceed_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
