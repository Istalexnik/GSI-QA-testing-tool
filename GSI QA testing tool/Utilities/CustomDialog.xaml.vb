Imports System
Imports System.Collections.Generic
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
    Partial Public Class CustomDialog
        Inherits Window

        Public Sub New(ByVal question As String, ByVal Optional defaultAnswer As String = "")
            InitializeComponent()
            lblQuestion.Content = question
            txtAnswer.Text = defaultAnswer
        End Sub

        Private Sub btnDialogOk_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.DialogResult = True
        End Sub

        Private Sub Window_ContentRendered(ByVal sender As Object, ByVal e As EventArgs)
            txtAnswer.SelectAll()
            txtAnswer.Focus()
        End Sub

        Public ReadOnly Property Answer As String
            Get
                Return txtAnswer.Text
            End Get
        End Property
    End Class
End Namespace
