Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Controls.Primitives

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_065_ResidentialAddress
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("Residential Address") Then
                Data.StopAtDialog()
            End If

            Thread.Sleep(500)

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucAddress_txtAddress1']") Then
                Debug.WriteLine("ResidentialAddress is On")
            Else
                Debug.WriteLine("ResidentialAddress is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rbACPEnrollment_1']")
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucAddress_txtAddress1']", Data._Address)
            Thread.Sleep(3000)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucAddress_ddlAltGeo']", 2)
            Thread.Sleep(4000)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_chkPopulateMailAddress']")
            Thread.Sleep(5000)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rdoCorrectedResidentialAddress_0']", wait)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rdoCorrectedMailingAddress_0']", wait)
            Finder.WaitClickableClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']", wait)
        End Sub
    End Class
End Namespace
