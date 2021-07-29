Public Class verifyplayer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


            If TextBox1.Text = "football123" And Label1.Text = "FootBall Players Details" Then
                Player.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "footballT123" And Label1.Text = "FootBall Tournament Details" Then
                tournament.Show()
                Me.Hide()
                TextBox1.Text = ""


            ElseIf TextBox1.Text = "hockey123" And Label1.Text = "Hockey Players Details" Then
                Player.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "hockeyT123" And Label1.Text = "Hockey Tournament Details" Then
                tournamenT_ingm.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "cricket123" And Label1.Text = "Cricket Players Details" Then
                Player.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "cricketT123" And Label1.Text = "Cricket Tournament Details" Then
                tournamenT_ingm.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "volleyball123" And Label1.Text = "VolleyBall Players Details" Then
                Player.Show()
                Me.Hide()
                TextBox1.Text = ""


            ElseIf TextBox1.Text = "volleyballT123" And Label1.Text = "VolleyBall Tournament Details" Then
                tournamenT_ingm.Show()
                Me.Hide()
                TextBox1.Text = ""

            ElseIf TextBox1.Text = "tennis123" And Label1.Text = "Tennis Players Details" Then
                Player.Show()
                TextBox1.Text = ""
                Me.Hide()

            ElseIf TextBox1.Text = "tennisT123" And Label1.Text = "Tennis Tournament Details" Then
                tournamenT_ingm.Show()
                Me.Hide()
                TextBox1.Text = ""
            Else : xverify()
            End If





    End Sub

    Private Sub verifyplayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class