Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool
    Class Environment
        Public siteName As String
        Public siteUrl As String
        Public zipCode As String
        Public state As String
        Public abbreviation As String
        Public employer1 As String
        Public employer2 As String
        Public staffLogin As String
        Public staffPass As String

        Public Sub New(ByVal siteName As String, ByVal siteUrl As String, ByVal zipCode As String, ByVal state As String, ByVal abbreviation As String, ByVal employer1 As String, ByVal employer2 As String, ByVal staffLogin As String, ByVal staffPass As String)
            Me.siteName = siteName
            Me.siteUrl = siteUrl
            Me.zipCode = zipCode
            Me.state = state
            Me.abbreviation = abbreviation
            Me.employer1 = employer1
            Me.employer2 = employer2
            Me.staffLogin = staffLogin
            Me.staffPass = staffPass
        End Sub

        Public Shared Function CreateEnvironments() As List(Of Environment)
            Dim list As List(Of Environment) = New List(Of Environment) From {
                New Environment("IA UAT", "https://uat-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("IA QA", "https://qa-app-vos19000000-gus.geosolinc.com/vosnet/default.aspx", "50031", "Iowa", "IA", "Target", "Amazon Com Services Inc", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("PR UAT", "https://uat-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("PR QA", "https://qa-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Publix", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("PR STAGING", "https://staging-app-vos72000000.geosolinc.com/vosnet/default.aspx", "00780", "Puerto Rico", "PR", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("DC UI UAT", "https://uat-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "SERDINO INC", "Toyota", "GSISA0", "GeoDCGUSSol22*@"),
                New Environment("DC UI QA", "https://qa-app-vos11000000-ui.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("DC PFL UAT", "https://uat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("DC PFL CUAT", "https://cuat-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("DC PFL STAGING", "https://staging-app-vos11980000.geosolinc.com/vosnet/default.aspx", "20010", "District of Columbia", "DC", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("PA UAT", "https://uat-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("PA CIT", "https://cit.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "Gsisa02", "UIgsiA1*"),
                New Environment("PA CUAT", "https://uat.benefits.uc.pa.gov/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "gsisa0", "UIgsiA1*"),
                New Environment("PA QA", "https://qa-app-vos42000000.geosolinc.com/vosnet/default.aspx", "17104", "Pennsylvania", "PA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("NE UAT", "https://uat-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "GSIUITAX1110S", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("NE QA", "https://qa-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("NE STAGING", "https://staging-app-vos31000000.geosolinc.com/vosnet/default.aspx", "68104", "Nebraska", "NE", "gsitaxmc080701", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("LA UAT", "https://uat-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("LA QA", "https://qa-app-vos22000000.geosolinc.com/vosnet/default.aspx", "70803", "Louisiana", "LA", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("TN UAT", "https://uat-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("TN QA", "https://qa-app-vos47000000.geosolinc.com/vosnet/default.aspx", "37243", "Tennessee", "TN", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("AZ UAT", "https://uat-app-vos04000000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@"),
                New Environment("AZ PUA UAT", "https://uat-app-vos04990000.geosolinc.com/vosnet/default.aspx", "86438", "Arizona", "AZ", "Target", "Toyota", "GSISA0", "GeoIAGUSSol22*@")
            }
            Return list
        End Function
    End Class
End Namespace
