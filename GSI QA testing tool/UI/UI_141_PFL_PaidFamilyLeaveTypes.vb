﻿Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports GSI_QA_testing_tool.Utilities

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_141_PFL_PaidFamilyLeaveTypes
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("PFL Paid Family Leave Types") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0']") Then
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is On")
            Else
                Debug.WriteLine("PFL_PaidFamilyLeaveTypes is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLClaimType_0']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLClaimType_rblPFLMethod_0']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
        End Sub
    End Class
End Namespace
