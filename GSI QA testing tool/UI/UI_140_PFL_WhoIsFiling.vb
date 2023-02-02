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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Who Is Filing") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "[for='ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0']") Then
                Debug.WriteLine("PFL_WhoIsFiling is On")
            Else
                Debug.WriteLine("PFL_WhoIsFiling is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0", js, wait)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton", js)
        End Sub
    End Class
End Namespace
