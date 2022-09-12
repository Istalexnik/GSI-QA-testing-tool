﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_005_HomePage
    {
        public static void GoTo(IWebDriver driver)
        {
            Finder.ClickIt(driver, "//button[@id='btnguestlogina']");
            Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']");
            Finder.ClickIt(driver, "//*[contains(text(),'File a Claim')]");
        }
    }
}
