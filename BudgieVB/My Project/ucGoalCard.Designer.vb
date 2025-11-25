<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGoalCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        lblNama = New Label()
        lblTerkumpul = New Label()
        lblTanggal = New Label()
        pnlBackground = New Panel()
        pnlProgress = New Panel()
        pnlBackground.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(8, 12)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(80, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Beli PS5"
        ' 
        ' lblTerkumpul
        ' 
        lblTerkumpul.AutoSize = True
        lblTerkumpul.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTerkumpul.Location = New Point(106, 16)
        lblTerkumpul.Name = "lblTerkumpul"
        lblTerkumpul.Size = New Size(183, 20)
        lblTerkumpul.TabIndex = 1
        lblTerkumpul.Text = "Rp 500.000 / Rp 5.000.000"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(8, 73)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(138, 20)
        lblTanggal.TabIndex = 2
        lblTanggal.Text = "Target: 25 Des 2025"
        ' 
        ' pnlBackground
        ' 
        pnlBackground.BackColor = Color.LightGray
        pnlBackground.Controls.Add(pnlProgress)
        pnlBackground.Location = New Point(13, 45)
        pnlBackground.Name = "pnlBackground"
        pnlBackground.Size = New Size(268, 24)
        pnlBackground.TabIndex = 3
        ' 
        ' pnlProgress
        ' 
        pnlProgress.BackColor = Color.SeaGreen
        pnlProgress.Dock = DockStyle.Left
        pnlProgress.Location = New Point(0, 0)
        pnlProgress.Name = "pnlProgress"
        pnlProgress.Size = New Size(58, 24)
        pnlProgress.TabIndex = 0
        ' 
        ' ucGoalCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        Controls.Add(pnlBackground)
        Controls.Add(lblTanggal)
        Controls.Add(lblTerkumpul)
        Controls.Add(lblNama)
        Name = "ucGoalCard"
        Size = New Size(300, 100)
        pnlBackground.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblTerkumpul As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents pnlProgress As Panel

End Class
