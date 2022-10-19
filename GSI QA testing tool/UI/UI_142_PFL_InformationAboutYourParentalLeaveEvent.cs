using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSI_QA_testing_tool.Utilities;
using System.Threading;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_142_PFL_InformationAboutYourParentalLeaveEvent
    {
        public static void GoTo(IWebDriver driver, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("PFL Information About Your Parental Leave Event"))
            {
                Data.StopAtDialog();
            }


            Thread.Sleep(500);

            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLBeginDate']"))
            {
                Debug.WriteLine("PFL_InformationAboutYourParentalLeaveEvent is On");
            }
            else
            {
                Debug.WriteLine("PFL_InformationAboutYourParentalLeaveEvent is Off");
                return;
            }


   
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLBeginDate']", DateMaker.Today());
            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalDaysPerWeek']", "5");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLParentalLeave_rblPFLParentalNormalWorkSunday_1']");


            string parentWindow = driver.CurrentWindowHandle;

            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_lnkButton']")));


            IList<string> allWindows = new List<string>(driver.WindowHandles);
            foreach (string curWindow in allWindows)
            {
                driver.SwitchTo().Window(curWindow);
            }

            IWebElement dateWidgetFrom = driver.FindElement(By.Id("ctl00_Main_content_ucCalendar_pnlCalendar"));

            IList<IWebElement> columns = dateWidgetFrom.FindElements(By.TagName("td"));

            DateMaker.ClickGivenDay(columns, DateMaker.GetCurrentDay());
            Thread.Sleep(1000);
            DateMaker.ClickGivenDay(columns, DateMaker.GetCurrentDayPlus(7));



            driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnSave']")).Click();

            driver.SwitchTo().Window(parentWindow);

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalEventType']", 1);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalFirstName']", "Test");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalLastName']", "Test");
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalDOB']", DateMaker.Today());
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_Wizard1_ucPFLParentalLeave_rblPFLParentalGender_1']");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalEvidence']", 1);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ucSupportingDocumentation_filUpload1']", "C:/Test/a.png");

            //   driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_Wizard1_ucPFLFamilyLeave_ucFamilySupportingDocumentation2_filUpload2']")).SendKeys("C:\\a.png");
            //   Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']");
            Thread.Sleep(3000);
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")));




        }
    }
}
