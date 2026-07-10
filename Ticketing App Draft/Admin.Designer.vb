<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtConcertName = New System.Windows.Forms.TextBox()
        Me.txtConcertDate = New System.Windows.Forms.TextBox()
        Me.gpBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConcertID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblPoster = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.picPreview = New System.Windows.Forms.PictureBox()
        Me.lblConcertDate = New System.Windows.Forms.Label()
        Me.lblConcertName = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnremoveR = New System.Windows.Forms.Button()
        Me.lblReceiptID = New System.Windows.Forms.Label()
        Me.txtRemoveT = New System.Windows.Forms.TextBox()
        Me.gpBox1.SuspendLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInsert.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.White
        Me.btnInsert.Location = New System.Drawing.Point(149, 309)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(130, 40)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.TabStop = False
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtConcertName
        '
        Me.txtConcertName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConcertName.Location = New System.Drawing.Point(206, 40)
        Me.txtConcertName.Name = "txtConcertName"
        Me.txtConcertName.Size = New System.Drawing.Size(241, 28)
        Me.txtConcertName.TabIndex = 1
        '
        'txtConcertDate
        '
        Me.txtConcertDate.Location = New System.Drawing.Point(209, 147)
        Me.txtConcertDate.Name = "txtConcertDate"
        Me.txtConcertDate.Size = New System.Drawing.Size(241, 28)
        Me.txtConcertDate.TabIndex = 4
        '
        'gpBox1
        '
        Me.gpBox1.BackColor = System.Drawing.Color.Transparent
        Me.gpBox1.Controls.Add(Me.Label1)
        Me.gpBox1.Controls.Add(Me.txtConcertID)
        Me.gpBox1.Controls.Add(Me.lblID)
        Me.gpBox1.Controls.Add(Me.lblPoster)
        Me.gpBox1.Controls.Add(Me.lblLoc)
        Me.gpBox1.Controls.Add(Me.txtLoc)
        Me.gpBox1.Controls.Add(Me.btnBrowse)
        Me.gpBox1.Controls.Add(Me.btnRemove)
        Me.gpBox1.Controls.Add(Me.picPreview)
        Me.gpBox1.Controls.Add(Me.lblConcertDate)
        Me.gpBox1.Controls.Add(Me.lblConcertName)
        Me.gpBox1.Controls.Add(Me.btnInsert)
        Me.gpBox1.Controls.Add(Me.txtConcertName)
        Me.gpBox1.Controls.Add(Me.txtConcertDate)
        Me.gpBox1.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpBox1.ForeColor = System.Drawing.Color.Black
        Me.gpBox1.Location = New System.Drawing.Point(51, 58)
        Me.gpBox1.Name = "gpBox1"
        Me.gpBox1.Size = New System.Drawing.Size(479, 509)
        Me.gpBox1.TabIndex = 5
        Me.gpBox1.TabStop = False
        Me.gpBox1.Text = "Insert and Remove Concert"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(-4, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "---------------------------------------------------------------------------"
        '
        'txtConcertID
        '
        Me.txtConcertID.Location = New System.Drawing.Point(183, 384)
        Me.txtConcertID.Name = "txtConcertID"
        Me.txtConcertID.Size = New System.Drawing.Size(241, 28)
        Me.txtConcertID.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(68, 389)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(110, 20)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "Concert ID:"
        '
        'lblPoster
        '
        Me.lblPoster.AutoSize = True
        Me.lblPoster.Location = New System.Drawing.Point(42, 201)
        Me.lblPoster.Name = "lblPoster"
        Me.lblPoster.Size = New System.Drawing.Size(141, 20)
        Me.lblPoster.TabIndex = 16
        Me.lblPoster.Text = "Concert Poster:"
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Location = New System.Drawing.Point(41, 95)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(143, 20)
        Me.lblLoc.TabIndex = 15
        Me.lblLoc.Text = "Concert Venue:"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(207, 93)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(241, 28)
        Me.txtLoc.TabIndex = 14
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(343, 234)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(81, 27)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "Browse Poster"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(149, 452)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(130, 40)
        Me.btnRemove.TabIndex = 8
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'picPreview
        '
        Me.picPreview.Location = New System.Drawing.Point(183, 201)
        Me.picPreview.Name = "picPreview"
        Me.picPreview.Size = New System.Drawing.Size(138, 84)
        Me.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPreview.TabIndex = 12
        Me.picPreview.TabStop = False
        '
        'lblConcertDate
        '
        Me.lblConcertDate.AutoSize = True
        Me.lblConcertDate.Location = New System.Drawing.Point(0, 147)
        Me.lblConcertDate.Name = "lblConcertDate"
        Me.lblConcertDate.Size = New System.Drawing.Size(183, 20)
        Me.lblConcertDate.TabIndex = 7
        Me.lblConcertDate.Text = "Concert Date/ Time:"
        '
        'lblConcertName
        '
        Me.lblConcertName.AutoSize = True
        Me.lblConcertName.Location = New System.Drawing.Point(43, 42)
        Me.lblConcertName.Name = "lblConcertName"
        Me.lblConcertName.Size = New System.Drawing.Size(137, 20)
        Me.lblConcertName.TabIndex = 5
        Me.lblConcertName.Text = "Concert Name:"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Britannic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.Location = New System.Drawing.Point(-6, 2)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(254, 37)
        Me.lblLogo.TabIndex = 6
        Me.lblLogo.Text = "🎶BookLa Ticket"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 606)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 35)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(547, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(571, 256)
        Me.DataGridView1.TabIndex = 10
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoad.Location = New System.Drawing.Point(725, 537)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLoad.Size = New System.Drawing.Size(178, 30)
        Me.btnLoad.TabIndex = 11
        Me.btnLoad.Text = "Refresh Table Receipt"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnremoveR
        '
        Me.btnremoveR.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnremoveR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnremoveR.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremoveR.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnremoveR.Location = New System.Drawing.Point(660, 450)
        Me.btnremoveR.Name = "btnremoveR"
        Me.btnremoveR.Size = New System.Drawing.Size(300, 38)
        Me.btnremoveR.TabIndex = 12
        Me.btnremoveR.Text = "Remove Completed Receipt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnremoveR.UseVisualStyleBackColor = False
        '
        'lblReceiptID
        '
        Me.lblReceiptID.AutoSize = True
        Me.lblReceiptID.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptID.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptID.Location = New System.Drawing.Point(626, 412)
        Me.lblReceiptID.Name = "lblReceiptID"
        Me.lblReceiptID.Size = New System.Drawing.Size(205, 20)
        Me.lblReceiptID.TabIndex = 13
        Me.lblReceiptID.Text = "Remove by ReceiptID:"
        '
        'txtRemoveT
        '
        Me.txtRemoveT.Location = New System.Drawing.Point(855, 412)
        Me.txtRemoveT.Name = "txtRemoveT"
        Me.txtRemoveT.Size = New System.Drawing.Size(105, 22)
        Me.txtRemoveT.TabIndex = 14
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 653)
        Me.Controls.Add(Me.txtRemoveT)
        Me.Controls.Add(Me.lblReceiptID)
        Me.Controls.Add(Me.btnremoveR)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.gpBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.gpBox1.ResumeLayout(False)
        Me.gpBox1.PerformLayout()
        CType(Me.picPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents txtConcertName As TextBox
    Friend WithEvents txtConcertDate As TextBox
    Friend WithEvents gpBox1 As GroupBox
    Friend WithEvents lblConcertName As Label
    Friend WithEvents lblConcertDate As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents txtLoc As TextBox
    Friend WithEvents lblPoster As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtConcertID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnremoveR As Button
    Friend WithEvents lblReceiptID As Label
    Friend WithEvents txtRemoveT As TextBox
    Friend WithEvents Label1 As Label
End Class
