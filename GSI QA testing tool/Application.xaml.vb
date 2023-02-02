Imports GSI_QA_testing_tool.GSI_QA_testing_tool

Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    Private Sub App_Exit(ByVal sender As Object, ByVal e As ExitEventArgs)
        Base.KillChromeProcess(2)
    End Sub
End Class
