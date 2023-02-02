Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Class UI_183_PFL_BenefitsInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Unemployment Claim Confirmation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton") Then
                Debug.WriteLine("PFL_BenefitsInformation is On")
            Else
                Debug.WriteLine("PFL_BenefitsInformation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblBRIPrintView_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton", js)
        End Sub
    End Class
End Namespace
