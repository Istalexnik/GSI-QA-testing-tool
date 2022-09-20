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
    internal class UI_140_PFL_WhoIsFiling
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait)
        {

            if (Data._StopAt.Contains("PFL Who Is Filing"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0']"))
            {
                Debug.WriteLine("PFL_WhoIsFiling is On");
            }
            else
            {
                Debug.WriteLine("PFL_WhoIsFiling is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLAuthorizedRepresentative_rblWhoIsFiling_0']", wait);
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']");

        }
    }
}
