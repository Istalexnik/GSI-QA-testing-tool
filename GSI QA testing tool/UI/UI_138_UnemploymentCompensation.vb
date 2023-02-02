Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_138_UnemploymentCompensation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Unemployment Compensation Claim") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory") Then
                Debug.WriteLine("UnemploymentCompensation is On")
            Else
                Debug.WriteLine("UnemploymentCompensation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory", js)
        End Sub
    End Class
End Namespace
