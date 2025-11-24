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
        btnGoals = New Button()
        btnBudget = New Button()
        btnTransaksi = New Button()
        btnDashboard = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        flpRiwayat = New FlowLayoutPanel()
        chartCategory = New ScottPlot.WinForms.FormsPlot()
        chartSpending = New ScottPlot.WinForms.FormsPlot()
        TabPage2 = New TabPage()
        lblNetWorth = New Label()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnGoals)
        Panel1.Controls.Add(btnBudget)
        Panel1.Controls.Add(btnTransaksi)
        Panel1.Controls.Add(btnDashboard)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1178, 82)
        Panel1.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(918, 34)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnGoals
        ' 
        btnGoals.Location = New Point(529, 34)
        btnGoals.Name = "btnGoals"
        btnGoals.Size = New Size(94, 29)
        btnGoals.TabIndex = 3
        btnGoals.Text = "Goals"
        btnGoals.UseVisualStyleBackColor = True
        ' 
        ' btnBudget
        ' 
        btnBudget.Location = New Point(377, 34)
        btnBudget.Name = "btnBudget"
        btnBudget.Size = New Size(94, 29)
        btnBudget.TabIndex = 2
        btnBudget.Text = "Budget"
        btnBudget.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.Location = New Point(238, 34)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Size = New Size(94, 29)
        btnTransaksi.TabIndex = 1
        btnTransaksi.Text = "Transaksi"
        btnTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(75, 34)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(94, 29)
        btnDashboard.TabIndex = 0
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 82)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1178, 600)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblNetWorth)
        TabPage1.Controls.Add(flpRiwayat)
        TabPage1.Controls.Add(chartCategory)
        TabPage1.Controls.Add(chartSpending)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1170, 567)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' flpRiwayat
        ' 
        flpRiwayat.AutoScroll = True
        flpRiwayat.Location = New Point(725, 230)
        flpRiwayat.Name = "flpRiwayat"
        flpRiwayat.Size = New Size(250, 125)
        flpRiwayat.TabIndex = 2
        ' 
        ' chartCategory
        ' 
        chartCategory.DisplayScale = 1.25F
        chartCategory.Location = New Point(151, 349)
        chartCategory.Name = "chartCategory"
        chartCategory.Size = New Size(188, 188)
        chartCategory.TabIndex = 1
        ' 
        ' chartSpending
        ' 
        chartSpending.DisplayScale = 1.25F
        chartSpending.Location = New Point(140, 121)
        chartSpending.Name = "chartSpending"
        chartSpending.Size = New Size(188, 188)
        chartSpending.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1170, 567)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lblNetWorth
        ' 
        lblNetWorth.AutoSize = True
        lblNetWorth.Location = New Point(412, 260)
        lblNetWorth.Name = "lblNetWorth"
        lblNetWorth.Size = New Size(53, 20)
        lblNetWorth.TabIndex = 3
        lblNetWorth.Text = "Label1"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1178, 682)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Name = "frmMain"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnGoals As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chartSpending As ScottPlot.WinForms.FormsPlot
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents flpRiwayat As FlowLayoutPanel
    Friend WithEvents chartCategory As ScottPlot.WinForms.FormsPlot
    Friend WithEvents lblNetWorth As Label

End Class
