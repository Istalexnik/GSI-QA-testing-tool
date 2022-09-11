using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_055_LoginInformation
    {
        public static void GoTo(IWebDriver driver)
        {

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_txtUsername']", Data._Login);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwd']", Data._Pass);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwdConfirm']", Data._Pass);

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucLogin_ddlSecurityQuestion']", 2);
            Finder.SendText(driver, "//input[@id='txtSecurityQuestionResponse']", "lol");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_radAuthorizedToWork_0']");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_txtZip']", Data._ZIP);

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmail']", Data.MakeEmail());
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmailConfirm']", Data.MakeEmail());
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOB']", Data._DOB);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOBConfirm']", Data._DOB);

            Finder.SendText(driver, "//label[@for='ctl00_Main_content_ucRegDemographics_txtMothersMaidenName']", Data._Pass);
            Finder.SendText(driver, "//label[@for='ctl00_Main_content_ucRegDemographics_txtCityOfBirth']", Data._Pass);

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucRegDemographics_rblGender_0']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucRegDemographics_ddlDraftStatus']", 2);

            Finder.WaitStaleClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']", 10);


        }
    }
}
