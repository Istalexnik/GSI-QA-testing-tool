using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_030_WorkersCompensation
    {
        public static void GoTo(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

        }
    }
}
