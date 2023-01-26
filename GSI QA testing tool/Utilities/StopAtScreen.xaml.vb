Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes

Namespace GSI_QA_testing_tool.Utilities
    Partial Public Class StopAtScreen
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub BtnStopAtScreenOk_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            For Each item In LbxStopAt.SelectedItems
                Data._StopAt += item.ToString() & ", "
            Next

            Debug.WriteLine(Data._StopAt)
            Close()
        End Sub
    End Class
End Namespace
