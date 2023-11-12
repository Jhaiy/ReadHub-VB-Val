Imports MySql.Data.MySqlClient

Public Class BookList
    Private Sub dashButton_Click(sender As Object, e As EventArgs) Handles dashButton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub userButton_Click(sender As Object, e As EventArgs) Handles userButton.Click
        Me.Hide()
        UserList.Show()
    End Sub

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        Me.Hide()
        Archives.Show()
    End Sub

    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        Me.Hide()
        BorrowedBooks.Show()
    End Sub

    Private Sub loadDataOnTable()
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
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataOnTable()
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        bookPanel.BackColor = Color.FromArgb(61, 90, 128)
        bookButton.BackColor = Color.FromArgb(152, 193, 217)
        booksTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        Label4.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
End Class
