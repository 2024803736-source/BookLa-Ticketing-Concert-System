```markdown
# BookLa Ticketing Concert System 🎟️

## 📌 Overview
A VB.NET Windows Form application for concert ticket booking.  
Built as part of CSC301 Visual Programming coursework.

## 🚀 Features & Critical Logic

### 🔐 Secure Admin Login (SQL Parameter Mapping)
* Prevents SQL injection by parameterizing user inputs into localized strings during state check validation.
vb
Dim cmd As New MySqlCommand("SELECT * FROM Admin WHERE Email=@email AND Password=@password", con)
cmd.Parameters.AddWithValue("@email", email)
cmd.Parameters.AddWithValue("@password", password)
Dim reader As MySqlDataReader = cmd.ExecuteReader()
If reader.HasRows Then Admin.Show() Else MessageBox.Show("Access Denied")


### 📋 CRUD Operations for Concert List

* Parses string-based inputs dynamically into standard MySQL DateTime strings before committing table database mutations.

vb
If DateTime.TryParse(txtConcertDate.Text, parsedDate) Then
    Dim Query As String = "INSERT INTO concertlist (ConcertName, ConcertDateTime) VALUES (@name, @date)"
    Dim cmd As New MySqlCommand(Query, con)
    cmd.Parameters.AddWithValue("@date", parsedDate.ToString("yyyy-MM-dd HH:mm:ss"))
    cmd.ExecuteNonQuery()
End If


### ⚡ Dynamic Event Feed Layout (`ListOfConcert.vb`)

* Purges the flow layout container control module on screen activation to strictly prevent duplicate visual row overlapping.

vb
flpConcerts.Controls.Clear()
ConcertData.SetupDataTable()
For Each row As DataRow In ConcertData.AllConcerts.Rows
    AddManualConcert(row("ConcertName").ToString(), "888", "588", "388", row("Date/Time").ToString(), row("Location").ToString(), img)
Next



### 🔗 Multi-Form State Forwarding (`ConcertCard.vb`)

* Captures user-triggered click states across child components, explicitly cloning runtime variables safely into the next dialog interface box.

vb
Dim f As New BookTicket
f.SelectedArtist = Me.lblName.Text
f.ConcertDate = Me.lblDate.Text
f.PosterImage = Me.pbPoster.Image
f.ShowDialog()


### 📊 Pricing Pipeline & Seat Allocation (`BuyTicket.vb`)

* Runs explicit casting calculations with a hardcoded 6% tax rate multiplier while building sequential alpha-numeric seat strings.

vb
Dim subtotal As Integer = qty * price
Dim tax As Double = subtotal * 0.06
Dim totalAll As Double = subtotal + tax

For i As Integer = 1 To qty
    If SelectedTier = "VIP" Then seats.Add("V" & (233 + i))
Next



### 💾 Database Persistence & Receipt Generation (`Receipt.vb`)

* Compresses localized string arrays into character-separated values to log transactional items safely within single database rows.

vb
Dim seatText As String = String.Join(",", SeatNumbers)
Dim query As String = "INSERT INTO receipt (OrderID, SeatNumber, TotalPrice) VALUES (@orderID, @seats, @total)"
Using cmd As New MySqlCommand(query, con)
    cmd.Parameters.AddWithValue("@seats", seatText)
    cmd.Parameters.AddWithValue("@total", TotalAll)
    cmd.ExecuteNonQuery()
End Using



## 🛠️ Tech Stack

* VB.NET (Visual Studio 2017)
* MySQL Database Engine & Workbench

## ▶️ How to Run

1. Clone this repository.
2. Open `Ticketing App Draft.sln` in Visual Studio.
3. Build and run the project.
4. Use Admin login to manage concerts.

## 📸 Screenshots

### Main Form

![Main Form](screenshot/mainform.png)



### Admin Form

![Admin Form](screenshot/adminform.png)



### Concert List

![Concerts](screenshot/concertsform.png)



### Book Ticket

![Book Ticket](screenshot/bookticket.png)



### Buy Ticket

![Buy Ticket](screenshot/buyticket.png)



### Receipt

![Receipt](screenshot/receipt.png)

## 👩‍💻 My Role & Leadership Reflection (STAR)

* **Designed database ERD & login system**
* **Implemented CRUD pipeline for concerts**
* **Built dynamic seat allocation & pricing logic**
* **Integrated receipt saving into MySQL**
* **Situation:** As Team Leader, I aimed to design an interface inspired by platforms like **GoLive**, showcasing preset default concerts alongside live, upcoming items added dynamically by system admins.
* **Task:** The core challenge was synchronizing image, time, and date parameters seamlessly. Databases store raw text strings and binary images, causing layout misalignments or failed interface updates on the user's view in real-time.
* **Action:** I constructed a global memory container using an image-typed `DataTable`. I then decoupled the population rendering loop into the screen’s `Activated` lifecycle state instead of standard form `Load`, adding a strict `.Controls.Clear()` call to wipe overlapping elements.
* **Result:** This unified the admin panel data with the customer layout perfectly. Images, pricing tiers, and schedules update across forms in real-time without causing rendering bugs or requiring an application restart.



*Designed and Built by Siti Maisarah & Team © CSC301 Visual Programming Project Showcase*



