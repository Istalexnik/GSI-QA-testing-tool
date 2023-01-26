Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Runtime.Remoting.Lifetime
Imports System.Security.Claims
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_000
        Public Shared Sub FileUI(ByVal driver As IWebDriver, ByVal wait As WebDriverWait, ByVal js As IJavaScriptExecutor)
            UI.UI_005_HomePage.[GoTo](driver)
            UI_010_IndividualPage.[GoTo](driver)
            UI_011_StaffDashBoard.[GoTo](driver)
            UI_012_EqualOpportunity.[GoTo](driver, js)
            UI_013_PrivacyAgreement.[GoTo](driver)
            UI_014_IndividualRegistration.[GoTo](driver)
            UI_015_UnemploymentInsurance.[GoTo](driver)
            UI_020_WelcomeTo.[GoTo](driver)
            UI_025_SocialSecurityNumber.[GoTo](driver)
            UI_030_WorkersCompensation.[GoTo](driver, js)
            UI_035_WorkHistoryVerification.[GoTo](driver)
            UI_040_StatesYouHaveWorkedIn.[GoTo](driver)
            UI_045_FederalService.[GoTo](driver, wait)
            UI_050_MilitaryService.[GoTo](driver)
            UI_055_LoginInformation.[GoTo](driver, wait)
            UI_060_NamePage.[GoTo](driver)
            UI_065_ResidentialAddress.[GoTo](driver, wait)
            UI_070_PhoneNumber.[GoTo](driver)
            UI_075_PreferredNotification.[GoTo](driver)
            UI_080_CitizenshipPage.[GoTo](driver, wait)
            UI_085_EducationInformation.[GoTo](driver, wait)
            UI_090_EmploymentInformation.[GoTo](driver, wait, js)
            UI_095_EmploymentStatus.[GoTo](driver, js)
            UI_100_EmploymentMiscellaneous.[GoTo](driver)
            UI_105_MajorDisaster.[GoTo](driver, wait)
            UI_110_LaborUnion.[GoTo](driver)
            UI_115_JobTitle.[GoTo](driver)
            UI_120_EthnicOrigin.[GoTo](driver)
            UI_125_IdentificationInformation.[GoTo](driver)
            UI_130_MilitaryInformation.[GoTo](driver, wait, js)
            UI_125_IdentificationInformation.[GoTo](driver)
            UI_135_PaymentInformation.[GoTo](driver, js)
            UI_136_VerifyIdentity.[GoTo](driver)
            UI_138_UnemploymentCompensation.[GoTo](driver)
            UI_139_PFL_ClaimFiling.[GoTo](driver)
            UI_140_PFL_WhoIsFiling.[GoTo](driver, wait)
            UI_141_PFL_PaidFamilyLeaveTypes.[GoTo](driver, wait)
            UI_142_PFL_InformationAboutYourParentalLeaveEvent.[GoTo](driver, js)
            UI_143_PFL_AdditionalClaimInformation.[GoTo](driver, wait)
            UI_148_UploadPage.[GoTo](driver)
            UI_150_EmploymentHistoryBeforeFirst.[GoTo](driver, wait, js)
            UI_160_EmploymentHistoryAfterFirst.[GoTo](driver, wait, js)
            UI_165_GapAnalysis.[GoTo](driver, wait, js)
            UI_170_ClaimConfirmation.[GoTo](driver)
            UI_175_ImportantAgreement.[GoTo](driver)
            UI_180_WhatYouMustDo.[GoTo](driver, js)
            UI_181_ComputerAccess.[GoTo](driver)
            UI_183_PFL_BenefitsInformation.[GoTo](driver)
            UI_185_UnemploymentClaimConfirmation.[GoTo](driver)
        End Sub
    End Class
End Namespace
