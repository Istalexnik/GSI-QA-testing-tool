Imports OpenQA.Selenium.Support.UI
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Threading
Imports GSI_QA_testing_tool.GSI_QA_testing_tool.Utilities

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_142_PFL_InformationAboutYourParentalLeaveEvent
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("PFL Information About Your Parental Leave Event") Then
                Data.StopAtDialog()
            End If

            Thread.Sleep(500)

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLBeginDate") Then
                Debug.WriteLine("PFL_InformationAboutYourParentalLeaveEvent is On")
            Else
                Debug.WriteLine("PFL_InformationAboutYourParentalLeaveEvent is Off")
                Return
            End If

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLBeginDate']", DateMaker.Today())
            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalDaysPerWeek']", "5")
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLParentalLeave_rblPFLParentalNormalWorkSunday_1", js)
            Dim parentWindow As String = driver.CurrentWindowHandle
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//a[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_lnkButton']")))
            Dim allWindows As IList(Of String) = New List(Of String)(driver.WindowHandles)

            For Each curWindow As String In allWindows
                driver.SwitchTo().Window(curWindow)
            Next

            Dim dateWidgetFrom As IWebElement = driver.FindElement(By.Id("ctl00_Main_content_ucCalendar_pnlCalendar"))
            Dim columns As IList(Of IWebElement) = dateWidgetFrom.FindElements(By.TagName("td"))
            DateMaker.ClickGivenDay(columns, DateMaker.GetCurrentDay())
            Thread.Sleep(1000)
            DateMaker.ClickGivenDay(columns, DateMaker.GetCurrentDayPlus(7))
            driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnSave']")).Click()
            driver.SwitchTo().Window(parentWindow)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalEventType']", 1)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalFirstName']", "Test")
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalLastName']", "Test")
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_txtPFLParentalDOB']", DateMaker.Today())
            Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_ucPFLParentalLeave_rblPFLParentalGender_1", js)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ddlPFLParentalEvidence']", 1)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucPFLParentalLeave_ucSupportingDocumentation_filUpload1']", "C:/Test/a.png")
            Thread.Sleep(3000)
            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton']")))
        End Sub
    End Class
End Namespace
