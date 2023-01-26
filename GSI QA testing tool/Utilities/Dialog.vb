Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows

Namespace GSI_QA_testing_tool.Utilities
    Module Dialog
        Sub ShowDialog(ByVal captionText As String, ByVal messageText As String)
            Dim messageBoxText As String = messageText
            Dim caption As String = captionText
            Dim button As MessageBoxButton = MessageBoxButton.OK
            Dim icon As MessageBoxImage = MessageBoxImage.Warning
            Dim result As MessageBoxResult
            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes)

            Select Case result
                Case MessageBoxResult.Cancel
                Case MessageBoxResult.Yes
                Case MessageBoxResult.No
            End Select
        End Sub
    End Module
End Namespace
