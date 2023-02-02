Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_141_PFL_PaidFamilyLeaveTypes
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Paid Family Leave Types") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0']") Then
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is On")
            Else
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLMethod_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
        End Sub
    End Class
End Namespace
