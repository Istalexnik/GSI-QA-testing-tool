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
    internal class UI_014_IndividualRegistration
    {
        public static void GoTo(IWebDriver driver)
        {


            if (Data._StopAt.Contains("Individual Registration Type"))
            {
                Data.StopAtDialog();
            }





            if (Finder.FindIt(driver, "//a[@id='ctl00_Main_content_lnkCompleteHeader']")) 
            {
                Debug.WriteLine("IndividualRegistration is On");
            }
            else
            {
                Debug.WriteLine("IndividualRegistration is Off");
                return;
            }



            Finder.ClickIt(driver, "//a[@id='ctl00_Main_content_lnkCompleteHeader']");
        }
    }
}
