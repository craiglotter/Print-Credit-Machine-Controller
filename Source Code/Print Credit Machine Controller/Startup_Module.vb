Imports System.Diagnostics
Imports System.IO

Module Startup_Module

    Private Sub Error_Handler(ByVal message As String)
        Try
            Dim Display_Message1 As New Display_Message(message)
            Display_Message1.ShowDialog()
        Catch ex As Exception
            MsgBox("An error occurred in Print Credit Machine Controller 1.1's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Sub main()
        Dim ApplicationName As String
        ApplicationName = "Print Credit Machine Controller 1.1"
        Try
            Dim aModuleName As String = Diagnostics.Process.GetCurrentProcess.MainModule.ModuleName
            Dim aProcName As String = System.IO.Path.GetFileNameWithoutExtension(aModuleName)

            If Process.GetProcessesByName(aProcName).Length > 1 Then
                Dim Display_Message1 As New Display_Message("Another Instance of " & ApplicationName & " is already running. Only one instance of " & ApplicationName & " is allowed to run at any time")
                Display_Message1.ShowDialog()
                Application.Exit()
            Else

                Dim dinfo As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Monitor")
                If dinfo.Exists = False Then
                    dinfo.Create()
                End If
                Dim sinfo As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Submit")
                If sinfo.Exists = False Then
                    sinfo.Create()
                End If
                Dim tinfo As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Logs")
                If tinfo.Exists = False Then
                    tinfo.Create()
                End If
                Dim zinfo As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Errors")
                If zinfo.Exists = False Then
                    zinfo.Create()
                End If
                zinfo = New DirectoryInfo(Application.StartupPath & "\Errors\Logs")
                If zinfo.Exists = False Then
                    zinfo.Create()
                End If
                zinfo = New DirectoryInfo(Application.StartupPath & "\Errors\Monitor")
                If zinfo.Exists = False Then
                    zinfo.Create()
                End If
                
                Dim winfo As DirectoryInfo = New DirectoryInfo(Application.StartupPath & "\Processing")
                If winfo.Exists = False Then
                    winfo.Create()
                End If

                Dim monitor As New Monitor_Program
                monitor.ShowDialog()
                Application.Exit()
            End If
        Catch ex As Exception
            Error_Handler("An """ & ex.Message & """ error occurred while launching " & ApplicationName & ". The program will attempt to recover shortly.")
        End Try
    End Sub
End Module
