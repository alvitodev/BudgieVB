<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAccount
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
        lblnamaakun = New Label()
        Label1 = New Label()
        txtNama = New TextBox()
        numSaldo = New NumericUpDown()
        Label2 = New Label()
        cmbCurrency = New ComboBox()
        Label3 = New Label()
        btnWarna = New Button()
        btnSimpan = New Button()
        CType(numSaldo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblnamaakun
        ' 
        lblnamaakun.AutoSize = True
        lblnamaakun.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        lblnamaakun.Location = New Point(52, 51)
        lblnamaakun.Name = "lblnamaakun"
        lblnamaakun.Size = New Size(135, 31)
        lblnamaakun.TabIndex = 0
        lblnamaakun.Text = "Nama Akun"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(58, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 31)
        Label1.TabIndex = 1
        Label1.Text = "Saldo Awal"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 13.8F)
        txtNama.Location = New Point(229, 44)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(285, 38)
        txtNama.TabIndex = 2
        ' 
        ' numSaldo
        ' 
        numSaldo.Font = New Font("Segoe UI", 13.8F)
        numSaldo.Location = New Point(228, 114)
        numSaldo.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        numSaldo.Name = "numSaldo"
        numSaldo.Size = New Size(286, 38)
        numSaldo.TabIndex = 3
        numSaldo.ThousandsSeparator = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(59, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 31)
        Label2.TabIndex = 4
        Label2.Text = "Mata Uang"
        ' 
        ' cmbCurrency
        ' 
        cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCurrency.Font = New Font("Segoe UI", 13.8F)
        cmbCurrency.FormattingEnabled = True
        cmbCurrency.Location = New Point(227, 176)
        cmbCurrency.Name = "cmbCurrency"
        cmbCurrency.Size = New Size(287, 39)
        cmbCurrency.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(43, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 31)
        Label3.TabIndex = 6
        Label3.Text = "Warna Kartu"
        ' 
        ' btnWarna
        ' 
        btnWarna.BackColor = Color.CornflowerBlue
        btnWarna.Font = New Font("Segoe UI", 13.8F)
        btnWarna.Location = New Point(227, 241)
        btnWarna.Name = "btnWarna"
        btnWarna.Size = New Size(287, 42)
        btnWarna.TabIndex = 7
        btnWarna.Text = "..."
        btnWarna.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(395, 309)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(119, 43)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' frmAddAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(562, 371)
        Controls.Add(btnSimpan)
        Controls.Add(btnWarna)
        Controls.Add(Label3)
        Controls.Add(cmbCurrency)
        Controls.Add(Label2)
        Controls.Add(numSaldo)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(lblnamaakun)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "frmAddAccount"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAddAccount"
        CType(numSaldo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblnamaakun As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents numSaldo As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnWarna As Button
    Friend WithEvents btnSimpan As Button
End Class
