Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Controls

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_135_PaymentInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(300)

            If Data._StopAt.Contains("Payment Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']") Then
                Debug.WriteLine("PaymentInformation is On")
            Else
                Debug.WriteLine("PaymentInformation is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']")
            Dim checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"))

            For Each checkbox In checkboxes
                js.ExecuteScript("arguments[0].click();", checkbox)
            Next

            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cb1099GConsent_0']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblWeeklyCert_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblFederalTaxWithheld_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucBackDateEffectiveDate_rblBackDate_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
