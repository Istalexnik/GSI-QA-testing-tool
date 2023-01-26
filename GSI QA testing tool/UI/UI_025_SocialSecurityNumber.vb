Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_025_SocialSecurityNumber
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Social Security Number") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSN']") Then
                Debug.WriteLine("SocialSecurityNumber is On")
            Else
                Debug.WriteLine("SocialSecurityNumber is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSN']", Data._SSN)
            Thread.Sleep(500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSNReenter']", Data._SSN)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")
        End Sub
    End Class
End Namespace
