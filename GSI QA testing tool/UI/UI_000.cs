﻿using GSI_QA_testing_tool.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GSI_QA_testing_tool.UI
{
    internal class UI_000
    {
        public static void FileUI(IWebDriver driver, WebDriverWait wait, IJavaScriptExecutor js)
        {
            // Home Page
            UI.UI_005_HomePage.GoTo(driver);

            // individual Page
            UI_010_IndividualPage.GoTo(driver);

            // Equal Opportunity and Non-Discrimination Notice
            UI_012_EqualOpportunity.GoTo(driver);

            // Privacy Agreement
            UI_013_PrivacyAgreement.GoTo(driver);

            // Individual Registration Type
            UI_014_IndividualRegistration.GoTo(driver);

            // Unemployment Insurance Compensation
            UI_015_UnemploymentInsurance.GoTo(driver);

            // Welcome to
            UI_020_WelcomeTo.GoTo(driver);

            // Social Security Number
            UI_025_SocialSecurityNumber.GoTo(driver);

            // Worker's Compensation
            UI_030_WorkersCompensation.GoTo(driver, js);

            // Work History Verification
            UI_035_WorkHistoryVerification.GoTo(driver);

            // States You Have Worked In
            UI_040_StatesYouHaveWorkedIn.GoTo(driver);

            // Federal Service
            UI_045_FederalService.GoTo(driver, wait);

            // Military Service
            UI_050_MilitaryService.GoTo(driver);

            // Login Information
            UI_055_LoginInformation.GoTo(driver, wait);

            // Name
            UI_060_NamePage.GoTo(driver);

            // Residential Address
            UI_065_ResidentialAddress.GoTo(driver, wait);

            // Phone Numbers
            UI_070_PhoneNumber.GoTo(driver);

            // Preferred Notification Method
            UI_075_PreferredNotification.GoTo(driver);

            // Citizenship
            UI_080_CitizenshipPage.GoTo(driver, wait);

            // Education Information
            UI_085_EducationInformation.GoTo(driver, wait);

            // Employment Information
            UI_090_EmploymentInformation.GoTo(driver, wait);

            // Employment - Status
            UI_095_EmploymentStatus.GoTo(driver, js);

            // Employment - Miscellaneous
            UI_100_EmploymentMiscellaneous.GoTo(driver);

            // Major Disaster Information
            UI_105_MajorDisaster.GoTo(driver, wait);

            // Labor Union Member
            UI_110_LaborUnion.GoTo(driver);

            // jobTitle
            UI_115_JobTitle.GoTo(driver);

            // Ethnic Origin
            UI_120_EthnicOrigin.GoTo(driver);

            // Identification Information
            UI_125_IdentificationInformation.GoTo(driver);

            // Military Information
            UI_130_MilitaryInformation.GoTo(driver, wait);

            // Identification Information //workaround for LA cause this page goes after military page
            UI_125_IdentificationInformation.GoTo(driver);

            // Payment Information
            UI_135_PaymentInformation.GoTo(driver, js);

            // Verify Your Identity
            UI_136_VerifyIdentity.GoTo(driver);

            // Unemployment Compensation Claim
            UI_138_UnemploymentCompensation.GoTo(driver);

            // Claim Filing
            UI_139_PFL_ClaimFiling.GoTo(driver);

            // Claim Filing
            UI_140_PFL_WhoIsFiling.GoTo(driver, wait);

            // Claim Filing
            UI_141_PFL_PaidFamilyLeaveTypes.GoTo(driver, wait);

            // Claim Filing
            UI_142_PFL_InformationAboutYourParentalLeaveEvent.GoTo(driver, js);

            // Claim Filing
            UI_143_PFL_AdditionalClaimInformation.GoTo(driver, wait);

            // Upload
            UI_148_UploadPage.GoTo(driver);

            // Employment History Before First Eployer
            UI_150_EmploymentHistoryBeforeFirst.GoTo(driver, wait, js);

            // Employment History After First Eployer
            UI_160_EmploymentHistoryAfterFirst.GoTo(driver, wait, js);

            // Gap Analysis
            UI_165_GapAnalysis.GoTo(driver, wait);

            // Claim Confirmation
            UI_170_ClaimConfirmation.GoTo(driver);

            // Important Agreement
            UI_175_ImportantAgreement.GoTo(driver);

            // What You Must Do
            UI_180_WhatYouMustDo.GoTo(driver, js);

            // Unemployment Claim Confirmation
            UI_183_PFL_BenefitsInformation.GoTo(driver);

            // Unemployment Claim Confirmation
            UI_185_UnemploymentClaimConfirmation.GoTo(driver);

         //   driver.Quit();
            CustomDialog customDialog = new CustomDialog("Claim Created", Data._Login);
            customDialog.ShowDialog();

        }
    }
}
