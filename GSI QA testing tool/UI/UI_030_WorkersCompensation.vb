Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_030_WorkersCompensation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(300)
            If Data._StopAt.Contains("Worker's Compensation") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1']") Then
                Debug.WriteLine("WorkersCompensation is On")
            Else
                Debug.WriteLine("WorkersCompensation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1", js)
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")))
        End Sub
    End Class
End Namespace
