Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Xml

Namespace GSI_QA_testing_tool.Utilities
    Friend Class DateMaker
        Public Shared Function GetCurrentDay() As String
            Return DateTime.Now.Day.ToString()
        End Function

        Public Shared Function Today() As String
            Return DateTime.Now.ToString("MM/dd/yyyy")
        End Function

        Public Shared Function GetCurrentDayPlus(ByVal days As Integer) As String
            Dim daysPlus As String = DateTime.Now.AddDays(days).Day.ToString()
            Return daysPlus
        End Function

        Public Shared Function TodayPlus(ByVal days As Integer) As String
            Dim daysPlus As String = DateTime.Now.AddDays(days).ToString("MM/dd/yyyy")
            Return daysPlus
        End Function

        Public Shared Sub ClickGivenDay(ByVal elementList As IList(Of IWebElement), ByVal day As String)
            For Each ele As IWebElement In elementList
                Dim gDate As String = ele.Text

                If gDate.Contains(day) Then
                    ele.Click()
                    Exit For
                End If
            Next
        End Sub
    End Class
End Namespace
