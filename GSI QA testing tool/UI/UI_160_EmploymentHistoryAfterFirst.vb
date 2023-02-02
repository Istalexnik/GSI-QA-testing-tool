Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_160_EmploymentHistoryAfterFirst
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(800)

            If Data._StopAt.Contains("Employment History After First Eployer") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_rblAddAnotherEntry_0") Then
                Debug.WriteLine("EmploymentHistoryAfterFirst is On")
            Else
                Debug.WriteLine("EmploymentHistoryAfterFirst is Off")
                Return
            End If

            If Data._SecondEmployer = True AndAlso Data._Emp2EnteredWhenUCXandWagesin = False Then

                If Finder.FindItByCSS(driver, "#ctl00_Main_content_lbHaveNotWorked") Then
                    'NE ZABUD~ OTKOMENTIT~!!!
                    'Finder.ClickIt(driver, "//td[contains(text(),'" & Data._Employer2 & "')]/following-sibling::td/a")
                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblBasePeriodEmployerConfirm_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                End If

                If Finder.FindItByCSS(driver, "#ctl00_Main_content_rblBasePeriodEmployerConfirm_0") Then
                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblBasePeriodEmployerConfirm_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                Else
                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblAddAnotherEntry_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                End If

                Data._claimType = 1
                UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer2, Data._WorkedFrom2, Data._WorkedTo2)
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_rblAddAnotherEntry_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
            Finder.UseAlert(driver, 300)
        End Sub
    End Class
End Namespace
