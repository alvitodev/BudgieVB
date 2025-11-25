<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnLogout = New Button()
        btnNavGoals = New Button()
        btnNavAnggaran = New Button()
        btnNavTransaksi = New Button()
        btnNavDashboard = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnAddTransaction = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel3 = New Panel()
        Label1 = New Label()
        chartPie = New ScottPlot.WinForms.FormsPlot()
        chartLine = New ScottPlot.WinForms.FormsPlot()
        lblNetWorthDashboard = New Label()
        flpGoalsDashboard = New FlowLayoutPanel()
        Panel4 = New Panel()
        pnlFilterHeader = New Panel()
        btnFilterInc = New Button()
        btnFilterAll = New Button()
        btnFilterExp = New Button()
        btnViewAllTrans = New Button()
        flpRecentTrans = New FlowLayoutPanel()
        flpBudgetDashboard = New FlowLayoutPanel()
        flpAkun = New FlowLayoutPanel()
        TabPage2 = New TabPage()
        flpListTransaksi = New FlowLayoutPanel()
        pnlHeaderTransaksi = New Panel()
        lblTotalMonth = New Label()
        lblExpMonth = New Label()
        lblIncMonth = New Label()
        lblBulanTahun = New Label()
        btnNextMonth = New Button()
        btnPrevMonth = New Button()
        TabPage3 = New TabPage()
        flpDaftarBudget = New FlowLayoutPanel()
        pnlFooterAnggaran = New Panel()
        btnAddBudget = New Button()
        TabPage4 = New TabPage()
        flpDaftarGoal = New FlowLayoutPanel()
        Panel2 = New Panel()
        btnAddGoal = New Button()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        pnlFilterHeader.SuspendLayout()
        TabPage2.SuspendLayout()
        pnlHeaderTransaksi.SuspendLayout()
        TabPage3.SuspendLayout()
        pnlFooterAnggaran.SuspendLayout()
        TabPage4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnNavGoals)
        Panel1.Controls.Add(btnNavAnggaran)
        Panel1.Controls.Add(btnNavTransaksi)
        Panel1.Controls.Add(btnNavDashboard)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1262, 50)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(1014, 12)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavGoals
        ' 
        btnNavGoals.Location = New Point(779, 12)
        btnNavGoals.Name = "btnNavGoals"
        btnNavGoals.Size = New Size(94, 29)
        btnNavGoals.TabIndex = 3
        btnNavGoals.Text = "Goals"
        btnNavGoals.UseVisualStyleBackColor = True
        ' 
        ' btnNavAnggaran
        ' 
        btnNavAnggaran.Location = New Point(531, 3)
        btnNavAnggaran.Name = "btnNavAnggaran"
        btnNavAnggaran.Size = New Size(94, 29)
        btnNavAnggaran.TabIndex = 2
        btnNavAnggaran.Text = "Budget"
        btnNavAnggaran.UseVisualStyleBackColor = True
        ' 
        ' btnNavTransaksi
        ' 
        btnNavTransaksi.Location = New Point(318, 12)
        btnNavTransaksi.Name = "btnNavTransaksi"
        btnNavTransaksi.Size = New Size(94, 29)
        btnNavTransaksi.TabIndex = 1
        btnNavTransaksi.Text = "Transaksi"
        btnNavTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.Location = New Point(71, 12)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(94, 29)
        btnNavDashboard.TabIndex = 0
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.Location = New Point(0, 50)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1262, 623)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnAddTransaction)
        TabPage1.Controls.Add(TableLayoutPanel1)
        TabPage1.Controls.Add(flpBudgetDashboard)
        TabPage1.Controls.Add(flpAkun)
        TabPage1.Location = New Point(4, 5)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1254, 614)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnAddTransaction
        ' 
        btnAddTransaction.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddTransaction.BackColor = Color.CornflowerBlue
        btnAddTransaction.FlatAppearance.BorderSize = 0
        btnAddTransaction.FlatStyle = FlatStyle.Flat
        btnAddTransaction.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddTransaction.ForeColor = Color.White
        btnAddTransaction.Location = New Point(1154, 517)
        btnAddTransaction.Name = "btnAddTransaction"
        btnAddTransaction.Size = New Size(76, 71)
        btnAddTransaction.TabIndex = 4
        btnAddTransaction.Text = "+"
        btnAddTransaction.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 247)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(1248, 364)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(chartPie)
        Panel3.Controls.Add(chartLine)
        Panel3.Controls.Add(lblNetWorthDashboard)
        Panel3.Controls.Add(flpGoalsDashboard)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(618, 338)
        Panel3.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(226, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 4
        Label1.Text = "Net Worth: "
        ' 
        ' chartPie
        ' 
        chartPie.DisplayScale = 1.25F
        chartPie.Location = New Point(294, 170)
        chartPie.Name = "chartPie"
        chartPie.Size = New Size(321, 165)
        chartPie.TabIndex = 3
        ' 
        ' chartLine
        ' 
        chartLine.DisplayScale = 1.25F
        chartLine.Location = New Point(3, 156)
        chartLine.Name = "chartLine"
        chartLine.Size = New Size(285, 179)
        chartLine.TabIndex = 2
        ' 
        ' lblNetWorthDashboard
        ' 
        lblNetWorthDashboard.AutoSize = True
        lblNetWorthDashboard.Location = New Point(333, 133)
        lblNetWorthDashboard.Name = "lblNetWorthDashboard"
        lblNetWorthDashboard.Size = New Size(53, 20)
        lblNetWorthDashboard.TabIndex = 1
        lblNetWorthDashboard.Text = "Label1"
        ' 
        ' flpGoalsDashboard
        ' 
        flpGoalsDashboard.AutoScroll = True
        flpGoalsDashboard.Dock = DockStyle.Top
        flpGoalsDashboard.Location = New Point(0, 0)
        flpGoalsDashboard.Name = "flpGoalsDashboard"
        flpGoalsDashboard.Size = New Size(618, 130)
        flpGoalsDashboard.TabIndex = 0
        flpGoalsDashboard.WrapContents = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(pnlFilterHeader)
        Panel4.Controls.Add(btnViewAllTrans)
        Panel4.Controls.Add(flpRecentTrans)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(627, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(618, 338)
        Panel4.TabIndex = 1
        ' 
        ' pnlFilterHeader
        ' 
        pnlFilterHeader.Controls.Add(btnFilterInc)
        pnlFilterHeader.Controls.Add(btnFilterAll)
        pnlFilterHeader.Controls.Add(btnFilterExp)
        pnlFilterHeader.Dock = DockStyle.Top
        pnlFilterHeader.Location = New Point(0, 0)
        pnlFilterHeader.Name = "pnlFilterHeader"
        pnlFilterHeader.Size = New Size(618, 59)
        pnlFilterHeader.TabIndex = 2
        ' 
        ' btnFilterInc
        ' 
        btnFilterInc.Location = New Point(242, 15)
        btnFilterInc.Name = "btnFilterInc"
        btnFilterInc.Size = New Size(94, 29)
        btnFilterInc.TabIndex = 1
        btnFilterInc.Text = "Income"
        btnFilterInc.UseVisualStyleBackColor = True
        ' 
        ' btnFilterAll
        ' 
        btnFilterAll.Location = New Point(77, 15)
        btnFilterAll.Name = "btnFilterAll"
        btnFilterAll.Size = New Size(94, 29)
        btnFilterAll.TabIndex = 0
        btnFilterAll.Text = "All"
        btnFilterAll.UseVisualStyleBackColor = True
        ' 
        ' btnFilterExp
        ' 
        btnFilterExp.Location = New Point(404, 15)
        btnFilterExp.Name = "btnFilterExp"
        btnFilterExp.Size = New Size(94, 29)
        btnFilterExp.TabIndex = 2
        btnFilterExp.Text = "Expense"
        btnFilterExp.UseVisualStyleBackColor = True
        ' 
        ' btnViewAllTrans
        ' 
        btnViewAllTrans.Dock = DockStyle.Bottom
        btnViewAllTrans.Location = New Point(0, 309)
        btnViewAllTrans.Name = "btnViewAllTrans"
        btnViewAllTrans.Size = New Size(618, 29)
        btnViewAllTrans.TabIndex = 1
        btnViewAllTrans.Text = "View All Transaction"
        btnViewAllTrans.UseVisualStyleBackColor = True
        ' 
        ' flpRecentTrans
        ' 
        flpRecentTrans.AutoScroll = True
        flpRecentTrans.Dock = DockStyle.Fill
        flpRecentTrans.FlowDirection = FlowDirection.TopDown
        flpRecentTrans.Location = New Point(0, 0)
        flpRecentTrans.Name = "flpRecentTrans"
        flpRecentTrans.Size = New Size(618, 338)
        flpRecentTrans.TabIndex = 3
        flpRecentTrans.WrapContents = False
        ' 
        ' flpBudgetDashboard
        ' 
        flpBudgetDashboard.AutoScroll = True
        flpBudgetDashboard.Dock = DockStyle.Top
        flpBudgetDashboard.Location = New Point(3, 117)
        flpBudgetDashboard.Name = "flpBudgetDashboard"
        flpBudgetDashboard.Size = New Size(1248, 130)
        flpBudgetDashboard.TabIndex = 6
        flpBudgetDashboard.WrapContents = False
        ' 
        ' flpAkun
        ' 
        flpAkun.AutoScroll = True
        flpAkun.Dock = DockStyle.Top
        flpAkun.Location = New Point(3, 3)
        flpAkun.Name = "flpAkun"
        flpAkun.Size = New Size(1248, 114)
        flpAkun.TabIndex = 5
        flpAkun.WrapContents = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(flpListTransaksi)
        TabPage2.Controls.Add(pnlHeaderTransaksi)
        TabPage2.Location = New Point(4, 5)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1254, 614)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' flpListTransaksi
        ' 
        flpListTransaksi.AutoScroll = True
        flpListTransaksi.Dock = DockStyle.Fill
        flpListTransaksi.FlowDirection = FlowDirection.TopDown
        flpListTransaksi.Location = New Point(3, 123)
        flpListTransaksi.Name = "flpListTransaksi"
        flpListTransaksi.Size = New Size(1248, 488)
        flpListTransaksi.TabIndex = 1
        flpListTransaksi.WrapContents = False
        ' 
        ' pnlHeaderTransaksi
        ' 
        pnlHeaderTransaksi.Controls.Add(lblTotalMonth)
        pnlHeaderTransaksi.Controls.Add(lblExpMonth)
        pnlHeaderTransaksi.Controls.Add(lblIncMonth)
        pnlHeaderTransaksi.Controls.Add(lblBulanTahun)
        pnlHeaderTransaksi.Controls.Add(btnNextMonth)
        pnlHeaderTransaksi.Controls.Add(btnPrevMonth)
        pnlHeaderTransaksi.Dock = DockStyle.Top
        pnlHeaderTransaksi.Location = New Point(3, 3)
        pnlHeaderTransaksi.Name = "pnlHeaderTransaksi"
        pnlHeaderTransaksi.Size = New Size(1248, 120)
        pnlHeaderTransaksi.TabIndex = 0
        ' 
        ' lblTotalMonth
        ' 
        lblTotalMonth.AutoSize = True
        lblTotalMonth.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalMonth.Location = New Point(853, 82)
        lblTotalMonth.Name = "lblTotalMonth"
        lblTotalMonth.Size = New Size(78, 20)
        lblTotalMonth.TabIndex = 5
        lblTotalMonth.Text = "Total/Sisa"
        ' 
        ' lblExpMonth
        ' 
        lblExpMonth.AutoSize = True
        lblExpMonth.ForeColor = Color.Red
        lblExpMonth.Location = New Point(578, 82)
        lblExpMonth.Name = "lblExpMonth"
        lblExpMonth.Size = New Size(90, 20)
        lblExpMonth.TabIndex = 4
        lblExpMonth.Text = "Pengeluaran"
        ' 
        ' lblIncMonth
        ' 
        lblIncMonth.AutoSize = True
        lblIncMonth.ForeColor = Color.Green
        lblIncMonth.Location = New Point(323, 92)
        lblIncMonth.Name = "lblIncMonth"
        lblIncMonth.Size = New Size(82, 20)
        lblIncMonth.TabIndex = 3
        lblIncMonth.Text = "Pemasukan"
        ' 
        ' lblBulanTahun
        ' 
        lblBulanTahun.AutoSize = True
        lblBulanTahun.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBulanTahun.Location = New Point(522, 37)
        lblBulanTahun.Name = "lblBulanTahun"
        lblBulanTahun.Size = New Size(184, 31)
        lblBulanTahun.TabIndex = 2
        lblBulanTahun.Text = "November 2025"
        ' 
        ' btnNextMonth
        ' 
        btnNextMonth.Location = New Point(853, 37)
        btnNextMonth.Name = "btnNextMonth"
        btnNextMonth.Size = New Size(94, 29)
        btnNextMonth.TabIndex = 1
        btnNextMonth.Text = ">"
        btnNextMonth.UseVisualStyleBackColor = True
        ' 
        ' btnPrevMonth
        ' 
        btnPrevMonth.Location = New Point(370, 39)
        btnPrevMonth.Name = "btnPrevMonth"
        btnPrevMonth.Size = New Size(94, 29)
        btnPrevMonth.TabIndex = 0
        btnPrevMonth.Text = "<"
        btnPrevMonth.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(flpDaftarBudget)
        TabPage3.Controls.Add(pnlFooterAnggaran)
        TabPage3.Location = New Point(4, 5)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1254, 614)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' flpDaftarBudget
        ' 
        flpDaftarBudget.AutoScroll = True
        flpDaftarBudget.Dock = DockStyle.Fill
        flpDaftarBudget.Location = New Point(3, 3)
        flpDaftarBudget.Name = "flpDaftarBudget"
        flpDaftarBudget.Size = New Size(1248, 548)
        flpDaftarBudget.TabIndex = 1
        ' 
        ' pnlFooterAnggaran
        ' 
        pnlFooterAnggaran.Controls.Add(btnAddBudget)
        pnlFooterAnggaran.Dock = DockStyle.Bottom
        pnlFooterAnggaran.Location = New Point(3, 551)
        pnlFooterAnggaran.Name = "pnlFooterAnggaran"
        pnlFooterAnggaran.Size = New Size(1248, 60)
        pnlFooterAnggaran.TabIndex = 0
        ' 
        ' btnAddBudget
        ' 
        btnAddBudget.Location = New Point(618, 15)
        btnAddBudget.Name = "btnAddBudget"
        btnAddBudget.Size = New Size(94, 29)
        btnAddBudget.TabIndex = 0
        btnAddBudget.Text = "+ Budget"
        btnAddBudget.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(flpDaftarGoal)
        TabPage4.Controls.Add(Panel2)
        TabPage4.Location = New Point(4, 5)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1254, 614)
        TabPage4.TabIndex = 3
        TabPage4.Text = "TabPage4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' flpDaftarGoal
        ' 
        flpDaftarGoal.AutoScroll = True
        flpDaftarGoal.Dock = DockStyle.Fill
        flpDaftarGoal.Location = New Point(3, 3)
        flpDaftarGoal.Name = "flpDaftarGoal"
        flpDaftarGoal.Size = New Size(1248, 548)
        flpDaftarGoal.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnAddGoal)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(3, 551)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1248, 60)
        Panel2.TabIndex = 0
        ' 
        ' btnAddGoal
        ' 
        btnAddGoal.Location = New Point(570, 6)
        btnAddGoal.Name = "btnAddGoal"
        btnAddGoal.Size = New Size(94, 29)
        btnAddGoal.TabIndex = 1
        btnAddGoal.Text = "+ Goal"
        btnAddGoal.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 673)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "frmMain"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        pnlFilterHeader.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        pnlHeaderTransaksi.ResumeLayout(False)
        pnlHeaderTransaksi.PerformLayout()
        TabPage3.ResumeLayout(False)
        pnlFooterAnggaran.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNavGoals As Button
    Friend WithEvents btnNavAnggaran As Button
    Friend WithEvents btnNavTransaksi As Button
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents flpDaftarBudget As FlowLayoutPanel
    Friend WithEvents pnlFooterAnggaran As Panel
    Friend WithEvents btnAddBudget As Button
    Friend WithEvents flpDaftarGoal As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddGoal As Button
    Friend WithEvents flpListTransaksi As FlowLayoutPanel
    Friend WithEvents pnlHeaderTransaksi As Panel
    Friend WithEvents lblTotalMonth As Label
    Friend WithEvents lblExpMonth As Label
    Friend WithEvents lblIncMonth As Label
    Friend WithEvents lblBulanTahun As Label
    Friend WithEvents btnNextMonth As Button
    Friend WithEvents btnPrevMonth As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents flpAkun As FlowLayoutPanel
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents chartPie As ScottPlot.WinForms.FormsPlot
    Friend WithEvents chartLine As ScottPlot.WinForms.FormsPlot
    Friend WithEvents lblNetWorthDashboard As Label
    Friend WithEvents flpGoalsDashboard As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnFilterExp As Button
    Friend WithEvents btnFilterInc As Button
    Friend WithEvents btnFilterAll As Button
    Friend WithEvents flpBudgetDashboard As FlowLayoutPanel
    Friend WithEvents flpRecentTrans As FlowLayoutPanel
    Friend WithEvents pnlFilterHeader As Panel
    Friend WithEvents btnViewAllTrans As Button
    Friend WithEvents Label1 As Label

End Class
