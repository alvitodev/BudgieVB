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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(339, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(294, 167)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(125, 27)
        txtUser.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(313, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(294, 243)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "●"c
        txtPass.Size = New Size(125, 27)
        txtPass.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(294, 87)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 4
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(294, 306)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.PasswordChar = "●"c
        txtConfirm.Size = New Size(125, 27)
        txtConfirm.TabIndex = 5
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(313, 360)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' lblToLogin
        ' 
        lblToLogin.AutoSize = True
        lblToLogin.Location = New Point(258, 406)
        lblToLogin.Name = "lblToLogin"
        lblToLogin.Size = New Size(177, 20)
        lblToLogin.TabIndex = 7
        lblToLogin.TabStop = True
        lblToLogin.Text = "Sudah punya akun? Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(318, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 8
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(294, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 20)
        Label4.TabIndex = 9
        Label4.Text = "Confirm Password"
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
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
End Class
