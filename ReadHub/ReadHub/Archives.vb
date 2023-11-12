Public Class Archives
    Private Sub Archives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class