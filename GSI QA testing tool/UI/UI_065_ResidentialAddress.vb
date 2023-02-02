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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Residential Address") Then
                Data.StopAtDialog()
            End If

            Thread.Sleep(500)

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucAddress_txtAddress1']") Then
                Debug.WriteLine("ResidentialAddress is On")
            Else
                Debug.WriteLine("ResidentialAddress is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucAddress_rbACPEnrollment_1", js)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucAddress_txtAddress1']", Data._Address)
            Thread.Sleep(3000)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucAddress_ddlAltGeo']", 2)
            Thread.Sleep(4000)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucAddress_chkPopulateMailAddress", js)
            Thread.Sleep(5000)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucAddress_rdoCorrectedResidentialAddress_0", js, wait)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucAddress_rdoCorrectedMailingAddress_0", js, wait)
            Finder.WaitClickableClickItByCSS(driver, "#ctl00_Main_content_btnNext", wait)
        End Sub
    End Class
End Namespace
