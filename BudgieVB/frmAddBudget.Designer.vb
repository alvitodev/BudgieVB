<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBudget
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
        txtNama = New TextBox()
        Label2 = New Label()
        numLimit = New NumericUpDown()
        btnSimpan = New Button()
        CType(numLimit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(199, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Anggaran"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(192, 159)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(216, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 2
        Label2.Text = "Batas Rupiah"
        ' 
        ' numLimit
        ' 
        numLimit.Location = New Point(183, 295)
        numLimit.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numLimit.Name = "numLimit"
        numLimit.Size = New Size(200, 27)
        numLimit.TabIndex = 3
        numLimit.ThousandsSeparator = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(664, 385)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' frmAddBudget
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSimpan)
        Controls.Add(numLimit)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "frmAddBudget"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddBudget"
        CType(numLimit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numLimit As NumericUpDown
    Friend WithEvents btnSimpan As Button
End Class
