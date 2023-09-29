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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Identification Information") Then
                Data.StopAtDialog()
            End If
            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucDrvLicense_rblValidLicense_1") Then
                Debug.WriteLine("IdentificationInformation is On")
            Else
                Debug.WriteLine("IdentificationInformation is Off")
                Return
            End If

            Thread.Sleep(1000)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucDrvLicense_rblValidLicense_0", js)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDrvLicense_txtDrvLicenseNumber']", Data._DriverLicense)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDrvLicense_ddlStateIssued']", 5)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
