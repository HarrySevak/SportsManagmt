Public Class mainpage

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBoxResult.No = MsgBox("DO YOU WANT TO LOGOUT?", MsgBoxStyle.YesNo, " Sports Management") Then Exit Sub

        Me.Close()
        Loginfrm.Show()






    End Sub

    Private Sub mainpage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If notify.RichTextBox1.Text = "" And Loginfrm.ComboBox1.Text = "player" Then

            Me.Label4.Dispose()
        ElseIf Loginfrm.ComboBox1.Text = "Administrator" Then
            Me.Label4.Text = "NEW NOTIFICATION"
        End If

        Me.SetBoundsCore(150, 80, 700, 500, BoundsSpecified.Location)
        Me.SetBoundsCore(150, 100, 830, 500, BoundsSpecified.Size)


        If Loginfrm.ComboBox1.Text = "Administrator" Then
            LoginToolStripMenuItem.Visible = True
        ElseIf Loginfrm.ComboBox1.Text = "Player" Then
            LoginToolStripMenuItem.Visible = False

        End If

        If Not reqregistration.TextBox4.Text = "" And Loginfrm.ComboBox1.Text = "Administrator" Then
            Label4.Enabled = True
        Else
            Label4.Enabled = False
        End If
        
    End Sub

    Private Sub SportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SportsToolStripMenuItem.Click
        Sports.Show()

    End Sub

    Private Sub LoginRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginRegistrationToolStripMenuItem.Click
        Loginreg.Show()
        Me.Close()



    End Sub

    Private Sub EmployeeRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRegistrationToolStripMenuItem.Click
        Studregistrn.Show()
        Me.Close()


    End Sub

    Private Sub TournamentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem.Click
        tournament.Show()
        Me.Close()

    End Sub

    Private Sub CollageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollageToolStripMenuItem.Click
        Collage.Show()


    End Sub

    Private Sub StateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StateToolStripMenuItem.Click
        state.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.MouseHover
        Label1.Text = "Manage players registration, Login information ,add update and remove players" & Environment.NewLine & " In tournament section  manage their upcoming events their venue and tournament timing"
    End Sub

    Private Sub LoginToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub LoginRegistrationToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginRegistrationToolStripMenuItem.MouseHover

    End Sub

    Private Sub LoginRegistrationToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginRegistrationToolStripMenuItem.MouseLeave

    End Sub

    Private Sub XToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.DropDownOpening

    End Sub

    Private Sub XToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.MouseHover
        Label3.Text = "have look at  players  with their levels in their respective  sport "
    End Sub

    Private Sub XToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.MouseLeave
        Label3.Text = ""
    End Sub

    Private Sub SportsToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SportsToolStripMenuItem.MouseHover
        Label2.Text = "View information about  various sports  from various colleges,their stats and lot"
    End Sub

    Private Sub SportsToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SportsToolStripMenuItem.MouseLeave
        Label2.Text = ""
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

   

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RequestToAddAPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestToAddAPlayerToolStripMenuItem.Click
        reqregistration.Show()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

        notify.Show()
    End Sub

    Private Sub Label4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.DoubleClick

    End Sub

    Private Sub InboxRequestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InboxRequestToolStripMenuItem.Click
        notify.Show()
        
    End Sub
End Class
