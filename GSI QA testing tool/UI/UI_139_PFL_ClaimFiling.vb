Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_139_PFL_ClaimFiling
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("PFL Claim Filing") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_rblPFLClaimProceed_0']") Then
                Debug.WriteLine("PFL_ClaimFiling is On")
            Else
                Debug.WriteLine("PFL_ClaimFiling is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblPFLClaimProceed_0']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
