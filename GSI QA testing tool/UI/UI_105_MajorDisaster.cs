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
    internal class UI_105_MajorDisaster
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("Major Disaster Information Not Filled Out"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1']"))
            {
                Debug.WriteLine("MajorDisaster is On");
            }
            else
            {
                Debug.WriteLine("MajorDisaster is Off");
                return;
            }

           //          Dialog.showDialog("Error", "hey");


            if (Data._claimType == 6)
            {
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_0']");
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlStateAffected']", 1);
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlDisaster']", 1, wait);
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlAffectedParish']", 1, wait);
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAffectedParishLive_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAffectedParishWork_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAffectedParishTravel_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radEmployerNotOperating_0']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radSelfEmployAffected_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radWeekUnempAfterDisaster_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAbleToReachPlaceOfEmployment_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAbleToReachNewPlaceOfEmployment_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radBreadwinner_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radInjury_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radFisherman_1']");
                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radAgriculturalSeasonal_1']");

                if (Data._StopAt.Contains("Major Disaster Information Filled Out"))
                {
                    CustomDialog customDialog = new CustomDialog("Make Selection", "Select pages you want to stop at, make changes and click ok before clicking the Next button");
                    customDialog.ShowDialog();
                }


                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

            }
            else
            {
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
            }


        }
    }
}
