Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports GSI_QA_testing_tool.Utilities

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_143_PFL_AdditionalClaimInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("PFL Additional ClaimInformation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1']") Then
                Debug.WriteLine("PFL_AdditionalClaimInformation is On")
            Else
                Debug.WriteLine("PFL_AdditionalClaimInformation is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingUIBenefits_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblCurrentlyReceivingLongTermBenefits_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblSelfEmploymentIncome_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAdditionalClaimInformation_rblAuthorizeDOESNotifyEmp_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
        End Sub
    End Class
End Namespace
