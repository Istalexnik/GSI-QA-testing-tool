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
    internal class UI_060_NamePage
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Name Page"))
            {
                CustomDialog customDialog = new CustomDialog("Make Selection", "Select pages you want to stop at, make changes and click ok before clicking the Next button");
                customDialog.ShowDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucName_txtFirstName']"))
            {
                Debug.WriteLine("NamePage is On");
            }
            else
            {
                Debug.WriteLine("NamePage is Off");
                return;
            }




            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtFirstName']", Data._FirstName);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucName_txtLastName']", Data._LastName);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
