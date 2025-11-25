<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTransaction
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
        Nama = New TabControl()
        TabPage1 = New TabPage()
        Label2 = New Label()
        Label1 = New Label()
        btnNext1 = New Button()
        dtpTanggal = New DateTimePicker()
        txtJudul = New TextBox()
        TabPage2 = New TabPage()
        btnModeExpense = New Button()
        btnModeIncome = New Button()
        cmbGoal = New ComboBox()
        cmbBudget = New ComboBox()
        flpCategories = New FlowLayoutPanel()
        btnNext2 = New Button()
        TabPage3 = New TabPage()
        Label4 = New Label()
        Label3 = New Label()
        btnBackspace = New Button()
        cmbAkun = New ComboBox()
        btnSimpan = New Button()
        btnAngka9 = New Button()
        btnAngka8 = New Button()
        btnAngka7 = New Button()
        btnAngka6 = New Button()
        btnAngka5 = New Button()
        btnAngka4 = New Button()
        btnAngka3 = New Button()
        btnAngka2 = New Button()
        btnAngka1 = New Button()
        btnAngka0 = New Button()
        lblNominalDisplay = New Label()
        Nama.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Nama
        ' 
        Nama.Controls.Add(TabPage1)
        Nama.Controls.Add(TabPage2)
        Nama.Controls.Add(TabPage3)
        Nama.Dock = DockStyle.Fill
        Nama.Location = New Point(0, 0)
        Nama.Name = "Nama"
        Nama.SelectedIndex = 0
        Nama.Size = New Size(572, 382)
        Nama.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(btnNext1)
        TabPage1.Controls.Add(dtpTanggal)
        TabPage1.Controls.Add(txtJudul)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(564, 349)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Nama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(273, 23)
        Label2.TabIndex = 4
        Label2.Text = "Tanggal transaksi (default: hari ini)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 31)
        Label1.TabIndex = 3
        Label1.Text = "Masukkan nama transaksi"
        ' 
        ' btnNext1
        ' 
        btnNext1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext1.Location = New Point(417, 274)
        btnNext1.Name = "btnNext1"
        btnNext1.Size = New Size(117, 50)
        btnNext1.TabIndex = 2
        btnNext1.Text = "Next ▶"
        btnNext1.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Location = New Point(31, 179)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(345, 38)
        dtpTanggal.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(32, 84)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(463, 38)
        txtJudul.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnModeExpense)
        TabPage2.Controls.Add(btnModeIncome)
        TabPage2.Controls.Add(cmbGoal)
        TabPage2.Controls.Add(cmbBudget)
        TabPage2.Controls.Add(flpCategories)
        TabPage2.Controls.Add(btnNext2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(564, 349)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kategori"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnModeExpense
        ' 
        btnModeExpense.BackColor = Color.Salmon
        btnModeExpense.FlatStyle = FlatStyle.Flat
        btnModeExpense.Location = New Point(14, 14)
        btnModeExpense.Name = "btnModeExpense"
        btnModeExpense.Size = New Size(258, 29)
        btnModeExpense.TabIndex = 7
        btnModeExpense.Text = "Keluar ▲"
        btnModeExpense.UseVisualStyleBackColor = False
        ' 
        ' btnModeIncome
        ' 
        btnModeIncome.BackColor = Color.WhiteSmoke
        btnModeIncome.FlatStyle = FlatStyle.Flat
        btnModeIncome.Location = New Point(278, 14)
        btnModeIncome.Name = "btnModeIncome"
        btnModeIncome.Size = New Size(270, 29)
        btnModeIncome.TabIndex = 8
        btnModeIncome.Text = "Masuk ▼"
        btnModeIncome.UseVisualStyleBackColor = False
        ' 
        ' cmbGoal
        ' 
        cmbGoal.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        cmbGoal.FormattingEnabled = True
        cmbGoal.Location = New Point(14, 282)
        cmbGoal.Name = "cmbGoal"
        cmbGoal.Size = New Size(362, 45)
        cmbGoal.TabIndex = 6
        cmbGoal.Text = "Pilih Goal (Opsional)"
        ' 
        ' cmbBudget
        ' 
        cmbBudget.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBudget.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        cmbBudget.FormattingEnabled = True
        cmbBudget.Location = New Point(14, 216)
        cmbBudget.Name = "cmbBudget"
        cmbBudget.Size = New Size(362, 45)
        cmbBudget.TabIndex = 5
        ' 
        ' flpCategories
        ' 
        flpCategories.Location = New Point(14, 49)
        flpCategories.Name = "flpCategories"
        flpCategories.Size = New Size(534, 123)
        flpCategories.TabIndex = 4
        ' 
        ' btnNext2
        ' 
        btnNext2.Font = New Font("Segoe UI", 13.8F)
        btnNext2.Location = New Point(430, 277)
        btnNext2.Name = "btnNext2"
        btnNext2.Size = New Size(118, 50)
        btnNext2.TabIndex = 3
        btnNext2.Text = "Next ▶"
        btnNext2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FloralWhite
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(Label3)
        TabPage3.Controls.Add(btnBackspace)
        TabPage3.Controls.Add(cmbAkun)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(btnAngka9)
        TabPage3.Controls.Add(btnAngka8)
        TabPage3.Controls.Add(btnAngka7)
        TabPage3.Controls.Add(btnAngka6)
        TabPage3.Controls.Add(btnAngka5)
        TabPage3.Controls.Add(btnAngka4)
        TabPage3.Controls.Add(btnAngka3)
        TabPage3.Controls.Add(btnAngka2)
        TabPage3.Controls.Add(btnAngka1)
        TabPage3.Controls.Add(btnAngka0)
        TabPage3.Controls.Add(lblNominalDisplay)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(564, 349)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Nominal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 25)
        Label4.TabIndex = 15
        Label4.Text = "Masukkan nominal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(427, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 28)
        Label3.TabIndex = 14
        Label3.Text = "Pilih Akun"
        ' 
        ' btnBackspace
        ' 
        btnBackspace.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBackspace.Location = New Point(196, 292)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(124, 45)
        btnBackspace.TabIndex = 13
        btnBackspace.Text = "Backspace"
        btnBackspace.UseVisualStyleBackColor = True
        ' 
        ' cmbAkun
        ' 
        cmbAkun.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbAkun.FormattingEnabled = True
        cmbAkun.Location = New Point(308, 154)
        cmbAkun.Name = "cmbAkun"
        cmbAkun.Size = New Size(224, 49)
        cmbAkun.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI", 13.8F)
        btnSimpan.Location = New Point(404, 277)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(128, 46)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnAngka9
        ' 
        btnAngka9.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka9.Location = New Point(196, 236)
        btnAngka9.Name = "btnAngka9"
        btnAngka9.Size = New Size(80, 45)
        btnAngka9.TabIndex = 10
        btnAngka9.Text = "9"
        btnAngka9.UseVisualStyleBackColor = True
        ' 
        ' btnAngka8
        ' 
        btnAngka8.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka8.Location = New Point(110, 236)
        btnAngka8.Name = "btnAngka8"
        btnAngka8.Size = New Size(80, 45)
        btnAngka8.TabIndex = 9
        btnAngka8.Text = "8"
        btnAngka8.UseVisualStyleBackColor = True
        ' 
        ' btnAngka7
        ' 
        btnAngka7.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka7.Location = New Point(24, 236)
        btnAngka7.Name = "btnAngka7"
        btnAngka7.Size = New Size(80, 45)
        btnAngka7.TabIndex = 8
        btnAngka7.Text = "7"
        btnAngka7.UseVisualStyleBackColor = True
        ' 
        ' btnAngka6
        ' 
        btnAngka6.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka6.Location = New Point(196, 180)
        btnAngka6.Name = "btnAngka6"
        btnAngka6.Size = New Size(80, 45)
        btnAngka6.TabIndex = 7
        btnAngka6.Text = "6"
        btnAngka6.UseVisualStyleBackColor = True
        ' 
        ' btnAngka5
        ' 
        btnAngka5.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka5.Location = New Point(110, 180)
        btnAngka5.Name = "btnAngka5"
        btnAngka5.Size = New Size(80, 45)
        btnAngka5.TabIndex = 6
        btnAngka5.Text = "5"
        btnAngka5.UseVisualStyleBackColor = True
        ' 
        ' btnAngka4
        ' 
        btnAngka4.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka4.Location = New Point(24, 180)
        btnAngka4.Name = "btnAngka4"
        btnAngka4.Size = New Size(80, 45)
        btnAngka4.TabIndex = 5
        btnAngka4.Text = "4"
        btnAngka4.UseVisualStyleBackColor = True
        ' 
        ' btnAngka3
        ' 
        btnAngka3.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka3.Location = New Point(196, 124)
        btnAngka3.Name = "btnAngka3"
        btnAngka3.Size = New Size(80, 45)
        btnAngka3.TabIndex = 4
        btnAngka3.Text = "3"
        btnAngka3.UseVisualStyleBackColor = True
        ' 
        ' btnAngka2
        ' 
        btnAngka2.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka2.Location = New Point(110, 124)
        btnAngka2.Name = "btnAngka2"
        btnAngka2.Size = New Size(80, 45)
        btnAngka2.TabIndex = 3
        btnAngka2.Text = "2"
        btnAngka2.UseVisualStyleBackColor = True
        ' 
        ' btnAngka1
        ' 
        btnAngka1.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka1.Location = New Point(24, 124)
        btnAngka1.Name = "btnAngka1"
        btnAngka1.Size = New Size(80, 45)
        btnAngka1.TabIndex = 2
        btnAngka1.Text = "1"
        btnAngka1.UseVisualStyleBackColor = True
        ' 
        ' btnAngka0
        ' 
        btnAngka0.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnAngka0.Location = New Point(110, 292)
        btnAngka0.Name = "btnAngka0"
        btnAngka0.Size = New Size(80, 45)
        btnAngka0.TabIndex = 1
        btnAngka0.Text = "0"
        btnAngka0.UseVisualStyleBackColor = True
        ' 
        ' lblNominalDisplay
        ' 
        lblNominalDisplay.AutoSize = True
        lblNominalDisplay.BackColor = Color.White
        lblNominalDisplay.BorderStyle = BorderStyle.FixedSingle
        lblNominalDisplay.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNominalDisplay.Location = New Point(24, 49)
        lblNominalDisplay.Name = "lblNominalDisplay"
        lblNominalDisplay.Size = New Size(77, 62)
        lblNominalDisplay.TabIndex = 0
        lblNominalDisplay.Text = "67"
        ' 
        ' frmAddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(572, 382)
        Controls.Add(Nama)
        Name = "frmAddTransaction"
        Text = "Tambahkan Transaksi"
        Nama.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Nama As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnNext1 As Button
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents flpCategories As FlowLayoutPanel
    Friend WithEvents btnNext2 As Button
    Friend WithEvents cmbAkun As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnAngka9 As Button
    Friend WithEvents btnAngka8 As Button
    Friend WithEvents btnAngka7 As Button
    Friend WithEvents btnAngka6 As Button
    Friend WithEvents btnAngka5 As Button
    Friend WithEvents btnAngka4 As Button
    Friend WithEvents btnAngka3 As Button
    Friend WithEvents btnAngka2 As Button
    Friend WithEvents btnAngka1 As Button
    Friend WithEvents btnAngka0 As Button
    Friend WithEvents lblNominalDisplay As Label
    Friend WithEvents btnBackspace As Button
    Friend WithEvents cmbBudget As ComboBox
    Friend WithEvents cmbGoal As ComboBox
    Friend WithEvents btnModeIncome As Button
    Friend WithEvents btnModeExpense As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
