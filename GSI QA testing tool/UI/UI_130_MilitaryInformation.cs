﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_130_MilitaryInformation
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {
            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1']")) 
            {
                Debug.WriteLine("MilitaryInformation is On");
            }
            else
            {
                Debug.WriteLine("MilitaryInformation is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblSpouseactivedutyBase_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblCaregiver_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblTAPWorkshop_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblSpouse_1']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblMilitaryService_1']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucVeteran_ddlClassifiedAsDisabledVeteran']", 1);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucVeteran_rblWounded_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");









            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDrvLicense_txtDrvLicenseNumber']", Data._DriverLicense);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDrvLicense_ddlStateIssued']", 5);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
