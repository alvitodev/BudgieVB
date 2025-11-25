Imports MySql.Data.MySqlClient
Imports ScottPlot ' Wajib import namespace ScottPlot 5

Public Class frmMain
    ' Variabel untuk menyimpan bulan yang sedang dilihat di tab Transaksi
    Dim ViewedDate As Date = Date.Now
    Dim CurrentDashboardFilter As String = "All" ' All, Income, Expense
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BukaDB()
        LoadChartSpending()
        LoadPieChart()
        LoadDaftarBudget()
    End Sub
    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Load Data Angka & List
        LoadNetWorth()
        LoadRiwayatTransaksi() ' <--- INI PENTING BUAT LIST KANAN

        ' Load Grafik
        LoadChartSpending()
        LoadPieChart()

        ' Load Tiles Horizontal (Atas)
        LoadAkunHorizontal()
        LoadBudgetHorizontal()
        LoadGoalsHorizontal()

        ' Load Tiles Halaman Utama (Bawah - Request barumu)
        LoadDaftarBudget()
        LoadDaftarGoal()
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
            ' Reset ID User biar aman
            CurrentUser_ID = 0

            ' Tampilkan Login lagi
            Dim frm As New frmLogin
            frm.Show()

            ' Tutup Dashboard
            Me.Close()
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
    Private Sub btnFilterAll_Click(sender As Object, e As EventArgs) Handles btnFilterAll.Click
        CurrentDashboardFilter = "All"
        RefreshDashboardCharts()
    End Sub

    Private Sub btnFilterExp_Click(sender As Object, e As EventArgs) Handles btnFilterExp.Click
        CurrentDashboardFilter = "Expense"
        RefreshDashboardCharts()
    End Sub

    Private Sub btnFilterInc_Click(sender As Object, e As EventArgs) Handles btnFilterInc.Click
        CurrentDashboardFilter = "Income"
        RefreshDashboardCharts()
    End Sub

    Sub RefreshDashboardCharts()
        LoadChartSpending()
        LoadPieChart()
        ' LoadRecentTransactions() ' Jangan lupa filter list transaksi juga
    End Sub
    Sub LoadDaftarGoal()
        flpDaftarGoal.Controls.Clear() ' 1. Bersihkan Panel

        Try
            BukaDB()

            ' 2. Ambil Data Goal dari Database
            Dim dtGoal As New DataTable
            Using CMD As New MySqlCommand("SELECT * FROM goals WHERE user_id = @uid", Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtGoal)
                End Using
            End Using

            ' 3. Loop data dan Bikin Kartu
            For Each row As DataRow In dtGoal.Rows
                ' --- LOGIC HITUNG PROGRESS ---
                Dim goalID As Integer = row("id")
                Dim target As Decimal = row("target_amount")

                ' Hitung total uang yg masuk ke goal ini (Pakai ABS biar positif)
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE goal_id = " & goalID
                Dim terkumpul As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terkumpul = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                ' --- BIKIN KARTU (DEKLARASI CARD DISINI) ---
                Dim card As New ucGoalCard ' <--- INI YANG KEMARIN HILANG
                card.NamaGoal = row("name").ToString

                Dim tgl As Date = Convert.ToDateTime(row("target_date"))
                card.TanggalTarget = tgl.ToString("dd MMM yyyy")

                card.SetProgress(terkumpul, target)

                ' Masukkan kartu ke Panel
                flpDaftarGoal.Controls.Add(card)
            Next

            ' 4. Tambahkan Tombol "+ Tambah Goal" di Ujung Akhir
            Dim btnAdd As New Button
            btnAdd.Text = "+ Tambah Goal"
            btnAdd.Size = New Size(300, 100) ' Samakan size kartu
            btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
            btnAdd.FlatStyle = FlatStyle.Flat
            btnAdd.Font = New System.Drawing.Font(Me.Font.FontFamily, 12, System.Drawing.FontStyle.Bold)
            btnAdd.ForeColor = System.Drawing.Color.Gray

            AddHandler btnAdd.Click, AddressOf btnAddGoal_Click

            flpDaftarGoal.Controls.Add(btnAdd)

        Catch ex As Exception
            MsgBox("Gagal load goal: " & ex.Message)
        End Try
    End Sub
    Sub LoadDaftarBudget()
        flpDaftarBudget.Controls.Clear()

        Try
            BukaDB()

            ' ... (Bagian Query Ambil Data Budget TETAP SAMA kayak sebelumnya) ...
            Dim sqlBudget As String = "SELECT * FROM budgets WHERE user_id = @uid"
            Dim dtBudget As New DataTable
            Using CMD As New MySqlCommand(sqlBudget, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtBudget)
                End Using
            End Using

            ' ... (Bagian Loop Bikin Kartu TETAP SAMA) ...
            For Each row As DataRow In dtBudget.Rows
                Dim budgetID As Integer = row("id")
                Dim limit As Decimal = row("amount_limit")
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE budget_id = " & budgetID & " AND amount < 0 AND MONTH(transaction_date) = MONTH(CURRENT_DATE())"
                Dim terpakai As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terpakai = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                Dim card As New ucBudgetCard
                card.NamaBudget = row("name").ToString
                card.SetProgress(terpakai, limit)
                flpDaftarBudget.Controls.Add(card)
            Next

            ' --- BAGIAN BARU: TAMBAH TOMBOL TILE DI AKHIR ---
            Dim btnAdd As New Button
            btnAdd.Text = "+ Tambah Budget"
            btnAdd.Size = New Size(300, 100) ' Samakan size dengan ucBudgetCard
            btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
            btnAdd.FlatStyle = FlatStyle.Flat
            btnAdd.Font = New System.Drawing.Font(Me.Font.FontFamily, 12, System.Drawing.FontStyle.Bold)
            btnAdd.ForeColor = System.Drawing.Color.Gray

            ' Sambungkan ke Event yang sudah ada
            AddHandler btnAdd.Click, AddressOf btnAddBudget_Click

            flpDaftarBudget.Controls.Add(btnAdd)
            ' -----------------------------------------------

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

                            ' --- PERBAIKAN DI SINI ---
                            ' Ganti RD jadi RDItem
                            item.TransactionID = RDItem("id")
                            ' -------------------------

                            item.Judul = RDItem("note").ToString
                            item.Nominal = RDItem("amount")
                            item.Margin = New Padding(20, 0, 0, 0)

                            ' --- LOGIC KLIK KANAN (Tetap sama) ---
                            AddHandler item.MouseDown, Sub(sender As Object, e As MouseEventArgs)
                                                           If e.Button = MouseButtons.Right Then
                                                               cmsTransaksi.Tag = item.TransactionID
                                                               cmsTransaksi.Show(Cursor.Position)
                                                           End If
                                                       End Sub
                            ' -------------------------------------

                            flpListTransaksi.Controls.Add(item)
                        End While
                    End Using
                End Using
            Next

        Catch ex As Exception
            MsgBox("Error load transaksi: " & ex.Message)
        End Try
    End Sub

    Private Sub menuHapus_Click(sender As Object, e As EventArgs) Handles menuHapus.Click
        ' Ambil ID dari Tag yang kita simpan tadi
        If cmsTransaksi.Tag Is Nothing Then Exit Sub
        Dim idTrans As Integer = CInt(cmsTransaksi.Tag)

        If MsgBox("Yakin hapus transaksi ini? Saldo akan dikembalikan.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                BukaDB()

                ' 1. Ambil Data Transaksi Dulu (Buat balikin saldo)
                Dim nominal As Decimal = 0
                Dim akunID As Integer = 0

                Using cmdCek As New MySqlCommand("SELECT amount, account_id FROM transactions WHERE id=" & idTrans, Conn)
                    Using rdCek As MySqlDataReader = cmdCek.ExecuteReader
                        If rdCek.Read() Then
                            nominal = rdCek("amount")
                            akunID = rdCek("account_id")
                        End If
                    End Using
                End Using

                ' 2. Hapus Transaksi
                Dim sqlDel As String = "DELETE FROM transactions WHERE id=" & idTrans
                Using cmdDel As New MySqlCommand(sqlDel, Conn)
                    cmdDel.ExecuteNonQuery()
                End Using

                ' 3. Kembalikan Saldo (Reverse Logic)
                ' Kalau tadinya Pengeluaran (-50.000), kita kurangi saldo dengan -50.000? SALAH.
                ' Rumus: SaldoBaru = SaldoLama - (NominalTransaksi)
                ' Contoh Expense: 100.000 - (-50.000) = 150.000 (Uang balik).
                ' Contoh Income: 100.000 - (50.000) = 50.000 (Uang ditarik).

                Dim sqlRev As String = "UPDATE accounts SET balance = balance - @amt WHERE id = @acc"
                Using cmdRev As New MySqlCommand(sqlRev, Conn)
                    cmdRev.Parameters.AddWithValue("@amt", nominal)
                    cmdRev.Parameters.AddWithValue("@acc", akunID)
                    cmdRev.ExecuteNonQuery()
                End Using

                MsgBox("Terhapus!")

                ' 4. Refresh Semua Halaman
                frmMain_Activated(Nothing, Nothing)

            Catch ex As Exception
                MsgBox("Gagal hapus: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnViewAllTrans_Click(sender As Object, e As EventArgs) Handles btnViewAllTrans.Click
        TabControl1.SelectedIndex = 1 ' Pindah ke Tab Transaksi
        LoadHalamanTransaksi() ' Refresh data
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
        chartLine.Plot.Clear()

        ' 1. Query SQL Agregasi Harian
        ' Mengambil total per hari dalam bulan ini
        Dim sql As String = ""
        If CurrentDashboardFilter = "All" Or CurrentDashboardFilter = "Expense" Then
            ' Kalau All/Expense, tampilkan garis Pengeluaran (Total negatif di-positifkan)
            sql = "SELECT DAY(transaction_date) as tgl, SUM(ABS(amount)) as total FROM transactions WHERE user_id=@uid AND amount < 0 AND MONTH(transaction_date)=MONTH(CURRENT_DATE()) GROUP BY tgl ORDER BY tgl"
        Else
            ' Kalau Income, tampilkan garis Pemasukan
            sql = "SELECT DAY(transaction_date) as tgl, SUM(amount) as total FROM transactions WHERE user_id=@uid AND amount > 0 AND MONTH(transaction_date)=MONTH(CURRENT_DATE()) GROUP BY tgl ORDER BY tgl"
        End If

        Dim listTgl As New List(Of Double)
        Dim listTotal As New List(Of Double)

        Using CMD As New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    listTgl.Add(Convert.ToDouble(RD("tgl")))
                    listTotal.Add(Convert.ToDouble(RD("total")))
                End While
            End Using
        End Using

        ' 2. Plot Data Real
        If listTgl.Count > 0 Then
            Dim sp = chartLine.Plot.Add.Scatter(listTgl.ToArray(), listTotal.ToArray())
            sp.LineWidth = 3
            sp.Color = If(CurrentDashboardFilter = "Income", ScottPlot.Colors.Green, ScottPlot.Colors.Salmon)

            chartLine.Plot.Title("Tren " & CurrentDashboardFilter & " Bulan Ini")
            chartLine.Plot.Axes.Bottom.Label.Text = "Tanggal"
            chartLine.Refresh()
        Else
            chartLine.Plot.Title("Belum ada data bulan ini")
            chartLine.Refresh()
        End If
    End Sub

    Sub LoadPieChart()
        chartPie.Plot.Clear()

        ' 1. Query Group by Category
        Dim sql As String = "SELECT c.name, SUM(ABS(t.amount)) as total, c.color_hex " &
                            "FROM transactions t JOIN categories c ON t.category_id = c.id " &
                            "WHERE t.user_id=@uid AND MONTH(t.transaction_date)=MONTH(CURRENT_DATE()) "

        ' Filter Query
        If CurrentDashboardFilter = "Income" Then
            sql &= "AND t.amount > 0 "
        ElseIf CurrentDashboardFilter = "Expense" Then
            sql &= "AND t.amount < 0 "
        Else
            sql &= "AND t.amount < 0 " ' Default All biasanya menampilkan breakdown pengeluaran
        End If

        sql &= "GROUP BY c.name"

        Dim slices As New List(Of ScottPlot.PieSlice)

        Using CMD As New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    Dim slice As New ScottPlot.PieSlice
                    slice.Value = Convert.ToDouble(RD("total"))
                    slice.Label = RD("name").ToString

                    ' Coba ambil warna dari DB, kalau error pake random
                    Try
                        Dim hex As String = RD("color_hex").ToString
                        slice.Fill = New ScottPlot.FillStyle With {.Color = ScottPlot.Color.FromHex(hex)}
                    Catch
                        ' Fallback color handled by ScottPlot usually
                    End Try

                    slices.Add(slice)
                End While
            End Using
        End Using

        ' 2. Plot
        If slices.Count > 0 Then
            Dim pie = chartPie.Plot.Add.Pie(slices)
            pie.DonutFraction = 0.5
            pie.SliceLabelDistance = 0.6
            chartPie.Plot.HideGrid()
            chartPie.Plot.Layout.Frameless()
            chartPie.Refresh()
        Else
            chartPie.Plot.Title("Data Kosong")
            chartPie.Refresh()
        End If
    End Sub
    ' Panggil ini di Form_Load dan setelah tambah transaksi
    Sub LoadNetWorth()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Dim query As String = "SELECT SUM(balance) FROM accounts WHERE user_id = @uid"
            Using CMD As New MySqlCommand(query, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Dim result = CMD.ExecuteScalar()

                ' GANTI lblNetWorth JADI lblNetWorthDashboard
                If IsDBNull(result) Then
                    lblNetWorthDashboard.Text = "Rp 0"
                Else
                    Dim total As Decimal = Convert.ToDecimal(result)
                    lblNetWorthDashboard.Text = "Rp " & total.ToString("N0")
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Sub LoadRiwayatTransaksi()
        ' GANTI flpRiwayat JADI flpRecentTrans
        flpRecentTrans.Controls.Clear()

        ' Query: Batasi cuma 10-20 transaksi terakhir biar enteng (Recent)
        Dim sql As String = "SELECT t.*, c.name as cat_name, c.icon_name FROM transactions t JOIN categories c ON t.category_id = c.id WHERE t.user_id = @uid ORDER BY t.transaction_date DESC LIMIT 20"

        Using CMD As New MySqlCommand(sql, Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read

                    Dim item As New ucTransactionItem
                    item.TransactionID = RD("id") ' <--- PENTING: Simpan ID
                    item.Judul = RD("note").ToString
                    item.Nominal = RD("amount")

                    ' --- LOGIC BARU: KLIK KANAN ---
                    ' Saat item diklik kanan, simpan ID-nya ke Tag Menu Strip biar bisa diambil nanti
                    AddHandler item.MouseDown, Sub(sender As Object, e As MouseEventArgs)
                                                   If e.Button = MouseButtons.Right Then
                                                       ' Simpan ID transaksi ke Tag milik ContextMenu
                                                       cmsTransaksi.Tag = item.TransactionID
                                                       ' Tampilkan menu di posisi mouse
                                                       cmsTransaksi.Show(Cursor.Position)
                                                   End If
                                               End Sub
                    ' -----------------------------

                    flpRecentTrans.Controls.Add(item)
                End While
            End Using
        End Using
    End Sub
    ' --- LOGIC LOAD AKUN HORIZONTAL ---
    Sub LoadAkunHorizontal()
        flpAkun.Controls.Clear()

        ' 1. Load Akun
        Using CMD As New MySqlCommand("SELECT * FROM accounts WHERE user_id=@uid", Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    Dim card As New ucAccountCard
                    card.NamaAkun = RD("name").ToString
                    card.Saldo = RD("balance")
                    card.SetWarna(RD("color_hex").ToString)
                    flpAkun.Controls.Add(card)
                End While
            End Using
        End Using

        ' 2. Button Add Akun
        Dim btnAdd As New Button
        btnAdd.Text = "+"
        btnAdd.Size = New Size(50, 100) ' Bikin agak ramping
        btnAdd.FlatStyle = FlatStyle.Flat
        ' PERBAIKAN: Panggil nama lengkap System.Drawing.Color
        btnAdd.BackColor = System.Drawing.Color.LightGray

        AddHandler btnAdd.Click, AddressOf btnAddAccount_Click
        flpAkun.Controls.Add(btnAdd)
    End Sub

    ' PERBAIKAN: Tambahkan Sub ini biar error hilang
    ' Cari Sub ini di frmMain.vb
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs)
        ' Buka Form Tambah Akun
        Dim frm As New frmAddAccount
        frm.ShowDialog()

        ' Refresh Tiles Akun setelah form ditutup
        LoadAkunHorizontal()
        LoadNetWorth() ' Net worth mungkin berubah karena saldo awal
    End Sub

    ' --- LOGIC LOAD BUDGET HORIZONTAL ---
    Sub LoadBudgetHorizontal()
        flpBudgetDashboard.Controls.Clear() ' Panel Budget Dashboard

        Try
            BukaDB()
            Dim dtBudget As New DataTable
            Using CMD As New MySqlCommand("SELECT * FROM budgets WHERE user_id = @uid", Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtBudget)
                End Using
            End Using

            For Each row As DataRow In dtBudget.Rows
                Dim budgetID As Integer = row("id")
                Dim limit As Decimal = row("amount_limit")
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE budget_id = " & budgetID & " AND amount < 0 AND MONTH(transaction_date) = MONTH(CURRENT_DATE())"

                Dim terpakai As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terpakai = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                Dim card As New ucBudgetCard
                card.NamaBudget = row("name").ToString
                card.SetProgress(terpakai, limit)
                flpBudgetDashboard.Controls.Add(card)
            Next

            ' Button Tambah Budget di Ujung
            Dim btnAdd As New Button
            btnAdd.Text = "+"
            btnAdd.Size = New Size(50, 100)
            btnAdd.BackColor = System.Drawing.Color.LightGray
            btnAdd.FlatStyle = FlatStyle.Flat
            ' Arahkan ke Sub yang sama dengan tombol Navigasi
            AddHandler btnAdd.Click, AddressOf btnAddBudget_Click
            flpBudgetDashboard.Controls.Add(btnAdd)

        Catch ex As Exception
        End Try
    End Sub

    ' --- LOGIC LOAD GOALS HORIZONTAL ---
    Sub LoadGoalsHorizontal()
        flpGoalsDashboard.Controls.Clear()

        Try
            BukaDB()
            Dim dtGoal As New DataTable
            Using CMD As New MySqlCommand("SELECT * FROM goals WHERE user_id = " & CurrentUser_ID, Conn)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dtGoal)
                End Using
            End Using

            For Each row As DataRow In dtGoal.Rows
                Dim goalID As Integer = row("id")
                Dim target As Decimal = row("target_amount")
                Dim sqlHitung As String = "SELECT COALESCE(SUM(ABS(amount)), 0) FROM transactions WHERE goal_id = " & goalID

                Dim terkumpul As Decimal = 0
                Using cmdHitung As New MySqlCommand(sqlHitung, Conn)
                    terkumpul = Convert.ToDecimal(cmdHitung.ExecuteScalar())
                End Using

                Dim card As New ucGoalCard
                card.NamaGoal = row("name").ToString
                Dim tgl As Date = Convert.ToDateTime(row("target_date"))
                card.TanggalTarget = tgl.ToString("dd MMM yyyy")
                card.SetProgress(terkumpul, target)

                flpGoalsDashboard.Controls.Add(card)
            Next

            ' Button Tambah Goal di Ujung
            Dim btnAdd As New Button
            btnAdd.Text = "+"
            btnAdd.Size = New Size(50, 100)
            btnAdd.BackColor = System.Drawing.Color.LightGray
            btnAdd.FlatStyle = FlatStyle.Flat
            AddHandler btnAdd.Click, AddressOf btnAddGoal_Click
            flpGoalsDashboard.Controls.Add(btnAdd)

        Catch ex As Exception
        End Try
    End Sub

End Class
