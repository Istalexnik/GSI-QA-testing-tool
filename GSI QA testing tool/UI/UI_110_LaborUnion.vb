Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_110_LaborUnion
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Labor Union Member") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucUILaborUnion_rblUnionMember_1") Then
                Debug.WriteLine("LaborUnion is On")
            Else
                Debug.WriteLine("LaborUnion is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUILaborUnion_rblUnionMember_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
