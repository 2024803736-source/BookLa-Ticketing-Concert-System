<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblSubs2 = New System.Windows.Forms.Label()
        Me.btnGetTicket = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAboutUs = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubs2
        '
        Me.lblSubs2.AutoSize = True
        Me.lblSubs2.BackColor = System.Drawing.Color.Transparent
        Me.lblSubs2.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubs2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSubs2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblSubs2.Location = New System.Drawing.Point(74, 286)
        Me.lblSubs2.Name = "lblSubs2"
        Me.lblSubs2.Size = New System.Drawing.Size(304, 75)
        Me.lblSubs2.TabIndex = 5
        Me.lblSubs2.Text = "Welcome to BookLa Ticket" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your place for effortless " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "concert ticket booking!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSubs2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGetTicket
        '
        Me.btnGetTicket.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnGetTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetTicket.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetTicket.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnGetTicket.Location = New System.Drawing.Point(126, 395)
        Me.btnGetTicket.Name = "btnGetTicket"
        Me.btnGetTicket.Size = New System.Drawing.Size(184, 42)
        Me.btnGetTicket.TabIndex = 9
        Me.btnGetTicket.Text = "Get Ticket"
        Me.btnGetTicket.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(-2, 197)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(466, 67)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "🎶BookLa Ticket"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.BackColor = System.Drawing.Color.Transparent
        Me.lblWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebsite.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWebsite.Location = New System.Drawing.Point(528, 576)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(395, 24)
        Me.lblWebsite.TabIndex = 13
        Me.lblWebsite.Text = "W W W . B O O K L A T I C K E T . C O M"
        Me.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.MidnightBlue
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl2.Location = New System.Drawing.Point(329, 49)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(64, 20)
        Me.lbl2.TabIndex = 17
        Me.lbl2.Text = "HOME"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1152, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerPanelToolStripMenuItem, Me.AdminPanelToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'CustomerPanelToolStripMenuItem
        '
        Me.CustomerPanelToolStripMenuItem.Enabled = False
        Me.CustomerPanelToolStripMenuItem.Name = "CustomerPanelToolStripMenuItem"
        Me.CustomerPanelToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.CustomerPanelToolStripMenuItem.Text = "Customer Panel"
        '
        'AdminPanelToolStripMenuItem
        '
        Me.AdminPanelToolStripMenuItem.Name = "AdminPanelToolStripMenuItem"
        Me.AdminPanelToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.AdminPanelToolStripMenuItem.Text = "Admin Panel"
        '
        'lblAboutUs
        '
        Me.lblAboutUs.AutoSize = True
        Me.lblAboutUs.BackColor = System.Drawing.Color.Transparent
        Me.lblAboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutUs.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblAboutUs.Location = New System.Drawing.Point(513, 49)
        Me.lblAboutUs.Name = "lblAboutUs"
        Me.lblAboutUs.Size = New System.Drawing.Size(103, 20)
        Me.lblAboutUs.TabIndex = 18
        Me.lblAboutUs.Text = "ABOUT US"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblContact.Location = New System.Drawing.Point(730, 49)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(127, 20)
        Me.lblContact.TabIndex = 19
        Me.lblContact.Text = "CONTACT US"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 653)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAboutUs)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.lblSubs2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnGetTicket)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubs2 As Label
    Friend WithEvents btnGetTicket As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAboutUs As Label
    Friend WithEvents lblContact As Label
End Class
