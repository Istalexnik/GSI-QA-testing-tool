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
Imports System.Windows.Controls.Primitives

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_055_LoginInformation
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            Thread.Sleep(500)

            If Data._StopAt.Contains("Login Information Not Filled Out") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucLogin_txtUsername']") Then
                Debug.WriteLine("LoginInformation is On")
            Else
                Debug.WriteLine("LoginInformation is Off")
                Return
            End If

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_txtUsername']", Data._Login)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwd']", Data._Pass)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucLogin_ucPassword_txtPwdConfirm']", Data._Pass)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucLogin_ddlSecurityQuestion']", 2)
            driver.FindElement(By.XPath("//input[@id='txtSecurityQuestionResponse']")).Clear()
            Finder.SendText(driver, "//input[@id='txtSecurityQuestionResponse']", "lol")
            Finder.JSClickIt(driver, "#ctl00_Main_content_radAuthorizedToWork_0", js)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_txtZip']", Data._ZIP)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmail']", Data._Email)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucEmailTextBox_txtEmailConfirm']", Data._Email)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOB']", Data._DOB)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtDOBConfirm']", Data._DOB)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtCityOfBirth']", Data._City)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucRegDemographics_txtMothersMaidenName']", "Mother")
            Finder.JSClickIt(driver, "#ctl00_Main_content_ucRegDemographics_rblGender_0", js)

            Try
                Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucRegDemographics_ddlDraftStatus']", 2, wait)
            Catch ex As Exception
            End Try

            Finder.JSClickIt(driver, "#ctl00_Main_content_ucRegDemographics_rblArrested_1", js)

            If Data._StopAt.Contains("Login Information Filled Out") Then
                Data.StopAtDialog()
            End If

            Finder.WaitClickableClickItByCSS(driver, "#ctl00_Main_content_btnNext", wait)
        End Sub
    End Class
End Namespace
