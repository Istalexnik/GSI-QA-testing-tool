Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_110_LaborUnion
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Labor Union Member") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUILaborUnion_rblUnionMember_1']") Then
                Debug.WriteLine("LaborUnion is On")
            Else
                Debug.WriteLine("LaborUnion is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUILaborUnion_rblUnionMember_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
