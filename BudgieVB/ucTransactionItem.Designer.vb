<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTransactionItem
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
        picIcon = New PictureBox()
        lblJudul = New Label()
        lblAmount = New Label()
        Panel1 = New Panel()
        CType(picIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picIcon
        ' 
        picIcon.Location = New Point(15, 16)
        picIcon.Name = "picIcon"
        picIcon.Size = New Size(40, 40)
        picIcon.TabIndex = 0
        picIcon.TabStop = False
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(72, 22)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(63, 23)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Label1"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmount.Location = New Point(256, 22)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(63, 23)
        lblAmount.TabIndex = 3
        lblAmount.Text = "Label1"
        lblAmount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 69)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 1)
        Panel1.TabIndex = 4
        ' 
        ' ucTransactionItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Panel1)
        Controls.Add(lblAmount)
        Controls.Add(lblJudul)
        Controls.Add(picIcon)
        Name = "ucTransactionItem"
        Size = New Size(350, 70)
        CType(picIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Panel1 As Panel

End Class
