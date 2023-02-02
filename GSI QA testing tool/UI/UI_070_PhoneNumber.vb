Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Controls.Primitives

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_070_PhoneNumber
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(800)

            If Data._StopAt.Contains("Phone Numbers") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucPhone_txtPrimePhone1") Then
                Debug.WriteLine("PhoneNumber is On")
            Else
                Debug.WriteLine("PhoneNumber is Off")
                Return
            End If

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone1']", Data._Phone.Substring(0, 3))
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone2']", Data._Phone.Substring(3, 3))
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucPhone_txtPrimePhone3']", Data._Phone.Substring(6, 4))
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucPhone_ddlPrimePhoneType']", 1)
            Thread.Sleep(500)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
