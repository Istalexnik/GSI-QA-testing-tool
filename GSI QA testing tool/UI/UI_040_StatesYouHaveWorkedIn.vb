Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Security.Claims
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_040_StatesYouHaveWorkedIn
        Public Shared Sub [GoTo](ByVal driver As IWebDriver, ByVal js As IJavaScriptExecutor)

            Thread.Sleep(300)

            If Finder.FindItByCSS(driver, "*[for='ctl00_Main_content_Wizard1_rblStatesWorkedIn_1']") Then
                Debug.WriteLine("StatesYouHaveWorkedIn is On")
            Else
                Debug.WriteLine("StatesYouHaveWorkedIn is Off")
                Return
            End If

            If Data._StopAt.Contains("States You Have Worked In") Then
                Data.StopAtDialog()
            End If


            If Data._claimType = 4 Then

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblStatesWorkedIn_0", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_chkStateHostState", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_chkStateList_9", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblAppliedUCPast12Months_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)

                If Data._StopAt.Contains("States You Have Worked In Credit Weeks") Then
                    Data.StopAtDialog()
                End If

                If Finder.FindItByCSS(driver, "#ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ1") Then
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ1']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ2']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ3']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ4']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl00_txtQ5']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ1']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ2']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ3']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ4']", Data._CreditWeeks)
                    Finder.SendText(driver, "//input[@id='ctl00_Main_content_Wizard1_ucEnterOOSCreditWeeks_rptCreditWeeks_ctl02_txtQ5']", Data._CreditWeeks)
                    Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
                End If

                If Data._StopAt.Contains("States You Have Worked In Interstate Claim") Then
                    Data.StopAtDialog()
                End If

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblFileInHostState_0", js)
                Finder.UseAlert(driver, 1500)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
            Else

                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblStatesWorkedIn_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_rblAppliedUCPast12Months_1", js)
                Finder.JSClickIt(driver, "#ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton", js)
            End If
        End Sub
    End Class
End Namespace
