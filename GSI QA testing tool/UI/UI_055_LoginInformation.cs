using GSI_QA_testing_tool.Utilities;
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
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            Thread.Sleep(500);


            if (Data._StopAt.Contains("Login Information Not Filled Out"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucLogin_txtUsername']"))
            {
                Debug.WriteLine("LoginInformation is On");
            }
            else
            {
                Debug.WriteLine("LoginInformation is Off");
                return;
            }


            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_txtUsername']", Data._Login);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwd']", Data._Pass);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwdConfirm']", Data._Pass);

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucLogin_ddlSecurityQuestion']", 2);
            driver.FindElement(By.XPath("//input[@id='txtSecurityQuestionResponse']")).Clear();
            Finder.SendText(driver, "//input[@id='txtSecurityQuestionResponse']", "lol");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_radAuthorizedToWork_0']");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_txtZip']", Data._ZIP);

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmail']", Data._Email);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmailConfirm']", Data._Email);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOB']", Data._DOB);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOBConfirm']", Data._DOB);

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtCityOfBirth']", Data._City);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtMothersMaidenName']", "Mother");


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucRegDemographics_rblGender_0']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucRegDemographics_ddlDraftStatus']", 2, wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucRegDemographics_rblArrested_1']");


            if (Data._StopAt.Contains("Login Information Filled Out"))
            {
                Data.StopAtDialog();
            }


            Finder.WaitClickableClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']", wait);

            
        }
    }
}
