Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Loginfrm


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.SetBounds(280, 200, 0, 0, BoundsSpecified.Location)


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.MouseEnter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Text = "select usertype"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If ComboBox1.Text = "" Then
            MsgBox("Enter usertype")
        ElseIf MaskedTextBox1.Text = "" Then
            MsgBox("Enter the username")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Enter the password")

        Else
            ' Try

            'Dim conn As SqlConnection = New SqlConnection()
            'conn.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\game1.mdf;Integrated Security=True;User Instance=True"

            'conn.Open()

            'Dim query As String = " SELECT username,password FROM login WHERE usertype = @usertype username = @username password = @password;"


            'cmd = New SqlCommand(query, Conn)
            'cmd.Parameters.AddWithValue("@usertype", ComboBox1.Text)
            'cmd.Parameters.AddWithValue("@username", MaskedTextBox1.Text)
            'cmd.Parameters.AddWithValue("@password", TextBox1.Text)



            'Dim right As Integer = cmd.ExecuteNonQuery()


            mainpage.Show()
            Me.Hide()

            'Catch ex As SqlException
            'MsgBox(ex.Message & ex.Number & ex.GetType.ToString)

            'MaskedTextBox1.Text = ""
            'TextBox1.Text = ""
            'Me.Show()


            'Finally

            'Conn.Close()

            'End Try

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        MaskedTextBox1.Text = ""
        TextBox1.Text = ""
        Dim temp As Integer = MsgBox("reset password ", MsgBoxStyle.YesNo)

        If temp = DialogResult.Yes Then
            Reset.Show()
            Me.Hide()

        ElseIf temp = DialogResult.No Then

            Me.Show()

        End If





    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()


    End Sub

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter



    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave




    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus

    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        If TextBox1.Text = "*************" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        Else

        End If
    End Sub

    Private Sub TextBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseHover

    End Sub



    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave




    End Sub




    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub MaskedTextBox1_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.CursorChanged


    End Sub

    Private Sub MaskedTextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.Enter

    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox1.KeyPress

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub MaskedTextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MaskedTextBox1.MouseClick
        If MaskedTextBox1.Text = "enter Username" Then
            MaskedTextBox1.Text = ""
            MaskedTextBox1.ForeColor = Color.Black
        Else
        End If
    End Sub

    Private Sub MaskedTextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.MouseEnter

    End Sub

    Private Sub MaskedTextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.MouseLeave


    End Sub

    Private Sub MaskedTextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MaskedTextBox1.MouseMove

    End Sub

    Private Sub MaskedTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.TextChanged
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseHover


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseHover

    End Sub
End Class


