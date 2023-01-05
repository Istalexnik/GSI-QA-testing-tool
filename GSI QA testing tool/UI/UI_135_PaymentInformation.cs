using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_135_PaymentInformation
    {
        public static void GoTo(IWebDriver driver, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("Payment Information"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']"))
            {
                Debug.WriteLine("PaymentInformation is On");
            }
            else
            {
                Debug.WriteLine("PaymentInformation is Off");
                return;
            }


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']");
            //Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cbdebitcardacklongform']");
            //Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cbdebitcardack']");
            var checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            foreach (var checkbox in checkboxes)
            {
                js.ExecuteScript("arguments[0].click();", checkbox);
            }
            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']");


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cb1099GConsent_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblWeeklyCert_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblFederalTaxWithheld_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucBackDateEffectiveDate_rblBackDate_1']");

            
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
