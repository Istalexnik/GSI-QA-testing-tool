using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_000
    {
        public static void fileUI(IWebDriver driver)
        {
            // Home Page
            UI.UI_005_HomePage.homePage(driver);

            // individual Page
            UI_010_IndividualPage.individualPage(driver);
        }
    }
}
