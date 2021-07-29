Imports System.Data.SqlClient

Module Module1
    Public ustyp As String
    public Dim usrnme As String
    Public Conn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\game1.mdf;Integrated Security=True;User Instance=True")
    Public cmd As New SqlCommand
    Public query As String

    Public Sub xverify()
        MsgBox("Wrong code", MsgBoxStyle.OkOnly)
        Sports.Show()
        
    End Sub
    Public Sub reqreg()
        notify.RichTextBox1.Text = reqregistration.Label1.Text + reqregistration.TextBox1.Text + reqregistration.TextBox2.Text + reqregistration.TextBox5.Text
        notify.RichTextBox1.Text += "given by-" + reqregistration.TextBox3.Text + reqregistration.ComboBox1.Text + reqregistration.TextBox4.Text

    End Sub


End Module
