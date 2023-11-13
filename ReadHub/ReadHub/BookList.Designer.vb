<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookList
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
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        bookPanel = New Panel()
        borrowButton = New FontAwesome.Sharp.IconButton()
        archiveButton = New FontAwesome.Sharp.IconButton()
        userButton = New FontAwesome.Sharp.IconButton()
        bookButton = New FontAwesome.Sharp.IconButton()
        dashButton = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        BTB = New TextBox()
        TTB = New TextBox()
        ATB = New TextBox()
        CTB = New TextBox()
        DTB = New TextBox()
        YTB = New TextBox()
        amendButton = New FontAwesome.Sharp.IconButton()
        discardButton = New FontAwesome.Sharp.IconButton()
        appendButton = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        booksTable = New DataGridView()
        Label4 = New Label()
        Panel3 = New Panel()
        IconButton8 = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        bookPanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(booksTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
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
        ' bookPanel
        ' 
        bookPanel.BackColor = SystemColors.Highlight
        bookPanel.Controls.Add(Panel3)
        bookPanel.Controls.Add(borrowButton)
        bookPanel.Controls.Add(archiveButton)
        bookPanel.Controls.Add(userButton)
        bookPanel.Controls.Add(bookButton)
        bookPanel.Controls.Add(dashButton)
        bookPanel.Controls.Add(Panel1)
        bookPanel.Dock = DockStyle.Left
        bookPanel.Location = New Point(0, 0)
        bookPanel.Name = "bookPanel"
        bookPanel.Size = New Size(238, 630)
        bookPanel.TabIndex = 12
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
        ' Panel2
        ' 
        Panel2.Controls.Add(IconButton7)
        Panel2.Controls.Add(IconButton6)
        Panel2.Controls.Add(IconButton5)
        Panel2.Controls.Add(IconButton4)
        Panel2.Controls.Add(IconButton3)
        Panel2.Controls.Add(IconButton2)
        Panel2.Controls.Add(IconButton1)
        Panel2.Controls.Add(BTB)
        Panel2.Controls.Add(TTB)
        Panel2.Controls.Add(ATB)
        Panel2.Controls.Add(CTB)
        Panel2.Controls.Add(DTB)
        Panel2.Controls.Add(YTB)
        Panel2.Controls.Add(amendButton)
        Panel2.Controls.Add(discardButton)
        Panel2.Controls.Add(appendButton)
        Panel2.Controls.Add(barButton)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(booksTable)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(238, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(809, 630)
        Panel2.TabIndex = 13
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
        IconButton7.Location = New Point(167, 128)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(75, 23)
        IconButton7.TabIndex = 41
        IconButton7.Text = "HORROR"
        IconButton7.UseVisualStyleBackColor = False
        ' 
        ' IconButton6
        ' 
        IconButton6.BackColor = Color.Tomato
        IconButton6.Cursor = Cursors.Hand
        IconButton6.FlatAppearance.BorderSize = 0
        IconButton6.FlatStyle = FlatStyle.Flat
        IconButton6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton6.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton6.IconColor = Color.Black
        IconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton6.Location = New Point(248, 128)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(80, 23)
        IconButton6.TabIndex = 40
        IconButton6.Text = "MYSTERY"
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' IconButton5
        ' 
        IconButton5.BackColor = Color.Tomato
        IconButton5.Cursor = Cursors.Hand
        IconButton5.FlatAppearance.BorderSize = 0
        IconButton5.FlatStyle = FlatStyle.Flat
        IconButton5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton5.IconColor = Color.Black
        IconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton5.Location = New Point(690, 128)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(75, 23)
        IconButton5.TabIndex = 39
        IconButton5.Text = "SCI-FI"
        IconButton5.UseVisualStyleBackColor = False
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.Tomato
        IconButton4.Cursor = Cursors.Hand
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton4.IconColor = Color.Black
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.Location = New Point(333, 128)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(83, 23)
        IconButton4.TabIndex = 38
        IconButton4.Text = "ROMANCE"
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.Tomato
        IconButton3.Cursor = Cursors.Hand
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.Location = New Point(592, 128)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(92, 23)
        IconButton3.TabIndex = 37
        IconButton3.Text = "ACADEMICS"
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.Tomato
        IconButton2.Cursor = Cursors.Hand
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.Location = New Point(511, 128)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(75, 23)
        IconButton2.TabIndex = 36
        IconButton2.Text = "HISTORY"
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.Tomato
        IconButton1.Cursor = Cursors.Hand
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(422, 128)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(83, 23)
        IconButton1.TabIndex = 35
        IconButton1.Text = "FANTASY"
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' BTB
        ' 
        BTB.BackColor = Color.MistyRose
        BTB.BorderStyle = BorderStyle.None
        BTB.Cursor = Cursors.IBeam
        BTB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        BTB.ForeColor = Color.Black
        BTB.Location = New Point(287, 548)
        BTB.Multiline = True
        BTB.Name = "BTB"
        BTB.Size = New Size(75, 23)
        BTB.TabIndex = 34
        BTB.Text = "Book_ID"
        ' 
        ' TTB
        ' 
        TTB.BackColor = Color.MistyRose
        TTB.BorderStyle = BorderStyle.None
        TTB.Cursor = Cursors.IBeam
        TTB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        TTB.ForeColor = Color.Black
        TTB.Location = New Point(368, 548)
        TTB.Multiline = True
        TTB.Name = "TTB"
        TTB.Size = New Size(75, 23)
        TTB.TabIndex = 33
        TTB.Text = "Title"
        ' 
        ' ATB
        ' 
        ATB.BackColor = Color.MistyRose
        ATB.BorderStyle = BorderStyle.None
        ATB.Cursor = Cursors.IBeam
        ATB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        ATB.ForeColor = Color.Black
        ATB.Location = New Point(448, 548)
        ATB.Multiline = True
        ATB.Name = "ATB"
        ATB.Size = New Size(75, 23)
        ATB.TabIndex = 32
        ATB.Text = "Author"
        ' 
        ' CTB
        ' 
        CTB.BackColor = Color.MistyRose
        CTB.BorderStyle = BorderStyle.None
        CTB.Cursor = Cursors.IBeam
        CTB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        CTB.ForeColor = Color.Black
        CTB.Location = New Point(529, 548)
        CTB.Multiline = True
        CTB.Name = "CTB"
        CTB.Size = New Size(75, 23)
        CTB.TabIndex = 31
        CTB.Text = "Category_ID"
        ' 
        ' DTB
        ' 
        DTB.BackColor = Color.MistyRose
        DTB.BorderStyle = BorderStyle.None
        DTB.Cursor = Cursors.IBeam
        DTB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DTB.ForeColor = Color.Black
        DTB.Location = New Point(610, 548)
        DTB.Multiline = True
        DTB.Name = "DTB"
        DTB.Size = New Size(75, 23)
        DTB.TabIndex = 30
        DTB.Text = "Description"
        ' 
        ' YTB
        ' 
        YTB.BackColor = Color.MistyRose
        YTB.BorderStyle = BorderStyle.None
        YTB.Cursor = Cursors.IBeam
        YTB.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        YTB.ForeColor = Color.Black
        YTB.Location = New Point(690, 548)
        YTB.Multiline = True
        YTB.Name = "YTB"
        YTB.Size = New Size(75, 23)
        YTB.TabIndex = 29
        YTB.Text = "Year_Published"
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
        amendButton.Location = New Point(690, 584)
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
        discardButton.Location = New Point(609, 584)
        discardButton.Name = "discardButton"
        discardButton.Size = New Size(75, 23)
        discardButton.TabIndex = 25
        discardButton.Text = "ARCHIVE"
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
        appendButton.Location = New Point(529, 584)
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
        Label2.Location = New Point(45, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 16)
        Label2.TabIndex = 12
        Label2.Text = "BOOK LIST"
        ' 
        ' booksTable
        ' 
        booksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        booksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        booksTable.GridColor = Color.White
        booksTable.Location = New Point(45, 158)
        booksTable.Name = "booksTable"
        booksTable.RowHeadersWidth = 62
        booksTable.RowTemplate.Height = 25
        booksTable.Size = New Size(720, 374)
        booksTable.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(371, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 10
        Label4.Text = "BOOKS"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton8)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 586)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(238, 44)
        Panel3.TabIndex = 12
        ' 
        ' IconButton8
        ' 
        IconButton8.Dock = DockStyle.Fill
        IconButton8.FlatAppearance.BorderSize = 0
        IconButton8.FlatStyle = FlatStyle.Flat
        IconButton8.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        IconButton8.ForeColor = Color.White
        IconButton8.IconChar = FontAwesome.Sharp.IconChar.None
        IconButton8.IconColor = Color.Black
        IconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton8.Location = New Point(0, 0)
        IconButton8.Name = "IconButton8"
        IconButton8.Size = New Size(238, 44)
        IconButton8.TabIndex = 6
        IconButton8.Text = "LOGOUT"
        IconButton8.UseVisualStyleBackColor = True
        ' 
        ' BookList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1047, 630)
        Controls.Add(Panel2)
        Controls.Add(bookPanel)
        Name = "BookList"
        Text = "BookList"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        bookPanel.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(booksTable, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bookPanel As Panel
    Friend WithEvents borrowButton As FontAwesome.Sharp.IconButton
    Friend WithEvents archiveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents userButton As FontAwesome.Sharp.IconButton
    Friend WithEvents bookButton As FontAwesome.Sharp.IconButton
    Friend WithEvents dashButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents booksTable As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents amendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents discardButton As FontAwesome.Sharp.IconButton
    Friend WithEvents appendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents ATB As TextBox
    Friend WithEvents CTB As TextBox
    Friend WithEvents DTB As TextBox
    Friend WithEvents YTB As TextBox
    Friend WithEvents BTB As TextBox
    Friend WithEvents TTB As TextBox
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
End Class
