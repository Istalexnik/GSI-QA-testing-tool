Imports GSI_QA_testing_tool.GSI_QA_testing_tool.Utilities
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Security.Claims
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool
    Module Data
        Public _StopAt As String
        Public _URL As String
        Public _ZIP As String
        Public _Site As String
        Public _Login As String
        Public _SSN As String
        Public _FirstName As String = "Alex"
        Public _LastName As String = "Istomin"
        Public _DOB As String = "11/11/1959"
        Public _Employer1 As String = ""
        Public _Employer2 As String = ""
        Public _DataPane As String = ""
        Public _SecondEmployer As Boolean = False
        Public _Staff As Boolean = False
        Public _WorkedFrom1 As String = "11/11/2020"
        Public _WorkedTo1 As String = DateTime.Now.ToString("MM/dd/yyyy")
        Public _WorkedFrom2 As String = "11/11/2020"
        Public _WorkedTo2 As String = DateTime.Now.ToString("MM/dd/yyyy")
        Public _claimType As Integer
        Public _claimTypes As String() = {"Regular", "UCX", "UCFE", "CWC", "Alien", "DUA"}
        Public _Employers As String() = {"Publix", "Amazon", "Walmart", "Alex"}
        Public _State As String
        Public _Abbreviation As String
        Public _BasePeriod As Boolean = True
        Public _CreditWeeks As String = "13"
        Public _FIC As String = "CA"
        Public _City As String = "City"
        Public _Wages As String = "5000"
        Public _Pass As String = "Olga2011!!!!!"
        Public _Email As String = "Random"
        Public _Phone As String = "Random"
        Public _Address As String = "1010 Street Avenue"
        Public _JobTitle As String = "test"
        Public _DriverLicense As String = "D234765456"
        Public _StaffLogin As String
        Public _StaffPass As String
        Public _Emp2EnteredWhenUCXandWagesin As Boolean

        Sub SetUpInitialData()
            _StopAt = ""
            NewSSN()
            _Emp2EnteredWhenUCXandWagesin = False
            _SecondEmployer = False
            _Staff = False
            _FirstName = "Alex"
            _LastName = "Istomin"
        End Sub

        Function FirstEmpIsLast()
            Return _SecondEmployer = False OrElse (_SecondEmployer = True AndAlso (DateTime.Parse(_WorkedTo1) > DateTime.Parse(_WorkedTo2)))
        End Function

        Function MakeEmail()
            _Email = $"{_Login}@geosolinc.com"
        End Function

        Function MakePhone()
            _Phone = "5" & Utilities.Rand.GenerateRandom("0123456789", 9)
        End Function

        Sub NewSSN()
            _SSN = "4" & Utilities.Rand.GenerateRandom("0123456789", 8)
        End Sub

        Function NewAlienCardNumber() As String
            Return "GSI" & Utilities.Rand.GenerateRandom("0123456789", 10)
        End Function

        Function NewUSCISNumber() As String
            Return Utilities.Rand.GenerateRandom("0123456789", 9)
        End Function

        Sub NewLogin()
            _Login = "GSIUI" & HostName().Substring(0, 2) & Utilities.Rand.GenerateRandom("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 7) & _claimType.ToString()
        End Sub

        Function HostName() As String
            Return System.Net.Dns.GetHostName()
        End Function

        Sub Printing()
            Debug.WriteLine($"{_Site} {_claimType} {_Login} {_SSN} {_FirstName} {_LastName} {_DOB} {_ZIP} " & $"{_URL} {_Employer1} {_WorkedFrom1} {_WorkedTo1} {_SecondEmployer} {_Employer2} {_WorkedFrom2} {_WorkedTo2}")
        End Sub

        Sub UpdateDataPane()
            _DataPane = $"{_Login} {_SSN} {_Site} \n" & _DataPane
        End Sub

        Sub CheckForStateAndAbbr()
            Dim envs As List(Of Environment) = Environment.CreateEnvironments()

            For Each v As Environment In envs

                If _Site = v.siteName Then
                    _State = v.state
                    _Abbreviation = v.abbreviation
                End If
            Next
        End Sub

        Sub StopAtDialog()
            Dim customDialog As CustomDialog = New CustomDialog("Stop At Dialog", "Make changes and click ok after clicking the Next button")
            customDialog.ShowDialog()
            Return
        End Sub

        Sub New()
        End Sub

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Module
End Namespace
