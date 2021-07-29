Public Class Studregistrn

    Private Sub Studregistrn_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainpage.Show()

    End Sub

    Private Sub Studregistrn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.Show("enter full name", Me)


    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Enter

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If IsNumeric(e.KeyChar) Then
            Label3.Text = "name should not contain numbers"

        End If
    End Sub

    Private Sub TextBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseEnter
    End Sub

    Private Sub TextBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseHover


    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.MouseLeave

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
      
    End Sub

    Private Sub TextBox4_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Enter
        Label3.Text = ""
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If Not IsNumeric(TextBox7.Text) Then
            MsgBox("only numbers allowed")
            Dim c As Integer
            c = CInt(TextBox7.Text)

            If c >= 100 Then
                MsgBox("enter proper age")
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class