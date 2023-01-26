Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Internal
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_005_HomePage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Home Page") Then
                Data.StopAtDialog()
            End If

            Thread.Sleep(500)

            If Data._claimType = 6 Then
                driver.FindElement(By.PartialLinkText("File a PUA Claim")).Click()
                Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']")
            Else
                Finder.ClickIt(driver, "//button[@id='btnguestlogina']")
                Finder.ClickIt(driver, "//a[@id='ctl00_hlNotRegistered']")
                Finder.ClickIt(driver, "//*[contains(text(),'File a Claim')]")
            End If
        End Sub
    End Class
End Namespace
