Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_013_PrivacyAgreement
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Privacy Agreement") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucPrivacyAgreement_btnAgree']") Then
                Debug.WriteLine("PrivacyAgreement is On")
            Else
                Debug.WriteLine("PrivacyAgreement is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPrivacyAgreement_chkCertification", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPrivacyAgreement_chkAuthorization", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPrivacyAgreement_btnAgree", js)
        End Sub
    End Class
End Namespace
