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
    internal class UI_148_UploadPage
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Upload Page"))
            {
                CustomDialog customDialog = new CustomDialog("Make Selection", "Select pages you want to stop at, make changes and click ok before clicking the Next button");
                customDialog.ShowDialog();
            }




            if (Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ddlUploadType1']"))
            {
                Debug.WriteLine("UploadPage is On");
            }
            else
            {
                Debug.WriteLine("UploadPage is Off");
                return;
            }



            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
