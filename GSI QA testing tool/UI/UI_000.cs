﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_000
    {
        public static void FileUI(IWebDriver driver)
        {
            // Home Page
            UI.UI_005_HomePage.GoTo(driver);

            // individual Page
            UI_010_IndividualPage.GoTo(driver);

            // Unemployment Insurance Compensation
            UI_015_UnemploymentInsurance.GoTo(driver);

            // Welcome to
            UI_020_WelcomeTo.GoTo(driver);

            // Social Security Number
            UI_025_SocialSecurityNumber.GoTo(driver);

            // Worker's Compensation
            UI_030_WorkersCompensation.GoTo(driver);

            // Work History Verification
            UI_035_WorkHistoryVerification.GoTo(driver);

            // States You Have Worked In
            UI_040_StatesYouHaveWorkedIn.GoTo(driver);

            // Federal Service
            UI_045_FederalService.GoTo(driver);




        }
    }
}