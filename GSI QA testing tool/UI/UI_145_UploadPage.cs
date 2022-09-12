using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_145_UploadPage
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ddlUploadType1']")) return;

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
