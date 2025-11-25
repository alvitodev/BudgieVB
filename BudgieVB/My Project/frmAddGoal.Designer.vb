<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddGoal
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
        numTarget = New NumericUpDown()
        dtpTarget = New DateTimePicker()
        btnSimpan = New Button()
        Label3 = New Label()
        CType(numTarget, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama Target"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(130, 167)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(161, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Target (Rp)"
        ' 
        ' numTarget
        ' 
        numTarget.Location = New Point(151, 311)
        numTarget.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numTarget.Name = "numTarget"
        numTarget.Size = New Size(150, 27)
        numTarget.TabIndex = 3
        ' 
        ' dtpTarget
        ' 
        dtpTarget.Location = New Point(334, 364)
        dtpTarget.Name = "dtpTarget"
        dtpTarget.Size = New Size(250, 27)
        dtpTarget.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(681, 397)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(413, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 6
        Label3.Text = "Tenggat Waktu"
        ' 
        ' frmAddGoal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(btnSimpan)
        Controls.Add(dtpTarget)
        Controls.Add(numTarget)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Name = "frmAddGoal"
        Text = "frmAddGoal"
        CType(numTarget, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numTarget As NumericUpDown
    Friend WithEvents dtpTarget As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label3 As Label
End Class
