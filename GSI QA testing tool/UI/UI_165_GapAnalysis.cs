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

namespace GSI_QA_testing_tool.UI
{
    internal class UI_165_GapAnalysis
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait, IJavaScriptExecutor js)
        {

            Thread.Sleep(800);


            if (Data._StopAt.Contains("Gap Analysis"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnNextMonetaryReview']"))
            {
                Debug.WriteLine("GapAnalysis is On");
            }
            else
            {
                Debug.WriteLine("GapAnalysis is Off");
                return;
            }

            if (Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ddlCorrectEmpsAndWages_0']"))
            {
                js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//*[@id='ctl00_Main_content_ddlCorrectEmpsAndWages_0']")));
            }

            Thread.Sleep(800);

            //    Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ddlCorrectEmpsAndWages_0']");
            if (Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl02_btnGapSummary']"))
            {
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl02_btnGapSummary']");
                Thread.Sleep(1000);
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_txtGapExplanation']", "test");
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_btnSave']", wait);
            }

            if(Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl03_btnGapSummary']"))
            {
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl03_btnGapSummary']", wait);
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_txtGapExplanation']", "test");
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_btnSave']");
            }
         //   Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNextMonetaryReview']");

            driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnNextMonetaryReview']")).Click();


        }
    }
}
