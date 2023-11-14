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
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        dashPanel.SuspendLayout()
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
        Panel3.SuspendLayout()
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
        dashPanel.Name = "dashPanel"
        dashPanel.Size = New Size(238, 630)
        dashPanel.TabIndex = 0
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
        borrowButton.Location = New Point(0, 305)
        borrowButton.Name = "borrowButton"
        borrowButton.Size = New Size(238, 49)
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
        archiveButton.Location = New Point(0, 256)
        archiveButton.Name = "archiveButton"
        archiveButton.Size = New Size(238, 49)
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
        userButton.Location = New Point(0, 207)
        userButton.Name = "userButton"
        userButton.Size = New Size(238, 49)
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
        bookButton.Location = New Point(0, 158)
        bookButton.Name = "bookButton"
        bookButton.Size = New Size(238, 49)
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
        dashButton.Location = New Point(0, 109)
        dashButton.Name = "dashButton"
        dashButton.Size = New Size(238, 49)
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 109)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bebas Neue", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(88, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 45)
        Label1.TabIndex = 1
        Label1.Text = "READHUB"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(31, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(30, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 16)
        Label2.TabIndex = 1
        Label2.Text = "USERS LIST"
        ' 
        ' studentTable
        ' 
        studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentTable.Location = New Point(30, 105)
        studentTable.Name = "studentTable"
        studentTable.RowHeadersWidth = 62
        studentTable.RowTemplate.Height = 25
        studentTable.Size = New Size(345, 86)
        studentTable.TabIndex = 2
        ' 
        ' borrowedStudTab
        ' 
        borrowedStudTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        borrowedStudTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowedStudTab.Location = New Point(427, 105)
        borrowedStudTab.Name = "borrowedStudTab"
        borrowedStudTab.RowHeadersWidth = 62
        borrowedStudTab.RowTemplate.Height = 25
        borrowedStudTab.Size = New Size(345, 86)
        borrowedStudTab.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(436, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 16)
        Label3.TabIndex = 4
        Label3.Text = "BORROWED BOOKS"
        ' 
        ' facultyTable
        ' 
        facultyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        facultyTable.GridColor = Color.White
        facultyTable.Location = New Point(30, 187)
        facultyTable.Name = "facultyTable"
        facultyTable.RowHeadersWidth = 62
        facultyTable.RowTemplate.Height = 25
        facultyTable.Size = New Size(345, 86)
        facultyTable.TabIndex = 5
        ' 
        ' borrowedFacTab
        ' 
        borrowedFacTab.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        borrowedFacTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowedFacTab.Location = New Point(427, 187)
        borrowedFacTab.Name = "borrowedFacTab"
        borrowedFacTab.RowHeadersWidth = 62
        borrowedFacTab.RowTemplate.Height = 25
        borrowedFacTab.Size = New Size(345, 86)
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
        Panel2.Location = New Point(238, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(809, 630)
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
        barButton.Location = New Point(762, 12)
        barButton.Name = "barButton"
        barButton.Size = New Size(35, 37)
        barButton.TabIndex = 22
        barButton.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(436, 485)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 16)
        Label7.TabIndex = 21
        Label7.Text = "ARCHIVE BOOKS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(30, 485)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 16)
        Label6.TabIndex = 20
        Label6.Text = "FAVORITES"
        ' 
        ' ArchiveBooksTable
        ' 
        ArchiveBooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ArchiveBooksTable.GridColor = Color.White
        ArchiveBooksTable.Location = New Point(436, 510)
        ArchiveBooksTable.Name = "ArchiveBooksTable"
        ArchiveBooksTable.RowHeadersWidth = 62
        ArchiveBooksTable.RowTemplate.Height = 25
        ArchiveBooksTable.Size = New Size(345, 86)
        ArchiveBooksTable.TabIndex = 17
        ' 
        ' favoritesTableLeft
        ' 
        favoritesTableLeft.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        favoritesTableLeft.GridColor = Color.White
        favoritesTableLeft.Location = New Point(30, 510)
        favoritesTableLeft.Name = "favoritesTableLeft"
        favoritesTableLeft.RowHeadersWidth = 62
        favoritesTableLeft.RowTemplate.Height = 25
        favoritesTableLeft.Size = New Size(345, 86)
        favoritesTableLeft.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(30, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 16)
        Label5.TabIndex = 11
        Label5.Text = "BOOKS"
        ' 
        ' booksTable
        ' 
        booksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        booksTable.GridColor = Color.White
        booksTable.Location = New Point(30, 329)
        booksTable.Name = "booksTable"
        booksTable.RowHeadersWidth = 62
        booksTable.RowTemplate.Height = 25
        booksTable.Size = New Size(751, 121)
        booksTable.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(371, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 16)
        Label4.TabIndex = 9
        Label4.Text = "BORROWED BOOKS"
        Label4.TextAlign = ContentAlignment.MiddleCenter
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
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(238, 44)
        IconButton1.TabIndex = 6
        IconButton1.Text = "LOGOUT"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 586)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(238, 44)
        Panel3.TabIndex = 7
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1047, 630)
        Controls.Add(Panel2)
        Controls.Add(dashPanel)
        Name = "Dashboard"
        Text = "Dashboard"
        dashPanel.ResumeLayout(False)
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
        Panel3.ResumeLayout(False)
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
End Class
