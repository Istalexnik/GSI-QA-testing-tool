Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_170_ClaimConfirmation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Claim Confirmation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_btnCertifyClaim") Then
                Debug.WriteLine("ClaimConfirmation is On")
            Else
                Debug.WriteLine("ClaimConfirmation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_btnCertifyClaim", js)
        End Sub
    End Class
End Namespace
