using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_135_PaymentInformation
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']")) return;

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_rblPaymentMethod_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cbdebitcardacklongform']");
            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cbdebitcardack']");
            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIPayment_cb1099GConsent_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_1']");

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
