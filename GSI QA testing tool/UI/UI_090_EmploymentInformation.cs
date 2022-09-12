﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_090_EmploymentInformation
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {
            if (!Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlEmployStatus']")) return;

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlEmployStatus']", 3);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEmployment_ddlTypeBusiness']", 1, wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblLookingForWork_0']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblCovid19_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblInterestedInRegisteredApprenticeship_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblCertifications_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEmployment_rblMigrant_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}