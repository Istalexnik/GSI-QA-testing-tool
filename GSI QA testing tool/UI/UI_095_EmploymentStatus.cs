using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_095_EmploymentStatus
    {
        public static void GoTo(IWebDriver driver)
        {
            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIEmployment_rblOfferedJobToday_0']"))
            {
                Debug.WriteLine("EmploymentStatus is On");
            }
            else
            {
                Debug.WriteLine("EmploymentStatus is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmployment_rblPhysicallyAbleToWork_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmployment_rblOfferedJobToday_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmployment_rblSelfEmployed_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmployment_rblElectedOfficial_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
