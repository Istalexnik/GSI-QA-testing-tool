Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
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

            Thread.Sleep(500)

            Try
                Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblSpouseEligiblePerson_1']", js, wait)
            Catch ex As Exception
            End Try


            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblSpouseactivedutyBase_1", js)
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblCaregiver_1", js)


            Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblSpouse_1']", js)


            If Data._claimType <> 2 Then
                Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblMilitaryService_1']", js)
            Else
                Try
                    Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblMilitaryService_1']", js)
                    driver.SwitchTo().Alert().Accept()
                Catch ex As Exception
                End Try
            End If



            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1", js)
            Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1']", js)

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucVeteran_rblTransitioningServiceMember_1", js)

            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucVeteran_ddlClassifiedAsDisabledVeteran']", "0")
            Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblWounded_1']", js)

            Finder.JSClickIt(driver, "[for='ctl00_Main_content_ucVeteran_rblTAPWorkshop_1']", js)

            Try
                Finder.WaitClickableClickItByCSS(driver, "#ctl00_Main_content_btnNext", wait)
            Catch ex As Exception
                wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.Id("ctl00_Main_content_btnNext"))))
                Finder.JSClickIt(driver, "#ctl00_Main_content_btnNext", js)

            End Try


        End Sub
    End Class
End Namespace
