Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class Archives
    Dim sqlQuery As String
    Dim Command As MySqlCommand
    Private Sub Archives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArcBKTab()
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        archivePanel.BackColor = Color.FromArgb(61, 90, 128)
        archiveButton.BackColor = Color.FromArgb(152, 193, 217)
        archiveTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        Label3.ForeColor = Color.FromArgb(255, 255, 255)
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

    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        Me.Hide()
        BorrowedBooks.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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
        archiveTable.DataSource = table
        con.Close()
    End Sub
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        ArcBKTab()
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
    Private Sub ArchiveSelectedBook(bookID As String, title As String, author As String, categoryID As String, description As String, yearPublished As Integer)
        ArchiveBook(bookID, title, author, categoryID, description, yearPublished)
    End Sub
    Private Sub amendButton_Click(sender As Object, e As EventArgs) Handles amendButton.Click
        If archiveTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = archiveTable.SelectedRows(0)
            Dim bookID As String = selectedRow.Cells("Book_ID").Value.ToString()

            If MessageBox.Show("Are you sure you want to restore the book with Book_ID " & bookID & "?", "Confirm restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim title As String = selectedRow.Cells("Title").Value.ToString()
                Dim author As String = selectedRow.Cells("Author").Value.ToString()
                Dim categoryID As String = selectedRow.Cells("Category_ID").Value.ToString()
                Dim description As String = selectedRow.Cells("Description").Value.ToString()
                Dim yearPublished As Integer = Convert.ToInt32(selectedRow.Cells("Year_Published").Value)

                ArchiveSelectedBook(bookID, title, author, categoryID, description, yearPublished)

            End If
        Else
            MessageBox.Show("Please select a row to restore.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DeleteBook(bookID As String)
        Try
            con.Open()
            Dim sqlQuery As String = "DELETE FROM readhub.archive_books WHERE Book_ID = @BookID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@BookID", bookID)
            command.ExecuteNonQuery()
            MessageBox.Show("Book with Book_ID " & bookID & " restoring successfully.")
        Catch ex As Exception
            MessageBox.Show("Error restoring book: " & ex.Message)
        Finally
            con.Close()
            ArcBKTab()
        End Try
    End Sub
    Private Sub ArchiveBook(bookID As String, title As String, author As String, categoryID As String, description As String, yearPublished As Integer)
        Try
            con.Open()

            Dim archiveQuery As String = "INSERT INTO readhub.book_information (Book_ID, Title, Author, Category_ID, Description, Year_Published) " &
                                         "VALUES (@BookID, @Title, @Author, @CategoryID, @Description, @YearPublished)"
            Dim archiveCommand As MySqlCommand = New MySqlCommand(archiveQuery, con)
            archiveCommand.Parameters.AddWithValue("@BookID", bookID)
            archiveCommand.Parameters.AddWithValue("@Title", title)
            archiveCommand.Parameters.AddWithValue("@Author", author)
            archiveCommand.Parameters.AddWithValue("@CategoryID", categoryID)
            archiveCommand.Parameters.AddWithValue("@Description", description)
            archiveCommand.Parameters.AddWithValue("@YearPublished", yearPublished)
            archiveCommand.ExecuteNonQuery()

            Dim deleteQuery As String = "DELETE FROM readhub.archive_books WHERE Book_ID = @BookID"
            Dim deleteCommand As MySqlCommand = New MySqlCommand(deleteQuery, con)
            deleteCommand.Parameters.AddWithValue("@BookID", bookID)
            deleteCommand.ExecuteNonQuery()

            MessageBox.Show("Book with Book_ID " & bookID & " Restoring successfully.")
        Catch ex As Exception
            MessageBox.Show("Error restoring book: " & ex.Message)
        Finally
            con.Close()
            ArcBKTab()
        End Try
    End Sub

    Private Sub archiveTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles archiveTable.CellContentClick

    End Sub
End Class