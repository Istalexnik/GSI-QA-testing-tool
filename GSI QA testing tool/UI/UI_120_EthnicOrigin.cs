using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_120_EthnicOrigin
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblHispanic_1']")) return;

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblHispanic_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_chkRaceList_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblLangSecondary_1']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEthnicity_ddlMaritalStatus']", 1);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
