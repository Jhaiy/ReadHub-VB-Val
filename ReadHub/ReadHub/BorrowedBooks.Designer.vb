<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        borrowedPanel = New Panel()
        borrowButton = New FontAwesome.Sharp.IconButton()
        archiveButton = New FontAwesome.Sharp.IconButton()
        userButton = New FontAwesome.Sharp.IconButton()
        bookButton = New FontAwesome.Sharp.IconButton()
        dashButton = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label5 = New Label()
        BorrowedBooksEmployee = New DataGridView()
        Label3 = New Label()
        exploreButton = New FontAwesome.Sharp.IconButton()
        amendButton = New FontAwesome.Sharp.IconButton()
        discardButton = New FontAwesome.Sharp.IconButton()
        appendButton = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        borrowedstudTable = New DataGridView()
        borrowedPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(BorrowedBooksEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(borrowedstudTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' borrowedPanel
        ' 
        borrowedPanel.BackColor = SystemColors.Highlight
        borrowedPanel.Controls.Add(borrowButton)
        borrowedPanel.Controls.Add(archiveButton)
        borrowedPanel.Controls.Add(userButton)
        borrowedPanel.Controls.Add(bookButton)
        borrowedPanel.Controls.Add(dashButton)
        borrowedPanel.Controls.Add(Panel1)
        borrowedPanel.Dock = DockStyle.Left
        borrowedPanel.Location = New Point(0, 0)
        borrowedPanel.Margin = New Padding(4, 5, 4, 5)
        borrowedPanel.Name = "borrowedPanel"
        borrowedPanel.Size = New Size(340, 1050)
        borrowedPanel.TabIndex = 15
        ' 
        ' borrowButton
        ' 
        borrowButton.Cursor = Cursors.Hand
        borrowButton.Dock = DockStyle.Top
        borrowButton.FlatAppearance.BorderSize = 0
        borrowButton.FlatStyle = FlatStyle.Flat
        borrowButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        borrowButton.ForeColor = Color.White
        borrowButton.IconChar = FontAwesome.Sharp.IconChar.None
        borrowButton.IconColor = Color.Black
        borrowButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        borrowButton.Location = New Point(0, 510)
        borrowButton.Margin = New Padding(4, 5, 4, 5)
        borrowButton.Name = "borrowButton"
        borrowButton.Size = New Size(340, 82)
        borrowButton.TabIndex = 11
        borrowButton.Text = "BORROWED BOOKS"
        borrowButton.UseVisualStyleBackColor = True
        ' 
        ' archiveButton
        ' 
        archiveButton.Cursor = Cursors.Hand
        archiveButton.Dock = DockStyle.Top
        archiveButton.FlatAppearance.BorderSize = 0
        archiveButton.FlatStyle = FlatStyle.Flat
        archiveButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        archiveButton.ForeColor = Color.White
        archiveButton.IconChar = FontAwesome.Sharp.IconChar.None
        archiveButton.IconColor = Color.Black
        archiveButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        archiveButton.Location = New Point(0, 428)
        archiveButton.Margin = New Padding(4, 5, 4, 5)
        archiveButton.Name = "archiveButton"
        archiveButton.Size = New Size(340, 82)
        archiveButton.TabIndex = 10
        archiveButton.Text = "ARCHIVES"
        archiveButton.UseVisualStyleBackColor = True
        ' 
        ' userButton
        ' 
        userButton.Cursor = Cursors.Hand
        userButton.Dock = DockStyle.Top
        userButton.FlatAppearance.BorderSize = 0
        userButton.FlatStyle = FlatStyle.Flat
        userButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        userButton.ForeColor = Color.White
        userButton.IconChar = FontAwesome.Sharp.IconChar.None
        userButton.IconColor = Color.Black
        userButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        userButton.Location = New Point(0, 346)
        userButton.Margin = New Padding(4, 5, 4, 5)
        userButton.Name = "userButton"
        userButton.Size = New Size(340, 82)
        userButton.TabIndex = 9
        userButton.Text = "USER'S LIST"
        userButton.UseVisualStyleBackColor = True
        ' 
        ' bookButton
        ' 
        bookButton.Cursor = Cursors.Hand
        bookButton.Dock = DockStyle.Top
        bookButton.FlatAppearance.BorderSize = 0
        bookButton.FlatStyle = FlatStyle.Flat
        bookButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        bookButton.ForeColor = Color.White
        bookButton.IconChar = FontAwesome.Sharp.IconChar.None
        bookButton.IconColor = Color.Black
        bookButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        bookButton.Location = New Point(0, 264)
        bookButton.Margin = New Padding(4, 5, 4, 5)
        bookButton.Name = "bookButton"
        bookButton.Size = New Size(340, 82)
        bookButton.TabIndex = 8
        bookButton.Text = "BOOK LIST"
        bookButton.UseVisualStyleBackColor = True
        ' 
        ' dashButton
        ' 
        dashButton.Cursor = Cursors.Hand
        dashButton.Dock = DockStyle.Top
        dashButton.FlatAppearance.BorderSize = 0
        dashButton.FlatStyle = FlatStyle.Flat
        dashButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        dashButton.ForeColor = Color.White
        dashButton.IconChar = FontAwesome.Sharp.IconChar.None
        dashButton.IconColor = Color.Black
        dashButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        dashButton.Location = New Point(0, 182)
        dashButton.Margin = New Padding(4, 5, 4, 5)
        dashButton.Name = "dashButton"
        dashButton.Size = New Size(340, 82)
        dashButton.TabIndex = 7
        dashButton.Text = "DASHBOARD"
        dashButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 182)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bebas Neue", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(126, 58)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 64)
        Label1.TabIndex = 1
        Label1.Text = "READHUB"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(44, 50)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 83)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(BorrowedBooksEmployee)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(exploreButton)
        Panel2.Controls.Add(amendButton)
        Panel2.Controls.Add(discardButton)
        Panel2.Controls.Add(appendButton)
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(borrowedstudTable)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(340, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1156, 1050)
        Panel2.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(66, 483)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(327, 25)
        Label5.TabIndex = 30
        Label5.Text = "BORROWED BOOKS FACULTY"
        ' 
        ' BorrowedBooksEmployee
        ' 
        BorrowedBooksEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BorrowedBooksEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BorrowedBooksEmployee.GridColor = Color.White
        BorrowedBooksEmployee.Location = New Point(66, 520)
        BorrowedBooksEmployee.Margin = New Padding(4, 5, 4, 5)
        BorrowedBooksEmployee.Name = "BorrowedBooksEmployee"
        BorrowedBooksEmployee.RowHeadersWidth = 62
        BorrowedBooksEmployee.RowTemplate.Height = 25
        BorrowedBooksEmployee.Size = New Size(1029, 307)
        BorrowedBooksEmployee.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(530, 32)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 25)
        Label3.TabIndex = 28
        Label3.Text = "BORROWED BOOKS"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' exploreButton
        ' 
        exploreButton.BackColor = Color.Tomato
        exploreButton.Cursor = Cursors.Hand
        exploreButton.FlatAppearance.BorderSize = 0
        exploreButton.FlatStyle = FlatStyle.Flat
        exploreButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        exploreButton.IconChar = FontAwesome.Sharp.IconChar.None
        exploreButton.IconColor = Color.Black
        exploreButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        exploreButton.Location = New Point(963, 873)
        exploreButton.Margin = New Padding(4, 5, 4, 5)
        exploreButton.Name = "exploreButton"
        exploreButton.Size = New Size(107, 38)
        exploreButton.TabIndex = 27
        exploreButton.Text = "EXPLORE"
        exploreButton.UseVisualStyleBackColor = False
        ' 
        ' amendButton
        ' 
        amendButton.BackColor = Color.Tomato
        amendButton.Cursor = Cursors.Hand
        amendButton.FlatAppearance.BorderSize = 0
        amendButton.FlatStyle = FlatStyle.Flat
        amendButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        amendButton.IconChar = FontAwesome.Sharp.IconChar.None
        amendButton.IconColor = Color.Black
        amendButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        amendButton.Location = New Point(847, 873)
        amendButton.Margin = New Padding(4, 5, 4, 5)
        amendButton.Name = "amendButton"
        amendButton.Size = New Size(107, 38)
        amendButton.TabIndex = 26
        amendButton.Text = "AMEND"
        amendButton.UseVisualStyleBackColor = False
        ' 
        ' discardButton
        ' 
        discardButton.BackColor = Color.Tomato
        discardButton.Cursor = Cursors.Hand
        discardButton.FlatAppearance.BorderSize = 0
        discardButton.FlatStyle = FlatStyle.Flat
        discardButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        discardButton.IconChar = FontAwesome.Sharp.IconChar.None
        discardButton.IconColor = Color.Black
        discardButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        discardButton.Location = New Point(731, 873)
        discardButton.Margin = New Padding(4, 5, 4, 5)
        discardButton.Name = "discardButton"
        discardButton.Size = New Size(107, 38)
        discardButton.TabIndex = 25
        discardButton.Text = "DISCARD"
        discardButton.UseVisualStyleBackColor = False
        ' 
        ' appendButton
        ' 
        appendButton.BackColor = Color.Tomato
        appendButton.Cursor = Cursors.Hand
        appendButton.FlatAppearance.BorderSize = 0
        appendButton.FlatStyle = FlatStyle.Flat
        appendButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        appendButton.IconChar = FontAwesome.Sharp.IconChar.None
        appendButton.IconColor = Color.Black
        appendButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        appendButton.Location = New Point(616, 873)
        appendButton.Margin = New Padding(4, 5, 4, 5)
        appendButton.Name = "appendButton"
        appendButton.Size = New Size(107, 38)
        appendButton.TabIndex = 24
        appendButton.Text = "APPEND"
        appendButton.UseVisualStyleBackColor = False
        ' 
        ' barButton
        ' 
        barButton.Cursor = Cursors.Hand
        barButton.FlatAppearance.BorderSize = 0
        barButton.FlatStyle = FlatStyle.Flat
        barButton.IconChar = FontAwesome.Sharp.IconChar.Navicon
        barButton.IconColor = Color.Black
        barButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        barButton.IconSize = 25
        barButton.Location = New Point(1089, 20)
        barButton.Margin = New Padding(4, 5, 4, 5)
        barButton.Name = "barButton"
        barButton.Size = New Size(50, 62)
        barButton.TabIndex = 23
        barButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(66, 96)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(345, 25)
        Label2.TabIndex = 12
        Label2.Text = "BORROWED BOOKS STUDENTS"
        ' 
        ' borrowedstudTable
        ' 
        borrowedstudTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        borrowedstudTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowedstudTable.GridColor = Color.White
        borrowedstudTable.Location = New Point(66, 133)
        borrowedstudTable.Margin = New Padding(4, 5, 4, 5)
        borrowedstudTable.Name = "borrowedstudTable"
        borrowedstudTable.RowHeadersWidth = 62
        borrowedstudTable.RowTemplate.Height = 25
        borrowedstudTable.Size = New Size(1029, 300)
        borrowedstudTable.TabIndex = 11
        ' 
        ' BorrowedBooks
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1496, 1050)
        Controls.Add(Panel2)
        Controls.Add(borrowedPanel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "BorrowedBooks"
        Text = "BorrowedBooks"
        borrowedPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BorrowedBooksEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(borrowedstudTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents borrowedPanel As Panel
    Friend WithEvents borrowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents archiveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents userButton As FontAwesome.Sharp.IconButton
    Friend WithEvents bookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents dashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents exploreButton As FontAwesome.Sharp.IconButton
    Friend WithEvents amendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents discardButton As FontAwesome.Sharp.IconButton
    Friend WithEvents appendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents borrowedstudTable As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents BorrowedBooksEmployee As DataGridView
End Class
