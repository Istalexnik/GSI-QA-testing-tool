﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_014_IndividualRegistration
    {
        public static void GoTo(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//a[@id='ctl00_Main_content_lnkCompleteHeader']");
        }
    }
}