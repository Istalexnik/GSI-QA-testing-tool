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
    internal class UI_020_WelcomeTo
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._StopAt.Contains("Welcome To"))
            {
                Data.StopAtDialog();
            }



            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']"))
            {
                Debug.WriteLine("WelcomeTo is On");
            }
            else
            {
                Debug.WriteLine("WelcomeTo is Off");
                return;
            }


            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']");        
        }
    }
}
