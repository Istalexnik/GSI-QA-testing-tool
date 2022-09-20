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
    internal class UI_030_WorkersCompensation
    {
        public static void GoTo(IWebDriver driver, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("Worker's Compensation"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1']"))
            {
                Debug.WriteLine("WorkersCompensation is On");
            }
            else
            {
                Debug.WriteLine("WorkersCompensation is Off");
                return;
            }



            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1']");
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")));
          //  Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");

        }
    }
}
