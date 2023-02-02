Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_010_IndividualPage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Individual Page") Then
                Data.StopAtDialog()
            End If

            If Data._Staff = True Then
                Finder.SendText(driver, "//input[@id='txtUserName']", Data._StaffLogin)
                Finder.SendText(driver, "//input[@id='txtPassword']", Data._StaffPass)
                Finder.JSClickIt(driver, "#ctl00_Main_content_cmdLoginButt", js)
            Else
                Finder.JSClickIt(driver, "#ctl00_hlNotRegistered", js)
                Finder.JSClickIt(driver, "#btnguestlogina", js)
                Finder.JSClickIt(driver, "#btnIndRegistration", js)
            End If
        End Sub
    End Class
End Namespace
