Public Class ucGoalCard
    Public Property NamaGoal As String
        Get
            Return lblNama.Text
        End Get
        Set(value As String)
            lblNama.Text = value
        End Set
    End Property

    Public Property TanggalTarget As String
        Set(value As String)
            lblTanggal.Text = "Target: " & value
        End Set
        Get
            Return lblTanggal.Text
        End Get
    End Property

    Public Sub SetProgress(terkumpul As Decimal, target As Decimal)
        ' Format: "Rp 1.000 / Rp 5.000"
        lblTerkumpul.Text = "Rp " & terkumpul.ToString("N0") & " / " & target.ToString("N0")

        If target > 0 Then
            Dim persen As Decimal = terkumpul / target
            If persen > 1 Then persen = 1 ' Mentok 100%

            pnlProgress.Width = CInt(pnlBackground.Width * persen)

            ' Ubah warna jadi Emas kalau sudah tercapai
            If persen >= 1 Then
                pnlProgress.BackColor = Color.Gold
            Else
                pnlProgress.BackColor = Color.SeaGreen
            End If
        End If
    End Sub

End Class