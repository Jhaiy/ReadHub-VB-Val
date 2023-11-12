Imports System.Data
Imports System.Data.Common
Imports MySql.Data.MySqlClient
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
        Try
            conadApter = New MySqlDataAdapter("SELECT * From admin_information WHERE Email = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' ", con)
            dataTable = New DataTable
            dataTable.Clear()
            conadApter.Fill(dataTable)
            If dataTable.Rows.Count > 0 Then
                MsgBox("Welcome to readhub!")
                Dashboard.Show()
                Me.Hide()
                TextBox1.Clear()
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
