﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_015_UnemploymentInsurance
    {
        public static void unemploymentInsurance(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_radFilingUI_0']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
