# BookLa Ticketing Concert System 🎟️



## 📌 Overview

A VB.NET Windows Form application for concert ticket booking.  

Built as part of CSC301 Visual Programming coursework.



## 🚀 Features

- Secure Admin Login (SQL parameter mapping)

- CRUD operations for concert list

- Dynamic event feed layout

- Multi-form ticket booking

- Pricing pipeline with tax

- Database persistence & receipt generation



## 🛠️ Tech Stack

- VB.NET (Visual Studio 2017)

- MySQL Database



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





## 👩‍💻 My Role

- Designed database ERD & login system

- Implemented CRUD pipeline for concerts

- Built dynamic seat allocation & pricing logic

- Integrated receipt saving into MySQL

- Situation: As Team Leader, I aimed to design an interface inspired by platforms like GoLive, showcasing preset default concerts alongside live, upcoming items added dynamically by system admins.

- Task: The core challenge was synchronizing image, time, and date parameters seamlessly. Databases store raw text strings and binary images, causing layout misalignments or failed interface updates on the user's view in real-time.

- Action: I constructed a global memory container using an image-typed DataTable. I then decoupled the population rendering loop into the screen’s Activated lifecycle state instead of standard form Load, adding a strict .Controls.Clear() call to wipe overlapping elements.
    - CRUD Operations for Concert List
        Parses string-based inputs dynamically into standard MySQL DateTime strings before committing table database mutations.
        VB.Net
            If DateTime.TryParse(txtConcertDate.Text, parsedDate) Then
                Dim Query As String = "INSERT INTO concertlist (ConcertName, ConcertDateTime) VALUES (@name, @date)"
                Dim cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@date", parsedDate.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End If

- Result: This unified the admin panel data with the customer layout perfectly. Images, pricing tiers, and schedules update across forms in real-time without causing rendering bugs or requiring an application restart.