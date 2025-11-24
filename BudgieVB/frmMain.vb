Imports MySql.Data.MySqlClient
Imports ScottPlot ' Wajib import namespace ScottPlot 5

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        LoadChartSpending()
        LoadPieChart()
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Refresh data setiap kali dashboard tampil lagi
        LoadNetWorth()
        LoadRiwayatTransaksi()
        ' LoadChartSpending() ' Panggil ini juga kalau mau chart update
    End Sub

    Sub LoadChartSpending()
        ' 1. Siapkan Data Dummy (Nanti ganti query SQL)
        Dim dataX As Double() = {1, 2, 3, 4, 5}
        Dim dataY As Double() = {10000, 25000, 5000, 40000, 15000}

        ' 2. Reset Plot
        chartSpending.Plot.Clear()

        ' 3. Tambahkan Scatter Plot (Garis)
        ' Sesuai sintaks ScottPlot 5 di repo [src/ScottPlot5/ScottPlot5/Plottables/Scatter.cs]
        Dim sp = chartSpending.Plot.Add.Scatter(dataX, dataY)
        sp.Color = Colors.Blue
        sp.LineWidth = 3

        ' 4. Styling Sederhana
        chartSpending.Plot.Title("Pengeluaran Bulan Ini")
        chartSpending.Refresh()
    End Sub

    Sub LoadPieChart()
        chartCategory.Plot.Clear()

        ' 1. Siapkan List PieSlice (Potongan Kue)
        Dim slices As New List(Of PieSlice)

        ' 2. Buat data dummy dengan Label & Warna manual
        ' Note: Colors.Red, dll itu bawaan ScottPlot
        Dim slice1 As New PieSlice With {
            .Value = 300000,
            .Label = "Makan",
            .Fill = New FillStyle With {.Color = Colors.Salmon}
        }
        Dim slice2 As New PieSlice With {
            .Value = 150000,
            .Label = "Transport",
            .Fill = New FillStyle With {.Color = Colors.LightBlue}
        }
        Dim slice3 As New PieSlice With {
            .Value = 100000,
            .Label = "Hobi",
            .Fill = New FillStyle With {.Color = Colors.LightGreen}
        }

        slices.Add(slice1)
        slices.Add(slice2)
        slices.Add(slice3)

        ' 3. Masukkan ke Plot
        Dim pie = chartCategory.Plot.Add.Pie(slices)

        ' 4. Konfigurasi Tampilan (Sesuai file Pie.cs yang kamu upload)
        pie.DonutFraction = 0.5 ' Supaya bolong tengah (Donut Chart)
        pie.SliceLabelDistance = 0.6 ' Mengatur jarak tulisan label dari tengah
        pie.ExplodeFraction = 0.05 ' Sedikit jarak antar potongan (opsional)

        ' 5. Styling Akhir
        chartCategory.Plot.Title("Alokasi Budget")
        chartCategory.Plot.HideGrid()
        chartCategory.Plot.Layout.Frameless() ' Hapus bingkai kotak
        chartCategory.Refresh()
    End Sub
    ' Panggil ini di Form_Load dan setelah tambah transaksi
    Sub LoadNetWorth()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' Hitung total saldo semua akun
            Dim query As String = "SELECT SUM(balance) FROM accounts WHERE user_id = @uid"
            Using CMD As New MySqlCommand(query, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Dim result = CMD.ExecuteScalar()

                If IsDBNull(result) Then
                    lblNetWorth.Text = "Rp 0"
                Else
                    ' Format Rupiah
                    Dim total As Decimal = Convert.ToDecimal(result)
                    lblNetWorth.Text = "Rp " & total.ToString("N0")
                End If
            End Using
        Catch ex As Exception
            ' Handle error silent
        End Try
    End Sub

    Sub LoadRiwayatTransaksi()
        flpRiwayat.Controls.Clear() ' Hapus list lama

        Dim sql As String = "SELECT t.*, c.name as cat_name, c.icon_name FROM transactions t JOIN categories c ON t.category_id = c.id WHERE t.user_id = @uid ORDER BY t.transaction_date DESC"

        Using CMD As New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    ' --- DISINI KITA PAKAI LEGO YANG KITA BUAT KEMARIN ---
                    Dim item As New ucTransactionItem

                    ' Isi Data ke UserControl
                    item.Judul = RD("note").ToString
                    item.Nominal = RD("amount")

                    ' (Opsional) Kalau mau set label kategori di usercontrol
                    ' item.Kategori = RD("cat_name").ToString 

                    flpRiwayat.Controls.Add(item)
                End While
            End Using
        End Using
    End Sub

End Class
