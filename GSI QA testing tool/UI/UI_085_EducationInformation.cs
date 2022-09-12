using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_085_EducationInformation
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {
            if (!Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']")) return;

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlIndEduLevel']", 16, wait);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucEducation_ddlSchoolStatus']", 4, wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucEducation_rblPlanSchoolIn12Months_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

        }
    }
}
