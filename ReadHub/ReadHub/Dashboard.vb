﻿Imports System.Windows.Documents
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
            ' Get the count and name from the result
            Dim mostBorrowedCount As Integer = Convert.ToInt32(reader("BorrowedCount"))
            Dim bookID As String = reader("Book_ID").ToString()

            ' Fetch the total count of all books
            Dim totalBooksCount As Integer = GetTotalBooksCount()

            ' Calculate the percentage
            Dim percentage As Integer = CInt((mostBorrowedCount / totalBooksCount) * 100)

            ' Update the label with book information
            Label8.Text = $"1. {bookID} - Count: {mostBorrowedCount}"

            ' Update the progress bar with the percentage
            PB1.Value = percentage
        End If

        con.Close()
    End Sub

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
End Class