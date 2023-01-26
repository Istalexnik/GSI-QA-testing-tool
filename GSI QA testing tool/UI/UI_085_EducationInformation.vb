Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_085_EducationInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("Education Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']") Then
                Debug.WriteLine("EducationInformation is On")
            Else
                Debug.WriteLine("EducationInformation is Off")
                Return
            End If

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']", 5, wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlSchoolStatus']", 4, wait)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEducation_rblPlanSchoolIn12Months_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
