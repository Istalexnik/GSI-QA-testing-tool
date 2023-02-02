Imports GSI_QA_testing_tool.GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Security.Policy
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Markup
Imports System.Windows.Threading

Namespace GSI_QA_testing_tool
    Class Base
        Shared driver As IWebDriver

        Public Shared Sub StartCreating(ByVal mw As MainWindow)
            Try
                CreateClaim(mw)
            Catch ex As Exception
                mw.Dispatcher.Invoke(Sub()
                                         mw.ScreenBeforeRunning()
                                     End Sub)
                Debug.WriteLine(ex.ToString() & ex.StackTrace)

                If ex.Message = "Thread was being aborted." Then
                    KillChromeProcess(1)
                Else
                    Dialog.ShowDialog("Error", ex.Message)
                End If

            Finally
                Data.SetUpInitialData()
                mw.Dispatcher.Invoke(Sub()
                                         mw.TxtSSN.Text = Data._SSN
                                     End Sub)
                mw.Dispatcher.Invoke(Sub()
                                         mw.TxtDataPane.Text = Data._DataPane
                                     End Sub)
            End Try
        End Sub

        Public Shared Sub CreateClaim(ByVal mw As MainWindow)
            Dim service As OpenQA.Selenium.Chrome.ChromeDriverService = OpenQA.Selenium.Chrome.ChromeDriverService.CreateDefaultService()
            service.HideCommandPromptWindow = True
            'Dim chromeDriverService = chromeDriverService.CreateDefaultService()
            'ChromeDriverService.HideCommandPromptWindow = True
            Dim chromeOptions = New ChromeOptions()
            chromeOptions.AddArguments(New List(Of String)() From {
                "no-sandbox"
            })
            chromeOptions.AddArguments(New List(Of String)() From {
                $"--user-data-dir={Path.GetFullPath("C:/ChromeProfile/")}"
            })
            chromeOptions.AddExcludedArgument("enable-automation")
            driver = New ChromeDriver(service, chromeOptions)
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120)
            Dim wait As WebDriverWait = New WebDriverWait(driver, TimeSpan.FromSeconds(15))
            Dim js As IJavaScriptExecutor = CType(driver, IJavaScriptExecutor)
            driver.Url = Data._URL
            UI.UI_000.FileUI(driver, wait, js)
            mw.Dispatcher.Invoke(Sub()
                                     mw.ScreenAfterRunning()
                                 End Sub)
            driver.Quit()
            Dim customDialog As CustomDialog = New CustomDialog("Claim Created", Data._Login)
            customDialog.ShowDialog()
        End Sub

        Public Shared Sub KillChromeProcess(ByVal driverOrBothDriverAndBrowser As Integer)
            Dim process As Process = New Process()
            Dim startinfo As ProcessStartInfo = New ProcessStartInfo With {
                .WindowStyle = ProcessWindowStyle.Hidden,
                .FileName = "cmd.exe",
                .Arguments = "/C " & "taskkill /f /im chromedriver.exe"
            }

            If driverOrBothDriverAndBrowser = 2 Then
                startinfo.Arguments = "/C " & "taskkill /f /im chrome.exe"
            End If

            process.StartInfo = startinfo
            process.Start()
        End Sub
    End Class
End Namespace
