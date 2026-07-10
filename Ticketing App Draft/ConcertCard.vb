Public Class ConcertCard
    Public VIP_Price As String
    Public Prem_Price As String
    Public Std_Price As String

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles MyBase.Click, pbPoster.Click, lblName.Click, lblDate.Click
        Dim f As New BookTicket

        f.SelectedArtist = Me.lblName.Text
        f.ConcertDate = Me.lblDate.Text
        f.ConcertLocation = Me.lblLocation.Text ' Pastikan lblLocation wujud
        f.PosterImage = Me.pbPoster.Image
        f.VIP_P = Me.VIP_Price
        f.Prem_P = Me.Prem_Price
        f.Std_P = Me.Std_Price

        f.ShowDialog()
    End Sub


End Class
