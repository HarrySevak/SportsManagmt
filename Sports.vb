Public Class Sports

    Private Sub FootballToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FootballToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        




    End Sub

    Private Sub FootballToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FootballToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FootballToolStripMenuItem.Click

    End Sub

    Private Sub FootballToolStripMenuItem_MouseHover1(ByVal sender As Object, ByVal e As System.EventArgs) Handles FootballToolStripMenuItem.MouseHover
        Label1.Text = "Info About FootBall Players like Tournament dates ,Venue , about Level etc"
        BackgroundImage = My.Resources.football24
    End Sub

    Private Sub FootballToolStripMenuItem_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles FootballToolStripMenuItem.MouseLeave
        Label1.Text = ""
        BackgroundImage = My.Resources.football1
    End Sub

    Private Sub Sports_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate


    End Sub

    Private Sub Sports_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mainpage.Enabled = True

        mainpage.Show()
    End Sub

    Private Sub Sports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Enabled Then
            mainpage.Enabled = False

        End If
    End Sub

    Private Sub TournamentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem.Click

        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "FootBall Tournament Details"
            verifyplayer.Show()

        Else
            tournament.Show()

        End If
    End Sub

    Private Sub TournamentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem1.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Show()
            verifyplayer.Label1.Text = "Hockey Tournament Details"

        Else
            tournament.Show()
        End If

    End Sub

    Private Sub TournamentToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem2.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "Cricket Tournament Details"
            verifyplayer.Show()
        Else
            tournament.Show()
        End If


    End Sub

    Private Sub TournamentToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem3.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "VolleyBall Tournament Details"
            verifyplayer.Show()
        Else
            tournament.Show()
        End If

    End Sub

    Private Sub TournamentToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TournamentToolStripMenuItem4.Click

        If Loginfrm.ComboBox1.Text = "Player" Then


            verifyplayer.Label1.Text = "Tennis Tournament Details"
            verifyplayer.Show()
        Else
            tournament.Show()

        End If
    End Sub

    Private Sub PlayersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "FootBall Players Detail"
            verifyplayer.Show()
        Else
            Player.Show()
        End If

    End Sub

    Private Sub PlayersToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem1.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "Cricket Players Details"
            verifyplayer.Show()
        Else
            Player.Show()
        End If

    End Sub

    Private Sub PlayeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayeToolStripMenuItem.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "Hockey Players Details"
            verifyplayer.Show()
        Else
            Player.Show()
        End If


    End Sub

    Private Sub PlayersToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem2.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "VolleyBall Players Details"
            verifyplayer.Show()
        Else
            Player.Show()
        End If
    End Sub

    Private Sub PlayersToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem3.Click
        If Loginfrm.ComboBox1.Text = "Player" Then
            verifyplayer.Label1.Text = "Tennis Players Details"
            verifyplayer.Show()
        Else
            Player.Show()
        End If
    End Sub

    Private Sub HockeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HockeyToolStripMenuItem.Click

    End Sub

    Private Sub HockeyToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HockeyToolStripMenuItem.MouseHover
        BackgroundImage = My.Resources.hockey2
    End Sub

    Private Sub HockeyToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HockeyToolStripMenuItem.MouseLeave
        BackgroundImage = My.Resources.football1
    End Sub

    Private Sub CricketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CricketToolStripMenuItem.Click

    End Sub

    Private Sub CricketToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CricketToolStripMenuItem.MouseHover
        BackgroundImage = My.Resources.cricket3


    End Sub

    Private Sub CricketToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CricketToolStripMenuItem.MouseLeave
        BackgroundImage = My.Resources.football1


    End Sub

    Private Sub Sports_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover

    End Sub

    Private Sub VolleyballToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolleyballToolStripMenuItem.Click

    End Sub

    Private Sub VolleyballToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles VolleyballToolStripMenuItem.MouseHover
        BackgroundImage = My.Resources.volley21
    End Sub

    Private Sub VolleyballToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles VolleyballToolStripMenuItem.MouseLeave
        BackgroundImage = My.Resources.football1
    End Sub

    Private Sub TennisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TennisToolStripMenuItem.Click

    End Sub

    Private Sub TennisToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles TennisToolStripMenuItem.MouseHover

        BackgroundImage = My.Resources.tennis14
    End Sub

    Private Sub TennisToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TennisToolStripMenuItem.MouseLeave


        BackgroundImage = My.Resources.football1
    End Sub
End Class