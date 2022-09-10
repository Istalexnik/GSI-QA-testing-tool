﻿using GSI_QA_testing_tool.Utilities;
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
                    Dialog.showDialog("Error", ex.Message);
                }
            }
            finally
            {
                mw.Dispatcher.Invoke(() => { mw.TxtSSN.Text = Data.NewSSN(); });
                mw.Dispatcher.Invoke(() => { mw.TxtDataPane.Text = Data._DataPane; });
           
            }
        }

        public static void CreateClaim(MainWindow mw)
        {
            
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>() { "no-sandbox" });
            driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
          //  WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Url = Data._URL;

            
            if (Data._Site.Contains("PFL"))
            {
                PFL.PFL_000.filePFL(driver);
            } else
            {
                UI.UI_000.FileUI(driver);
            }
            


            mw.Dispatcher.Invoke(() => { mw.ScreenAfterRunning(); });
            //TURN IT ON LATER WHEN YOU ARE DONE WITH SCRIPTS!!!!!!!!!!!!
           // KillChromeProcess(2);
          //  CustomDialog customDialog = new CustomDialog("Claim Created", Data._Login);
          //  customDialog.ShowDialog();

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