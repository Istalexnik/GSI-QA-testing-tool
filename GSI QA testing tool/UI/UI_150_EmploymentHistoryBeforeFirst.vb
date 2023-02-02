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
    Friend Class UI_150_EmploymentHistoryBeforeFirst
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Employment History Before First Eployer") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_rblAddAnotherEntry_0']") Then
                Debug.WriteLine("Employment History Before First is On")
            Else
                Debug.WriteLine("Employment History Before First is Off")
            End If

            Dim EmpReverse As String
            Dim EmpStartDateReverse As String
            Dim EmpLastDatReverse As String

            If Data._claimType = 2 OrElse Data._claimType = 3 Then

                If Finder.FindItByCSS(driver, "#ctl00_Main_content_lbHaveNotWorked") Then
                    Finder.ClickIt(driver, "//td[contains(text(),'" & Data._Employer2 & "')]/following-sibling::td/a")
                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblBasePeriodEmployerConfirm_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                    UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer1, Data._WorkedFrom1, Data._WorkedTo1)
                    Data._Emp2EnteredWhenUCXandWagesin = True
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                Else
                    Finder.JSClickIt(driver, "#ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_lnkEditAction", js)
                End If
            Else

                If Finder.FindItByCSS(driver, "#ctl00_Main_content_lbHaveNotWorked") Then

                    Try

                        Finder.ClickIt(driver, "//td[contains(text(),'" & Data._Employer1 & "')]/following-sibling::td/a")
                    Catch
                        EmpReverse = Data._Employer1
                        Data._Employer1 = Data._Employer2
                        Data._Employer2 = EmpReverse
                        EmpStartDateReverse = Data._WorkedFrom1
                        EmpLastDatReverse = Data._WorkedTo1
                        Data._WorkedFrom1 = Data._WorkedFrom2
                        Data._WorkedTo1 = Data._WorkedTo2
                        Data._WorkedFrom2 = EmpStartDateReverse
                        Data._WorkedTo2 = EmpLastDatReverse

                        Finder.ClickIt(driver, "//td[contains(text(),'" & Data._Employer1 & "')]/following-sibling::td/a")
                    End Try

                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblBasePeriodEmployerConfirm_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                Else
                    Finder.JSClickIt(driver, "#ctl00_Main_content_rblAddAnotherEntry_0", js)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
                End If
            End If

            UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer1, Data._WorkedFrom1, Data._WorkedTo1)
        End Sub
    End Class
End Namespace
