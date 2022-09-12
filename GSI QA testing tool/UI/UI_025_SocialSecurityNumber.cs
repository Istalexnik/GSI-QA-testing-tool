using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_025_SocialSecurityNumber
    {
        public static void GoTo(IWebDriver driver)
        {
            if (!Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSN']")) return;

            Thread.Sleep(300);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSN']", Data._SSN);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucSSN_txtSSNReenter']", Data._SSN);

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
        }
    }
}
