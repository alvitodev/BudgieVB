Public Class ucTransactionItem
    Public Property Judul As String
        Get
            Return lblJudul.Text
        End Get
        Set(value As String)
            lblJudul.Text = value
        End Set
    End Property

    Public Property Nominal As Decimal
        Get
            Return 0 ' Placeholder
        End Get
        Set(value As Decimal)
            ' Format uang dan warna
            lblAmount.Text = "Rp " & value.ToString("N0")
            If value < 0 Then
                lblAmount.ForeColor = Color.Red ' Pengeluaran
            Else
                lblAmount.ForeColor = Color.Green ' Pemasukan
            End If
        End Set
    End Property

    ' Tambahkan properti lain (Note, Tanggal) sesuai kebutuhan
End Class