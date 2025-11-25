<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        txtPass = New TextBox()
        btnLogin = New Button()
        Label2 = New Label()
        Label3 = New Label()
        btnRegister = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Zen Dots", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(56, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(696, 101)
        Label1.TabIndex = 0
        Label1.Text = "BUDGIE APP"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI", 25.8000011F)
        txtUser.Location = New Point(352, 147)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(380, 65)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 25.8000011F)
        txtPass.Location = New Point(352, 230)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "●"c
        txtPass.Size = New Size(380, 65)
        txtPass.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        btnLogin.Location = New Point(424, 336)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(166, 54)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22.2F)
        Label2.Location = New Point(107, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 50)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 22.2F)
        Label3.Location = New Point(111, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 50)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        btnRegister.Location = New Point(180, 336)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(166, 54)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(803, 429)
        Controls.Add(btnRegister)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label1)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Budgie Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegister As Button
End Class
