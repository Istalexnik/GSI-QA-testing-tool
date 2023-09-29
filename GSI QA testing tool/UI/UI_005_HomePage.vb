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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Home Page") Then
                Data.StopAtDialog()
            End If

            Thread.Sleep(3000)

            If Data._claimType = 6 Then
                driver.FindElement(By.PartialLinkText("File a PUA Claim")).Click()
                Finder.JSClickIt(driver, "#ctl00_hlNotRegistered", js)
            ElseIf Data._Site.Contains("AZ") Then
                driver.FindElement(By.PartialLinkText("File a regular unemployment claim")).Click()
                Dim originalWindow As String = driver.CurrentWindowHandle
                For Each window In driver.WindowHandles
                    If originalWindow <> window Then
                        driver.Close()
                        driver.SwitchTo().Window(window)
                    End If
                Next


            Else
                Finder.JSClickIt(driver, "#btnguestlogina", js)
                Finder.JSClickIt(driver, "#btnguestloginb", js)
                Finder.JSClickIt(driver, "#btnguestlogina2", js)

                Finder.JSClickIt(driver, "#ctl00_hlNotRegistered", js)
                Thread.Sleep(2500)

                'If driver.FindElements(By.CssSelector("*:contains('File a Claim')")).Count <> 0 Then
                '    js.ExecuteScript("arguments[0].click();", driver.FindElement(By.CssSelector("*:contains('File a Claim')")))
                'End If

            End If
        End Sub
    End Class
End Namespace
