using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_020_WelcomeTo
    {
        public static void GoTo(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton']");        
        }
    }
}
