using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_100_EmploymentMiscellaneous
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Employment - Miscellaneous"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1']"))
            {
                Debug.WriteLine("EmploymentMiscellaneous is On");
            }
            else
            {
                Debug.WriteLine("EmploymentMiscellaneous is Off");
                return;
            }

            Thread.Sleep(500);

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
