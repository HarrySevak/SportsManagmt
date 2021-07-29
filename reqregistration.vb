Public Class reqregistration

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim request As Integer = MsgBox("We Will Contact You Soon ")
        reqreg()
        If request = MsgBoxResult.Ok Then
            Me.Close()


        End If
       
    End Sub

    Private Sub reqregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class