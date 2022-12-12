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
    internal class UI_150_EmploymentHistoryBeforeFirst
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait, IJavaScriptExecutor js)
        {

            if (Data._StopAt.Contains("Employment History Before First Eployer"))
            {
                Data.StopAtDialog();
            }




            //if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_0']") || Finder.FindIt(driver, "/a[@id='ctl00_Main_content_lbHaveNotWorked']"))
            //{
            //    Debug.WriteLine("EmploymentHistoryBeforeFirst is On");
            //}
            //else
            //{
            //    Debug.WriteLine("EmploymentHistoryBeforeFirst is Off");
            //    return;
            //}


            string EmpReverse;
            string EmpStartDateReverse;
            string EmpLastDatReverse;

            if (Data._claimType == 2 || Data._claimType == 3)
            {
                if (Finder.FindIt(driver, "//a[@id='ctl00_Main_content_lbHaveNotWorked']"))
                {
                    Finder.ClickIt(driver, "//td[contains(text(),'" + Data._Employer2 + "')]/following-sibling::td/a");
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");

                    // Employer
                    UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer1, Data._WorkedFrom1, Data._WorkedTo1);

                    Data._Emp2EnteredWhenUCXandWagesin = true;
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }
                else
                {
                    Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_lnkEditAction']");
                }
            }
            else
            {
                if (Finder.FindIt(driver, "//a[@id='ctl00_Main_content_lbHaveNotWorked']"))
                {
                    try
                    {
                        Finder.ClickIt(driver, "//td[contains(text(),'" + Data._Employer1 + "')]/following-sibling::td/a");
                    }
                    catch
                    {
                        EmpReverse = Data._Employer1;
                        Data._Employer1 = Data._Employer2;
                        Data._Employer2 = EmpReverse;
                        EmpStartDateReverse = Data._WorkedFrom1;
                        EmpLastDatReverse = Data._WorkedTo1;
                        Data._WorkedFrom1 = Data._WorkedFrom2;
                        Data._WorkedTo1 = Data._WorkedTo2;
                        Data._WorkedFrom2 = EmpStartDateReverse;
                        Data._WorkedTo2 = EmpLastDatReverse;
                        Finder.ClickIt(driver, "//td[contains(text(),'" + Data._Employer1 + "')]/following-sibling::td/a");
                    }
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }
                else
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_0']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
                }
            }

            UI_155_EmployerPage.CreateUIEmployer(driver, wait, js, Data._Employer1, Data._WorkedFrom1, Data._WorkedTo1);


        }
    }
}
