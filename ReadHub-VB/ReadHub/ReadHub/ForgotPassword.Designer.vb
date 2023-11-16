<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        loginPanel = New Panel()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        loginPanel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        loginPanel.Location = New Point(286, 208)
        loginPanel.Margin = New Padding(4, 5, 4, 5)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(873, 632)
        loginPanel.TabIndex = 1
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1443, 1050)
        Controls.Add(loginPanel)
        Name = "ForgotPassword"
        Text = "ForgotPassword"
        ResumeLayout(False)
    End Sub

    Friend WithEvents loginPanel As Panel
End Class
