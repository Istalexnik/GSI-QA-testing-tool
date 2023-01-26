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
    internal class UI_120_EthnicOrigin
    {
        public static void GoTo(IWebDriver driver)
        {


            Thread.Sleep(800);


            if (Data._StopAt.Contains("Ethnic Origin"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblHispanic_1']")) 
            {
                Debug.WriteLine("EthnicOrigin is On");
            }
            else
            {
                Debug.WriteLine("EthnicOrigin is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblHispanic_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_chkRaceList_1']");
            Thread.Sleep(300);

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEthnicity_rblLangSecondary_1']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEthnicity_ddlMaritalStatus']", 1);

            Thread.Sleep(600);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
