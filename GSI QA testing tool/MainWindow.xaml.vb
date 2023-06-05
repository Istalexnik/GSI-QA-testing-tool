Imports GSI_QA_testing_tool.GSI_QA_testing_tool.Utilities
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Linq
Imports System.Security.Claims
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation

Namespace GSI_QA_testing_tool
    Partial Public Class MainWindow
        Inherits Window

        Private thread As Thread
        ReadOnly envs As List(Of Environment) = Environment.CreateEnvironments()

        Public Sub New()
            InitializeComponent()
            InitialSetUpGUI()
        End Sub

        Public Sub InitialSetUpGUI()
            CbxSite.Items.Clear()
            CbxClaimType.Items.Clear()

            For Each v As Environment In envs
                CbxSite.Items.Add(v.siteName)
            Next

            For i As Integer = 0 To Data._claimTypes.Length - 1
                CbxClaimType.Items.Add(Data._claimTypes(i))
            Next

            CbxSite.SelectedIndex = 0
            CbxClaimType.SelectedIndex = 0
            Data.SetUpInitialData()
            TxtSSN.Text = Data._SSN
            TxtFirstName.Text = Data._FirstName
            TxtLastName.Text = Data._LastName
            TxtDOB.Text = Data._DOB
            TxtWorkedFrom1.Text = Data._WorkedFrom1
            TxtWorkedTo1.Text = Data._WorkedTo1
            TxtWorkedFrom2.Text = Data._WorkedFrom2
            TxtWorkedTo2.Text = Data._WorkedTo2
            ChbSecondEmployer.IsChecked = Data._SecondEmployer
            ChbStaff.IsChecked = Data._Staff
            TxtEmail.Text = "Random"
            TxtPhone.Text = "Random"
            txtAddress.Text = "Random"
        End Sub

        Public Sub ScreenBeforeRunning()
            BtnStart.Visibility = Visibility.Visible
            BtnStop.Visibility = Visibility.Hidden
        End Sub

        Public Sub ScreenWhileRunning()
            BtnStart.Visibility = Visibility.Hidden
            BtnStop.Visibility = Visibility.Visible
        End Sub

        Public Sub ScreenAfterRunning()
            ScreenBeforeRunning()
        End Sub

        Private Sub BtnStart_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Try
                AssigningFromGUIToData()
                ScreenWhileRunning()
                thread = New Thread(Sub() Base.StartCreating(Me))
                thread.SetApartmentState(ApartmentState.STA)
                thread.Start()
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            Finally
            End Try
        End Sub

        Private Sub BtnStop_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            thread.Abort()
            ScreenBeforeRunning()
        End Sub

        Private Sub BtnReset_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Base.KillChromeProcess(2)
            InitialSetUpGUI()
        End Sub

        Private Sub CbxSite_SelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
            Dim currentSite As String = Nothing

            For Each v As Environment In envs

                If CbxSite.SelectedItem IsNot Nothing Then
                    currentSite = CbxSite.SelectedItem.ToString()
                End If

                If currentSite = v.siteName Then
                    TxtZIP.Text = v.zipCode
                    TxtURL.Text = v.siteUrl
                    TxtEmployer1.Text = v.employer1
                    TxtEmployer2.Text = v.employer2
                    Data._StaffLogin = v.staffLogin
                    Data._StaffPass = v.staffPass
                End If
            Next

            If currentSite = "AZ PUA UAT" Then
                CbxClaimType.SelectedItem = "DUA"
            End If
        End Sub

        Public Sub AssigningFromGUIToData()
            Data._SSN = TxtSSN.Text
            Data._FirstName = TxtFirstName.Text
            Data._LastName = TxtLastName.Text
            Data._DOB = TxtDOB.Text
            Data._Employer1 = TxtEmployer1.Text
            Data._WorkedFrom1 = TxtWorkedFrom1.Text
            Data._WorkedTo1 = TxtWorkedTo1.Text
            Data._Employer2 = TxtEmployer2.Text
            Data._WorkedFrom2 = TxtWorkedFrom2.Text
            Data._WorkedTo2 = TxtWorkedTo2.Text
            Data._SecondEmployer = CBool(ChbSecondEmployer.IsChecked)
            Data._Staff = CBool(ChbStaff.IsChecked)
            Data._Site = CbxSite.SelectedItem.ToString()
            Data._URL = TxtURL.Text
            Data._ZIP = TxtZIP.Text
            Data._claimType = CInt(CbxClaimType.SelectedIndex) + 1
            Data.NewLogin()
            Data.MakeEmail()
            Data.MakePhone()
            Data.MakeAddress()


            If TxtEmail.Text <> "Random" AndAlso TxtEmail.Text <> "" Then
                Data._Email = TxtEmail.Text
            End If

            If TxtPhone.Text <> "Random" AndAlso TxtPhone.Text <> "" Then
                Data._Phone = TxtPhone.Text
            End If

            If txtAddress.Text <> "Random" AndAlso txtAddress.Text <> "" Then
                Data._Address = txtAddress.Text
            End If

            Data.CheckForStateAndAbbr()
            Data.UpdateDataPane()
            Data.Printing()
        End Sub

        Private Sub BtnStopAt_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim StopAtSceen As StopAtScreen = New StopAtScreen()
            StopAtSceen.Show()
        End Sub
    End Class
End Namespace
