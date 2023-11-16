Imports System.Data
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cms

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        loginPanel.BackColor = Color.FromArgb(61, 90, 128)
        loginButton.BackColor = Color.FromArgb(152, 193, 217)
        loginLbl.ForeColor = Color.FromArgb(224, 251, 252)
        adminLbl.ForeColor = Color.FromArgb(224, 251, 252)
        emailLbl.ForeColor = Color.FromArgb(224, 251, 252)
        passwordLbl.ForeColor = Color.FromArgb(224, 251, 252)

    End Sub
    Dim conadApter As MySqlDataAdapter
    Dim dataTable As DataTable

    Public Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        opencon()
        Dim Time = Date.Now.ToString("hh:mm:ss")
        Dim currDate = Date.Now.ToString("dd MMM yyyy")
        Dim sqlQuery As String
        Dim command As MySqlCommand
        Try
            conadApter = New MySqlDataAdapter("SELECT * From admin_information WHERE Email = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' ", con)
            dataTable = New DataTable
            dataTable.Clear()
            conadApter.Fill(dataTable)
            If dataTable.Rows.Count > 0 Then
                sqlQuery = "INSERT INTO admin_in(Email, Login_Time, Login_Date) values ('" & TextBox1.Text & "'" & "," & "'" & Time & "'" & "," & "'" & currDate & "'" & ")"
                command = New MySqlCommand(sqlQuery, con)
                command.ExecuteNonQuery()
                MsgBox("Welcome to readhub!")
                Dashboard.Show()
                Me.Hide()
                TextBox2.Clear()
            Else
                MsgBox("Username and password is incorrect!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
