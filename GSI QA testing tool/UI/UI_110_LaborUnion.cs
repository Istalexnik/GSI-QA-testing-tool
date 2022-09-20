using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_110_LaborUnion
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Labor Union Member"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUILaborUnion_rblUnionMember_1']")) 
            {
                Debug.WriteLine("LaborUnion is On");
            }
            else
            {
                Debug.WriteLine("LaborUnion is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUILaborUnion_rblUnionMember_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
