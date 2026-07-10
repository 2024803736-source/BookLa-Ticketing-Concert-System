Imports MySql.Data.MySqlClient

Public Class MainForm

    ' Connection string to the BookLaTicketvb database
    Dim con As New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")

    ' Button to open the concert list form
    Private Sub btnGetTicket_Click(sender As Object, e As EventArgs) Handles btnGetTicket.Click
        ListOfConcert.Show()
    End Sub

    ' Admin Panel access with email and password verification
    Private Sub AdminPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminPanelToolStripMenuItem.Click
        Dim email As String = InputBox("Enter Admin Email:", "Security Check")
        Dim password As String = InputBox("Enter Admin Password:", "Security Check")

        Try
            ' Create database connection and SQL command
            Dim con As New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
            Dim cmd As New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)

            ' Pass values safely using parameters
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)

            con.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if admin credentials exist
            If reader.HasRows Then
                MessageBox.Show("Login successful!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Admin.Show()
            Else
                MessageBox.Show("Incorrect email or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            con.Close()
        Catch ex As Exception
            ' Display database error if connection or query fails
            MessageBox.Show("Database error: " & ex.Message)
        End Try

    End Sub

    ' Message  shown when customer panel menu is clicked
    Private Sub CustomerPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerPanelToolStripMenuItem.Click
        MessageBox.Show("You are currently in the Customer Panel.")
    End Sub

    ' Display information about the company
    Private Sub lblAboutUs_Click(sender As Object, e As EventArgs) Handles lblAboutUs.Click
        MessageBox.Show("We provide the smoothest ticketing service with fast booking, secure payments, and real-time seat selection. Our mission is to make your concert experience effortless and enjoyable!" &
                        vbCrLf & vbCrLf & "Find out more at our social media:" & vbCrLf & "TikTok & Instagram: @BookLa_Ticket", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    '  Display customer service contact information
    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click
        MessageBox.Show("Customer Service Number: +60-123-456789" & vbCrLf & "Operating Hours: Mon-Fri, 9:00 AM - 6:00 PM" & vbCrLf & vbCrLf & "We’re here to make sure your concert night is unforgettable!", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Main form load event (optional database connection test)
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: test DB connection on load
        ' Try
        '     con.Open()
        '     con.Close()
        ' Catch ex As Exception
        '     MessageBox.Show("Database connection failed: " & ex.Message)
        ' End Try
    End Sub

End Class
