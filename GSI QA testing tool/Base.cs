using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace GSI_QA_testing_tool
{
    class Base
    {
        static IWebDriver driver;


        public static void startCreating(MainWindow mw)
        {
            try
            {
                createClaim(mw);
            }
            catch (Exception ex)
            {
                mw.Dispatcher.Invoke(() => { mw.screenBeforeRunning(); });
                Debug.WriteLine(ex.ToString() + ex.StackTrace);
                if (ex.Message == "Thread was being aborted.")
                { killChromeProcess(1); }
                else
                {
                    Utilities.Dialog.showDialog("Error", ex.Message);
                }
            }
            finally
            {
                mw.Dispatcher.Invoke(() => { mw.txtSSN.Text = Data._newSSN(); });
                mw.Dispatcher.Invoke(() => { mw.txtDataPane.Text = Data._DataPane; });
           
            }
        }

        public static void createClaim(MainWindow mw)
        {
            
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "no-sandbox" });
            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
          //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Url = Data._URL;

            
            if (Data._Site.Contains("PFL") == true)
            {
                PFL.PFL_000.filePFL(driver);
            } else
            {
                UI.UI_000.fileUI(driver);
            }
            


            mw.Dispatcher.Invoke(() => { mw.screenAfterRunning(); });
            killChromeProcess(2);
            CustomDialog customDialog = new CustomDialog("Claim Created", Data._Login);
            customDialog.ShowDialog();

        }

        public static void killChromeProcess(int driverOrBothDriverAndBrowser)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startinfo.FileName = "cmd.exe";
            startinfo.Arguments = "/C " + "taskkill /f /im chromedriver.exe";
            if (driverOrBothDriverAndBrowser == 2)
            {
                startinfo.Arguments = "/C " + "taskkill /f /im chrome.exe";
            }
            process.StartInfo = startinfo;
            process.Start();
        }


    }
}
