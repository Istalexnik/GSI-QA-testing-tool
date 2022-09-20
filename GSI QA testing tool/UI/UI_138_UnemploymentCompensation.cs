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
    internal class UI_138_UnemploymentCompensation
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Unemployment Compensation Claim"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory']")) 
            {
                Debug.WriteLine("UnemploymentCompensation is On");
            }
            else
            {
                Debug.WriteLine("UnemploymentCompensation is Off");
                return;
            }



            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory']");

        }
    }
}
