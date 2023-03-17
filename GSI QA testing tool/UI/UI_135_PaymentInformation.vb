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

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucUIPayment_rblPaymentMethod_1") Then
                Debug.WriteLine("PaymentInformation is On")
            Else
                Debug.WriteLine("PaymentInformation is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIPayment_rblPaymentMethod_1", js)
            Dim checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"))

            For Each checkbox In checkboxes
                js.ExecuteScript("arguments[0].click();", checkbox)
            Next

            Finder.JSClickIt(driver, "#btn-dialog-ok", js)


            If Finder.FindItByCSS(driver, "#predisclosurepdf") Then
                Dim parentWindow As String = driver.CurrentWindowHandle
                Finder.JSClickIt(driver, "#predisclosurepdf", js)

                Dim allWindows As IList(Of String) = New List(Of String)(driver.WindowHandles)

                For Each curWindow As String In allWindows
                    driver.SwitchTo().Window(curWindow)
                Next

                driver.SwitchTo().Window(parentWindow)

                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIPayment_cbAcknowledgeDebitOnPage", js)
            End If



            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIPayment_cb1099GConsent_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIPayment_rblWeeklyCert_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPaymentDeductions_rblFederalTaxWithheld_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucBackDateEffectiveDate_rblBackDate_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
