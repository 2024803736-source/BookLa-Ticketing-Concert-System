Imports MySql.Data.MySqlClient


Public Class Admin

    ' MySQL database connection
    Dim con As New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")

    ' Command used for admin login validation
    Dim cmd As New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)

    ' Load receipt data into DataGridView
    Private Sub LoadReceiptTable()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            con.Open()
            ' Query to retrieve all receipt records
            Dim Query As String = "SELECT * FROM booklaticketvb.receipt"
            Dim cmd As New MySqlCommand(Query, con)

            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)

            ' Bind data to DataGridView
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Form load event
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReceiptTable() ' Default display is Receipt table

        ' Setup AllConcerts table if not initialized
        If AllConcerts.Columns.Count = 0 Then
            SetupDataTable()
        End If

    End Sub

    ' Browse button to select concert image
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        con = New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
        cmd = New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)
        Dim opn As New OpenFileDialog
        opn.Filter = "Images (*.jpg;*.png)|*.jpg;*.png"

        ' Load selected image into picture box
        If opn.ShowDialog = DialogResult.OK Then
            picPreview.Image = Image.FromFile(opn.FileName)
        End If
    End Sub

    ' Back button to return to main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub

    ' Insert new concert data
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        con = New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
        cmd = New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)
        Dim inputDate As String = txtConcertDate.Text
        Dim parsedDate As DateTime

        ' Try to parse data or time flexibly
        If DateTime.TryParse(inputDate, parsedDate) Then
            Try
                ' 1. Insert into MySQL database (ConcertID auto increment)
                con.Open()
                Dim Query As String = "INSERT INTO concertlist (ConcertName, ConcertDateTime, ConcertVenue) VALUES (@name, @date, @venue)"
                Dim cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@name", txtConcertName.Text)
                cmd.Parameters.AddWithValue("@date", parsedDate.ToString("yyyy-MM-dd HH:mm:ss")) ' Format standard untuk MySQL
                cmd.Parameters.AddWithValue("@venue", txtLoc.Text)
                cmd.ExecuteNonQuery()
                con.Close()

                ' 2. Insert into AllConcerts  DataTable (formatted nicely for UI display)

                AllConcerts.Rows.Add(txtConcertName.Text, parsedDate.ToString("d MMM yyyy, h:mm tt"), txtLoc.Text, picPreview.Image)


                MessageBox.Show("Concert added successfully!")

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("Unrecognized date/time format. Example: 21 Feb 2026 9:00 PM")
        End If
    End Sub


    ' Remove concert by ConcertID
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        con = New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
        cmd = New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)

        Dim READER As MySqlDataReader

        Try
            con.Open()
            'Delete concert record from database
            Dim Query As String
            Query = "delete from booklaticketvb.concertlist where ConcertID = '" & txtConcertID.Text & "'"
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            Dim count As Integer

            MessageBox.Show("Concert Data, Deleted!")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose() 'ready to use for another process
        End Try
    End Sub

    ' Button to remove receipt by ReceiptID
    Private Sub btnremoveR_Click(sender As Object, e As EventArgs) Handles btnremoveR.Click
        con = New MySqlConnection("server=localhost;user id=mai;password=mai;database=BookLaTicketvb")
        cmd = New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)

        Dim READER As MySqlDataReader

        Try
            con.Open()
            'Delete receipt record
            Dim Query As String = "DELETE FROM booklaticketvb.receipt WHERE ReceiptID = '" & txtRemoveT.Text & "'"
            cmd = New MySqlCommand(Query, con)
            READER = cmd.ExecuteReader
            Dim count As Integer

            MessageBox.Show("Concert Data, Deleted!")
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    'Reload receipt table
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadReceiptTable()
    End Sub


End Class