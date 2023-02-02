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
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Employment - Miscellaneous") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1") Then
                Debug.WriteLine("EmploymentMiscellaneous is On")
            Else
                Debug.WriteLine("EmploymentMiscellaneous is Off")
                Return
            End If

            Thread.Sleep(500)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblCertifiedTrade_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblEmployedBySchool_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblWorkedAsProfessionalAthlete_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblCommuterClaim_0", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIEmploymentStatus_rblFilingClaimDueToCOVID19_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
        End Sub
    End Class
End Namespace
