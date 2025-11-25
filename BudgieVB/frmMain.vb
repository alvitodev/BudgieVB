Imports MySql.Data.MySqlClient
Imports ScottPlot ' Wajib import namespace ScottPlot 5

Public Class frmMain
    ' Variabel untuk menyimpan bulan yang sedang dilihat di tab Transaksi
    Dim ViewedDate As Date = Date.Now
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        LoadChartSpending()
        LoadPieChart()
        LoadDaftarBudget()
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Refresh data setiap kali dashboard tampil lagi
        LoadNetWorth()
        LoadRiwayatTransaksi()
        ' LoadChartSpending() ' Panggil ini juga kalau mau chart update
    End Sub
    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click
        ' 1. Bikin object form wizard
        Dim frm As New frmAddTransaction

        ' 2. Tampilkan sebagai Dialog (Mode Popup yang mengunci form belakang)
        frm.ShowDialog()

        ' 3. Saat popup ditutup, kodingan di bawah ini baru jalan:
        ' Refresh Dashboard supaya data baru langsung muncul
        LoadNetWorth()
        LoadRiwayatTransaksi()
        LoadChartSpending()
        LoadPieChart()
    End Sub
    ' Tombol DASHBOARD (Index 0)
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        TabControl1.SelectedIndex = 0
    End Sub

    ' Tombol TRANSAKSI (Index 1)
    Private Sub btnNavTransaksi_Click(sender As Object, e As EventArgs) Handles btnNavTransaksi.Click
        TabControl1.SelectedIndex = 1
        LoadHalamanTransaksi()
    End Sub

    ' Tombol ANGGARAN (Index 2)
    Private Sub btnNavAnggaran_Click(sender As Object, e As EventArgs) Handles btnNavAnggaran.Click
        TabControl1.SelectedIndex = 2
        LoadDaftarBudget()
    End Sub

    ' Tombol GOALS (Index 3 - Jika ada)
    Private Sub btnNavGoals_Click(sender As Object, e As EventArgs) Handles btnNavGoals.Click
        TabControl1.SelectedIndex = 3
        LoadDaftarGoal()
    End Sub

    ' Tombol LOGOUT
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim tanya = MsgBox("Yakin mau keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi")
        If tanya = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
    ' Tambahkan di Event Button Tambah Budget
    Private Sub btnAddBudget_Click(sender As Object, e As EventArgs) Handles btnAddBudget.Click
        Dim frm As New frmAddBudget
        frm.ShowDialog()
        LoadDaftarBudget() ' Refresh setelah tutup
    End Sub
    Private Sub btnAddGoal_Click(sender As Object, e As EventArgs) Handles btnAddGoal.Click
        Dim frm As New frmAddGoal
        frm.ShowDialog()
        LoadDaftarGoal() ' Refresh
    End Sub
    ' Tombol Mundur Bulan (<)
    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        ViewedDate = ViewedDate.AddMonths(-1)
        LoadHalamanTransaksi()
    End Sub

    ' Tombol Maju Bulan (>)
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        ViewedDate = ViewedDate.AddMonths(1)
        LoadHalamanTransaksi()
    End Sub
    Sub LoadDaftarGoal()
        flpDaftarGoal.Controls.Clear()

        Try
            BukaDB()

            ' 1. Ambil semua Goal user
            Dim dtGoal As New DataTable
            Using CMD As New MySqlCommand("SELECT * FROM goals WHERE user_id = " & CurrentUser_ID, Conn)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtGoal)
                End Using
            End Using

            ' 2. Loop & Hitung Progress
            For Each row As DataRow In dtGoal.Rows
                Dim goalID As Integer = row("id")
                Dim target As Decimal = row("target_amount")

                ' LOGIC BARU: Gunakan ABS (Nilai Mutlak)
                ' Jadi mau Income (+50.000) atau Expense (-50.000), tetap dihitung sebagai progress 50.000
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE goal_id = " & goalID

                Dim terkumpul As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terkumpul = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                ' 3. Bikin Kartu
                Dim card As New ucGoalCard
                card.NamaGoal = row("name").ToString

                ' Format tanggal cantik (misal: 25 Dec 2025)
                Dim tgl As Date = Convert.ToDateTime(row("target_date"))
                card.TanggalTarget = tgl.ToString("dd MMM yyyy")

                card.SetProgress(terkumpul, target)
                flpDaftarGoal.Controls.Add(card)
            Next

        Catch ex As Exception
            MsgBox("Gagal load goal: " & ex.Message)
        End Try
    End Sub
    Sub LoadDaftarBudget()
        flpDaftarBudget.Controls.Clear()

        Try
            BukaDB()

            ' 1. Ambil semua budget milik user
            Dim sqlBudget As String = "SELECT * FROM budgets WHERE user_id = @uid"
            Dim dtBudget As New DataTable
            Using CMD As New MySqlCommand(sqlBudget, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtBudget)
                End Using
            End Using

            ' 2. Loop setiap budget untuk hitung pengeluaran & bikin kartu
            For Each row As DataRow In dtBudget.Rows
                Dim budgetID As Integer = row("id")
                Dim limit As Decimal = row("amount_limit")

                ' Hitung total transaksi (Expense) bulan ini yg masuk budgetID ini
                ' Note: Kita ambil nilai absolut (ABS) karena expense biasanya disimpan minus
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE budget_id = " & budgetID & " AND amount < 0 AND MONTH(transaction_date) = MONTH(CURRENT_DATE())"

                Dim terpakai As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terpakai = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                ' 3. Bikin UserControl (Kartu)
                Dim card As New ucBudgetCard
                card.NamaBudget = row("name").ToString
                card.SetProgress(terpakai, limit) ' Ini memanggil logic warna-warni yang kita buat kemarin

                flpDaftarBudget.Controls.Add(card)
            Next

        Catch ex As Exception
            MsgBox("Gagal load budget: " & ex.Message)
        End Try
    End Sub
    Sub LoadHalamanTransaksi()
        flpListTransaksi.Controls.Clear()

        ' 1. Update Header Bulan
        lblBulanTahun.Text = ViewedDate.ToString("MMMM yyyy")

        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' 2. Hitung Ringkasan Bulan Ini
            Dim sqlSummary As String = "SELECT " &
                "SUM(CASE WHEN amount > 0 THEN amount ELSE 0 END) as Pemasukan, " &
                "SUM(CASE WHEN amount < 0 THEN amount ELSE 0 END) as Pengeluaran " &
                "FROM transactions WHERE user_id=@uid AND MONTH(transaction_date)=@bln AND YEAR(transaction_date)=@thn"

            Using CMD As New MySqlCommand(sqlSummary, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@bln", ViewedDate.Month)
                CMD.Parameters.AddWithValue("@thn", ViewedDate.Year)

                Using RD As MySqlDataReader = CMD.ExecuteReader
                    If RD.Read() AndAlso IsNumeric(RD("Pemasukan")) Then
                        Dim inc As Decimal = RD("Pemasukan")
                        Dim exp As Decimal = RD("Pengeluaran")
                        Dim net As Decimal = inc + exp

                        lblIncMonth.Text = "Masuk: Rp " & inc.ToString("N0")
                        lblExpMonth.Text = "Keluar: Rp " & Math.Abs(exp).ToString("N0")
                        lblTotalMonth.Text = "Sisa: Rp " & net.ToString("N0")
                    Else
                        lblIncMonth.Text = "Masuk: Rp 0"
                        lblExpMonth.Text = "Keluar: Rp 0"
                        lblTotalMonth.Text = "Sisa: Rp 0"
                    End If
                End Using
            End Using

            ' 3. Load List Transaksi (Grouping)
            Dim listTanggal As New List(Of Date)
            Dim sqlDate As String = "SELECT DISTINCT DATE(transaction_date) as tgl FROM transactions WHERE user_id=@uid AND MONTH(transaction_date)=@bln AND YEAR(transaction_date)=@thn ORDER BY tgl DESC"

            Using CMD As New MySqlCommand(sqlDate, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@bln", ViewedDate.Month)
                CMD.Parameters.AddWithValue("@thn", ViewedDate.Year)
                Using RD As MySqlDataReader = CMD.ExecuteReader
                    While RD.Read
                        listTanggal.Add(Convert.ToDateTime(RD("tgl")))
                    End While
                End Using
            End Using

            ' 4. Loop Setiap Tanggal
            For Each tgl As Date In listTanggal
                ' --- A. Bikin Header Tanggal (Panel) ---
                ' Gunakan System.Windows.Forms.Panel untuk memastikan ini Panel UI
                Dim pnlHeader As New System.Windows.Forms.Panel
                pnlHeader.Width = flpListTransaksi.Width - 25
                pnlHeader.Height = 30
                ' Gunakan System.Drawing.Color untuk warna UI
                pnlHeader.BackColor = System.Drawing.Color.LightGray
                pnlHeader.Margin = New Padding(0, 10, 0, 0)

                ' Label Tanggal (Kiri) -> PAKE NAMA LENGKAP
                Dim lblTgl As New System.Windows.Forms.Label
                lblTgl.Text = tgl.ToString("dddd, dd MMM")
                lblTgl.AutoSize = True
                lblTgl.Location = New Point(5, 5)
                ' Pake System.Drawing.Font
                lblTgl.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Bold)
                pnlHeader.Controls.Add(lblTgl)

                ' Label Total Harian (Kanan) -> PAKE NAMA LENGKAP
                Dim totalHari As Decimal = HitungTotalHarian(tgl)
                Dim lblTotalHari As New System.Windows.Forms.Label
                lblTotalHari.Text = "Rp " & totalHari.ToString("N0")
                lblTotalHari.AutoSize = True
                lblTotalHari.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Bold)
                lblTotalHari.Location = New Point(pnlHeader.Width - 120, 5)

                If totalHari >= 0 Then
                    lblTotalHari.ForeColor = System.Drawing.Color.Green
                Else
                    lblTotalHari.ForeColor = System.Drawing.Color.Red
                End If
                pnlHeader.Controls.Add(lblTotalHari)

                flpListTransaksi.Controls.Add(pnlHeader)

                ' --- B. Ambil Item Transaksi ---
                Dim sqlItem As String = "SELECT * FROM transactions WHERE user_id=@uid AND DATE(transaction_date)=@tgl ORDER BY transaction_date DESC"
                Using CMD As New MySqlCommand(sqlItem, Conn)
                    CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                    CMD.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
                    Using RDItem As MySqlDataReader = CMD.ExecuteReader
                        While RDItem.Read
                            Dim item As New ucTransactionItem
                            item.Judul = RDItem("note").ToString
                            item.Nominal = RDItem("amount")
                            item.Margin = New Padding(20, 0, 0, 0)
                            flpListTransaksi.Controls.Add(item)
                        End While
                    End Using
                End Using
            Next

        Catch ex As Exception
            MsgBox("Error load transaksi: " & ex.Message)
        End Try
    End Sub

    ' Fungsi Helper untuk hitung total per hari
    Function HitungTotalHarian(tgl As Date) As Decimal
        Dim total As Decimal = 0
        Using CMD As New MySqlCommand("SELECT SUM(amount) FROM transactions WHERE user_id=@uid AND DATE(transaction_date)=@tgl", Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            CMD.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
            Dim res = CMD.ExecuteScalar()
            If IsNumeric(res) Then total = Convert.ToDecimal(res)
        End Using
        Return total
    End Function

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
