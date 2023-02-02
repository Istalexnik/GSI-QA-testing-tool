Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_015_UnemploymentInsurance
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Unemployment Insurance Compensation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_radFilingUI_0") Then
                Debug.WriteLine("UnemploymentInsurance is On")
            Else
                Debug.WriteLine("UnemploymentInsurance is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_radFilingUI_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
