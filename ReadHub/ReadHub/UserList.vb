Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class UserList
    Dim sqlQuery As String
    Dim Command As MySqlCommand
    Private Sub UserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facTable()
        studentTable()
        ColorRowsBasedOnStatus()
        ComboBox1.Height = 40

        ComboBox1.ItemHeight = 30

        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        Label4.ForeColor = Color.FromArgb(255, 255, 255)
        userButton.BackColor = Color.FromArgb(152, 193, 217)
        studTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        facultyTable.BackgroundColor = Color.FromArgb(61, 90, 128)
        userPanel.BackColor = Color.FromArgb(61, 90, 128)
    End Sub

    Private Sub dashButton_Click(sender As Object, e As EventArgs) Handles dashButton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        Me.Hide()
        BookList.Show()
    End Sub

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        Me.Hide()
        Archives.Show()
    End Sub

    Private Sub borrowButton_Click(sender As Object, e As EventArgs) Handles borrowButton.Click
        Me.Hide()
        BorrowedBooks.Show()
    End Sub
    Private Sub studentTable()
        Try
            con.Open()
            Dim Command As MySqlCommand
            Dim sqlQuery As String
            sqlQuery = "SELECT * FROM readhub.student_information"
            Command = New MySqlCommand(sqlQuery, con)
            Command.ExecuteNonQuery()
            Dim table As New DataTable
            Dim Adapter As New MySqlDataAdapter(Command)

            Adapter.Fill(table)

            studTable.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error fetching student data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub facTable()
        Try
            con.Open()
            Dim Command As MySqlCommand
            Dim sqlQuery As String
            sqlQuery = "SELECT * FROM readhub.employee_information"
            Command = New MySqlCommand(sqlQuery, con)
            Command.ExecuteNonQuery()
            Dim table As New DataTable
            Dim Adapter As New MySqlDataAdapter(Command)

            Adapter.Fill(table)
            facultyTable.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error fetching faculty data: " & ex.Message)
        Finally
            con.Close()
        End Try
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

    Private Sub InsertData(User_ID As String, Fullname As String, Email As String, BorrowerType_ID As String, Address As String, ContactNumber As String, Program_ID As String, Campus_ID As String, Account_Created As String, Status_ID As String, password As String)
        Try
            con.Open()
            Dim sqlQuery As String = "INSERT INTO readhub.student_information (User_ID,	Fullname, Email, BorrowerType_ID, Address, `Contact Number`, Program_ID, Campus_ID, Account_Created, Status_ID, password) VALUES (@User_ID, @Fullname, @Email, @BorrowerType_ID, @Address, @ContactNumber, @Program_ID, @Campus_ID, @Account_Created, @Status_ID, @password)"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@User_ID", User_ID)
            command.Parameters.AddWithValue("@Fullname", Fullname)
            command.Parameters.AddWithValue("@Email", Email)
            command.Parameters.AddWithValue("@BorrowerType_ID", BorrowerType_ID)
            command.Parameters.AddWithValue("@Address", Address)
            command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
            command.Parameters.AddWithValue("@Program_ID", Program_ID)
            command.Parameters.AddWithValue("@Campus_ID", Campus_ID)
            command.Parameters.AddWithValue("@Account_Created", Account_Created)
            command.Parameters.AddWithValue("@Status_ID", Status_ID)
            command.Parameters.AddWithValue("@password", password)
            command.ExecuteNonQuery()
            MessageBox.Show("Registration is successful")
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub InsertStudInf()
        Dim User_ID As String = UID1.Text
        Dim Fullname As String = FN1.Text
        Dim Email As String = E1.Text
        Dim BorrowerType_ID As String = BT1.Text
        Dim Address As String = A1.Text

        Dim ContactNumber As String = CN1.Text

        Dim Program_ID As String = PID1.Text
        Dim Campus_ID As String = C1.Text
        Dim Account_Created As String = AC1.Text
        Dim Status_ID As String = S1.Text
        Dim password As String = P1.Text

        InsertData(User_ID, Fullname, Email, BorrowerType_ID, Address, ContactNumber, Program_ID, Campus_ID, Account_Created, Status_ID, password)

        studentTable()
    End Sub
    Private Sub regButton1_Click(sender As Object, e As EventArgs) Handles regButton1.Click
        InsertStudInf()
    End Sub
    Private Sub UpdateData(User_ID As String, Fullname As String, Email As String, BorrowerType_ID As String, Address As String, ContactNumber As String, Program_ID As String, Campus_ID As String, Account_Created As String, Status_ID As String, password As String)
        Try
            con.Open()
            Dim sqlQuery As String = "UPDATE readhub.student_information SET Fullname = @Fullname, Email = @Email, BorrowerType_ID = @BorrowerType_ID, Address = @Address, `Contact Number` = @ContactNumber, Program_ID = @Program_ID, Campus_ID = @Campus_ID, Account_Created = @Account_Created, Status_ID = @Status_ID, password = @password WHERE User_ID = @User_ID"
            Dim command As MySqlCommand = New MySqlCommand(sqlQuery, con)
            command.Parameters.AddWithValue("@User_ID", User_ID)
            command.Parameters.AddWithValue("@Fullname", Fullname)
            command.Parameters.AddWithValue("@Email", Email)
            command.Parameters.AddWithValue("@BorrowerType_ID", BorrowerType_ID)
            command.Parameters.AddWithValue("@Address", Address)
            command.Parameters.AddWithValue("@ContactNumber", ContactNumber)
            command.Parameters.AddWithValue("@Program_ID", Program_ID)
            command.Parameters.AddWithValue("@Campus_ID", Campus_ID)
            command.Parameters.AddWithValue("@Account_Created", Account_Created)
            command.Parameters.AddWithValue("@Status_ID", Status_ID)
            command.Parameters.AddWithValue("@password", password)
            command.ExecuteNonQuery()
            MessageBox.Show("Update is successful")
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub UpdateStudInf()
        If studTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = studTable.SelectedRows(0)

            ' Check the value of User_ID
            Dim userID As String = selectedRow.Cells("User_ID").Value.ToString()
            MessageBox.Show($"Selected User_ID: {userID}")
            UID1.Text = userID


            ' Rest of your code remains unchanged
            Dim newFullname As String = FN1.Text
            Dim newEmail As String = E1.Text
            Dim newBorrowerType_ID As String = BT1.Text
            Dim newAddress As String = A1.Text
            Dim newContactNumber As String = CN1.Text
            Dim newProgram_ID As String = PID1.Text
            Dim newCampus_ID As String = C1.Text
            Dim newAccount_Created As String = AC1.Text
            Dim newStatus_ID As String = S1.Text
            Dim password As String = P1.Text

            UpdateData(userID, newFullname, newEmail, newBorrowerType_ID, newAddress, newContactNumber, newProgram_ID, newCampus_ID, newAccount_Created, newStatus_ID, password)
        Else
            MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub modButton1_Click(sender As Object, e As EventArgs) Handles modButton1.Click
        UpdateStudInf()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        studentTable()
        ColorRowsBasedOnStatus()
    End Sub

    Private Sub BT1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        If studTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = studTable.SelectedRows(0)
            Dim userID As String = selectedRow.Cells("User_ID").Value.ToString()
            Dim newFullname As String = selectedRow.Cells("Fullname").Value.ToString()
            Dim newEmail As String = selectedRow.Cells("Email").Value.ToString()
            Dim newBorrowerType_ID As String = selectedRow.Cells("BorrowerType_ID").Value.ToString()
            Dim newAddress As String = selectedRow.Cells("Address").Value.ToString()
            Dim newContactNumber As String = selectedRow.Cells("Contact Number").Value.ToString()
            Dim newProgram_ID As String = selectedRow.Cells("Program_ID").Value.ToString()
            Dim newCampus_ID As String = selectedRow.Cells("Campus_ID").Value.ToString()
            Dim newAccount_Created As String = selectedRow.Cells("Account_Created").Value.ToString()
            Dim newStatus_ID As String = selectedRow.Cells("Status_ID").Value.ToString()
            Dim password As String = selectedRow.Cells("password").Value.ToString()

            UID1.Text = userID
            FN1.Text = newFullname
            E1.Text = newEmail
            BT1.Text = newBorrowerType_ID
            A1.Text = newAddress
            CN1.Text = newContactNumber
            PID1.Text = newProgram_ID
            C1.Text = newCampus_ID
            AC1.Text = newAccount_Created
            S1.Text = newStatus_ID
            P1.Text = password
        Else
            MessageBox.Show("Please select a row to get User_ID.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ColorRowsBasedOnStatus()
        For Each row As DataGridViewRow In studTable.Rows
            If row.Cells("Status_ID") IsNot Nothing AndAlso row.Cells("Status_ID").Value IsNot Nothing Then
                Dim status As String = row.Cells("Status_ID").Value.ToString()

                Select Case status
                    Case "S_1"
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8EDC8E")
                    Case "S_2"
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF4B4B")
                    Case "S_3"
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FDFD96")
                    Case "S_4"
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7EC0EE")
                    Case "S_5"
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFA500")
                    Case Else
                        row.DefaultCellStyle.BackColor = Color.White
                End Select
            End If
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If studTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = studTable.SelectedRows(0)
            Dim selectedStatus As String = ""

            Select Case ComboBox1.SelectedIndex
                Case 0
                    selectedStatus = "S_1"
                Case 1
                    selectedStatus = "S_2"
                Case 2
                    selectedStatus = "S_3"
                Case 3
                    selectedStatus = "S_4"
                Case 4
                    selectedStatus = "S_5"
            End Select

            selectedRow.Cells("Status_ID").Value = selectedStatus

            UpdateData(selectedRow.Cells("User_ID").Value.ToString(),
                       selectedRow.Cells("Fullname").Value.ToString(),
                       selectedRow.Cells("Email").Value.ToString(),
                       selectedRow.Cells("BorrowerType_ID").Value.ToString(),
                       selectedRow.Cells("Address").Value.ToString(),
                       selectedRow.Cells("Contact Number").Value.ToString(),
                       selectedRow.Cells("Program_ID").Value.ToString(),
                       selectedRow.Cells("Campus_ID").Value.ToString(),
                       selectedRow.Cells("Account_Created").Value.ToString(),
                       selectedStatus,
                       selectedRow.Cells("password").Value.ToString())

        Else
            MessageBox.Show("Please select a row in the DataGridView.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class