Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Diagnostics
Imports GSI_QA_testing_tool.Utilities
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
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlUnemploymentInsurance']", 1, wait)
            Thread.Sleep(300)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblLookingForWork_0']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblCovid19_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblInterestedInRegisteredApprenticeship_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblCertifications_1']")
            Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucEmployment_rblMigrant_1']", js)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
