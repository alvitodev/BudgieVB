<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Label1 = New Label()
        txtUser = New TextBox()
        Label2 = New Label()
        txtPass = New TextBox()
        txtNama = New TextBox()
        txtConfirm = New TextBox()
        btnRegister = New Button()
        lblToLogin = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F)
        Label1.Location = New Point(256, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtUser.Location = New Point(383, 167)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(276, 38)
        txtUser.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F)
        Label2.Location = New Point(214, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 31)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtPass.Location = New Point(383, 226)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "●"c
        txtPass.Size = New Size(276, 38)
        txtPass.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtNama.Location = New Point(383, 108)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(276, 38)
        txtNama.TabIndex = 4
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtConfirm.Location = New Point(383, 289)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.PasswordChar = "●"c
        txtConfirm.Size = New Size(276, 38)
        txtConfirm.TabIndex = 5
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.Location = New Point(294, 349)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(135, 43)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' lblToLogin
        ' 
        lblToLogin.AutoSize = True
        lblToLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblToLogin.LinkColor = Color.White
        lblToLogin.Location = New Point(244, 399)
        lblToLogin.Name = "lblToLogin"
        lblToLogin.Size = New Size(236, 28)
        lblToLogin.TabIndex = 7
        lblToLogin.TabStop = True
        lblToLogin.Text = "Sudah punya akun? Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F)
        Label3.Location = New Point(221, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 31)
        Label3.TabIndex = 8
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F)
        Label4.Location = New Point(134, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 31)
        Label4.TabIndex = 9
        Label4.Text = "Confirm Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Zen Dots", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(167, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(416, 59)
        Label5.TabIndex = 10
        Label5.Text = "BUDGIE APP"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblToLogin)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirm)
        Controls.Add(txtNama)
        Controls.Add(txtPass)
        Controls.Add(Label2)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblToLogin As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
