using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_075_PreferredNotification
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods']")) return;

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods']", 1);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddlDeterminationNotificationMethod']", 1);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddl1099GNotificationMethod']", 1);

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucNotificationMethod_cb1099Acknowledge']");
            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucNotificationMethod_rblSignUpMessageLaborService_1']");
            Finder.UseDropDownByIndex(driver, "//select[contains(@id, 'ctl00_Main_content_ucSiteAccess_ddl')]", 2);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

           


        }
    }
}
