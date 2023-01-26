Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_140_PFL_WhoIsFiling
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("PFL Who Is Filing") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0']") Then
                Debug.WriteLine("PFL_WhoIsFiling is On")
            Else
                Debug.WriteLine("PFL_WhoIsFiling is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0']", wait)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']")
        End Sub
    End Class
End Namespace
