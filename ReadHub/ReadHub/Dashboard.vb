Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        faculTable()
        stTable()
        bksTable()
        BorStudTab()
        BorEmpTab()
        FavTab()
        ArcBKTab()
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        dashPanel.BackColor = Color.FromArgb(61, 90, 128)
        dashButton.BackColor = Color.FromArgb(152, 193, 217)
        facultyTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        borrowedFacTab.BackgroundColor = Color.FromArgb(61, 90, 128)
        borrowedStudTab.BackgroundColor = Color.FromArgb(61, 90, 128)
        Label4.ForeColor = Color.FromArgb(255, 255, 255)
        booksTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        favoritesTableLeft.BackgroundColor = Color.FromArgb(61, 90, 128)
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
    Private Sub FavTab()
        con.Open()
        Dim Command As MySqlCommand
        Dim sqlQuery As String
        sqlQuery = "SELECT * FROM readhub.favorites"
        Command = New MySqlCommand(sqlQuery, con)
        Command.ExecuteNonQuery()
        Dim table As New DataTable
        Dim Adapter As New MySqlDataAdapter(Command)
        Adapter.Fill(table)
        favoritesTableLeft.DataSource = table
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
End Class