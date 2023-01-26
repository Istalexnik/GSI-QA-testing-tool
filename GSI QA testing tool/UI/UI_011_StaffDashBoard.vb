Imports OpenQA.Selenium

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_011_StaffDashBoard
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._Staff = True Then

                If Data._StopAt.Contains("StaffDashBoard Page") Then
                    Data.StopAtDialog()
                End If

                Finder.ClickIt(driver, "//*[@id='ctl00_Main_content_ucStaffSignNotice_btnAgree']")

                Finder.ClickIt(driver, "//*[@id='btnPopupclose']")
                driver.FindElement(By.CssSelector(".fa-bars")).Click()
                driver.FindElement(By.CssSelector("*[id^='ctl00_MstPageSideMenu_r_hlManageClaimants']")).Click()
                driver.FindElement(By.CssSelector("*[id^='ctl00_Main_content_MenuLandingPage_hlCreateaClaimantAccount']")).Click()
            End If
        End Sub
    End Class
End Namespace
