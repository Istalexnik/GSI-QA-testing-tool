using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_100_EmploymentMiscellaneous
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1']")) return;

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCertifiedTrade_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblEmployedBySchool_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblWorkedAsProfessionalAthlete_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCommuterClaim_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblFilingClaimDueToCOVID19_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
