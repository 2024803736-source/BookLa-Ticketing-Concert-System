<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuyTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuyTicket))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblSQty = New System.Windows.Forms.Label()
        Me.lblPQty = New System.Windows.Forms.Label()
        Me.lblVQty = New System.Windows.Forms.Label()
        Me.btnStdPlus = New System.Windows.Forms.Button()
        Me.btnStdMinus = New System.Windows.Forms.Button()
        Me.btnPremPlus = New System.Windows.Forms.Button()
        Me.btnPremMinus = New System.Windows.Forms.Button()
        Me.btnVIPPlus = New System.Windows.Forms.Button()
        Me.btnVIPMinus = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblBuy = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalAll = New System.Windows.Forms.Label()
        Me.lblSubtotalAmount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblLogo = New System.Windows.Forms.Label()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblName.Location = New System.Drawing.Point(63, 153)
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
        Me.lblDate.Location = New System.Drawing.Point(60, 470)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(177, 20)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Concert Date/ Time"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblS.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.Color.Black
        Me.lblS.Location = New System.Drawing.Point(481, 116)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(164, 25)
        Me.lblS.TabIndex = 4
        Me.lblS.Text = "STANDARD :"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.BackColor = System.Drawing.Color.Transparent
        Me.lblP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblP.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.ForeColor = System.Drawing.Color.Black
        Me.lblP.Location = New System.Drawing.Point(493, 207)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(152, 25)
        Me.lblP.TabIndex = 5
        Me.lblP.Text = "PREMIUM : "
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.BackColor = System.Drawing.Color.Transparent
        Me.lblV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblV.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.ForeColor = System.Drawing.Color.Black
        Me.lblV.Location = New System.Drawing.Point(563, 304)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(68, 25)
        Me.lblV.TabIndex = 6
        Me.lblV.Text = "VIP :"
        '
        'lblSQty
        '
        Me.lblSQty.AutoSize = True
        Me.lblSQty.BackColor = System.Drawing.Color.Transparent
        Me.lblSQty.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSQty.ForeColor = System.Drawing.Color.Black
        Me.lblSQty.Location = New System.Drawing.Point(798, 119)
        Me.lblSQty.Name = "lblSQty"
        Me.lblSQty.Size = New System.Drawing.Size(25, 25)
        Me.lblSQty.TabIndex = 10
        Me.lblSQty.Text = "0"
        '
        'lblPQty
        '
        Me.lblPQty.AutoSize = True
        Me.lblPQty.BackColor = System.Drawing.Color.Transparent
        Me.lblPQty.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPQty.ForeColor = System.Drawing.Color.Black
        Me.lblPQty.Location = New System.Drawing.Point(798, 207)
        Me.lblPQty.Name = "lblPQty"
        Me.lblPQty.Size = New System.Drawing.Size(25, 25)
        Me.lblPQty.TabIndex = 11
        Me.lblPQty.Text = "0"
        '
        'lblVQty
        '
        Me.lblVQty.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.lblVQty.AutoSize = True
        Me.lblVQty.BackColor = System.Drawing.Color.Transparent
        Me.lblVQty.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVQty.ForeColor = System.Drawing.Color.Black
        Me.lblVQty.Location = New System.Drawing.Point(798, 296)
        Me.lblVQty.Name = "lblVQty"
        Me.lblVQty.Size = New System.Drawing.Size(25, 25)
        Me.lblVQty.TabIndex = 12
        Me.lblVQty.Text = "0"
        '
        'btnStdPlus
        '
        Me.btnStdPlus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnStdPlus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdPlus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStdPlus.Location = New System.Drawing.Point(868, 109)
        Me.btnStdPlus.Name = "btnStdPlus"
        Me.btnStdPlus.Size = New System.Drawing.Size(50, 40)
        Me.btnStdPlus.TabIndex = 13
        Me.btnStdPlus.Text = "+"
        Me.btnStdPlus.UseVisualStyleBackColor = False
        '
        'btnStdMinus
        '
        Me.btnStdMinus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnStdMinus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStdMinus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStdMinus.Location = New System.Drawing.Point(704, 109)
        Me.btnStdMinus.Name = "btnStdMinus"
        Me.btnStdMinus.Size = New System.Drawing.Size(50, 40)
        Me.btnStdMinus.TabIndex = 14
        Me.btnStdMinus.Text = "-"
        Me.btnStdMinus.UseVisualStyleBackColor = False
        '
        'btnPremPlus
        '
        Me.btnPremPlus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPremPlus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremPlus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPremPlus.Location = New System.Drawing.Point(868, 200)
        Me.btnPremPlus.Name = "btnPremPlus"
        Me.btnPremPlus.Size = New System.Drawing.Size(50, 40)
        Me.btnPremPlus.TabIndex = 15
        Me.btnPremPlus.Text = "+"
        Me.btnPremPlus.UseVisualStyleBackColor = False
        '
        'btnPremMinus
        '
        Me.btnPremMinus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnPremMinus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremMinus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPremMinus.Location = New System.Drawing.Point(704, 200)
        Me.btnPremMinus.Name = "btnPremMinus"
        Me.btnPremMinus.Size = New System.Drawing.Size(50, 40)
        Me.btnPremMinus.TabIndex = 16
        Me.btnPremMinus.Text = "-"
        Me.btnPremMinus.UseVisualStyleBackColor = False
        '
        'btnVIPPlus
        '
        Me.btnVIPPlus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnVIPPlus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIPPlus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnVIPPlus.Location = New System.Drawing.Point(868, 289)
        Me.btnVIPPlus.Name = "btnVIPPlus"
        Me.btnVIPPlus.Size = New System.Drawing.Size(50, 40)
        Me.btnVIPPlus.TabIndex = 17
        Me.btnVIPPlus.Text = "+"
        Me.btnVIPPlus.UseVisualStyleBackColor = False
        '
        'btnVIPMinus
        '
        Me.btnVIPMinus.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnVIPMinus.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIPMinus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnVIPMinus.Location = New System.Drawing.Point(704, 289)
        Me.btnVIPMinus.Name = "btnVIPMinus"
        Me.btnVIPMinus.Size = New System.Drawing.Size(50, 40)
        Me.btnVIPMinus.TabIndex = 18
        Me.btnVIPMinus.Text = "-"
        Me.btnVIPMinus.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPay.Location = New System.Drawing.Point(1015, 606)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(125, 35)
        Me.btnPay.TabIndex = 19
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'pbPoster
        '
        Me.pbPoster.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbPoster.Location = New System.Drawing.Point(64, 177)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(380, 270)
        Me.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPoster.TabIndex = 24
        Me.pbPoster.TabStop = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLocation.Location = New System.Drawing.Point(60, 450)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(137, 20)
        Me.lblLocation.TabIndex = 25
        Me.lblLocation.Text = "Concert Venue"
        '
        'lblBuy
        '
        Me.lblBuy.AutoSize = True
        Me.lblBuy.BackColor = System.Drawing.Color.Transparent
        Me.lblBuy.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuy.Location = New System.Drawing.Point(409, 9)
        Me.lblBuy.Name = "lblBuy"
        Me.lblBuy.Size = New System.Drawing.Size(437, 50)
        Me.lblBuy.TabIndex = 26
        Me.lblBuy.Text = "TICKET PAYMENT"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.Location = New System.Drawing.Point(24, 605)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 35)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(45, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "TAX (6%) :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TOTAL PRICE :"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSubtotal.Location = New System.Drawing.Point(197, 36)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(47, 20)
        Me.lblSubtotal.TabIndex = 20
        Me.lblSubtotal.Text = "RM "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(26, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "SUBTOTAL :"
        '
        'lblTotalAll
        '
        Me.lblTotalAll.AutoSize = True
        Me.lblTotalAll.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalAll.Location = New System.Drawing.Point(197, 190)
        Me.lblTotalAll.Name = "lblTotalAll"
        Me.lblTotalAll.Size = New System.Drawing.Size(41, 20)
        Me.lblTotalAll.TabIndex = 23
        Me.lblTotalAll.Text = "RM"
        '
        'lblSubtotalAmount
        '
        Me.lblSubtotalAmount.AutoSize = True
        Me.lblSubtotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtotalAmount.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotalAmount.ForeColor = System.Drawing.Color.Black
        Me.lblSubtotalAmount.Location = New System.Drawing.Point(197, 66)
        Me.lblSubtotalAmount.Name = "lblSubtotalAmount"
        Me.lblSubtotalAmount.Size = New System.Drawing.Size(41, 20)
        Me.lblSubtotalAmount.TabIndex = 24
        Me.lblSubtotalAmount.Text = "RM"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTax.Location = New System.Drawing.Point(197, 124)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(41, 20)
        Me.lblTax.TabIndex = 21
        Me.lblTax.Text = "RM"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblSubtotalAmount)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblTotalAll)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(486, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 219)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TICKET PRICE "
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Britannic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.Black
        Me.lblLogo.Location = New System.Drawing.Point(-2, -1)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(254, 37)
        Me.lblLogo.TabIndex = 28
        Me.lblLogo.Text = "🎶BookLa Ticket"
        '
        'BuyTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1152, 653)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblBuy)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.pbPoster)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnVIPMinus)
        Me.Controls.Add(Me.btnVIPPlus)
        Me.Controls.Add(Me.btnPremMinus)
        Me.Controls.Add(Me.btnPremPlus)
        Me.Controls.Add(Me.btnStdMinus)
        Me.Controls.Add(Me.btnStdPlus)
        Me.Controls.Add(Me.lblVQty)
        Me.Controls.Add(Me.lblPQty)
        Me.Controls.Add(Me.lblSQty)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblName)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BuyTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuyTicket"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblP As Label
    Friend WithEvents lblV As Label
    Friend WithEvents lblSQty As Label
    Friend WithEvents lblPQty As Label
    Friend WithEvents lblVQty As Label
    Friend WithEvents btnStdPlus As Button
    Friend WithEvents btnStdMinus As Button
    Friend WithEvents btnPremPlus As Button
    Friend WithEvents btnPremMinus As Button
    Friend WithEvents btnVIPPlus As Button
    Friend WithEvents btnVIPMinus As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents pbPoster As PictureBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblBuy As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalAll As Label
    Friend WithEvents lblSubtotalAmount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLogo As Label
End Class
