Imports MySql.Data.MySqlClient

Public Class Receipt
    ' MYSQL database connection
    Dim con As New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")

    ' Data passed from BuyTicket form
    Public SelectedArtist As String
    Public ConcertDate As String
    Public ConcertLocation As String
    Public PosterImage As Image
    Public SelectedTier As String
    Public Quantity As Integer
    Public UnitPrice As Integer
    Public Subtotal As Double
    Public Tax As Double
    Public TotalAll As Double
    Public SeatNumbers As List(Of String)

    'Function to calculate tax (returns a value)
    Public Function CalculateTax(subtotal As Double) As Double
        Return subtotal * 0.06
    End Function

    'Function to calculate total (returns a value)
    Public Function CalculateTotal(subtotal As Double) As Double
        Dim taxAmount As Double = CalculateTax(subtotal)
        Return subtotal + taxAmount
    End Function

    ' Receipt form load event
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display concert information
        lblConcertName.Text = SelectedArtist
        lblConcertDate.Text = ConcertDate
        lblConcertLocation.Text = ConcertLocation
        pbPoster.Image = PosterImage
        pbPoster.SizeMode = PictureBoxSizeMode.StretchImage
        pbPoster.BackColor = Color.Transparent

        ' Display purchase information
        lblTier.Text = SelectedTier
        lblQuantity.Text = Quantity.ToString()
        lblUnitPrice.Text = " RM " & UnitPrice.ToString()

        'Use Functions here
        Tax = CalculateTax(Subtotal)
        TotalAll = CalculateTotal(Subtotal)

        lblSubtotal.Text = "RM " & Subtotal.ToString("F2")
        lblTax.Text = "RM " & Tax.ToString("F2")
        lblTotal.Text = "RM " & TotalAll.ToString("F2")

        ' Display seat numbers ( one seat per line)
        Dim seatText As String = ""
        For i As Integer = 0 To SeatNumbers.Count - 1
            seatText &= "Seat Number " & (i + 1).ToString() & ": " & SeatNumbers(i) & vbCrLf
        Next
        lblSeats.Text = seatText

        ' Auto generate Customer ID
        Dim custBase As Integer = 1000
        Dim custID As String = "CUST" & (custBase + New Random().Next(1, 999)).ToString()
        lblCustomerId.Text = custID

        ' Display purchase date and time
        lblPurchaseDate.Text = "Purchased on: " & DateTime.Now.ToString("dd MMMM yyyy, hh:mm tt")
    End Sub

    ' Save receipt information into MYSQL database
    Private Sub SaveReceiptToDatabase()
        Try
            Using con As New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
                con.Open()

                ' Combine seat numbers into a single string
                Dim seatText As String = String.Join(",", SeatNumbers)

                ' Insert query based on receipt table structure
                Dim query As String = "INSERT INTO receipt (OrderID, BuyTime, ConcertName, Tier, Quantity, SeatNumber, UnitPrice, Subtotal, Tax, TotalPrice) " &
                                  "VALUES (@orderID, @buyTime, @concertName, @tier, @qty, @seats, @unitPrice, @subtotal, @tax, @total)"

                Using cmd As New MySqlCommand(query, con)
                    ' Assign parameter values
                    cmd.Parameters.AddWithValue("@orderID", lblCustomerId.Text)
                    cmd.Parameters.AddWithValue("@buyTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@concertName", SelectedArtist)
                    cmd.Parameters.AddWithValue("@tier", SelectedTier)
                    cmd.Parameters.AddWithValue("@qty", Quantity)
                    cmd.Parameters.AddWithValue("@seats", seatText)
                    cmd.Parameters.AddWithValue("@unitPrice", UnitPrice)
                    cmd.Parameters.AddWithValue("@subtotal", Subtotal)
                    cmd.Parameters.AddWithValue("@tax", Tax)
                    cmd.Parameters.AddWithValue("@total", TotalAll)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Receipt saved to database.")
        Catch ex As Exception
            MessageBox.Show("Error saving receipt: " & ex.Message)
        End Try
    End Sub

    ' Close button to save receipt and close form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        SaveReceiptToDatabase()
        Me.Close()
    End Sub

End Class
