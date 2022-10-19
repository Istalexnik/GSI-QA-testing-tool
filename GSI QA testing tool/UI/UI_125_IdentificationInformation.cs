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
    internal class UI_125_IdentificationInformation
    {
        public static void GoTo(IWebDriver driver)
        {


            if (Data._StopAt.Contains("Identification Information"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucDrvLicense_rblValidLicense_0']")) 
            {
                Debug.WriteLine("IdentificationInformation is On");
            }
            else
            {
                Debug.WriteLine("IdentificationInformation is Off");
                return;
            }

            Thread.Sleep(500);



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDrvLicense_rblValidLicense_0']");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDrvLicense_txtDrvLicenseNumber']", Data._DriverLicense);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDrvLicense_ddlStateIssued']", 5);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
