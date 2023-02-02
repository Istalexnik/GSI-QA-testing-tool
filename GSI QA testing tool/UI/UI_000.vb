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
            UI.UI_005_HomePage.[GoTo](driver, js)
            UI_010_IndividualPage.[GoTo](driver, js)
            UI_011_StaffDashBoard.[GoTo](driver, js)
            UI_012_EqualOpportunity.[GoTo](driver, js)
            UI_013_PrivacyAgreement.[GoTo](driver, js)
            UI_014_IndividualRegistration.[GoTo](driver, js)
            UI_015_UnemploymentInsurance.[GoTo](driver, js)
            UI_020_WelcomeTo.[GoTo](driver, js)
            UI_025_SocialSecurityNumber.[GoTo](driver, js)
            UI_030_WorkersCompensation.[GoTo](driver, js)
            UI_035_WorkHistoryVerification.[GoTo](driver, js)
            UI_040_StatesYouHaveWorkedIn.[GoTo](driver, js)
            UI_045_FederalService.[GoTo](driver, wait, js)
            UI_050_MilitaryService.[GoTo](driver, js)
            UI_055_LoginInformation.[GoTo](driver, wait, js)
            UI_060_NamePage.[GoTo](driver, js)
            UI_065_ResidentialAddress.[GoTo](driver, wait, js)
            UI_070_PhoneNumber.[GoTo](driver, js)
            UI_075_PreferredNotification.[GoTo](driver, js)
            UI_080_CitizenshipPage.[GoTo](driver, wait, js)
            UI_085_EducationInformation.[GoTo](driver, wait, js)
            UI_090_EmploymentInformation.[GoTo](driver, wait, js)
            UI_095_EmploymentStatus.[GoTo](driver, js)
            UI_100_EmploymentMiscellaneous.[GoTo](driver, js)
            UI_105_MajorDisaster.[GoTo](driver, wait, js)
            UI_110_LaborUnion.[GoTo](driver, js)
            UI_115_JobTitle.[GoTo](driver, js)
            UI_120_EthnicOrigin.[GoTo](driver, js)
            UI_125_IdentificationInformation.[GoTo](driver, js)
            UI_130_MilitaryInformation.[GoTo](driver, wait, js)
            UI_125_IdentificationInformation.[GoTo](driver, js)
            UI_135_PaymentInformation.[GoTo](driver, js)
            UI_136_VerifyIdentity.[GoTo](driver, js)
            UI_138_UnemploymentCompensation.[GoTo](driver, js)
            UI_139_PFL_ClaimFiling.[GoTo](driver, js)
            UI_140_PFL_WhoIsFiling.[GoTo](driver, wait, js)
            UI_141_PFL_PaidFamilyLeaveTypes.[GoTo](driver, wait, js)
            UI_142_PFL_InformationAboutYourParentalLeaveEvent.[GoTo](driver, js)
            UI_143_PFL_AdditionalClaimInformation.[GoTo](driver, wait, js)
            UI_148_UploadPage.[GoTo](driver, js)
            UI_150_EmploymentHistoryBeforeFirst.[GoTo](driver, wait, js)
            UI_160_EmploymentHistoryAfterFirst.[GoTo](driver, wait, js)
            UI_165_GapAnalysis.[GoTo](driver, wait, js)
            UI_170_ClaimConfirmation.[GoTo](driver, js)
            UI_175_ImportantAgreement.[GoTo](driver, js)
            UI_180_WhatYouMustDo.[GoTo](driver, js)
            UI_181_ComputerAccess.[GoTo](driver, js)
            UI_183_PFL_BenefitsInformation.[GoTo](driver, js)
            UI_185_UnemploymentClaimConfirmation.[GoTo](driver, js)
        End Sub
    End Class
End Namespace
