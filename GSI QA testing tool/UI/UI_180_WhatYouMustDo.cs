using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_180_WhatYouMustDo
    {
        public static void GoTo(IWebDriver driver, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("What You Must Do"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton' or @*='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']"))
            {
                Debug.WriteLine("WhatYouMustDo is On");
            }
            else
            {
                Debug.WriteLine("WhatYouMustDo is Off");
                throw new Exception("The claim is not completed");
            }




            //var checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            //foreach (var checkbox in checkboxes)
            //{

            //    checkbox.Click();
            //}
            
            var checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            foreach (var checkbox in checkboxes)
            {
                js.ExecuteScript("arguments[0].click();", checkbox);
            }

            Thread.Sleep(500);

            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignName']"))
            {               
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignName']", "Sam");
                Finder.ClickIt(driver, "//a[@id='ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignDate_DateInputImage']");
            }
                                            
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton']");
            Finder.ClickIt(driver, "//*[@*='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucGSIButtons_btnNext']");
        }
    }
}
