<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAccountCard
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
        pnlBg = New Panel()
        lblNama = New Label()
        lblSaldo = New Label()
        lblCurrency = New Label()
        pnlBg.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBg
        ' 
        pnlBg.BackColor = Color.CornflowerBlue
        pnlBg.Controls.Add(lblCurrency)
        pnlBg.Controls.Add(lblSaldo)
        pnlBg.Controls.Add(lblNama)
        pnlBg.Dock = DockStyle.Fill
        pnlBg.Location = New Point(0, 0)
        pnlBg.Name = "pnlBg"
        pnlBg.Size = New Size(200, 100)
        pnlBg.TabIndex = 0
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(17, 14)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(57, 23)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' lblSaldo
        ' 
        lblSaldo.AutoSize = True
        lblSaldo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSaldo.ForeColor = Color.White
        lblSaldo.Location = New Point(17, 37)
        lblSaldo.Name = "lblSaldo"
        lblSaldo.Size = New Size(137, 28)
        lblSaldo.TabIndex = 1
        lblSaldo.Text = "Rp 1.000.000"
        ' 
        ' lblCurrency
        ' 
        lblCurrency.AutoSize = True
        lblCurrency.ForeColor = Color.White
        lblCurrency.Location = New Point(17, 70)
        lblCurrency.Name = "lblCurrency"
        lblCurrency.Size = New Size(33, 20)
        lblCurrency.TabIndex = 2
        lblCurrency.Text = "IDR"
        ' 
        ' ucAccountCard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(pnlBg)
        Name = "ucAccountCard"
        Size = New Size(200, 100)
        pnlBg.ResumeLayout(False)
        pnlBg.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBg As Panel
    Friend WithEvents lblCurrency As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblNama As Label

End Class
