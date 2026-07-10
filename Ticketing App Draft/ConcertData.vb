Module ConcertData

    ' DataTable to store all concert information for display
    Public AllConcerts As New DataTable()

    ' Initialize the concert DataTable structure and default data
    Public Sub SetupDataTable()
        ' Only setup columns if they have not been added yet
        If AllConcerts.Columns.Count = 0 Then

            ' Define DataTable columns
            AllConcerts.Columns.Add("ConcertName")
            AllConcerts.Columns.Add("Date/Time")
            AllConcerts.Columns.Add("Location")
            AllConcerts.Columns.Add("Poster", GetType(Image)) ' Store image only

            ' Insert default concert data with date and time
            AllConcerts.Rows.Add("AFGAN: Retrospektif Showcase", "5th Jan 2026, 9:00 PM", "Idea Live Arena, Petaling Jaya", My.Resources.afgan_poster)
            AllConcerts.Rows.Add("My Chemical Romance: SEA 2026", "1st May 2026, 9:30 PM", "Axiata Arena, Kuala Lumpur", My.Resources.mcr_poster)
            AllConcerts.Rows.Add("TREASURE: Pulse On", "30th May 2026, 7:30 PM", "Axiata Arena, Kuala Lumpur", My.Resources.treasure_poster)
            AllConcerts.Rows.Add("Bryan Adams: Roll with the Punches", "6th Feb 2026, 9:00 PM", "Idea Live Arena, Petaling Jaya", My.Resources.bryanadams_poster)
        End If
    End Sub
End Module
