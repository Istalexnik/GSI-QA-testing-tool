using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GSI_QA_testing_tool.Utilities
{
    internal class DateMaker
    {

        public static string GetCurrentDay()
        {
            return DateTime.Now.Day.ToString();
        }

        public static string Today()
        {
          return  DateTime.Now.ToString("MM/dd/yyyy");
        }
            

        public static string GetCurrentDayPlus(int days)
        {
            string daysPlus = DateTime.Now.AddDays(days).Day.ToString(); 
            return daysPlus;
        }

        public static string TodayPlus(int days)
        {
            String daysPlus = DateTime.Now.AddDays(days).ToString("MM/dd/yyyy");
            return daysPlus;
        }



        public static void ClickGivenDay(IList<IWebElement> elementList, string day)
        {


            foreach (IWebElement ele in elementList) // use foreach iterate each cell.
            {
                string date = ele.Text; // get the text of the element.

                if (date.Contains(day)) // check if the date is 20
                {
                    ele.Click(); // if date is 20, select it.
                    break;
                }
            }

            // DatePicker is a table. Thus we can navigate to each cell
            // and if a cell matches with the current date then we will click it.
            /** Functional JAVA version of this method. */
            // elementList.stream().Filter(element->element.getText().contains(day)).findFirst().ifPresent(IWebElement::Click);
            /** Non-functional JAVA version of this method. */
            // for (
            // WebElement cell : elementList) {
            // String cellText = cell.getText();
            // if (cellText.contains(day)) {
            // cell.click();
            // break;
            // }
            // }
        }





    }
}
