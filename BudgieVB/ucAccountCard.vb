Public Class ucAccountCard
    Public Property NamaAkun As String
        Set(value As String)
            lblNama.Text = value
        End Set
        Get
            Return lblNama.Text
        End Get
    End Property

    Public Property Saldo As Decimal
        Set(value As Decimal)
            lblSaldo.Text = "Rp " & value.ToString("N0")
        End Set
        Get
            Return 0
        End Get
    End Property

    Public Sub SetWarna(hex As String)
        Try
            pnlBg.BackColor = System.Drawing.ColorTranslator.FromHtml(hex)
        Catch
            pnlBg.BackColor = Color.CornflowerBlue
        End Try
    End Sub

End Class