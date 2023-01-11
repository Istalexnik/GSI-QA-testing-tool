using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_070_PhoneNumber
    {
        public static void GoTo(IWebDriver driver)
        {

            Thread.Sleep(800);


            if (Data._StopAt.Contains("Phone Numbers"))
            {
                Data.StopAtDialog();
            }




            if (Finder.FindIt(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone1']")) 
            {
                Debug.WriteLine("PhoneNumber is On");
            }
            else
            {
                Debug.WriteLine("PhoneNumber is Off");
                return;
            }


            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone1']", Data._Phone.Substring(0,3));
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone2']", Data._Phone.Substring(3, 3));
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone3']", Data._Phone.Substring(6, 4));
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucPhone_ddlPrimePhoneType']", 1);

            Thread.Sleep(500);



            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']");
        }
    }
}
