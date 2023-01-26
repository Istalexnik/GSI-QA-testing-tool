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
    Friend Class UI_120_EthnicOrigin
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            Thread.Sleep(800)

            If Data._StopAt.Contains("Ethnic Origin") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_ucEthnicity_rblHispanic_1']") Then
                Debug.WriteLine("EthnicOrigin is On")
            Else
                Debug.WriteLine("EthnicOrigin is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblHispanic_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_chkRaceList_1']")
            Thread.Sleep(300)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblLangSecondary_1']")
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEthnicity_ddlMaritalStatus']", 1)
            Thread.Sleep(600)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
