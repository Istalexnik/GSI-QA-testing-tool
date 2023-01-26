Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_148_UploadPage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Upload Page") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ddlUploadType1']") Then
                Debug.WriteLine("UploadPage is On")
            Else
                Debug.WriteLine("UploadPage is Off")
                Return
            End If

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
