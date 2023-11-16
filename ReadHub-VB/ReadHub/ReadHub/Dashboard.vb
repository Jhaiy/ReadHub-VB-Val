Imports System.Windows.Documents
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim sqlQuery As String
    Dim Command As MySqlCommand
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        faculTable()
        stTable()
        bksTable()
        BorStudTab()
        BorEmpTab()

        ArcBKTab()
        UpdateProgressBar()
        UpdateProgressBar2()
        UpdateProgressBar3()
        UpdateProgressBar4()
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        dashPanel.BackColor = Color.FromArgb(61, 90, 128)
        dashButton.BackColor = Color.FromArgb(152, 193, 217)
        facultyTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        borrowedFacTab.BackgroundColor = Color.FromArgb(61, 90, 128)
        borrowedStudTab.BackgroundColor = Color.FromArgb(61, 90, 128)
        Label4.ForeColor = Color.FromArgb(255, 255, 255)
        booksTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        ArchiveBooksTable.BackgroundColor = Color.FromArgb(61, 90, 128)
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        Me.Hide()
        BookList.Show()
    End Sub

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        Me.Hide()
        Archives.Show()
    End Sub

    Private Sub userButton_Click(sender As Object, e As EventArgs) Handles userButton.Click
        Me.Hide()
        UserList.Show()
    End Sub
    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        Me.Hide()
        BorrowedBooks.Show()
    End Sub
    Private Sub stTable()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.student_information"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)

        Adapter.Fill(table)

        studentTable.DataSource = table
        con.Close()
    End Sub

    Private Sub faculTable()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.employee_information"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        facultyTable.DataSource = table
        con.Close()
    End Sub
    Private Sub bksTable()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.book_information"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        booksTable.DataSource = table
        con.Close()
    End Sub

    Private Sub BorStudTab()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.borrowed_books_student"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        borrowedStudTab.DataSource = table
        con.Close()
    End Sub
    Private Sub BorEmpTab()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.borrowed_books_employee"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        borrowedFacTab.DataSource = table
        con.Close()
    End Sub
    Private Sub ArcBKTab()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.archive_books"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        ArchiveBooksTable.DataSource = table
        con.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        con.Open()
        Dim Time = Date.Now.ToString("hh:mm:ss")
        Dim currDate = Date.Now.ToString("dd MMM yyyy")
        sqlQuery = "INSERT INTO admin_out(Email, Logout_Time, Logout_Date) values ('" & Login.TextBox1.Text & "'" & "," & "'" & Time & "'" & "," & "'" & currDate & "'" & ")"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        con.Close()
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub UpdateProgressBar()
        con.Open()

        ' Fetch the count and name of the most borrowed book from the database
        sqlQuery = "SELECT Book_ID, COUNT(Book_ID) AS BorrowedCount FROM readhub.borrowed_books_student GROUP BY Book_ID ORDER BY BorrowedCount DESC LIMIT 1"
        Command = New MySqlCommand(sqlQuery, con)

        ' Execute the query and read the result
        Dim reader As MySqlDataReader = Command.ExecuteReader()
        If reader.Read() Then
            ' Get the count and Book_ID from the result
            Dim mostBorrowedCount As Integer = Convert.ToInt32(reader("BorrowedCount"))
            Dim bookID As String = reader("Book_ID").ToString()

            ' Fetch the book title from the book_information table
            Dim bookTitle As String = GetBookTitle(bookID)

            ' Fetch the total count of all books
            Dim totalBooksCount As Integer = GetTotalBooksCount()

            ' Calculate the percentage
            Dim percentage As Integer = CInt((mostBorrowedCount / totalBooksCount) * 100)

            ' Update the label with book information
            Label8.Text = $"1. {bookTitle} - Borrowed Count: {mostBorrowedCount}"

            ' Update the progress bar with the percentage
            PB1.Value = percentage
        End If

        con.Close()
    End Sub

    Private Function GetBookTitle(bookID As String) As String
        ' Fetch the book title based on the Book_ID from the book_information table
        Dim bookTitleQuery As String = $"SELECT Title FROM readhub.book_information WHERE Book_ID = '{bookID}'"
        Using titleConnection As New MySqlConnection("Server = localhost;username=root;password=;database=readhub;")
            titleConnection.Open()

            Using titleCommand As New MySqlCommand(bookTitleQuery, titleConnection)
                ' Execute the query and read the result
                Dim titleReader As MySqlDataReader = titleCommand.ExecuteReader()

                If titleReader.Read() Then
                    Return titleReader("Title").ToString()
                End If
            End Using
        End Using

        Return "Unknown Title"
    End Function

    Private Function GetTotalBooksCount() As Integer
        ' Fetch the total count of all books from the database
        Dim totalBooksQuery As String = "SELECT COUNT(Book_ID) AS TotalCount FROM readhub.borrowed_books_student"
        Using totalBooksConnection As New MySqlConnection("Server = localhost;username=root;password=;database=readhub;") ' Replace with your connection string
            totalBooksConnection.Open()

            Using totalBooksCommand As New MySqlCommand(totalBooksQuery, totalBooksConnection)
                ' Execute the query and read the result
                Dim totalBooksReader As MySqlDataReader = totalBooksCommand.ExecuteReader()

                If totalBooksReader.Read() Then
                    Return Convert.ToInt32(totalBooksReader("TotalCount"))
                End If
            End Using
        End Using

        Return 0
    End Function
    Private Sub UpdateProgressBar2()
        con.Open()

        ' Fetch the second highest count and name of the borrowed book from the database
        sqlQuery = "SELECT Book_ID, COUNT(Book_ID) AS BorrowedCount FROM readhub.borrowed_books_student GROUP BY Book_ID ORDER BY BorrowedCount DESC LIMIT 1 OFFSET 1"
        Command = New MySqlCommand(sqlQuery, con)

        ' Execute the query and read the result
        Dim reader As MySqlDataReader = Command.ExecuteReader()
        If reader.Read() Then
            ' Get the count and Book_ID from the result
            Dim secondBorrowedCount As Integer = Convert.ToInt32(reader("BorrowedCount"))
            Dim bookID As String = reader("Book_ID").ToString()

            ' Fetch the book title from the book_information table
            Dim bookTitle As String = GetBookTitle(bookID)

            ' Fetch the total count of all books
            Dim totalBooksCount As Integer = GetTotalBooksCount()

            ' Calculate the percentage
            Dim percentage As Integer = CInt((secondBorrowedCount / totalBooksCount) * 100)

            ' Update the label with book information for the second highest
            Label9.Text = $"2. {bookTitle} - Borrowed Count: {secondBorrowedCount}"

            ' Update the progress bar with the percentage for the second highest
            PB2.Value = percentage
        End If

        con.Close()
    End Sub
    Private Sub UpdateProgressBar3()
        con.Open()

        ' Fetch the third highest count and name of the borrowed book from the database
        sqlQuery = "SELECT Book_ID, COUNT(Book_ID) AS BorrowedCount FROM readhub.borrowed_books_student GROUP BY Book_ID ORDER BY BorrowedCount DESC LIMIT 1 OFFSET 2"
        Command = New MySqlCommand(sqlQuery, con)

        ' Execute the query and read the result
        Dim reader As MySqlDataReader = Command.ExecuteReader()
        If reader.Read() Then
            ' Get the count and Book_ID from the result
            Dim thirdBorrowedCount As Integer = Convert.ToInt32(reader("BorrowedCount"))
            Dim bookID As String = reader("Book_ID").ToString()

            ' Fetch the book title from the book_information table
            Dim bookTitle As String = GetBookTitle(bookID)

            ' Fetch the total count of all books
            Dim totalBooksCount As Integer = GetTotalBooksCount()

            ' Calculate the percentage
            Dim percentage As Integer = CInt((thirdBorrowedCount / totalBooksCount) * 100)

            ' Update the label with book information for the third highest
            Label10.Text = $"3. {bookTitle} - Count: {thirdBorrowedCount}"

            ' Update the progress bar with the percentage for the third highest
            PB3.Value = percentage
        End If

        con.Close()
    End Sub
    Private Sub UpdateProgressBar4()
        con.Open()

        ' Fetch the fourth highest count and name of the borrowed book from the database
        sqlQuery = "SELECT Book_ID, COUNT(Book_ID) AS BorrowedCount FROM readhub.borrowed_books_student GROUP BY Book_ID ORDER BY BorrowedCount DESC LIMIT 1 OFFSET 3"
        Command = New MySqlCommand(sqlQuery, con)

        ' Execute the query and read the result
        Dim reader As MySqlDataReader = Command.ExecuteReader()
        If reader.Read() Then
            ' Get the count and Book_ID from the result
            Dim fourthBorrowedCount As Integer = Convert.ToInt32(reader("BorrowedCount"))
            Dim bookID As String = reader("Book_ID").ToString()

            ' Fetch the book title from the book_information table
            Dim bookTitle As String = GetBookTitle(bookID)

            ' Fetch the total count of all books
            Dim totalBooksCount As Integer = GetTotalBooksCount()

            ' Calculate the percentage
            Dim percentage As Integer = CInt((fourthBorrowedCount / totalBooksCount) * 100)

            ' Update the label with book information for the fourth highest
            Label11.Text = $"4. {bookTitle} - Count: {fourthBorrowedCount}"

            ' Update the progress bar with the percentage for the fourth highest
            PB4.Value = percentage
        End If

        con.Close()
    End Sub


End Class