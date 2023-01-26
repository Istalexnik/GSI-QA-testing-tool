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
    Friend Class UI_060_NamePage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Name Page") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucName_txtFirstName']") Then
                Debug.WriteLine("NamePage is On")
            Else
                Debug.WriteLine("NamePage is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtFirstName']", Data._FirstName)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtLastName']", Data._LastName)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
