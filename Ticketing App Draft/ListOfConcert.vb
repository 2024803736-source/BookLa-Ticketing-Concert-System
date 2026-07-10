Public Class ListOfConcert

    ' Use Activated event so the screen always updates when returning from tha Admin screen
    Private Sub ListOfConcert_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RefreshDisplay()
    End Sub

    ' Refresh and redraw all concert cards on the screen
    Public Sub RefreshDisplay()
        ' 1. Clear the panel to prevent cards from overlapping
        flpConcerts.Controls.Clear()

        ' 2. Ensure default concert data (Afgan, MCR, Treasure) has been inserted into the DataTable
        ConcertData.SetupDataTable()

        ' 3. Loop through each row in the DataTable from the Module
        For Each row As DataRow In ConcertData.AllConcerts.Rows
            ' Retrieve image directly from the "Poster" column
            Dim img As Image = Nothing
            If Not IsDBNull(row("Poster")) Then
                img = DirectCast(row("Poster"), Image)
            End If

            ' Call function to draw the concert card
            AddManualConcert(row("ConcertName").ToString(), "888", "588", "388", row("Date/Time").ToString(), row("Location").ToString(), img)
        Next
    End Sub

    ' Function AddManualConcert to manually create and add a concert card (Existing function retained)
    Public Sub AddManualConcert(name As String, vip As String, prem As String, std As String, concertDateText As String, loc As String, img As Image)
        Dim card As New ConcertCard()

        ' Set card size and layout
        card.Size = New Size(600, 90)
        card.lblName.AutoSize = False
        card.lblName.Width = 350

        'Assign concert details
        card.lblName.Text = name
        card.lblDate.Text = concertDateText
        card.lblLocation.Text = loc

        ' Assign ticket prices
        card.VIP_Price = vip
        card.Prem_Price = prem
        card.Std_Price = std

        ' Assign poster image
        card.pbPoster.Image = img
        card.pbPoster.SizeMode = PictureBoxSizeMode.Zoom

        ' Add card to FlowLayoutPanel
        flpConcerts.Controls.Add(card)
    End Sub

    ' Back button to return to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub


End Class