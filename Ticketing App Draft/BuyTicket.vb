Public Class BuyTicket
    ' Data received from BookTicket form
    Public SelectedArtist As String
    Public ConcertDate As String
    Public ConcertLocation As String
    Public PosterImage As Image
    Public VIP_Price As Integer
    Public Prem_Price As Integer
    Public Std_Price As Integer
    Public SelectedTier As String
    Public SelectedStandardSection As String
    Public PreviousForm As Form

    ' Ticket quantity
    Dim vipQty As Integer = 0
    Dim premQty As Integer = 0
    Dim stdQty As Integer = 0

    ' Load selected concert details and initialize values
    Private Sub BuyTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = SelectedArtist
        lblDate.Text = ConcertDate
        lblLocation.Text = ConcertLocation
        pbPoster.Image = PosterImage
        pbPoster.SizeMode = PictureBoxSizeMode.StretchImage
        pbPoster.BackColor = Color.Transparent

        ' Set initial quantity based on selected ticket tier
        If SelectedTier = "VIP" Then
            vipQty = 1 : lblVQty.Text = vipQty.ToString()
        Else : lblVQty.Text = "0"
        End If

        If SelectedTier = "Premium" Then
            premQty = 1 : lblPQty.Text = premQty.ToString()
        Else : lblPQty.Text = "0"
        End If

        If SelectedTier = "Standard" Then
            stdQty = 1 : lblSQty.Text = stdQty.ToString()
        Else : lblSQty.Text = "0"
        End If

        ' Enable quantity buttons based on selected tier
        btnVIPPlus.Enabled = (SelectedTier = "VIP")
        btnVIPMinus.Enabled = (SelectedTier = "VIP")
        btnPremPlus.Enabled = (SelectedTier = "Premium")
        btnPremMinus.Enabled = (SelectedTier = "Premium")
        btnStdPlus.Enabled = (SelectedTier = "Standard")
        btnStdMinus.Enabled = (SelectedTier = "Standard")

        UpdateTotals()
    End Sub

    ' VIP quantity controls
    Private Sub btnVIPPlus_Click(sender As Object, e As EventArgs) Handles btnVIPPlus.Click
        vipQty += 1
        lblVQty.Text = vipQty.ToString()
        UpdateTotals()
    End Sub

    Private Sub btnVIPMinus_Click(sender As Object, e As EventArgs) Handles btnVIPMinus.Click
        If vipQty > 1 Then
            vipQty -= 1
            lblVQty.Text = vipQty.ToString()
            UpdateTotals()
        End If
    End Sub

    ' Premium quantity controls
    Private Sub btnPremPlus_Click(sender As Object, e As EventArgs) Handles btnPremPlus.Click
        premQty += 1
        lblPQty.Text = premQty.ToString()
        UpdateTotals()
    End Sub

    Private Sub btnPremMinus_Click(sender As Object, e As EventArgs) Handles btnPremMinus.Click
        If premQty > 1 Then
            premQty -= 1
            lblPQty.Text = premQty.ToString()
            UpdateTotals()
        End If
    End Sub

    ' Standard quantity controls
    Private Sub btnStdPlus_Click(sender As Object, e As EventArgs) Handles btnStdPlus.Click
        stdQty += 1
        lblSQty.Text = stdQty.ToString()
        UpdateTotals()
    End Sub

    Private Sub btnStdMinus_Click(sender As Object, e As EventArgs) Handles btnStdMinus.Click
        If stdQty > 1 Then
            stdQty -= 1
            lblSQty.Text = stdQty.ToString()
            UpdateTotals()
        End If
    End Sub

    ' Calculate and update price totals
    Private Sub UpdateTotals()
        Dim qty As Integer = 0
        Dim price As Integer = 0

        If SelectedTier = "VIP" Then
            qty = vipQty : price = VIP_Price
        ElseIf SelectedTier = "Premium" Then
            qty = premQty : price = Prem_Price
        ElseIf SelectedTier = "Standard" Then
            qty = stdQty : price = Std_Price
        End If

        Dim subtotal As Integer = qty * price
        Dim tax As Double = subtotal * 0.06
        Dim totalAll As Double = subtotal + tax

        lblSubtotal.Text = qty & " x " & price
        lblSubtotalAmount.Text = "RM " & subtotal.ToString("F2")
        lblTax.Text = "RM " & tax.ToString("F2")
        lblTotalAll.Text = "RM " & totalAll.ToString("F2")
    End Sub

    ' Proceed to payment and generate receipt
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim qty As Integer = 0
        Dim price As Integer = 0

        If SelectedTier = "VIP" Then qty = vipQty : price = VIP_Price
        If SelectedTier = "Premium" Then qty = premQty : price = Prem_Price
        If SelectedTier = "Standard" Then qty = stdQty : price = Std_Price

        If qty = 0 Then
            MessageBox.Show("Please select at least one ticket.")
            Exit Sub
        End If

        Dim subtotal As Integer = qty * price
        Dim tax As Double = subtotal * 0.06
        Dim totalAll As Double = subtotal + tax

        ' Generate seat numbers based on tier and section
        Dim seats As New List(Of String)
        For i As Integer = 1 To qty
            If SelectedTier = "VIP" Then
                seats.Add("V" & (233 + i))
            ElseIf SelectedTier = "Premium" Then
                seats.Add("P" & (92 + i))
            ElseIf SelectedTier = "Standard" Then
                Dim prefix As String = SelectedStandardSection
                Dim base As Integer = If(prefix = "A", 12, If(prefix = "B", 45, 78))
                seats.Add(prefix & (base + i))
            End If
        Next

        ' Open receipt form
        Dim r As New Receipt With {
            .SelectedArtist = SelectedArtist,
            .ConcertDate = ConcertDate,
            .ConcertLocation = ConcertLocation,
            .PosterImage = PosterImage,
            .SelectedTier = SelectedTier,
            .Quantity = qty,
            .UnitPrice = price,
            .Subtotal = subtotal,
            .Tax = tax,
            .TotalAll = totalAll,
            .SeatNumbers = seats
        }

        Me.Hide()
        r.ShowDialog()
        Me.Show()
    End Sub

    ' Return to previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm IsNot Nothing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub


End Class
