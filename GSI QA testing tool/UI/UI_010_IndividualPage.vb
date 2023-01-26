Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_010_IndividualPage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Individual Page") Then
                Data.StopAtDialog()
            End If

            If Data._Staff = True Then
                Finder.SendText(driver, "//input[@id='txtUserName']", Data._StaffLogin)
                Finder.SendText(driver, "//input[@id='txtPassword']", Data._StaffPass)
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_cmdLoginButt']")
            Else
                Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']")
                Finder.ClickIt(driver, "//button[@id='btnguestlogina']")
                Finder.ClickIt(driver, "//input[@id='btnIndRegistration']")
            End If
        End Sub
    End Class
End Namespace
