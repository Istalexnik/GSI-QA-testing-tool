Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Controls

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_180_WhatYouMustDo
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("What You Must Do") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton, #ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton") Then
                Debug.WriteLine("WhatYouMustDo is On")
            Else
                Debug.WriteLine("WhatYouMustDo is Off")
                Throw New Exception("The claim is not completed")
            End If

            Dim checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"))

            For Each checkbox In checkboxes
                js.ExecuteScript("arguments[0].click();", checkbox)
            Next

            Thread.Sleep(500)

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignName") Then
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignName']", "Sam")
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignDate_DateInputImage", js)
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucGSIButtons_btnNext", js)
        End Sub
    End Class
End Namespace
