Public Class BookTicket

    ' Data received from the previous form
    Public SelectedArtist As String
    Public VIP_P As String
    Public Prem_P As String
    Public Std_P As String
    Public ConcertDate As String
    Public ConcertLocation As String
    Public PosterImage As Image
    Public PreviousForm As Form

    ' Load concert details and reset selections
    Private Sub BookTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = SelectedArtist
        lblDate.Text = ConcertDate
        lblLocation.Text = ConcertLocation
        pbPoster.Image = PosterImage

        pbPoster.SizeMode = PictureBoxSizeMode.StretchImage
        pbPoster.BackColor = Color.Transparent

        lblPriceDisplay.Text = "Select a seating tier"

        ' Reset all seating selections
        rdVIP.Checked = False
        rdPremium.Checked = False
        rdStandardA.Checked = False
        rdStandardB.Checked = False
        rdStandardC.Checked = False
    End Sub

    ' Display VIP price when selected
    Private Sub rdVIP_CheckedChanged(sender As Object, e As EventArgs) Handles rdVIP.CheckedChanged
        If rdVIP.Checked Then lblPriceDisplay.Text = "RM " & VIP_P
    End Sub

    ' Display Premium price when selected
    Private Sub rdPremium_CheckedChanged(sender As Object, e As EventArgs) Handles rdPremium.CheckedChanged
        If rdPremium.Checked Then lblPriceDisplay.Text = "RM " & Prem_P
    End Sub

    ' Display Standard price when any standard section is selected
    Private Sub rdStandard_CheckedChanged(sender As Object, e As EventArgs) Handles rdStandardA.CheckedChanged, rdStandardB.CheckedChanged, rdStandardC.CheckedChanged
        If rdStandardA.Checked Or rdStandardB.Checked Or rdStandardC.Checked Then
            lblPriceDisplay.Text = "RM " & Std_P
        End If
    End Sub

    ' Confirm ticket selection and proceed to purchase
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        ' Ensure at least one seating tier is selected
        If Not rdVIP.Checked AndAlso Not rdPremium.Checked AndAlso Not rdStandardA.Checked AndAlso Not rdStandardB.Checked AndAlso Not rdStandardC.Checked Then
            MessageBox.Show("Please select seating tier.")
            Exit Sub
        End If

        ' Pass selected data to BuyTicket form
        Dim f As New BuyTicket With {
            .SelectedArtist = SelectedArtist,
            .ConcertDate = ConcertDate,
            .ConcertLocation = ConcertLocation,
            .PosterImage = PosterImage,
            .VIP_Price = CInt(VIP_P),
            .Prem_Price = CInt(Prem_P),
            .Std_Price = CInt(Std_P),
            .PreviousForm = Me
        }

        ' Determine selected tier and standard section
        If rdVIP.Checked Then
            f.SelectedTier = "VIP"
        ElseIf rdPremium.Checked Then
            f.SelectedTier = "Premium"
        ElseIf rdStandardA.Checked Then
            f.SelectedTier = "Standard"
            f.SelectedStandardSection = "A"
        ElseIf rdStandardB.Checked Then
            f.SelectedTier = "Standard"
            f.SelectedStandardSection = "B"
        ElseIf rdStandardC.Checked Then
            f.SelectedTier = "Standard"
            f.SelectedStandardSection = "C"
        End If

        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    ' Return to the previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If PreviousForm IsNot Nothing Then
            PreviousForm.Show()
        End If
        Me.Close()
    End Sub
End Class
