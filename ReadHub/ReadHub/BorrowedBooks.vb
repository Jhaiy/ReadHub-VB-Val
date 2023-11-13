Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class BorrowedBooks
    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BorStudTab()
        BorEmpTab()
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        borrowedPanel.BackColor = Color.FromArgb(61, 90, 128)
        borrowButton.BackColor = Color.FromArgb(152, 193, 217)
        borrowedstudTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        Label3.ForeColor = Color.FromArgb(255, 255, 255)
        BorrowedBooksEmployee.BackgroundColor = Color.FromArgb(61, 90, 128)
    End Sub

    Private Sub dashButton_Click(sender As Object, e As EventArgs) Handles dashButton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        Me.Hide()
        BookList.Show()
    End Sub

    Private Sub userButton_Click(sender As Object, e As EventArgs) Handles userButton.Click
        Me.Hide()
        UserList.Show()
    End Sub

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        Me.Hide()
        Archives.Show()
    End Sub

    Private Sub borrowedTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles borrowedstudTable.CellContentClick

    End Sub

    Private Sub appendButton_Click(sender As Object, e As EventArgs) Handles appendButton.Click

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
        borrowedstudTable.DataSource = table
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
        BorrowedBooksEmployee.DataSource = table
        con.Close()
    End Sub
End Class