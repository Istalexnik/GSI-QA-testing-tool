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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Education Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucEducation_ddlIndEduLevel") Then
                Debug.WriteLine("EducationInformation is On")
            Else
                Debug.WriteLine("EducationInformation is Off")
                Return
            End If

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']", 5, wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlSchoolStatus']", 4, wait)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucEducation_rblPlanSchoolIn12Months_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
