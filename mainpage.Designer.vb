<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainpage))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CollageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NationalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RequestToAddAPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.InboxRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SportsToolStripMenuItem, Me.XToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(776, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginRegistrationToolStripMenuItem, Me.EmployeeRegistrationToolStripMenuItem, Me.TournamentToolStripMenuItem, Me.InboxRequestToolStripMenuItem})
        Me.LoginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LoginToolStripMenuItem.Text = "Manage"
        '
        'LoginRegistrationToolStripMenuItem
        '
        Me.LoginRegistrationToolStripMenuItem.Name = "LoginRegistrationToolStripMenuItem"
        Me.LoginRegistrationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.LoginRegistrationToolStripMenuItem.Text = "Login Registration"
        '
        'EmployeeRegistrationToolStripMenuItem
        '
        Me.EmployeeRegistrationToolStripMenuItem.Name = "EmployeeRegistrationToolStripMenuItem"
        Me.EmployeeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EmployeeRegistrationToolStripMenuItem.Text = "Student Registration"
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.TournamentToolStripMenuItem.Text = "Tournament"
        '
        'SportsToolStripMenuItem
        '
        Me.SportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SportsToolStripMenuItem.Name = "SportsToolStripMenuItem"
        Me.SportsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SportsToolStripMenuItem.Text = "Sports"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CollageToolStripMenuItem, Me.StateToolStripMenuItem, Me.NationalToolStripMenuItem})
        Me.XToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.XToolStripMenuItem.Text = "Level"
        '
        'CollageToolStripMenuItem
        '
        Me.CollageToolStripMenuItem.Name = "CollageToolStripMenuItem"
        Me.CollageToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.CollageToolStripMenuItem.Text = "Collage"
        '
        'StateToolStripMenuItem
        '
        Me.StateToolStripMenuItem.Name = "StateToolStripMenuItem"
        Me.StateToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.StateToolStripMenuItem.Text = "State"
        '
        'NationalToolStripMenuItem
        '
        Me.NationalToolStripMenuItem.Name = "NationalToolStripMenuItem"
        Me.NationalToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.NationalToolStripMenuItem.Text = "National"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestToAddAPlayerToolStripMenuItem, Me.MailToolStripMenuItem, Me.FeedbackToolStripMenuItem})
        Me.ContactToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ContactToolStripMenuItem.Text = "contact"
        '
        'RequestToAddAPlayerToolStripMenuItem
        '
        Me.RequestToAddAPlayerToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestToAddAPlayerToolStripMenuItem.Name = "RequestToAddAPlayerToolStripMenuItem"
        Me.RequestToAddAPlayerToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.RequestToAddAPlayerToolStripMenuItem.Text = "*register new player *"
        '
        'MailToolStripMenuItem
        '
        Me.MailToolStripMenuItem.Name = "MailToolStripMenuItem"
        Me.MailToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MailToolStripMenuItem.Text = "mail "
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.FeedbackToolStripMenuItem.Text = "feedback"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = CType(resources.GetObject("TableLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.655172!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.34483!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(870, 547)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.Snow
        Me.Panel1.Location = New System.Drawing.Point(86, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 247)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(275, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(221, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(181, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(670, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "new notification"
        '
        'InboxRequestToolStripMenuItem
        '
        Me.InboxRequestToolStripMenuItem.Name = "InboxRequestToolStripMenuItem"
        Me.InboxRequestToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.InboxRequestToolStripMenuItem.Text = "Request inbox"
        '
        'mainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(776, 538)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainpage"
        Me.Opacity = 0.98
        Me.Text = "   MasterPage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TournamentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NationalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestToAddAPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InboxRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
