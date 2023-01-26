Imports OpenQA.Selenium
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Timers
Imports System.Windows.Controls.Primitives
Imports System.Net.Mime.MediaTypeNames

Namespace GSI_QA_testing_tool
    Public Class Finder
        Public Shared Function FindIt(ByVal driver As IWebDriver, ByVal path As String) As Boolean
            Return driver.FindElements(By.XPath(path)).Count <> 0
        End Function

        Public Shared Function FindItByCSS(ByVal driver As IWebDriver, ByVal CSSPath As String) As Boolean
            Return driver.FindElements(By.CssSelector(CSSPath)).Count <> 0
        End Function


        Public Shared Sub JSClickIt(ByVal driver As IWebDriver, ByVal CSSpath As String, ByVal js As IJavaScriptExecutor)
            If driver.FindElements(By.CssSelector(CSSpath)).Count <> 0 Then
                js.ExecuteScript("arguments[0].click();", driver.FindElement(By.CssSelector(CSSpath)))
            End If
        End Sub

        Public Shared Sub ClickIt(ByVal driver As IWebDriver, ByVal path As String)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                driver.FindElement(By.XPath(path)).Click()
            End If
        End Sub

        Public Shared Sub ClickIt(ByVal driver As IWebDriver, ByVal path As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).Click()
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub

        Public Shared Sub WaitStaleClickIt(ByVal driver As IWebDriver, ByVal path As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).Click()
            End If
        End Sub

        Public Shared Sub WaitClickableClickIt(ByVal driver As IWebDriver, ByVal path As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path))).Click()
            End If
        End Sub

        Public Shared Sub SendText(ByVal driver As IWebDriver, ByVal path As String, ByVal text As String)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                driver.FindElement(By.XPath(path)).SendKeys(text)
            End If
        End Sub

        Public Shared Sub SendText(ByVal driver As IWebDriver, ByVal path As String, ByVal text As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                driver.FindElement(By.XPath(path)).SendKeys(text)
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub

        Public Shared Sub WaitStaleSendText(ByVal driver As IWebDriver, ByVal path As String, ByVal text As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
                driver.FindElement(By.XPath(path)).SendKeys(text)
            End If
        End Sub

        Public Shared Sub WaitClickableSendText(ByVal driver As IWebDriver, ByVal path As String, ByVal text As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(path)))
                driver.FindElement(By.XPath(path)).SendKeys(text)
            End If
        End Sub

        Public Shared Sub ActionsSendText(ByVal driver As IWebDriver, ByVal path As String, ByVal text As String, ByVal Optional wait As WebDriverWait = Nothing)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim act As Actions = New Actions(driver)
                act.MoveToElement(driver.FindElement(By.XPath(path)))
                act.Click()
                act.Pause(New TimeSpan(300))
                act.SendKeys(text)
                act.DoubleClick()
                act.Pause(New TimeSpan(1000))
                act.SendKeys(Keys.Down)
                act.SendKeys(Keys.Down)
                act.SendKeys(Keys.Enter)
                act.Build().Perform()
            End If

            If wait IsNot Nothing Then
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub

        Public Shared Sub UseAlert(ByVal driver As IWebDriver, ByVal time As Integer)
            Try
                Dim alert As IAlert = driver.SwitchTo().Alert()
                Thread.Sleep(time)
                alert.Accept()
            Catch nap As NoAlertPresentException
                Debug.WriteLine(nap.Message)
            End Try
        End Sub

        Public Shared Sub UseDropDownByValue(ByVal driver As IWebDriver, ByVal path As String, ByVal value As String)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByValue(value)
            End If
        End Sub

        Public Shared Sub UseDropDownByValue(ByVal driver As IWebDriver, ByVal path As String, ByVal value As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByValue(value)
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub

        Public Shared Sub UseDropDownByText(ByVal driver As IWebDriver, ByVal path As String, ByVal value As String)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByText(value)
            End If
        End Sub

        Public Shared Sub UseDropDownByText(ByVal driver As IWebDriver, ByVal path As String, ByVal value As String, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByText(value)
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub

        Public Shared Sub UseDropDownByIndex(ByVal driver As IWebDriver, ByVal path As String, ByVal value As Integer)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByIndex(value)
            End If
        End Sub

        Public Shared Sub UseDropDownByIndex(ByVal driver As IWebDriver, ByVal path As String, ByVal value As Integer, ByVal wait As WebDriverWait)
            If driver.FindElements(By.XPath(path)).Count <> 0 Then
                Dim [select] As SelectElement = New SelectElement(driver.FindElement(By.XPath(path)))
                [select].SelectByIndex(value)
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath(path))))
            End If
        End Sub
    End Class
End Namespace
