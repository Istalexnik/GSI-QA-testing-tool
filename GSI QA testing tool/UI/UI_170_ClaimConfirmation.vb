Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports GSI_QA_testing_tool.Utilities

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_170_ClaimConfirmation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Claim Confirmation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnCertifyClaim']") Then
                Debug.WriteLine("ClaimConfirmation is On")
            Else
                Debug.WriteLine("ClaimConfirmation is Off")
                Return
            End If

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnCertifyClaim']")
        End Sub
    End Class
End Namespace
