Public Class ucBudgetCard
    Public Property NamaBudget As String
        Get
            Return lblNama.Text
        End Get
        Set(value As String)
            lblNama.Text = value
        End Set
    End Property

    Public Sub SetProgress(terpakai As Decimal, limit As Decimal)
        ' Update Label Sisa
        Dim sisa As Decimal = limit - terpakai
        lblSisa.Text = "Sisa Rp " & sisa.ToString("N0")

        ' Logic Panjang Panel Progress
        If limit > 0 Then
            Dim persentase As Decimal = (terpakai / limit)
            If persentase > 1 Then persentase = 1 ' Mentok 100%

            ' Ubah lebar panel biru sesuai persentase dari panel abu-abu
            pnlProgress.Width = CInt(pnlBackground.Width * persentase)

            ' Ubah warna jadi merah kalau over budget
            If persentase >= 1 Then
                pnlProgress.BackColor = Color.Red
            Else
                pnlProgress.BackColor = Color.CornflowerBlue
            End If
        End If
    End Sub


End Class