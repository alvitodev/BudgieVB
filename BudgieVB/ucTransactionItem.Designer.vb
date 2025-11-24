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
        lblNote = New Label()
        lblAmount = New Label()
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
        lblJudul.Location = New Point(77, 16)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(63, 23)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Label1"
        ' 
        ' lblNote
        ' 
        lblNote.AutoSize = True
        lblNote.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNote.ForeColor = Color.Gray
        lblNote.Location = New Point(77, 39)
        lblNote.Name = "lblNote"
        lblNote.Size = New Size(46, 17)
        lblNote.TabIndex = 2
        lblNote.Text = "Label1"
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
        ' ucTransactionItem
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblAmount)
        Controls.Add(lblNote)
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
    Friend WithEvents lblNote As Label
    Friend WithEvents lblAmount As Label

End Class
