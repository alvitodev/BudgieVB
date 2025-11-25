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
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label1.Location = New Point(177, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 38)
        Label1.TabIndex = 0
        Label1.Text = "Nama Target"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        txtNama.Location = New Point(45, 78)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(463, 43)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label2.Location = New Point(141, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(254, 38)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah Target (Rp)"
        ' 
        ' numTarget
        ' 
        numTarget.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        numTarget.Location = New Point(45, 188)
        numTarget.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numTarget.Name = "numTarget"
        numTarget.Size = New Size(463, 43)
        numTarget.TabIndex = 3
        ' 
        ' dtpTarget
        ' 
        dtpTarget.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTarget.Location = New Point(45, 298)
        dtpTarget.Name = "dtpTarget"
        dtpTarget.Size = New Size(463, 43)
        dtpTarget.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(186, 360)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(159, 51)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Label3.Location = New Point(166, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(209, 38)
        Label3.TabIndex = 6
        Label3.Text = "Tenggat Waktu"
        ' 
        ' frmAddGoal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 427)
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
