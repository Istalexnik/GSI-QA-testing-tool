Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_143_PFL_AdditionalClaimInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Additional ClaimInformation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1") Then
                Debug.WriteLine("PFL_AdditionalClaimInformation is On")
            Else
                Debug.WriteLine("PFL_AdditionalClaimInformation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingLongTermBenefits_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblSelfEmploymentIncome_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblAuthorizeDOESNotifyEmp_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
        End Sub
    End Class
End Namespace
