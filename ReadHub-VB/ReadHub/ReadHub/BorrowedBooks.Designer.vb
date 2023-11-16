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
        S = New Panel()
        IconButton7 = New FontAwesome.Sharp.IconButton()
        IconButton6 = New FontAwesome.Sharp.IconButton()
        BBID1 = New TextBox()
        FA1 = New TextBox()
        FSID1 = New TextBox()
        RD1 = New TextBox()
        DB1 = New TextBox()
        BID1 = New TextBox()
        UID1 = New TextBox()
        BBID2 = New TextBox()
        ComboBox2 = New ComboBox()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        IconButton5 = New FontAwesome.Sharp.IconButton()
        FA2 = New TextBox()
        FSID2 = New TextBox()
        RD2 = New TextBox()
        DB2 = New TextBox()
        BID2 = New TextBox()
        UID2 = New TextBox()
        ComboBox1 = New ComboBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        Label5 = New Label()
        BorrowedBooksEmployee = New DataGridView()
        Label3 = New Label()
        amendButton = New FontAwesome.Sharp.IconButton()
        appendButton = New FontAwesome.Sharp.IconButton()
        barButton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        borrowedstudTable = New DataGridView()
        borrowedPanel.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        S.SuspendLayout()
        CType(BorrowedBooksEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(borrowedstudTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' borrowedPanel
        ' 
        borrowedPanel.BackColor = SystemColors.Highlight
        borrowedPanel.Controls.Add(Panel3)
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
        ' Panel3
        ' 
        Panel3.Controls.Add(IconButton1)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 977)
        Panel3.Margin = New Padding(4, 5, 4, 5)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(340, 73)
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
        ' S
        ' 
        S.Controls.Add(IconButton7)
        S.Controls.Add(IconButton6)
        S.Controls.Add(BBID1)
        S.Controls.Add(FA1)
        S.Controls.Add(FSID1)
        S.Controls.Add(RD1)
        S.Controls.Add(DB1)
        S.Controls.Add(BID1)
        S.Controls.Add(UID1)
        S.Controls.Add(BBID2)
        S.Controls.Add(ComboBox2)
        S.Controls.Add(IconButton3)
        S.Controls.Add(IconButton4)
        S.Controls.Add(IconButton5)
        S.Controls.Add(FA2)
        S.Controls.Add(FSID2)
        S.Controls.Add(RD2)
        S.Controls.Add(DB2)
        S.Controls.Add(BID2)
        S.Controls.Add(UID2)
        S.Controls.Add(ComboBox1)
        S.Controls.Add(IconButton2)
        S.Controls.Add(Label5)
        S.Controls.Add(BorrowedBooksEmployee)
        S.Controls.Add(Label3)
        S.Controls.Add(amendButton)
        S.Controls.Add(appendButton)
        S.Controls.Add(barButton)
        S.Controls.Add(Label2)
        S.Controls.Add(borrowedstudTable)
        S.Dock = DockStyle.Fill
        S.Location = New Point(340, 0)
        S.Margin = New Padding(4, 5, 4, 5)
        S.Name = "S"
        S.Size = New Size(1156, 1050)
        S.TabIndex = 16
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
        IconButton7.Location = New Point(615, 121)
        IconButton7.Margin = New Padding(4, 5, 4, 5)
        IconButton7.Name = "IconButton7"
        IconButton7.Size = New Size(95, 38)
        IconButton7.TabIndex = 70
        IconButton7.Text = "SELECT"
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
        IconButton6.Location = New Point(615, 534)
        IconButton6.Margin = New Padding(4, 5, 4, 5)
        IconButton6.Name = "IconButton6"
        IconButton6.Size = New Size(95, 38)
        IconButton6.TabIndex = 69
        IconButton6.Text = "SELECT"
        IconButton6.UseVisualStyleBackColor = False
        ' 
        ' BBID1
        ' 
        BBID1.Location = New Point(149, 455)
        BBID1.Name = "BBID1"
        BBID1.Size = New Size(130, 31)
        BBID1.TabIndex = 63
        BBID1.Text = "BorrowedBooks_ID"
        ' 
        ' FA1
        ' 
        FA1.Location = New Point(965, 455)
        FA1.Name = "FA1"
        FA1.Size = New Size(130, 31)
        FA1.TabIndex = 68
        FA1.Text = "Fine_Amount"
        ' 
        ' FSID1
        ' 
        FSID1.Location = New Point(829, 455)
        FSID1.Name = "FSID1"
        FSID1.Size = New Size(130, 31)
        FSID1.TabIndex = 67
        FSID1.Text = "Fine_Status_ID"
        ' 
        ' RD1
        ' 
        RD1.Location = New Point(693, 455)
        RD1.Name = "RD1"
        RD1.Size = New Size(130, 31)
        RD1.TabIndex = 66
        RD1.Text = "Return_Date"
        ' 
        ' DB1
        ' 
        DB1.Location = New Point(557, 455)
        DB1.Name = "DB1"
        DB1.Size = New Size(130, 31)
        DB1.TabIndex = 65
        DB1.Text = "Date_Borrowed"
        ' 
        ' BID1
        ' 
        BID1.Location = New Point(421, 455)
        BID1.Name = "BID1"
        BID1.Size = New Size(130, 31)
        BID1.TabIndex = 64
        BID1.Text = "Book_ID"
        ' 
        ' UID1
        ' 
        UID1.Location = New Point(285, 455)
        UID1.Name = "UID1"
        UID1.Size = New Size(130, 31)
        UID1.TabIndex = 62
        UID1.Text = "User_ID"
        ' 
        ' BBID2
        ' 
        BBID2.Location = New Point(149, 870)
        BBID2.Name = "BBID2"
        BBID2.Size = New Size(130, 31)
        BBID2.TabIndex = 55
        BBID2.Text = "BorrowedBooks_ID"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.Tomato
        ComboBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.ItemHeight = 22
        ComboBox2.Items.AddRange(New Object() {"Paid", "Unpaid", "Pending", "Partial Payment"})
        ComboBox2.Location = New Point(436, 121)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(172, 30)
        ComboBox2.TabIndex = 54
        ComboBox2.Tag = ""
        ComboBox2.Text = "FINE STATUS"
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
        IconButton3.Location = New Point(832, 121)
        IconButton3.Margin = New Padding(4, 5, 4, 5)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(133, 38)
        IconButton3.TabIndex = 53
        IconButton3.Text = "RETURNED"
        IconButton3.UseVisualStyleBackColor = False
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
        IconButton4.Location = New Point(717, 121)
        IconButton4.Margin = New Padding(4, 5, 4, 5)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(107, 38)
        IconButton4.TabIndex = 52
        IconButton4.Text = "AMEND"
        IconButton4.UseVisualStyleBackColor = False
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
        IconButton5.Location = New Point(973, 121)
        IconButton5.Margin = New Padding(4, 5, 4, 5)
        IconButton5.Name = "IconButton5"
        IconButton5.Size = New Size(122, 38)
        IconButton5.TabIndex = 51
        IconButton5.Text = "REFRESH"
        IconButton5.UseVisualStyleBackColor = False
        ' 
        ' FA2
        ' 
        FA2.Location = New Point(965, 870)
        FA2.Name = "FA2"
        FA2.Size = New Size(130, 31)
        FA2.TabIndex = 61
        FA2.Text = "Fine_Amount"
        ' 
        ' FSID2
        ' 
        FSID2.Location = New Point(829, 870)
        FSID2.Name = "FSID2"
        FSID2.Size = New Size(130, 31)
        FSID2.TabIndex = 60
        FSID2.Text = "Fine_Status_ID"
        ' 
        ' RD2
        ' 
        RD2.Location = New Point(693, 870)
        RD2.Name = "RD2"
        RD2.Size = New Size(130, 31)
        RD2.TabIndex = 59
        RD2.Text = "Return_Date"
        ' 
        ' DB2
        ' 
        DB2.Location = New Point(557, 870)
        DB2.Name = "DB2"
        DB2.Size = New Size(130, 31)
        DB2.TabIndex = 58
        DB2.Text = "Date_Borrowed"
        ' 
        ' BID2
        ' 
        BID2.Location = New Point(421, 870)
        BID2.Name = "BID2"
        BID2.Size = New Size(130, 31)
        BID2.TabIndex = 57
        BID2.Text = "Book_ID"
        ' 
        ' UID2
        ' 
        UID2.Location = New Point(285, 870)
        UID2.Name = "UID2"
        UID2.Size = New Size(130, 31)
        UID2.TabIndex = 56
        UID2.Text = "User_ID"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Tomato
        ComboBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.ItemHeight = 22
        ComboBox1.Items.AddRange(New Object() {"Paid", "Unpaid", "Pending", "Partial Payment"})
        ComboBox1.Location = New Point(436, 534)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(172, 30)
        ComboBox1.TabIndex = 33
        ComboBox1.Tag = ""
        ComboBox1.Text = "FINE STATUS"
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
        IconButton2.Location = New Point(832, 534)
        IconButton2.Margin = New Padding(4, 5, 4, 5)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(133, 38)
        IconButton2.TabIndex = 31
        IconButton2.Text = "RETURNED"
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(66, 547)
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
        BorrowedBooksEmployee.Location = New Point(66, 582)
        BorrowedBooksEmployee.Margin = New Padding(4, 5, 4, 5)
        BorrowedBooksEmployee.Name = "BorrowedBooksEmployee"
        BorrowedBooksEmployee.RowHeadersWidth = 62
        BorrowedBooksEmployee.RowTemplate.Height = 25
        BorrowedBooksEmployee.Size = New Size(1029, 280)
        BorrowedBooksEmployee.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Bebas Neue", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(66, 20)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 48)
        Label3.TabIndex = 28
        Label3.Text = "BORROWED BOOKS"
        Label3.TextAlign = ContentAlignment.MiddleCenter
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
        amendButton.Location = New Point(717, 534)
        amendButton.Margin = New Padding(4, 5, 4, 5)
        amendButton.Name = "amendButton"
        amendButton.Size = New Size(107, 38)
        amendButton.TabIndex = 26
        amendButton.Text = "AMEND"
        amendButton.UseVisualStyleBackColor = False
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
        appendButton.Location = New Point(973, 534)
        appendButton.Margin = New Padding(4, 5, 4, 5)
        appendButton.Name = "appendButton"
        appendButton.Size = New Size(122, 38)
        appendButton.TabIndex = 24
        appendButton.Text = "REFRESH"
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
        Label2.Location = New Point(66, 131)
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
        borrowedstudTable.Location = New Point(66, 167)
        borrowedstudTable.Margin = New Padding(4, 5, 4, 5)
        borrowedstudTable.Name = "borrowedstudTable"
        borrowedstudTable.RowHeadersWidth = 62
        borrowedstudTable.RowTemplate.Height = 25
        borrowedstudTable.Size = New Size(1029, 280)
        borrowedstudTable.TabIndex = 11
        ' 
        ' BorrowedBooks
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1496, 1050)
        Controls.Add(S)
        Controls.Add(borrowedPanel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "BorrowedBooks"
        Text = "z"
        borrowedPanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        S.ResumeLayout(False)
        S.PerformLayout()
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
    Friend WithEvents S As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents amendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents appendButton As FontAwesome.Sharp.IconButton
    Friend WithEvents barButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents borrowedstudTable As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents BorrowedBooksEmployee As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents BBID2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents FA2 As TextBox
    Friend WithEvents FSID2 As TextBox
    Friend WithEvents RD2 As TextBox
    Friend WithEvents DB2 As TextBox
    Friend WithEvents BID2 As TextBox
    Friend WithEvents UID2 As TextBox
    Friend WithEvents UID1 As TextBox
    Friend WithEvents BBID1 As TextBox
    Friend WithEvents FA1 As TextBox
    Friend WithEvents FSID1 As TextBox
    Friend WithEvents RD1 As TextBox
    Friend WithEvents DB1 As TextBox
    Friend WithEvents BID1 As TextBox
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
End Class
