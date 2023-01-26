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
    Friend Class UI_115_JobTitle
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            Thread.Sleep(800)

            If Data._StopAt.Contains("Job Title") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']") Then
                Debug.WriteLine("JobTitle is On")
            Else
                Debug.WriteLine("JobTitle is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']", Data._JobTitle)
            Thread.Sleep(3500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']", Keys.ArrowDown + Keys.Enter)
            Thread.Sleep(1500)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucJobTitleToOcc_ONETDropDownList']", 1)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucJobTitleToOcc_rbl18MoPartTime_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblLangSecondary_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
