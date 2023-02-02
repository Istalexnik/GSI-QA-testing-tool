Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_012_EqualOpportunity
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Equal Opportunity") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_btnAgree") Then
                Debug.WriteLine("EqualOpportunity is On")
            Else
                Debug.WriteLine("EqualOpportunity is Off")
                Return
            End If

            js.ExecuteScript("arguments[0].click();", driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_btnAgree']")))
        End Sub
    End Class
End Namespace
