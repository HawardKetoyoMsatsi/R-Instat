﻿Namespace My
    ''' The 'My' namespace and the 'My.Application' objects are part of the dotnet framework.
    ''' This class extends the 'My.Application' object by creating a Partial class named MyApplication.
    ''' This class handles the event raised when R-Instat is launched when it's already running.
    ''' For more details on extending 'My.Application', please see: 
    ''' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/customizing-extending-my/extending-the-my-namespace 
    ''' </summary>
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            If e.CommandLine.Count > 0 Then
                If MsgBox("Would you like to open this file?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    dlgImportDataset.strFileToOpenOn = e.CommandLine(0)
                    dlgImportDataset.bStartOpenDialog = False
                    dlgImportDataset.ShowDialog()
                End If
            End If
        End Sub
    End Class
End Namespace
