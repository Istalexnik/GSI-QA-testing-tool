Imports GSI_QA_testing_tool.Utilities
Imports OpenQA.Selenium
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Controls.Primitives

Namespace GSI_QA_testing_tool.UI
    Friend Class UI_075_PreferredNotification
        Public Shared Sub [GoTo](ByVal driver As IWebDriver)
            If Data._StopAt.Contains("Preferred Notification Method") Then
                Data.StopAtDialog()
            End If

            If Finder.FindItByCSS(driver, "*[id='ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods']") Then
                Debug.WriteLine("PreferredNotification is On")
            Else
                Debug.WriteLine("PreferredNotification is Off")
                Return
            End If

            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddlDeterminationNotificationMethod']", 1)
            Finder.UseDropDownByIndex(driver, "//select[@id='ctl00_Main_content_ucNotificationMethod_ddl1099GNotificationMethod']", 1)
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucNotificationMethod_cb1099Acknowledge']")
            Finder.ClickIt(driver, "//*[@id='btn-dialog-ok']")
            Finder.ClickIt(driver, "//label[@for='ctl00_Main_content_ucNotificationMethod_rblSignUpMessageLaborService_1']")
            Finder.UseDropDownByIndex(driver, "//select[contains(@id, 'ctl00_Main_content_ucSiteAccess_ddl')]", 2)
            Finder.ClickIt(driver, "//input[@id='ctl00_Main_content_btnNext']")
        End Sub
    End Class
End Namespace
