Imports System.CodeDom
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient

Public Class BookList
    Dim sqlQuery As String
    Dim Command As MySqlCommand
    Dim dataReader As MySqlDataReader
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
        'con.Open()
        'Dim Command As MySqlCommand
        'Dim sqlQuery As String
        'sqlQuery = "SELECT * FROM readhub.book_information"
        'Command = New MySqlCommand(sqlQuery, con)
        'Command.ExecuteNonQuery()
        'Dim table As New DataTable
        'Dim Adapter As New MySqlDataAdapter(Command)

        'Adapter.Fill(table)

        'booksTable.DataSource = table
        'con.Close()
        con.Open()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
            dataReader.Dispose()
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim Command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Title like '%" & searchBox.Text & "%'", con)
            dataReader = Command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
            dataReader.Dispose()
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
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
    Private Sub ArchiveBook(bookID As String, title As String, author As String, categoryID As String, description As String, yearPublished As Integer)
        Try
            con.Open()

            Dim archiveQuery As String = "INSERT INTO readhub.archive_books (Book_ID, Title, Author, Category_ID, Description, Year_Published) " &
                                         "VALUES (@BookID, @Title, @Author, @CategoryID, @Description, @YearPublished)"
            Dim archiveCommand As MySqlCommand = New MySqlCommand(archiveQuery, con)
            archiveCommand.Parameters.AddWithValue("@BookID", bookID)
            archiveCommand.Parameters.AddWithValue("@Title", title)
            archiveCommand.Parameters.AddWithValue("@Author", author)
            archiveCommand.Parameters.AddWithValue("@CategoryID", categoryID)
            archiveCommand.Parameters.AddWithValue("@Description", description)
            archiveCommand.Parameters.AddWithValue("@YearPublished", yearPublished)
            archiveCommand.ExecuteNonQuery()

            Dim deleteQuery As String = "DELETE FROM readhub.book_information WHERE Book_ID = @BookID"
            Dim deleteCommand As MySqlCommand = New MySqlCommand(deleteQuery, con)
            deleteCommand.Parameters.AddWithValue("@BookID", bookID)
            deleteCommand.ExecuteNonQuery()

            MessageBox.Show("Book with Book_ID " & bookID & " archived successfully.")
        Catch ex As Exception
            MessageBox.Show("Error archiving book: " & ex.Message)
        Finally
            con.Close()
            loadDataOnTable()
        End Try
    End Sub

    Private Sub ArchiveSelectedBook(bookID As String, title As String, author As String, categoryID As String, description As String, yearPublished As Integer)
        ArchiveBook(bookID, title, author, categoryID, description, yearPublished)
    End Sub
    Private Sub discardButton_Click(sender As Object, e As EventArgs) Handles discardButton.Click
        If booksTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = booksTable.SelectedRows(0)
            Dim bookID As String = selectedRow.Cells("Book_ID").Value.ToString()

            If MessageBox.Show("Are you sure you want to discard the book with Book_ID " & bookID & "?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim title As String = selectedRow.Cells("Title").Value.ToString()
                Dim author As String = selectedRow.Cells("Author").Value.ToString()
                Dim categoryID As String = selectedRow.Cells("Category_ID").Value.ToString()
                Dim description As String = selectedRow.Cells("Description").Value.ToString()
                Dim yearPublished As Integer = Convert.ToInt32(selectedRow.Cells("Year_Published").Value)

                ArchiveSelectedBook(bookID, title, author, categoryID, description, yearPublished)

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

    Private Sub amendButton_Click(sender As Object, e As EventArgs) Handles amendButton.Click
        If booksTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = booksTable.SelectedRows(0)
            Dim bookID As String = selectedRow.Cells("Book_ID").Value.ToString()

            Dim newbookID As String = BTB.Text
            Dim newTitle As String = TTB.Text
            Dim newAuthor As String = ATB.Text
            Dim newCategoryID As String = CTB.Text
            Dim newDescription As String = DTB.Text
            Dim newYearPublished As Integer

            If Integer.TryParse(YTB.Text, newYearPublished) Then
            Else
                MessageBox.Show("Invalid year format. Please enter a valid year.")
                Exit Sub
            End If

            UpdateBook(bookID, newbookID, newTitle, newAuthor, newCategoryID, newDescription, newYearPublished)
        Else
            MessageBox.Show("Please select a row to amend.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateBook(bookID As String, newbookID As String, newTitle As String, newAuthor As String, newCategoryID As String, newDescription As String, newYearPublished As Integer)
        Try
            con.Open()
            Dim sqlQuery As String = "UPDATE readhub.book_information SET Book_ID = @NewBookID, Title = @NewTitle, Author = @NewAuthor, Category_ID = @NewCategoryID, Description = @NewDescription, Year_Published = @NewYearPublished WHERE Book_ID = @BookID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@NewBookID", newbookID)
            command.Parameters.AddWithValue("@NewTitle", newTitle)
            command.Parameters.AddWithValue("@NewAuthor", newAuthor)
            command.Parameters.AddWithValue("@NewCategoryID", newCategoryID)
            command.Parameters.AddWithValue("@NewDescription", newDescription)
            command.Parameters.AddWithValue("@NewYearPublished", newYearPublished)
            command.Parameters.AddWithValue("@BookID", bookID)
            command.ExecuteNonQuery()
            MessageBox.Show("Book with Book_ID " & bookID & " updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating book: " & ex.Message)
        Finally
            con.Close()
            loadDataOnTable()
        End Try
    End Sub
    Private Sub horror()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_1'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub mystery()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_2'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub romance()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_3'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub fantasy()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_4'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub history()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_5'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub academics()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_6'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub scifi()
        con.Open()
        booksTable.Rows.Clear()
        Try
            Dim command As New MySqlCommand("SELECT * FROM readhub.book_information WHERE Category_ID = 'CAT_7'", con)
            dataReader = command.ExecuteReader
            While dataReader.Read
                booksTable.Rows.Add(dataReader.Item("Book_ID"), dataReader.Item("Title"), dataReader.Item("Author"), dataReader.Item("Description"), dataReader.Item("Year_Published"))
            End While
        Catch ex As Exception
            MsgBox("Debug Error")
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        horror()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        mystery()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        romance()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        fantasy()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        history()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        academics()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        scifi()
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
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

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        loadDataOnTable()
    End Sub
End Class
