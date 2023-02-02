Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_136_VerifyIdentity
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Verify Your Identity") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "[id='ctl00_Main_content_btnNext']") Then
                Debug.WriteLine("VerifyIdentity is On")
            Else
                Debug.WriteLine("VerifyIdentity is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
