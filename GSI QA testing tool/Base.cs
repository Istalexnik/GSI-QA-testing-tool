using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Threading;

namespace GSI_QA_testing_tool
{
    class Base
    {
        static IWebDriver driver;


        public static void StartCreating(MainWindow mw)
        {
            try
            {
                CreateClaim(mw);
            }
            catch (Exception ex)
            {
                mw.Dispatcher.Invoke(() => { mw.ScreenBeforeRunning(); });
                Debug.WriteLine(ex.ToString() + ex.StackTrace);
                if (ex.Message == "Thread was being aborted.")
                { KillChromeProcess(1); }
                else
                {
                    Dialog.ShowDialog("Error", ex.Message);
                }
            }
            finally
            {
                Data.SetUpInitialData();
                mw.Dispatcher.Invoke(() => { mw.TxtSSN.Text = Data._SSN; });
                mw.Dispatcher.Invoke(() => { mw.TxtDataPane.Text = Data._DataPane; });
            }
        }

        public static void CreateClaim(MainWindow mw)
        {

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "no-sandbox" });
            //keep this for the final version
            //chromeOptions.AddArguments(new List<string>() { $@"--user-data-dir={Path.GetFullPath(@"../../Assets/ChromeProfile/")}" });
            chromeOptions.AddArguments(new List<string>() { $@"--user-data-dir={Path.GetFullPath(@"C:/ChromeProfile/")}" });
            chromeOptions.AddExcludedArgument("enable-automation");
            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver.Url = Data._URL;

            
            //Start
            UI.UI_000.FileUI(driver, wait, js);
             

            mw.Dispatcher.Invoke(() => { mw.ScreenAfterRunning(); });

            driver.Quit();
            CustomDialog customDialog = new CustomDialog("Claim Created", Data._Login);
            customDialog.ShowDialog();
        }



        public static void KillChromeProcess(int driverOrBothDriverAndBrowser)
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C " + "taskkill /f /im chromedriver.exe"
            };
            if (driverOrBothDriverAndBrowser == 2)
            {
                startinfo.Arguments = "/C " + "taskkill /f /im chrome.exe";
            }
            process.StartInfo = startinfo;
            process.Start();
        }


    }
}
