Public Class BorrowedBooks
    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Me.BackColor = Color.FromArgb(152, 193, 217)
        borrowedPanel.BackColor = Color.FromArgb(61, 90, 128)
        borrowButton.BackColor = Color.FromArgb(152, 193, 217)
        borrowedTable.BackgroundColor = Color.FromArgb(61, 90, 128)
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

    Private Sub archiveButton_Click(sender As Object, e As EventArgs) Handles archiveButton.Click
        Me.Hide()
        Archives.Show()
    End Sub

    Private Sub borrowedTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles borrowedTable.CellContentClick

    End Sub

    Private Sub appendButton_Click(sender As Object, e As EventArgs) Handles appendButton.Click

    End Sub
End Class