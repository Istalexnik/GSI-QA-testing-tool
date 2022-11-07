using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_085_EducationInformation
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("Education Information"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']"))
            {
                Debug.WriteLine("EducationInformation is On");
            }
            else
            {
                Debug.WriteLine("EducationInformation is Off");
                return;
            }



            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']", 5, wait);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlSchoolStatus']", 4, wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEducation_rblPlanSchoolIn12Months_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
