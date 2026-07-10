<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookTicket))
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.rdStandardA = New System.Windows.Forms.RadioButton()
        Me.rdPremium = New System.Windows.Forms.RadioButton()
        Me.rdVIP = New System.Windows.Forms.RadioButton()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdStandardC = New System.Windows.Forms.RadioButton()
        Me.rdStandardB = New System.Windows.Forms.RadioButton()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPriceDisplay = New System.Windows.Forms.Label()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbPoster
        '
        Me.pbPoster.BackColor = System.Drawing.Color.Black
        Me.pbPoster.Location = New System.Drawing.Point(58, 194)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(380, 270)
        Me.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPoster.TabIndex = 0
        Me.pbPoster.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(54, 171)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(131, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Concert Name"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDate.Location = New System.Drawing.Point(54, 486)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(121, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Concert Date"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLocation.Location = New System.Drawing.Point(54, 465)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(137, 20)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Concert Venue"
        '
        'rdStandardA
        '
        Me.rdStandardA.AutoSize = True
        Me.rdStandardA.BackColor = System.Drawing.Color.Transparent
        Me.rdStandardA.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStandardA.Location = New System.Drawing.Point(183, 349)
        Me.rdStandardA.Name = "rdStandardA"
        Me.rdStandardA.Size = New System.Drawing.Size(118, 22)
        Me.rdStandardA.TabIndex = 2
        Me.rdStandardA.TabStop = True
        Me.rdStandardA.Text = "Standard A"
        Me.rdStandardA.UseVisualStyleBackColor = False
        '
        'rdPremium
        '
        Me.rdPremium.AutoSize = True
        Me.rdPremium.BackColor = System.Drawing.Color.Transparent
        Me.rdPremium.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPremium.Location = New System.Drawing.Point(185, 251)
        Me.rdPremium.Name = "rdPremium"
        Me.rdPremium.Size = New System.Drawing.Size(99, 22)
        Me.rdPremium.TabIndex = 1
        Me.rdPremium.TabStop = True
        Me.rdPremium.Text = "Premium"
        Me.rdPremium.UseVisualStyleBackColor = False
        '
        'rdVIP
        '
        Me.rdVIP.AutoSize = True
        Me.rdVIP.BackColor = System.Drawing.Color.Transparent
        Me.rdVIP.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdVIP.ForeColor = System.Drawing.Color.Black
        Me.rdVIP.Location = New System.Drawing.Point(203, 156)
        Me.rdVIP.Name = "rdVIP"
        Me.rdVIP.Size = New System.Drawing.Size(59, 22)
        Me.rdVIP.TabIndex = 0
        Me.rdVIP.TabStop = True
        Me.rdVIP.Text = "VIP"
        Me.rdVIP.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfirm.Location = New System.Drawing.Point(1003, 606)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(137, 35)
        Me.btnConfirm.TabIndex = 5
        Me.btnConfirm.Text = "Book Now"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 50)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BOOK TICKET "
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.Location = New System.Drawing.Point(12, 606)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 35)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.rdStandardC)
        Me.GroupBox1.Controls.Add(Me.rdStandardB)
        Me.GroupBox1.Controls.Add(Me.rdPremium)
        Me.GroupBox1.Controls.Add(Me.rdStandardA)
        Me.GroupBox1.Controls.Add(Me.rdVIP)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(495, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 442)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Seat :"
        '
        'rdStandardC
        '
        Me.rdStandardC.AutoSize = True
        Me.rdStandardC.BackColor = System.Drawing.Color.Transparent
        Me.rdStandardC.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdStandardC.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStandardC.Location = New System.Drawing.Point(52, 199)
        Me.rdStandardC.Name = "rdStandardC"
        Me.rdStandardC.Size = New System.Drawing.Size(88, 74)
        Me.rdStandardC.TabIndex = 4
        Me.rdStandardC.TabStop = True
        Me.rdStandardC.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Standard " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     C"
        Me.rdStandardC.UseVisualStyleBackColor = False
        '
        'rdStandardB
        '
        Me.rdStandardB.AutoSize = True
        Me.rdStandardB.BackColor = System.Drawing.Color.Transparent
        Me.rdStandardB.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rdStandardB.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdStandardB.ForeColor = System.Drawing.Color.Black
        Me.rdStandardB.Location = New System.Drawing.Point(345, 199)
        Me.rdStandardB.Name = "rdStandardB"
        Me.rdStandardB.Size = New System.Drawing.Size(83, 74)
        Me.rdStandardB.TabIndex = 3
        Me.rdStandardB.TabStop = True
        Me.rdStandardB.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Standard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      B"
        Me.rdStandardB.UseVisualStyleBackColor = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Britannic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(-6, 0)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(254, 37)
        Me.lblLogo.TabIndex = 12
        Me.lblLogo.Text = "🎶BookLa Ticket"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(956, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 579)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seat Price : "
        '
        'lblPriceDisplay
        '
        Me.lblPriceDisplay.AutoSize = True
        Me.lblPriceDisplay.BackColor = System.Drawing.Color.Transparent
        Me.lblPriceDisplay.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceDisplay.Location = New System.Drawing.Point(618, 579)
        Me.lblPriceDisplay.Name = "lblPriceDisplay"
        Me.lblPriceDisplay.Size = New System.Drawing.Size(43, 21)
        Me.lblPriceDisplay.TabIndex = 6
        Me.lblPriceDisplay.Text = "RM"
        '
        'BookTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 653)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPriceDisplay)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.pbPoster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BookTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookTicket"
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbPoster As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents rdStandardA As RadioButton
    Friend WithEvents rdPremium As RadioButton
    Friend WithEvents rdVIP As RadioButton
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdStandardC As RadioButton
    Friend WithEvents rdStandardB As RadioButton
    Friend WithEvents lblLogo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPriceDisplay As Label
End Class
