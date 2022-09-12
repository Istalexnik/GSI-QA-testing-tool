using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_140_UnemploymentCompensation
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory']")) return;

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory']");

        }
    }
}
