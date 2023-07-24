Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_130_MilitaryInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            If Data._StopAt.Contains("Military Information") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_ucVeteran_rblTAPWorkshop_1']") Then
                Debug.WriteLine("MilitaryInformation is On")
            Else
                Debug.WriteLine("MilitaryInformation is maybe On")
            End If



            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblSpouseactivedutyBase_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblCaregiver_1", js)
            Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucVeteran_rblSpouse_1']", js)

            If Data._claimType <> 2 Then
                Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucVeteran_rblMilitaryService_1']", js)
            Else
                Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucVeteran_rblMilitaryService_1']", js)
                driver.SwitchTo().Alert().Accept()
            End If


            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblTransitioningServiceMember_1", js)
            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucVeteran_ddlClassifiedAsDisabledVeteran']", "0")
            Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucVeteran_rblWounded_1']", js)

            Finder.JSClickIt(driver, "*[for='ctl00_Main_content_ucVeteran_rblTAPWorkshop_1']", js)

            Finder.WaitClickableClickItByCSS(driver, "#ctl00_Main_content_btnNext", wait)
        End Sub
    End Class
End Namespace
