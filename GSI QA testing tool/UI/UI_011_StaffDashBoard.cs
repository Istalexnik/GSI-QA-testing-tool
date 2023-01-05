using OpenQA.Selenium;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_011_StaffDashBoard
    {
        public static void GoTo(IWebDriver driver)
        {

            if (Data._Staff == true)
            {

                if (Data._StopAt.Contains("StaffDashBoard Page"))
                {
                    Data.StopAtDialog();
                }



                Finder.ClickIt(driver, "//*[@id='btnPopupclose']");
                driver.FindElement(By.CssSelector(".fa-bars")).Click();
                driver.FindElement(By.CssSelector("*[id^='ctl00_MstPageSideMenu_r_hlManageClaimants']")).Click();
                driver.FindElement(By.CssSelector("*[id^='ctl00_Main_content_MenuLandingPage_hlCreateaClaimantAccount']")).Click();


                //Finder.ClickIt(driver, "//*[@id='ctl00_MstPageSideMenu_r_hlManageClaimants11984']");
                //Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_MenuLandingPage_hlCreateaClaimantAccount13525']");
            }

        }
    }
}
