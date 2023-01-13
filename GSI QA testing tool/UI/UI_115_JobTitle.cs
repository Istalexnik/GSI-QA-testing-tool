using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_115_JobTitle
    {
        public static void GoTo(IWebDriver driver)
        {

            Thread.Sleep(800);



            if (Data._StopAt.Contains("Job Title"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']"))
            {
                Debug.WriteLine("JobTitle is On");
            }
            else
            {
                Debug.WriteLine("JobTitle is Off");
                return;
            }


            Thread.Sleep(500);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']", Data._JobTitle);
            Thread.Sleep(3500);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucJobTitleToOcc_txtJobTitle']", Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(1500);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucJobTitleToOcc_ONETDropDownList']", 1);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucJobTitleToOcc_rbl18MoPartTime_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblLangSecondary_1']");

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
