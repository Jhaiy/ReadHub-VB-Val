Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class BorrowedBooks
    Dim sqlQuery As String
    Dim Command As MySqlCommand
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

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        BorStudTab()
    End Sub

    Private Sub appendButton_Click(sender As Object, e As EventArgs) Handles appendButton.Click
        BorEmpTab()
    End Sub

    Private Sub S_Paint(sender As Object, e As PaintEventArgs) Handles S.Paint

    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        If borrowedstudTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = borrowedstudTable.SelectedRows(0)
            Dim userID As String = selectedRow.Cells("BorrowedBooks_ID").Value.ToString()
            Dim newFullname As String = selectedRow.Cells("User_ID").Value.ToString()
            Dim newEmail As String = selectedRow.Cells("Book_ID").Value.ToString()
            Dim newBorrowerType_ID As String = selectedRow.Cells("Date_Borrowed").Value.ToString()
            Dim newAddress As String = selectedRow.Cells("Return_Date").Value.ToString()
            Dim newContactNumber As String = selectedRow.Cells("Fine_Status_ID").Value.ToString()
            Dim newDepartment_ID As String = selectedRow.Cells("Fine_Amount").Value.ToString()

            BBID1.Text = userID
            UID1.Text = newFullname
            BID1.Text = newEmail
            DB1.Text = newBorrowerType_ID
            RD1.Text = newAddress
            FSID1.Text = newContactNumber
            FA1.Text = newDepartment_ID

        Else
            MessageBox.Show("Please select a row to get BorrowedBooks_ID.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        If BorrowedBooksEmployee.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BorrowedBooksEmployee.SelectedRows(0)
            Dim userID As String = selectedRow.Cells("BorrowedBooks_ID").Value.ToString()
            Dim newFullname As String = selectedRow.Cells("User_ID").Value.ToString()
            Dim newEmail As String = selectedRow.Cells("Book_ID").Value.ToString()
            Dim newBorrowerType_ID As String = selectedRow.Cells("Date_Borrowed").Value.ToString()
            Dim newAddress As String = selectedRow.Cells("Return_Date").Value.ToString()
            Dim newContactNumber As String = selectedRow.Cells("Fine_Status_ID").Value.ToString()
            Dim newDepartment_ID As String = selectedRow.Cells("Fine_Amount").Value.ToString()

            BBID2.Text = userID
            UID2.Text = newFullname
            BID2.Text = newEmail
            DB2.Text = newBorrowerType_ID
            RD2.Text = newAddress
            FSID2.Text = newContactNumber
            FA2.Text = newDepartment_ID

        Else
            MessageBox.Show("Please select a row to get BorrowedBooks_ID.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        UpdateStudBor()
    End Sub
    Private Sub UpdatestudData(BorT_ID As String, newUser_ID As String, newBook_ID As String, newDate_Borrowed As String, newReturn_Date As String, newFineStatus_ID As String, newFineAmount As String)
        Try
            con.Open()
            Dim sqlQuery As String = "UPDATE readhub.borrowed_books_student SET User_ID = @User_ID, Book_ID = @Book_ID, Date_Borrowed = @Date_Borrowed, Return_Date = @Return_Date, Fine_Status_ID = @Fine_Status_ID, Fine_Amount = @Fine_Amount WHERE BorrowedBooks_ID = @BorrowedBooks_ID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)

            command.Parameters.AddWithValue("@BorrowedBooks_ID", BorT_ID)
            command.Parameters.AddWithValue("@User_ID", newUser_ID)
            command.Parameters.AddWithValue("@Book_ID", newBook_ID)
            command.Parameters.AddWithValue("@Date_Borrowed", newDate_Borrowed)
            command.Parameters.AddWithValue("@Return_Date", newReturn_Date)
            command.Parameters.AddWithValue("@Fine_Status_ID", newFineStatus_ID)
            command.Parameters.AddWithValue("@Fine_Amount", newFineAmount)
            command.ExecuteNonQuery()
            MessageBox.Show("Update is successful")
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateStudBor()
        If borrowedstudTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = borrowedstudTable.SelectedRows(0)

            Dim BorT_ID As String = selectedRow.Cells("BorrowedBooks_ID").Value.ToString()
            MessageBox.Show($"Selected User_ID: {BorT_ID}")
            BBID1.Text = BorT_ID

            Dim newUser_ID As String = UID1.Text
            Dim newBook_ID As String = BID1.Text
            Dim newDate_Borrowed As String = DB1.Text
            Dim newReturn_Date As String = RD1.Text
            Dim newFineStatus_ID As String = FSID1.Text
            Dim newFineAmmount As String = FA1.Text

            UpdatestudData(BorT_ID, newUser_ID, newBook_ID, newDate_Borrowed, newReturn_Date, newFineStatus_ID, newFineAmmount)
        Else
            MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub amendButton_Click(sender As Object, e As EventArgs) Handles amendButton.Click
        UpdateEmpBor()
    End Sub
    Private Sub UpdateempData(BorT_ID As String, newUser_ID As String, newBook_ID As String, newDate_Borrowed As String, newReturn_Date As String, newFineStatus_ID As String, newFineAmount As String)
        Try
            con.Open()
            Dim sqlQuery As String = "UPDATE readhub.borrowed_books_employee SET User_ID = @User_ID, Book_ID = @Book_ID, Date_Borrowed = @Date_Borrowed, Return_Date = @Return_Date, Fine_Status_ID = @Fine_Status_ID, Fine_Amount = @Fine_Amount WHERE BorrowedBooks_ID = @BorrowedBooks_ID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)

            command.Parameters.AddWithValue("@BorrowedBooks_ID", BorT_ID)
            command.Parameters.AddWithValue("@User_ID", newUser_ID)
            command.Parameters.AddWithValue("@Book_ID", newBook_ID)
            command.Parameters.AddWithValue("@Date_Borrowed", newDate_Borrowed)
            command.Parameters.AddWithValue("@Return_Date", newReturn_Date)
            command.Parameters.AddWithValue("@Fine_Status_ID", newFineStatus_ID)
            command.Parameters.AddWithValue("@Fine_Amount", newFineAmount)
            command.ExecuteNonQuery()
            MessageBox.Show("Update is successful")
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateEmpBor()
        If BorrowedBooksEmployee.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = BorrowedBooksEmployee.SelectedRows(0)

            Dim BorT_ID As String = selectedRow.Cells("BorrowedBooks_ID").Value.ToString()
            MessageBox.Show($"Selected User_ID: {BorT_ID}")
            BBID1.Text = BorT_ID

            Dim newUser_ID As String = UID2.Text
            Dim newBook_ID As String = BID2.Text
            Dim newDate_Borrowed As String = DB2.Text
            Dim newReturn_Date As String = RD2.Text
            Dim newFineStatus_ID As String = FSID2.Text
            Dim newFineAmmount As String = FA2.Text

            UpdateempData(BorT_ID, newUser_ID, newBook_ID, newDate_Borrowed, newReturn_Date, newFineStatus_ID, newFineAmmount)
        Else
            MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class