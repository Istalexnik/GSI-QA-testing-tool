using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool
{
    public class Finder
    {
        public static void click(IWebDriver driver, String path)
        {
            if (driver.FindElements(By.XPath(path)).Count != 0)

            {
                driver.FindElement(By.XPath(path)).Click();
            }
        }

    }
}
