﻿Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_014_IndividualRegistration
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)

            Thread.Sleep(3000)


            If Data._StopAt.Contains("Individual Registration Type") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "[id='ctl00_Main_content_lnkCompleteHeader']") Then
                Debug.WriteLine("IndividualRegistration is On")
            Else
                Debug.WriteLine("IndividualRegistration is Off")
                Return
            End If

            Finder.JSClickIt(driver, "#ctl00_Main_content_lnkCompleteHeader", js)
        End Sub
    End Class
End Namespace
