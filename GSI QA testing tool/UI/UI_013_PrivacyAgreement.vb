Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_013_PrivacyAgreement
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Privacy Agreement") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucPrivacyAgreement_btnAgree']") Then
                Debug.WriteLine("PrivacyAgreement is On")
            Else
                Debug.WriteLine("PrivacyAgreement is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPrivacyAgreement_chkCertification']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPrivacyAgreement_chkAuthorization']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucPrivacyAgreement_btnAgree']")
        End Sub
    End Class
End Namespace
