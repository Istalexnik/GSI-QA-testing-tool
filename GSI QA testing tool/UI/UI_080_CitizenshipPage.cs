﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_080_CitizenshipPage
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {
            if (!Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']")) return;


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblDependents_1']", wait);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddlHowManyDependents']", 1);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddlMaritalStatus']", 1);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblDisability_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblChildSupport_1']");
            if (Data._claimType == 5)
            {
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']", "3", wait);
                Finder.UseDropDownByText(driver, "//select[contains(@id, 'ctl00_Main_content_ucDemographics_ddl_UI_AlienRegDoc')]", "I-551 Permanent Resident Card", wait);
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_DocumentNumber']", Data.NewAlienCardNumber());
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_DocumentExpDate']", "11/11/2033");
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_AlienReceiptNumber']", Data.NewUSCISNumber());
            }
            else
            {
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']", 1, wait);
            }
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}