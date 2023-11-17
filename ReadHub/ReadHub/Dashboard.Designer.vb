<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        dashPanel = New Panel()
        Panel3 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        borrowButton = New FontAwesome.Sharp.IconButton()
        archiveButton = New FontAwesome.Sharp.IconButton()
        userButton = New FontAwesome.Sharp.IconButton()
        bookButton = New FontAwesome.Sharp.IconButton()
        dashButton = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        studentTable = New DataGridView()
        borrowedStudTab = New DataGridView()
        Label3 = New Label()
        facultyTable = New DataGridView()
        borrowedFacTab = New DataGridView()
        Panel2 = New Panel()
        barButton = New FontAwesome.Sharp.IconButton()
        Label7 = New Label()
        Label6 = New Label()
        ArchiveBooksTable = New DataGridView()
        favoritesTableLeft = New DataGridView()
        Label5 = New Label()
        booksTable = New DataGridView()
        Label4 = New Label()
<<<<<<< HEAD
        Panel4 = New Panel()
        Label11 = New Label()
        PB4 = New ProgressBar()
        Label10 = New Label()
        PB3 = New ProgressBar()
        Label9 = New Label()
        PB2 = New ProgressBar()
        Label8 = New Label()
        Label6 = New Label()
        PB1 = New ProgressBar()
=======
>>>>>>> 78edce19eaecd377039bc5e5ef68ec974331c84b
        dashPanel.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(borrowedStudTab, ComponentModel.ISupportInitialize).BeginInit()
        CType(facultyTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(borrowedFacTab, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ArchiveBooksTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(favoritesTableLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(booksTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dashPanel
        ' 
        dashPanel.BackColor = SystemColors.Highlight
        dashPanel.Controls.Add(Panel3)
        dashPanel.Controls.Add(borrowButton)
        dashPanel.Controls.Add(archiveButton)
        dashPanel.Controls.Add(userButton)
        dashPanel.Controls.Add(bookButton)
        dashPanel.Controls.Add(dashButton)
        dashPanel.Controls.Add(Panel1)
        dashPanel.Dock = DockStyle.Left
        dashPanel.Location = New Point(0, 0)
        dashPanel.Margin = New Padding(4, 5, 4, 5)
        dashPanel.Name = "dashPanel"
        dashPanel.Size = New Size(340, 1050)
        dashPanel.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 977)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(340, 73)
        Panel3.TabIndex = 7
        ' 
        ' IconButton1
        ' 
        IconButton1.Dock = DockStyle.Fill
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.ForeColor = Color.White
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(0, 0)
        IconButton1.Margin = New Padding(4, 5, 4, 5)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(340, 73)
        IconButton1.TabIndex = 6
        IconButton1.Text = "LOGOUT"
        IconButton1.UseVisualStyleBackColor = True
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
        borrowButton.TabIndex = 5
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
        archiveButton.TabIndex = 4
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
        userButton.TabIndex = 3
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
        bookButton.TabIndex = 2
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
        dashButton.TabIndex = 1
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
        Panel1.TabIndex = 0
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(43, 133)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 1
        Label2.Text = "USERS LIST"
        ' 
        ' studentTable
        ' 
        studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentTable.Location = New Point(43, 175)
        studentTable.Margin = New Padding(4, 5, 4, 5)
        studentTable.Name = "studentTable"
        studentTable.RowHeadersWidth = 62
        studentTable.RowTemplate.Height = 25
        studentTable.Size = New Size(493, 143)
        studentTable.TabIndex = 2
        ' 
        ' borrowedStudTab
        ' 
        borrowedStudTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        borrowedStudTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowedStudTab.Location = New Point(610, 175)
        borrowedStudTab.Margin = New Padding(4, 5, 4, 5)
        borrowedStudTab.Name = "borrowedStudTab"
        borrowedStudTab.RowHeadersWidth = 62
        borrowedStudTab.RowTemplate.Height = 25
        borrowedStudTab.Size = New Size(493, 143)
        borrowedStudTab.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(623, 133)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(222, 25)
        Label3.TabIndex = 4
        Label3.Text = "BORROWED BOOKS"
        ' 
        ' facultyTable
        ' 
        facultyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        facultyTable.GridColor = Color.White
        facultyTable.Location = New Point(43, 312)
        facultyTable.Margin = New Padding(4, 5, 4, 5)
        facultyTable.Name = "facultyTable"
        facultyTable.RowHeadersWidth = 62
        facultyTable.RowTemplate.Height = 25
        facultyTable.Size = New Size(493, 143)
        facultyTable.TabIndex = 5
        ' 
        ' borrowedFacTab
        ' 
        borrowedFacTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        borrowedFacTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowedFacTab.Location = New Point(610, 312)
        borrowedFacTab.Margin = New Padding(4, 5, 4, 5)
        borrowedFacTab.Name = "borrowedFacTab"
        borrowedFacTab.RowHeadersWidth = 62
        borrowedFacTab.RowTemplate.Height = 25
        borrowedFacTab.Size = New Size(493, 143)
        borrowedFacTab.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(ArchiveBooksTable)
        Panel2.Controls.Add(favoritesTableLeft)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(booksTable)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(borrowedFacTab)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(facultyTable)
        Panel2.Controls.Add(studentTable)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(borrowedStudTab)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(340, 0)
        Panel2.Margin = New Padding(4, 5, 4, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1156, 1050)
        Panel2.TabIndex = 7
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
        barButton.TabIndex = 22
        barButton.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(623, 808)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 25)
        Label7.TabIndex = 21
        Label7.Text = "ARCHIVE BOOKS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(43, 808)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 25)
        Label6.TabIndex = 20
        Label6.Text = "FAVORITES"
        ' 
        ' ArchiveBooksTable
        ' 
        ArchiveBooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ArchiveBooksTable.GridColor = Color.White
        ArchiveBooksTable.Location = New Point(623, 850)
        ArchiveBooksTable.Margin = New Padding(4, 5, 4, 5)
        ArchiveBooksTable.Name = "ArchiveBooksTable"
        ArchiveBooksTable.RowHeadersWidth = 62
        ArchiveBooksTable.RowTemplate.Height = 25
        ArchiveBooksTable.Size = New Size(493, 143)
        ArchiveBooksTable.TabIndex = 17
        ' 
        ' favoritesTableLeft
        ' 
        favoritesTableLeft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        favoritesTableLeft.GridColor = Color.White
        favoritesTableLeft.Location = New Point(43, 850)
        favoritesTableLeft.Margin = New Padding(4, 5, 4, 5)
        favoritesTableLeft.Name = "favoritesTableLeft"
        favoritesTableLeft.RowHeadersWidth = 62
        favoritesTableLeft.RowTemplate.Height = 25
        favoritesTableLeft.Size = New Size(493, 143)
        favoritesTableLeft.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 508)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 25)
        Label5.TabIndex = 11
        Label5.Text = "BOOKS"
        ' 
        ' booksTable
        ' 
        booksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        booksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        booksTable.GridColor = Color.White
        booksTable.Location = New Point(43, 548)
        booksTable.Margin = New Padding(4, 5, 4, 5)
        booksTable.Name = "booksTable"
        booksTable.RowHeadersWidth = 62
        booksTable.RowTemplate.Height = 25
        booksTable.Size = New Size(1073, 202)
        booksTable.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Bebas Neue", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(43, 20)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(173, 48)
        Label4.TabIndex = 9
        Label4.Text = "DASHBOARD"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
