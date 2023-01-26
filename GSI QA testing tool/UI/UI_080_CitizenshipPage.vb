Imports GSI_QA_testing_tool.Utilities
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
    Friend Class UI_080_CitizenshipPage
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait)
            If Data._StopAt.Contains("Citizenship Page") Then
                Data.StopAtDialog()
            End If

            If Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']") Then
                Debug.WriteLine("CitizenshipPage is On")
            Else
                Debug.WriteLine("CitizenshipPage is Off")
                Return
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblDependents_1']", wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddlHowManyDependents']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddlMaritalStatus']", 1)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblDisability_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblChildSupport_1']")

            If Data._claimType = 5 Then
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']", "3", wait)
                Finder.UseDropDownByText(driver, "//select[contains(@id, 'ctl00_Main_content_ucDemographics_ddl_UI_AlienRegDoc')]", "I-551 Permanent Resident Card", wait)
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_DocumentNumber']", Data.NewAlienCardNumber())
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_DocumentExpDate']", "11/11/2033")
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucDemographics_txt_UI_AlienReceiptNumber']", Data.NewUSCISNumber())
            Else
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucDemographics_ddl_UI_Citizen' or @id='ctl00_Main_content_ucDemographics_ddlCitizen']", 1, wait)
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucDemographics_rblChildSupport_1']")
            Finder.WaitClickableClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']", wait)
        End Sub
    End Class
End Namespace
