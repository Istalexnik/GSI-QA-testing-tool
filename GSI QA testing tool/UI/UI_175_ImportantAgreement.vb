Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_175_ImportantAgreement
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Important Agreement (FFF)") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']") Then
                Debug.WriteLine("ImportantAgreement is On")
            Else
                Debug.WriteLine("ImportantAgreement is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_chkSelfCertification']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_rblAcceptTerms_0']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']")
        End Sub
    End Class
End Namespace