<<<<<<< HEAD
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(61), CByte(90), CByte(128))
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(PB4)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(PB3)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(PB2)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(PB1)
        Panel4.Location = New Point(43, 762)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1060, 231)
        Panel4.TabIndex = 27
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(561, 130)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(23, 25)
        Label11.TabIndex = 32
        Label11.Text = "4"
        ' 
        ' PB4
        ' 
        PB4.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PB4.ForeColor = Color.Tomato
        PB4.Location = New Point(567, 158)
        PB4.Name = "PB4"
        PB4.Size = New Size(470, 27)
        PB4.TabIndex = 31
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(561, 57)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(23, 25)
        Label10.TabIndex = 30
        Label10.Text = "3"
        ' 
        ' PB3
        ' 
        PB3.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PB3.ForeColor = Color.Tomato
        PB3.Location = New Point(567, 85)
        PB3.Name = "PB3"
        PB3.Size = New Size(470, 27)
        PB3.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(17, 130)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(23, 25)
        Label9.TabIndex = 28
        Label9.Text = "2"
        ' 
        ' PB2
        ' 
        PB2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PB2.ForeColor = Color.Tomato
        PB2.Location = New Point(23, 158)
        PB2.Name = "PB2"
        PB2.Size = New Size(470, 27)
        PB2.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(17, 57)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(23, 25)
        Label8.TabIndex = 25
        Label8.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(17, 19)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(292, 25)
        Label6.TabIndex = 26
        Label6.Text = "MOST BORROWED BOOKS"
        ' 
        ' PB1
        ' 
        PB1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PB1.ForeColor = Color.Tomato
        PB1.Location = New Point(23, 85)
        PB1.Name = "PB1"
        PB1.Size = New Size(470, 27)
        PB1.TabIndex = 23
        ' 
=======
>>>>>>> 78edce19eaecd377039bc5e5ef68ec974331c84b
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1496, 1050)
        Controls.Add(Panel2)
        Controls.Add(dashPanel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Dashboard"
        Text = "Dashboard"
        dashPanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(studentTable, ComponentModel.ISupportInitialize).EndInit()
        CType(borrowedStudTab, ComponentModel.ISupportInitialize).EndInit()
        CType(facultyTable, ComponentModel.ISupportInitialize).EndInit()
        CType(borrowedFacTab, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ArchiveBooksTable, ComponentModel.ISupportInitialize).EndInit()
        CType(favoritesTableLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(booksTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dashPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents borrowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents archiveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents userButton As FontAwesome.Sharp.IconButton
    Friend WithEvents bookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents studentTable As DataGridView
    Friend WithEvents borrowedStudTab As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents facultyTable As DataGridView
    Friend WithEvents borrowedFacTab As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ArchiveBooksTable As DataGridView
    Friend WithEvents favoritesTableLeft As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents booksTable As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
<<<<<<< HEAD
    Friend WithEvents PB1 As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PB4 As ProgressBar
    Friend WithEvents Label10 As Label
    Friend WithEvents PB3 As ProgressBar
    Friend WithEvents Label9 As Label
    Friend WithEvents PB2 As ProgressBar
=======
>>>>>>> 78edce19eaecd377039bc5e5ef68ec974331c84b
End Class
