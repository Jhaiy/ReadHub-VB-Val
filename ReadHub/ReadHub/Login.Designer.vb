<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        loginPanel = New Panel()
        loginButton = New FontAwesome.Sharp.IconButton()
        Label8 = New Label()
        TextBox2 = New TextBox()
        passwordLbl = New Label()
        TextBox1 = New TextBox()
        emailLbl = New Label()
        adminLbl = New Label()
        loginLbl = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        loginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        loginPanel.Controls.Add(loginButton)
        loginPanel.Controls.Add(Label8)
        loginPanel.Controls.Add(TextBox2)
        loginPanel.Controls.Add(passwordLbl)
        loginPanel.Controls.Add(TextBox1)
        loginPanel.Controls.Add(emailLbl)
        loginPanel.Controls.Add(adminLbl)
        loginPanel.Controls.Add(loginLbl)
        loginPanel.Dock = DockStyle.Right
        loginPanel.Location = New Point(918, 0)
        loginPanel.Margin = New Padding(4, 5, 4, 5)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(521, 1047)
        loginPanel.TabIndex = 0
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.LightBlue
        loginButton.Cursor = Cursors.Hand
        loginButton.FlatAppearance.BorderSize = 0
        loginButton.FlatStyle = FlatStyle.Flat
        loginButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        loginButton.ForeColor = Color.White
        loginButton.IconChar = FontAwesome.Sharp.IconChar.None
        loginButton.IconColor = Color.Black
        loginButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        loginButton.Location = New Point(70, 677)
        loginButton.Margin = New Padding(4, 5, 4, 5)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(389, 58)
        loginButton.TabIndex = 11
        loginButton.Text = "LOGIN"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.BackColor = Color.Transparent
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.ForeColor = Color.Tomato
        Label8.Location = New Point(158, 616)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(203, 38)
        Label8.TabIndex = 10
        Label8.Text = "FORGOT PASSWORD?"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(70, 529)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(389, 48)
        TextBox2.TabIndex = 9
        ' 
        ' passwordLbl
        ' 
        passwordLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        passwordLbl.BackColor = Color.Transparent
        passwordLbl.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        passwordLbl.ForeColor = Color.Black
        passwordLbl.Location = New Point(158, 486)
        passwordLbl.Margin = New Padding(4, 0, 4, 0)
        passwordLbl.Name = "passwordLbl"
        passwordLbl.Size = New Size(203, 38)
        passwordLbl.TabIndex = 8
        passwordLbl.Text = "PASSWORD"
        passwordLbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(70, 402)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(389, 48)
        TextBox1.TabIndex = 7
        TextBox1.Text = " "
        ' 
        ' emailLbl
        ' 
        emailLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        emailLbl.BackColor = Color.Transparent
        emailLbl.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        emailLbl.ForeColor = Color.Black
        emailLbl.Location = New Point(158, 359)
        emailLbl.Margin = New Padding(4, 0, 4, 0)
        emailLbl.Name = "emailLbl"
        emailLbl.Size = New Size(203, 38)
        emailLbl.TabIndex = 6
        emailLbl.Text = "EMAIL"
        emailLbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' adminLbl
        ' 
        adminLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        adminLbl.BackColor = Color.Transparent
        adminLbl.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        adminLbl.ForeColor = Color.Black
        adminLbl.Location = New Point(158, 291)
        adminLbl.Margin = New Padding(4, 0, 4, 0)
        adminLbl.Name = "adminLbl"
        adminLbl.Size = New Size(203, 38)
        adminLbl.TabIndex = 5
        adminLbl.Text = "ADMIN"
        adminLbl.TextAlign = ContentAlignment.TopCenter
        ' 
        ' loginLbl
        ' 
        loginLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        loginLbl.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        loginLbl.ForeColor = Color.Black
        loginLbl.Location = New Point(158, 216)
        loginLbl.Margin = New Padding(4, 0, 4, 0)
        loginLbl.Name = "loginLbl"
        loginLbl.Size = New Size(203, 97)
        loginLbl.TabIndex = 4
        loginLbl.Text = "LOGIN"
        loginLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(33, 40)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 128)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME BACK,"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Bebas Neue", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(360, 447)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 75)
        Label2.TabIndex = 2
        Label2.Text = "READHUB"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(186, 467)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(523, 187)
        Label3.TabIndex = 3
        Label3.Text = "ENTER YOUR PERSONAL DETAILS AND START JOURNEY WITH US"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1439, 1047)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(loginPanel)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Login"
        Text = "ReadHub"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loginPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents loginLbl As Label
    Friend WithEvents adminLbl As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents passwordLbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents emailLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents loginButton As FontAwesome.Sharp.IconButton
End Class
