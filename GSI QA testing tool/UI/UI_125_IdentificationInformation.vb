Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_125_IdentificationInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Identification Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucDrvLicense_rblValidLicense_0']") Then
                Debug.WriteLine("IdentificationInformation is On")
            Else
                Debug.WriteLine("IdentificationInformation is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDrvLicense_rblValidLicense_0']")
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDrvLicense_txtDrvLicenseNumber']", Data._DriverLicense)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDrvLicense_ddlStateIssued']", 5)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
