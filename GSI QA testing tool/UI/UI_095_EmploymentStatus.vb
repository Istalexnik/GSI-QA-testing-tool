Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Diagnostics
Imports System.Threading

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_095_EmploymentStatus
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Employment - Status") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucUIEmployment_rblSelfEmployed_1") Then
                Debug.WriteLine("EmploymentStatus is On")
            Else
                Debug.WriteLine("EmploymentStatus is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmployment_rblOfferedJobToday_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmployment_rblPhysicallyAbleToWork_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmployment_rblAvailableToWork_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmployment_rblSelfEmployed_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmployment_rblElectedOfficial_1", js)
            Thread.Sleep(300)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
