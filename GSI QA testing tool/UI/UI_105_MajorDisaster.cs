﻿using OpenQA.Selenium;
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
        public static void GoTo(IWebDriver driver)
        {
            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1']"))
            {
                Debug.WriteLine("MajorDisaster is On");
            }
            else
            {
                Debug.WriteLine("MajorDisaster is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
