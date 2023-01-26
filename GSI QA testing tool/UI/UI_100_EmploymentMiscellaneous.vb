Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_100_EmploymentMiscellaneous
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Employment - Miscellaneous") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1']") Then
                Debug.WriteLine("EmploymentMiscellaneous is On")
            Else
                Debug.WriteLine("EmploymentMiscellaneous is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCertifiedTrade_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblEmployedBySchool_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblWorkedAsProfessionalAthlete_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblCommuterClaim_0']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucUIEmploymentStatus_rblFilingClaimDueToCOVID19_1']")
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
