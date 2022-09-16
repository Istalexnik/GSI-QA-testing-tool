﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_065_ResidentialAddress
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {
            Thread.Sleep(300);

            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucAddress_txtAddress1']")) 
            {
                Debug.WriteLine("ResidentialAddress is On");
            }
            else
            {
                Debug.WriteLine("ResidentialAddress is Off");
                return;
            }

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rbACPEnrollment_1']");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucAddress_txtAddress1']", Data._Address);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucAddress_ddlAltGeo']", 2, wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_chkPopulateMailAddress']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rdoCorrectedResidentialAddress_0']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucAddress_rdoCorrectedMailingAddress_0']", wait);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
