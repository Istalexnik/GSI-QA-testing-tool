﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_155_EmployerPage
    {
        public static void GoTo(IWebDriver driver, WebDriverWait wait, string Employer, string From, string To)
        {
            if (Finder.FindIt(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboSeparationReason']"))
            {
                Debug.WriteLine("EmployerPage is On");
            }
            else
            {
                Debug.WriteLine("EmployerPage is Off");
                return;
            }
         

            if (!Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0']"))
            {
                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName']", Employer);

                if (driver.FindElements(By.CssSelector("[id$=ac_results]")).Count() == 0)
                {
                    for (int i = 0; i < Data._Employers.Length; i++)
                    {
                        driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName']")).Clear();
                        Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName']", Data._Employers[i].ToString());
                        Thread.Sleep(1000);
                        if (driver.FindElements(By.CssSelector("[id$=ac_results]")).Count() > 0) {
                            break; 
                        }
                    }
                }

                Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtFindEmployerName']", Keys.ArrowDown + Keys.Enter);

                if (Finder.FindIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_gvFindEmployerResults_ctl02_rbSelectedEmployer']"))
                {
                    Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_gvFindEmployerResults_ctl02_rbSelectedEmployer']");
                    Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_btnSelectEmployer']");
                }

            }
            else
            {
                if (Data._claimType != 2 || Data._claimType != 3)
                {
                    driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']")).Clear();
                    Finder.ActionsSendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmpName']", Employer);
                }
            }


            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0']", wait);
            Finder.WaitClickableClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblEmployerLiable_0']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblIsThisEmployerTempOrAgency_1']");
            


            if (Data._claimType == 2 || Data._claimType == 3)
            {
                if (driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtNameOnCheckStub']")).GetAttribute("value").Equals(""))
                {
                    driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtNameOnCheckStub']")).SendKeys("U.S. SENATE");
                }

                Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1']", wait);
            }

            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Data._JobTitle);
            Thread.Sleep(2500);
            Finder.SendText(driver, "//input[@id='ctl00_Main_content_ucIndEmpHistory_txtJobTitle']", Keys.ArrowDown + Keys.Enter, wait);

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ONETDropDownList']", 1);
            Finder.UseDropDownByIndex(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblSalaryCommission_1']", 1, wait);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboFullPartTime']", 1);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlScheduleOfWork']", 1);
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlWholeHours']", 2);
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtSalary']", "10");
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboSalaryBase']", 1);
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtStartDate']", From);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1']", wait);
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtGrossEarningsThisWeek']", "0");
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtHoursWorkedThisWeek']", "0");

            if (Data._claimType != 3)
            {
                Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_cboSeparationReason']", "0001", wait);
            }

            Finder.UseDropDownByValue(driver, "//select[@id='ctl00_Main_content_ucIndEmpHistory_ddlLackOfWorkEvent']", "1", wait);

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblVoluntaryLayoff_1']");
            Finder.SendText(driver, "//*[@id='ctl00_Main_content_ucIndEmpHistory_txtEndDate']", To);
            Finder.ClickIt(driver, "//input[@id='//label[@for='ctl00_Main_content_ucIndEmpHistory_rblIntendToRecall_1']", wait);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblFamilyResponsibilities_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblEducationalInstitution_1']");
            Thread.Sleep(300);
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblCorporateOfficer_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblTransferOutOfCountry_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblLackOfTransportation_1']");

            // Employer - Frame
            if (driver.FindElements(By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]")).Count() != 0)
            {
                IWebElement iframe = driver.FindElement(By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]"));                                                                                                                                                                                                                                                                        // xpath
                driver.SwitchTo().Frame(iframe);
                driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']")).SendKeys("TEST");
                driver.SwitchTo().ParentFrame();
            }

            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblSpouseorChildofEmployer_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Severance_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Vacation_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Holiday_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Sick_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Bonus_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_WARN_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_InLieu_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_PTO_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_AdminPay_rdoPayType_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblPension_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rbl401k_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblMilitaryDisabilityCompensation_1']");
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucIndEmpHistory_rblWCReceived_1']");

            if (driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).Text == "")
            {
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1']")).SendKeys("333");
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone2']")).SendKeys("333");
                driver.FindElement(By.XPath("//input[@id='ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone3']")).SendKeys("3333");
            }

            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_ucWizardButtons_btnSave']");

            Finder.ClickIt(driver, "//div[@id='ui-id-1']//following-sibling::div/div/button[@id='btn-dialog-save']");
            Finder.ClickIt(driver, "//div[@id='ui-id-3']//following-sibling::div/div/button[@id='btn-dialog-save']");
            Finder.ClickIt(driver, "//div[@id='ui-id-5']//following-sibling::div/div/button[@id='btn-dialog-save']");


        }

    }
}