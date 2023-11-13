<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archives
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
        archivePanel = New Panel()
        borrowButton = New FontAwesome.Sharp.IconButton()
        archiveButton = New FontAwesome.Sharp.IconButton()
        userButton = New FontAwesome.Sharp.IconButton()
        bookButton = New FontAwesome.Sharp.IconButton()
        dashButton = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        exploreButton = New FontAwesome.Sharp.IconButton()
        amendButton = New FontAwesome.Sharp.IconButton()
        discardButton = New FontAwesome.Sharp.IconButton()
        appendButton = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        archiveTable = New DataGridView()
        Label4 = New Label()
        Panel3 = New Panel()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        archivePanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(archiveTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' archivePanel
        ' 
        archivePanel.BackColor = SystemColors.Highlight
        archivePanel.Controls.Add(Panel3)
        archivePanel.Controls.Add(borrowButton)
        archivePanel.Controls.Add(archiveButton)
        archivePanel.Controls.Add(userButton)
        archivePanel.Controls.Add(bookButton)
        archivePanel.Controls.Add(dashButton)
        archivePanel.Controls.Add(Panel1)
        archivePanel.Dock = DockStyle.Left
        archivePanel.Location = New Point(0, 0)
        archivePanel.Name = "archivePanel"
        archivePanel.Size = New Size(238, 630)
        archivePanel.TabIndex = 14
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
        archiveButton.Location = New Point(0, 256)
        archiveButton.Name = "archiveButton"
        archiveButton.Size = New Size(238, 49)
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
        userButton.Location = New Point(0, 207)
        userButton.Name = "userButton"
        userButton.Size = New Size(238, 49)
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
        bookButton.Location = New Point(0, 158)
        bookButton.Name = "bookButton"
        bookButton.Size = New Size(238, 49)
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
        dashButton.Location = New Point(0, 109)
        dashButton.Name = "dashButton"
        dashButton.Size = New Size(238, 49)
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 109)
        Panel1.TabIndex = 6
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
        ' Panel2
        ' 
        Panel2.Controls.Add(IconButton7)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(exploreButton)
        Panel2.Controls.Add(amendButton)
        Panel2.Controls.Add(discardButton)
        Panel2.Controls.Add(appendButton)
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(archiveTable)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(238, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(809, 630)
        Panel2.TabIndex = 15
        ' 
        ' IconButton7
        ' 
        IconButton7.BackColor = Color.Tomato
        IconButton7.Cursor = Cursors.Hand
        IconButton7.FlatAppearance.BorderSize = 0
        IconButton7.FlatStyle = FlatStyle.Flat
        IconButton7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton7.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton7.IconColor = Color.Black
        IconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton7.Location = New Point(685, 79)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(83, 23)
        IconButton7.TabIndex = 42
        IconButton7.Text = "REFRESH"
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(371, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 16)
        Label3.TabIndex = 28
        Label3.Text = "ARCHIVE ACCOUNT"
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
        exploreButton.Location = New Point(685, 583)
        exploreButton.Name = "exploreButton"
        exploreButton.Size = New Size(82, 23)
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
        amendButton.Location = New Point(604, 583)
        amendButton.Name = "amendButton"
        amendButton.Size = New Size(75, 23)
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
        discardButton.Location = New Point(523, 583)
        discardButton.Name = "discardButton"
        discardButton.Size = New Size(75, 23)
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
        appendButton.Location = New Point(442, 583)
        appendButton.Name = "appendButton"
        appendButton.Size = New Size(75, 23)
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
        barButton.Location = New Point(762, 12)
        barButton.Name = "barButton"
        barButton.Size = New Size(35, 37)
        barButton.TabIndex = 23
        barButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(47, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 16)
        Label2.TabIndex = 12
        Label2.Text = "ARCHIVE BOOKS"
        ' 
        ' archiveTable
        ' 
        archiveTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        archiveTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        archiveTable.GridColor = Color.White
        archiveTable.Location = New Point(47, 109)
        archiveTable.Name = "archiveTable"
        archiveTable.RowHeadersWidth = 62
        archiveTable.RowTemplate.Height = 25
        archiveTable.Size = New Size(720, 468)
        archiveTable.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(371, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 10
        Label4.Text = "BOOKS"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 586)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(238, 44)
        Panel3.TabIndex = 12
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
        ' Archives
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1047, 630)
        Controls.Add(Panel2)
        Controls.Add(archivePanel)
        Name = "Archives"
        Text = "Archives"
        archivePanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(archiveTable, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents archivePanel As Panel
    Friend WithEvents borrowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents archiveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents userButton As FontAwesome.Sharp.IconButton
    Friend WithEvents bookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents dashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exploreButton As FontAwesome.Sharp.IconButton
    Friend WithEvents amendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents discardButton As FontAwesome.Sharp.IconButton
    Friend WithEvents appendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents archiveTable As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
