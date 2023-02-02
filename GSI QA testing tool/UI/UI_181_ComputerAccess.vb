Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Class UI_181_ComputerAccess
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Computer Access") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_Wizard1_rblClaimantHasComputerAccess_1']") Then
                Debug.WriteLine("Computer Access is On")
            Else
                Debug.WriteLine("Computer Access is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblClaimantHasComputerAccess_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton", js)
        End Sub
    End Class
End Namespace
