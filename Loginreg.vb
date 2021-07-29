Public Class Loginreg

    Private Sub Loginreg_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainpage.Show()
    End Sub

    Private Sub Loginreg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            query = "insert into tbl_log(usertype,username,password)"
            query = query & "values('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')'"

            cmd = New Data.SqlClient.SqlCommand(query, Conn)
            cmd.Connection = Conn
            Conn.Open()
            cmd.ExecuteNonQuery()
        Catch EX As Exception

            MsgBox("error")


        End Try

    End Sub
End Class