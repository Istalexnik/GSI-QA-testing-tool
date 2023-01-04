using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_160_EmploymentHistoryAfterFirst
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait, IJavaScriptExecutor js)
        {

            Thread.Sleep(800);



            if (Data._StopAt.Contains("Employment History After First Eployer"))
            {
                Data.StopAtDialog();
            }





            if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_0']"))
            {
                Debug.WriteLine("EmploymentHistoryAfterFirst is On");
            }
            else
            {
                Debug.WriteLine("EmploymentHistoryAfterFirst is Off");
                return;
            }



            if (Data._SecondEmployer == true && Data._Emp2EnteredWhenUCXandWagesin == false)
            {
                if (Finder.FindIt(driver, "/a[@id='ctl00_Main_content_lbHaveNotWorked']"))
                {
                    Finder.ClickIt(driver, "//td[contains(text(),'" + Data._Employer2 + "')]/following-sibling::td/a");
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }

                if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']"))
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }
                else
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }

                //Employer
                Data._claimType = 1; //so that there is no UCX/UCFE triggers on employer page for second employer
                UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer2, Data._WorkedFrom2, Data._WorkedTo2);

            }


                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_1']");
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

                Finder.UseAlert(driver, 300);
            


        }
    }
}
