﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_070_PhoneNumber
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone1']")) return;

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone1']", "813");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone2']", "654");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone3']", "6437");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucPhone_ddlPrimePhoneType']", 1);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}