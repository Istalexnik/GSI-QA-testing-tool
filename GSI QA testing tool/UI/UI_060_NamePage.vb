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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Name Page") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucName_txtFirstName']") Then
                Debug.WriteLine("NamePage is On")
            Else
                Debug.WriteLine("NamePage is Off")
                Return
            End If


            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtFirstName']", Data._FirstName)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtLastName']", Data._LastName)
            Thread.Sleep(700)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)

            'workaround the bug
            Thread.Sleep(1500)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
