﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.PFL
{
    internal class PFL_000
    {
        public static void FilePFL(IWebDriver driver, WebDriverWait wait)
        {
            UI.UI_005_HomePage.GoTo(driver);
        }
    }
}
