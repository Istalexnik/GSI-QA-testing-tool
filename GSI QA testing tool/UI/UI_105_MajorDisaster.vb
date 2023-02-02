Imports GSI_QA_testing_tool.GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_105_MajorDisaster
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Major Disaster Information Not Filled Out") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "#ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1") Then
                Debug.WriteLine("MajorDisaster is On")
            Else
                Debug.WriteLine("MajorDisaster is Off")
                Return
            End If

            If Data._claimType = 6 Then
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_0", js)
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlStateAffected']", 1)
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlDisaster']", 1, wait)
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucUIDUA_ddlAffectedParish']", 1, wait)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAffectedParishLive_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAffectedParishWork_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAffectedParishTravel_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radEmployerNotOperating_0", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radSelfEmployAffected_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radWeekUnempAfterDisaster_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAbleToReachPlaceOfEmployment_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAbleToReachNewPlaceOfEmployment_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radBreadwinner_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radInjury_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radFisherman_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radAgriculturalSeasonal_1", js)

                If Data._StopAt.Contains("Major Disaster Information Filled Out") Then
                    Dim customDialog As CustomDialog = New CustomDialog("Make Selection", "Select pages you want to stop at, make changes and click ok before clicking the Next button")
                    customDialog.ShowDialog()
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
            Else
                Finder.JSClickIt(driver, "#ctl00_Main_content_ucUIDUA_radUnempDueToDisaster_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)
            End If
        End Sub
    End Class
End Namespace
