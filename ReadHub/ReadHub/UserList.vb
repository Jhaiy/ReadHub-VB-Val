﻿Imports System.Windows.Documents
Imports MySql.Data.MySqlClient
Public Class UserList
    Private Sub UserList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        facTable()
        studentTable()



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
        con.Close()
    End Sub

    Private Sub facTable()
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
        con.Close()
    End Sub

End Class