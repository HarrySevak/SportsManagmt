Public Class Reset

    Private Sub Reset_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Loginfrm.Show()


    End Sub
    Sub clear()

        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
    Private Sub Reset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim pass As String = TextBox1.Text
        Dim pass1 As String = TextBox2.Text


        If ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

            MsgBox("enter all field")

            '    Dim a As Integer = TextBox1.Text.CompareTo(TextBox2.Text)

            

        ElseIf pass = pass1 Then

            Me.Close()
            MsgBox("Password Succesfully Changed", MsgBoxStyle.Information)


            Loginfrm.Show()


        Else

            Label5.ForeColor = Color.Red
            Label5.Text = "password not match"
            Label7.Text = "re-enter password"



        End If

    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Label5.Text = ""
        Label7.Text = ""
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave
        
        

    End Sub

    Private Sub TextBox1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Move

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub ComboBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.MouseHover

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.CursorChanged
      

    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
      
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click

        Dim mix As String = TextBox1.Text
        If IsNumeric(mix) Or Not IsNumeric(mix) Then
            Label5.Text = "*must be mix of letters and numbers"
        Else
            Label5.Text = ""
        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged


    End Sub
End Class