Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_185_UnemploymentClaimConfirmation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Unemployment Claim Confirmation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_btnNext']") Then
                Debug.WriteLine("UnemploymentClaimConfirmation is On")
            Else
                Debug.WriteLine("UnemploymentClaimConfirmation is Off")
                Throw New Exception("The claim is not completed")
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
