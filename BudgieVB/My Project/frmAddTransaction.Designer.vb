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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnNext1 = New Button()
        dtpTanggal = New DateTimePicker()
        txtJudul = New TextBox()
        TabPage2 = New TabPage()
        btnModeIncome = New Button()
        btnModeExpense = New Button()
        cmbGoal = New ComboBox()
        cmbBudget = New ComboBox()
        flpCategories = New FlowLayoutPanel()
        btnNext2 = New Button()
        TabPage3 = New TabPage()
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
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 450)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnNext1)
        TabPage1.Controls.Add(dtpTanggal)
        TabPage1.Controls.Add(txtJudul)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 417)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnNext1
        ' 
        btnNext1.Location = New Point(313, 313)
        btnNext1.Name = "btnNext1"
        btnNext1.Size = New Size(94, 29)
        btnNext1.TabIndex = 2
        btnNext1.Text = "Button1"
        btnNext1.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(295, 24)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(250, 27)
        dtpTanggal.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(257, 198)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 27)
        txtJudul.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnModeIncome)
        TabPage2.Controls.Add(btnModeExpense)
        TabPage2.Controls.Add(cmbGoal)
        TabPage2.Controls.Add(cmbBudget)
        TabPage2.Controls.Add(flpCategories)
        TabPage2.Controls.Add(btnNext2)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 417)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnModeIncome
        ' 
        btnModeIncome.BackColor = Color.WhiteSmoke
        btnModeIncome.FlatStyle = FlatStyle.Flat
        btnModeIncome.Location = New Point(278, 214)
        btnModeIncome.Name = "btnModeIncome"
        btnModeIncome.Size = New Size(94, 29)
        btnModeIncome.TabIndex = 8
        btnModeIncome.Text = "Income"
        btnModeIncome.UseVisualStyleBackColor = False
        ' 
        ' btnModeExpense
        ' 
        btnModeExpense.BackColor = Color.Salmon
        btnModeExpense.FlatStyle = FlatStyle.Flat
        btnModeExpense.Location = New Point(124, 214)
        btnModeExpense.Name = "btnModeExpense"
        btnModeExpense.Size = New Size(94, 29)
        btnModeExpense.TabIndex = 7
        btnModeExpense.Text = "Expense"
        btnModeExpense.UseVisualStyleBackColor = False
        ' 
        ' cmbGoal
        ' 
        cmbGoal.FormattingEnabled = True
        cmbGoal.Location = New Point(248, 349)
        cmbGoal.Name = "cmbGoal"
        cmbGoal.Size = New Size(151, 28)
        cmbGoal.TabIndex = 6
        cmbGoal.Text = "Pilih Goal (Opsional)"
        ' 
        ' cmbBudget
        ' 
        cmbBudget.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBudget.FormattingEnabled = True
        cmbBudget.Location = New Point(247, 281)
        cmbBudget.Name = "cmbBudget"
        cmbBudget.Size = New Size(189, 28)
        cmbBudget.TabIndex = 5
        ' 
        ' flpCategories
        ' 
        flpCategories.Location = New Point(37, 29)
        flpCategories.Name = "flpCategories"
        flpCategories.Size = New Size(700, 149)
        flpCategories.TabIndex = 4
        ' 
        ' btnNext2
        ' 
        btnNext2.Location = New Point(515, 246)
        btnNext2.Name = "btnNext2"
        btnNext2.Size = New Size(94, 29)
        btnNext2.TabIndex = 3
        btnNext2.Text = "Button1"
        btnNext2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
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
        TabPage3.Size = New Size(792, 417)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnBackspace
        ' 
        btnBackspace.Location = New Point(429, 338)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(94, 29)
        btnBackspace.TabIndex = 13
        btnBackspace.Text = "Backspace"
        btnBackspace.UseVisualStyleBackColor = True
        ' 
        ' cmbAkun
        ' 
        cmbAkun.FormattingEnabled = True
        cmbAkun.Location = New Point(555, 59)
        cmbAkun.Name = "cmbAkun"
        cmbAkun.Size = New Size(151, 28)
        cmbAkun.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(681, 371)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnAngka9
        ' 
        btnAngka9.Location = New Point(429, 286)
        btnAngka9.Name = "btnAngka9"
        btnAngka9.Size = New Size(94, 29)
        btnAngka9.TabIndex = 10
        btnAngka9.Text = "9"
        btnAngka9.UseVisualStyleBackColor = True
        ' 
        ' btnAngka8
        ' 
        btnAngka8.Location = New Point(316, 286)
        btnAngka8.Name = "btnAngka8"
        btnAngka8.Size = New Size(94, 29)
        btnAngka8.TabIndex = 9
        btnAngka8.Text = "8"
        btnAngka8.UseVisualStyleBackColor = True
        ' 
        ' btnAngka7
        ' 
        btnAngka7.Location = New Point(201, 286)
        btnAngka7.Name = "btnAngka7"
        btnAngka7.Size = New Size(94, 29)
        btnAngka7.TabIndex = 8
        btnAngka7.Text = "7"
        btnAngka7.UseVisualStyleBackColor = True
        ' 
        ' btnAngka6
        ' 
        btnAngka6.Location = New Point(429, 240)
        btnAngka6.Name = "btnAngka6"
        btnAngka6.Size = New Size(94, 29)
        btnAngka6.TabIndex = 7
        btnAngka6.Text = "6"
        btnAngka6.UseVisualStyleBackColor = True
        ' 
        ' btnAngka5
        ' 
        btnAngka5.Location = New Point(316, 240)
        btnAngka5.Name = "btnAngka5"
        btnAngka5.Size = New Size(94, 29)
        btnAngka5.TabIndex = 6
        btnAngka5.Text = "5"
        btnAngka5.UseVisualStyleBackColor = True
        ' 
        ' btnAngka4
        ' 
        btnAngka4.Location = New Point(201, 240)
        btnAngka4.Name = "btnAngka4"
        btnAngka4.Size = New Size(94, 29)
        btnAngka4.TabIndex = 5
        btnAngka4.Text = "4"
        btnAngka4.UseVisualStyleBackColor = True
        ' 
        ' btnAngka3
        ' 
        btnAngka3.Location = New Point(429, 190)
        btnAngka3.Name = "btnAngka3"
        btnAngka3.Size = New Size(94, 29)
        btnAngka3.TabIndex = 4
        btnAngka3.Text = "3"
        btnAngka3.UseVisualStyleBackColor = True
        ' 
        ' btnAngka2
        ' 
        btnAngka2.Location = New Point(316, 190)
        btnAngka2.Name = "btnAngka2"
        btnAngka2.Size = New Size(94, 29)
        btnAngka2.TabIndex = 3
        btnAngka2.Text = "2"
        btnAngka2.UseVisualStyleBackColor = True
        ' 
        ' btnAngka1
        ' 
        btnAngka1.Location = New Point(201, 190)
        btnAngka1.Name = "btnAngka1"
        btnAngka1.Size = New Size(94, 29)
        btnAngka1.TabIndex = 2
        btnAngka1.Text = "1"
        btnAngka1.UseVisualStyleBackColor = True
        ' 
        ' btnAngka0
        ' 
        btnAngka0.Location = New Point(316, 338)
        btnAngka0.Name = "btnAngka0"
        btnAngka0.Size = New Size(94, 29)
        btnAngka0.TabIndex = 1
        btnAngka0.Text = "0"
        btnAngka0.UseVisualStyleBackColor = True
        ' 
        ' lblNominalDisplay
        ' 
        lblNominalDisplay.AutoSize = True
        lblNominalDisplay.Location = New Point(242, 112)
        lblNominalDisplay.Name = "lblNominalDisplay"
        lblNominalDisplay.Size = New Size(25, 20)
        lblNominalDisplay.TabIndex = 0
        lblNominalDisplay.Text = "67"
        ' 
        ' frmAddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Name = "frmAddTransaction"
        Text = "frmAddTransaction"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
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
End Class
