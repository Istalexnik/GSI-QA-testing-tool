Imports GSI_QA_testing_tool.Utilities
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
    Friend Class UI_155_EmployerPage
        Public Shared Sub CreateUIEmployer(ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor, ByVal Employer As String, ByVal From As String, ByVal [To] As String)
            If Data._StopAt.Contains("Employer Page Not Filled Out") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName'], [for='ctl00_Main_content_ucIndEmpHistory_txtEmpName']") Then
                Debug.WriteLine("EmployerPage is On")
            Else
                Debug.WriteLine("EmployerPage is Off")
            End If

            If Data._Site.Contains("DC PFL") Then
                CreatePFLEmployer(driver, wait, Employer, From)
                Return
            End If

            Thread.Sleep(500)

            If Not Finder.FindItByCSS(driver, "#ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0") Then
                Finder.ActionsSendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName']", Employer, wait)

                If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucIndEmpHistory_gvFindEmployerResults_ctl02_rbSelectedEmployer']") Then
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_gvFindEmployerResults_ctl02_rbSelectedEmployer']")
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_btnSelectEmployer']")
                End If

                wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0']")))
            Else

                If Data._claimType <> 2 AndAlso Data._claimType <> 3 Then
                    driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']")).Clear()
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']", Employer)
                    Thread.Sleep(2500)

                    Try
                        Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']", Keys.ArrowDown + Keys.Enter, wait)
                    Catch e As Exception
                        Console.WriteLine("Employer Field  is not using javasCript and Employer is not picking up from  system")
                    End Try
                End If
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0']", wait)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblEmployerLiable_0']")
            Finder.WaitClickableClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblIsThisEmployerTempOrAgency_1']", wait)

            If Data._claimType = 2 OrElse Data._claimType = 3 Then

                If driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtNameOnCheckStub']")).GetAttribute("value").Equals("") Then
                    driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtNameOnCheckStub']")).SendKeys("U.S. SENATE")
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1']", wait)
            End If

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Data._JobTitle)
            Thread.Sleep(2500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Keys.ArrowDown + Keys.Enter, wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ONETDropDownList']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboEmpType']", 1, wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboFullPartTime']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlScheduleOfWork']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlWholeHours']", 2)
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtSalary']", "10")
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboSalaryBase']", 1)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblSalaryCommission_1']")
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtStartDate']", From)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1']")
            Thread.Sleep(3500)
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtGrossEarningsThisWeek']", "0")
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtHoursWorkedThisWeek']", "0")

            If Data._claimType <> 3 Then
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboSeparationReason']", "0001", wait)
            End If

            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlLackOfWorkEvent']", "1")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblVoluntaryLayoff_1']")
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtEndDate']", [To])
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblIntendToRecall_1']")
            Thread.Sleep(300)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblFamilyResponsibilities_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblEducationalInstitution_1']")
            Thread.Sleep(300)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCorporateOfficer_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblTransferOutOfCountry_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLackOfTransportation_1']")

            If driver.FindElements(By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]")).Count() <> 0 Then
                Dim iframe As IWebElement = driver.FindElement(By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]"))
                driver.SwitchTo().Frame(iframe)
                driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']")).SendKeys("TEST")
                driver.SwitchTo().ParentFrame()
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblSpouseorChildofEmployer_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Severance_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Vacation_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Holiday_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Sick_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Bonus_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_WARN_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_InLieu_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_PTO_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_AdminPay_rdoPayType_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblPension_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rbl401k_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblMilitaryDisabilityCompensation_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblWCReceived_1']")

            If driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).Text = "" Then
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).SendKeys("333")
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone2']")).SendKeys("333")
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone3']")).SendKeys("3333")
            End If

            If Data._StopAt.Contains("Employer Page Filled Out") Then
                Data.StopAtDialog()
            End If

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucWizardButtons_btnSave']")
            Dim forms = driver.FindElements(By.XPath("//button[@id='btn-dialog-save']"))

            For Each form In forms
                js.ExecuteScript("arguments[0].click();", form)
            Next

            wait.Until(ExpectedConditions.ElementExists(By.XPath("//label[@for='ctl00_Main_content_rblAddAnotherEntry_1']")))

            If Employer = Data._Employer2 Then

                If Data.FirstEmpIsLast() Then
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_RowSelect_LastEmployer']", wait)
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
            End If
        End Sub

        Public Shared Sub CreatePFLEmployer(ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal Employer As String, ByVal From As String)
            If Data._StopAt.Contains("PFL Employer Page Not Filled Out") Then
                Data.StopAtDialog()
            End If

            driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']")).Clear()
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']", Employer)
            Thread.Sleep(2500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']", Keys.ArrowDown + Keys.Enter, wait)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtSupervisorName']", "Test")
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtSupervisorEmail']", Data._Email)

            If driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).Text = "" Then
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).SendKeys("333")
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone2']")).SendKeys("333")
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone3']")).SendKeys("3333")
            End If

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_chkPopulateEmpWorkSiteAddress']", wait)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Data._JobTitle)
            Thread.Sleep(2500)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Keys.ArrowDown + Keys.Enter, wait)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboFullPartTime']", 1)
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtStartDate']", From)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblReceivedPFLProgramNotice_1']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1']", wait)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucWizardButtons_btnSave']")

            If Employer = Data._Employer2 Then

                If Data.FirstEmpIsLast() Then
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_RowSelect_LastEmployer']", wait)
                End If

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_rblAddAnotherEntry_1']")
                Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
            End If
        End Sub
    End Class
End Namespace
