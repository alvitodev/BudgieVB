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
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(121, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 31)
        Label1.TabIndex = 0
        Label1.Text = "Nama Anggaran"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        txtNama.Location = New Point(32, 67)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(357, 38)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(135, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 31)
        Label2.TabIndex = 2
        Label2.Text = "Batas Rupiah"
        ' 
        ' numLimit
        ' 
        numLimit.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        numLimit.Location = New Point(32, 183)
        numLimit.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numLimit.Name = "numLimit"
        numLimit.Size = New Size(357, 38)
        numLimit.TabIndex = 3
        numLimit.ThousandsSeparator = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(141, 253)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(135, 44)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' frmAddBudget
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 321)
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
