Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_165_GapAnalysis
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(800)

            If Data._StopAt.Contains("Gap Analysis") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//input[@id='ctl00_Main_content_btnNextMonetaryReview']") Then
                Debug.WriteLine("GapAnalysis is On")
            Else
                Debug.WriteLine("GapAnalysis is Off")
                Return
            End If

            If Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ddlCorrectEmpsAndWages_0']") Then
                js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//*[@id='ctl00_Main_content_ddlCorrectEmpsAndWages_0']")))
            End If

            Thread.Sleep(800)

            If Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl02_btnGapSummary']") Then
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl02_btnGapSummary']")
                Thread.Sleep(1000)
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_txtGapExplanation']", "test")
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_btnSave']", wait)
            End If

            If Finder.FindIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl03_btnGapSummary']") Then
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_grdEmploymentGaps_ctl03_btnGapSummary']", wait)
                Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_txtGapExplanation']", "test")
                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucEmployerGapAnalysis_btnSave']")
            End If

            driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnNextMonetaryReview']")).Click()
        End Sub
    End Class
End Namespace
