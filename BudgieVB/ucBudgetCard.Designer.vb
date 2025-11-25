<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBudgetCard
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
        lblSisa = New Label()
        pnlBackground = New Panel()
        pnlProgress = New Panel()
        pnlBackground.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(10, 6)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(73, 28)
        lblNama.TabIndex = 0
        lblNama.Text = "Makan"
        ' 
        ' lblSisa
        ' 
        lblSisa.AutoSize = True
        lblSisa.Location = New Point(10, 66)
        lblSisa.Name = "lblSisa"
        lblSisa.Size = New Size(112, 20)
        lblSisa.TabIndex = 1
        lblSisa.Text = "Sisa Rp 500.000"
        ' 
        ' pnlBackground
        ' 
        pnlBackground.BackColor = Color.LightGray
        pnlBackground.Controls.Add(pnlProgress)
        pnlBackground.Location = New Point(14, 37)
        pnlBackground.Name = "pnlBackground"
        pnlBackground.Size = New Size(306, 24)
        pnlBackground.TabIndex = 2
        ' 
        ' pnlProgress
        ' 
        pnlProgress.BackColor = Color.CornflowerBlue
        pnlProgress.Dock = DockStyle.Left
        pnlProgress.Location = New Point(0, 0)
        pnlProgress.Name = "pnlProgress"
        pnlProgress.Size = New Size(50, 24)
        pnlProgress.TabIndex = 0
        ' 
        ' ucBudgetCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        Controls.Add(pnlBackground)
        Controls.Add(lblSisa)
        Controls.Add(lblNama)
        Name = "ucBudgetCard"
        Size = New Size(336, 93)
        pnlBackground.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblSisa As Label
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents pnlProgress As Panel

End Class
