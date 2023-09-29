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
    Friend Class UI_090_EmploymentInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(500)

            If Data._StopAt.Contains("Employment Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucEmployment_ddlEmployStatus']") Then
                Debug.WriteLine("EmploymentInformation is On")
            Else
                Debug.WriteLine("EmploymentInformation is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlEmployStatus']", 3)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlTypeBusiness']", 1)
            Try
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlUnemploymentInsurance']", 1, wait)
            Catch ex As Exception
            End Try


            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEmployment_rblLookingForWork_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEmployment_rblCovid19_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEmployment_rblInterestedInRegisteredApprenticeship_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEmployment_rblFilingclaimDueToDomesticViolence_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEmployment_rblCertifications_1", js)
            Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucEmployment_rblMigrant_1']", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
