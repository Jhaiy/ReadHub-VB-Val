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

    Private Sub appendButton_Click(sender As Object, e As EventArgs) Handles appendButton.Click

        InsertNewBook()
    End Sub

    Private Sub InsertData(bookID As String, title As String, author As String, categoryID As String, description As String, yearPublished As Integer)
        Try
            con.Open()
            Dim sqlQuery As String = "INSERT INTO readhub.book_information (Book_ID, Title, Author, Category_ID, Description, Year_Published) VALUES (@BookID, @Title, @Author, @CategoryID, @Description, @YearPublished)"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@BookID", bookID)
            command.Parameters.AddWithValue("@Title", title)
            command.Parameters.AddWithValue("@Author", author)
            command.Parameters.AddWithValue("@CategoryID", categoryID)
            command.Parameters.AddWithValue("@Description", description)
            command.Parameters.AddWithValue("@YearPublished", yearPublished)
            command.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub InsertNewBook()
        Dim bookID As String = BTB.Text
        Dim title As String = TTB.Text
        Dim author As String = ATB.Text
        Dim categoryID As String = CTB.Text
        Dim description As String = DTB.Text
        Dim yearPublished As Integer

        If Integer.TryParse(YTB.Text, yearPublished) Then
        Else
            MessageBox.Show("Invalid year format. Please enter a valid year.")
            Exit Sub
        End If

        InsertData(bookID, title, author, categoryID, description, yearPublished)

        loadDataOnTable()
    End Sub

    Private Sub discardButton_Click(sender As Object, e As EventArgs) Handles discardButton.Click
        If booksTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = booksTable.SelectedRows(0)
            Dim bookID As String = selectedRow.Cells("Book_ID").Value.ToString()

            If MessageBox.Show("Are you sure you want to discard the book with Book_ID " & bookID & "?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                DeleteBook(bookID)
            End If
        Else
            MessageBox.Show("Please select a row to discard.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub DeleteBook(bookID As String)
        Try
            con.Open()
            Dim sqlQuery As String = "DELETE FROM readhub.book_information WHERE Book_ID = @BookID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@BookID", bookID)
            command.ExecuteNonQuery()
            MessageBox.Show("Book with Book_ID " & bookID & " discarded successfully.")
        Catch ex As Exception
            MessageBox.Show("Error discarding book: " & ex.Message)
        Finally
            con.Close()
            loadDataOnTable()
        End Try
    End Sub
End Class
