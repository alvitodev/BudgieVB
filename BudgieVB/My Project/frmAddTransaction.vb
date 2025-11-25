Imports MySql.Data.MySqlClient

Public Class frmAddTransaction
    Dim SelectedCategoryID As Integer = 0
    ' Tambahkan Variabel Global Baru di bagian atas Class
    Dim CurrentTransactionType As String = "Expense" ' Default Expense

    ' --- LOGIC LOAD KATEGORI DENGAN FILTER ---
    Sub LoadCategories(Optional tipe As String = "Expense")
        flpCategories.Controls.Clear()
        CurrentTransactionType = tipe ' Simpan status saat ini

        ' Update Warna Tombol (Visual Feedback)
        If tipe = "Expense" Then
            btnModeExpense.BackColor = Color.Salmon
            btnModeExpense.ForeColor = Color.White
            btnModeIncome.BackColor = Color.WhiteSmoke
            btnModeIncome.ForeColor = Color.Black
        Else
            btnModeIncome.BackColor = Color.LightGreen
            btnModeIncome.ForeColor = Color.White
            btnModeExpense.BackColor = Color.WhiteSmoke
            btnModeExpense.ForeColor = Color.Black
        End If

        ' Query Filter berdasarkan Tipe
        Using CMD As New MySqlCommand("SELECT * FROM categories WHERE type = @tipe", Conn)
            CMD.Parameters.AddWithValue("@tipe", tipe)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    Dim btn As New Button
                    btn.Width = 80
                    btn.Height = 80
                    btn.Text = RD("name").ToString
                    btn.Tag = RD("id")
                    btn.BackColor = Color.White
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderSize = 1
                    AddHandler btn.Click, AddressOf Category_Click
                    flpCategories.Controls.Add(btn)
                End While
            End Using
        End Using
    End Sub

    ' --- EVENT TOMBOL TYPE ---

    Private Sub btnModeExpense_Click(sender As Object, e As EventArgs) Handles btnModeExpense.Click
        LoadCategories("Expense")
    End Sub

    Private Sub btnModeIncome_Click(sender As Object, e As EventArgs) Handles btnModeIncome.Click
        LoadCategories("Income")
    End Sub

    Private Sub frmAddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form dibuka, load data dari DB
        LoadCategories()
        LoadAccounts()
        LoadBudgetsCombo()
        LoadGoalsCombo()
        LoadCategories("Expense")

        ' Set default tanggal hari ini
        dtpTanggal.Value = Date.Now

        ' Sembunyikan Header TabControl (Supaya user gak bisa klik tab sembarangan)
        Nama.Appearance = TabAppearance.FlatButtons
        Nama.ItemSize = New Size(0, 1)
        Nama.SizeMode = TabSizeMode.Fixed
    End Sub

    ' --- LOGIC LOAD DATA ---
    Sub LoadCategories()
        flpCategories.Controls.Clear()

        ' Ambil semua kategori
        Using CMD As New MySqlCommand("SELECT * FROM categories", Conn)
            Using RD As MySqlDataReader = CMD.ExecuteReader
                While RD.Read
                    ' Bikin tombol dinamis untuk setiap kategori
                    Dim btn As New Button
                    btn.Width = 80
                    btn.Height = 80
                    btn.Text = RD("name").ToString
                    btn.Tag = RD("id") ' Simpan ID di Tag
                    btn.BackColor = Color.WhiteSmoke
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderSize = 0

                    ' Event saat tombol kategori diklik
                    AddHandler btn.Click, AddressOf Category_Click

                    flpCategories.Controls.Add(btn)
                End While
            End Using
        End Using
    End Sub

    Sub LoadAccounts()
        ' Isi ComboBox Akun
        Dim dt As New DataTable
        Using CMD As New MySqlCommand("SELECT id, name FROM accounts WHERE user_id = @uid", Conn)
            CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
            Using DA As New MySqlDataAdapter(CMD)
                DA.Fill(dt)
            End Using
        End Using

        cmbAkun.DataSource = dt
        cmbAkun.DisplayMember = "name" ' Yang tampil teks nama
        cmbAkun.ValueMember = "id"     ' Yang diambil value ID
    End Sub

    Sub LoadBudgetsCombo()
        Dim dt As New DataTable
        Using CMD As New MySqlCommand("SELECT id, name FROM budgets WHERE user_id = " & CurrentUser_ID, Conn)
            Using DA As New MySqlDataAdapter(CMD)
                DA.Fill(dt)
            End Using
        End Using

        ' Tambahkan opsi kosong (No Budget)
        Dim row As DataRow = dt.NewRow()
        row("id") = 0
        row("name") = "-- Tanpa Budget --"
        dt.Rows.InsertAt(row, 0)

        cmbBudget.DataSource = dt
        cmbBudget.DisplayMember = "name"
        cmbBudget.ValueMember = "id"
    End Sub

    Sub LoadGoalsCombo()
        Try
            ' Pastikan koneksi aman
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim dt As New DataTable
            ' Ambil ID dan Nama Goal punya user
            Using CMD As New MySqlCommand("SELECT id, name FROM goals WHERE user_id = @uid", Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                Using DA As New MySqlDataAdapter(CMD)
                    DA.Fill(dt)
                End Using
            End Using

            ' Bikin opsi default "Tanpa Goal" di paling atas
            Dim row As DataRow = dt.NewRow()
            row("id") = 0
            row("name") = "-- Tanpa Goal --"
            dt.Rows.InsertAt(row, 0)

            ' Pasang ke ComboBox Goal
            cmbGoal.DataSource = dt
            cmbGoal.DisplayMember = "name"
            cmbGoal.ValueMember = "id"

        Catch ex As Exception
            MsgBox("Gagal load goal: " & ex.Message)
        End Try
    End Sub

    ' --- LOGIC INTERAKSI ---
    Private Sub Category_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        ' Reset warna tombol lain
        For Each ctrl As Control In flpCategories.Controls
            ctrl.BackColor = Color.WhiteSmoke
        Next

        ' Tandai tombol yang dipilih
        btn.BackColor = Color.LightBlue
        SelectedCategoryID = CInt(btn.Tag)
    End Sub

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        If txtJudul.Text = "" Then
            MsgBox("Isi judul dulu bro!")
            Exit Sub
        End If
        Nama.SelectedIndex = 1 ' Pindah ke Tab Kategori
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        If SelectedCategoryID = 0 Then
            MsgBox("Pilih kategori dulu!")
            Exit Sub
        End If
        Nama.SelectedIndex = 2 ' Pindah ke Tab Nominal
    End Sub

    ' Logic Numpad (Hubungkan semua tombol angka 0-9 ke event ini)
    Private Sub Numpad_Click(sender As Object, e As EventArgs) Handles btnAngka1.Click, btnAngka2.Click, btnAngka3.Click, btnAngka4.Click, btnAngka5.Click, btnAngka6.Click, btnAngka7.Click, btnAngka8.Click, btnAngka9.Click, btnAngka0.Click
        Dim btn = CType(sender, Button)
        lblNominalDisplay.Text &= btn.Text
    End Sub

    ' Tombol Hapus Angka (Backspace)
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If lblNominalDisplay.Text.Length > 0 Then
            lblNominalDisplay.Text = lblNominalDisplay.Text.Substring(0, lblNominalDisplay.Text.Length - 1)
        End If
    End Sub

    ' --- LOGIC SIMPAN FINAL ---
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' 1. Validasi Input Dasar
        If lblNominalDisplay.Text = "" OrElse lblNominalDisplay.Text = "0" Then
            MsgBox("Isi nominal dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cmbAkun.SelectedIndex < 0 Then
            MsgBox("Pilih akun dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            ' 2. Buka Koneksi (Cek State)
            If Conn.State = ConnectionState.Closed Or Conn.State = ConnectionState.Broken Then Conn.Open()

            ' 3. Persiapan Data
            Dim nominal As Decimal = Decimal.Parse(lblNominalDisplay.Text)
            ' Tentukan tanda plus/minus berdasarkan tombol yang dipilih user
            If CurrentTransactionType = "Expense" Then
                nominal = Math.Abs(nominal) * -1 ' Pastikan Negatif
            Else
                nominal = Math.Abs(nominal) ' Pastikan Positif (Income)
            End If
            ' Cek Income/Expense
            Dim tipeKategori As String = ""
            Using cmdCek As New MySqlCommand("SELECT type FROM categories WHERE id = @catID", Conn)
                cmdCek.Parameters.AddWithValue("@catID", SelectedCategoryID)
                Dim result = cmdCek.ExecuteScalar()
                If result IsNot Nothing Then tipeKategori = result.ToString()
            End Using

            ' Kalau Expense, jadikan negatif
            If tipeKategori = "Expense" Then nominal = Math.Abs(nominal) * -1

            ' 4. Handle Budget ID (Bagian Rawan Error)
            ' Kita pastikan nilainya benar-benar NULL database (DBNull.Value) kalau tidak dipilih
            Dim idBudget As Object = DBNull.Value
            If cmbBudget.SelectedIndex > 0 Then ' Asumsi index 0 adalah "-- Tanpa Budget --"
                If IsNumeric(cmbBudget.SelectedValue) Then
                    idBudget = Convert.ToInt32(cmbBudget.SelectedValue)
                End If
            End If

            ' Handle Goal ID (Logic sama, biarkan NULL dulu kalau belum ada fitur Goal)
            ' Handle Goal ID
            Dim idGoal As Object = DBNull.Value
            If cmbGoal.SelectedIndex > 0 Then
                If IsNumeric(cmbGoal.SelectedValue) Then
                    idGoal = Convert.ToInt32(cmbGoal.SelectedValue)
                End If
            End If

            ' 5. Query Insert (Perhatikan Parameter @bud)
            Dim sql As String = "INSERT INTO transactions (user_id, account_id, category_id, budget_id, goal_id, amount, note, transaction_date) VALUES (@uid, @acc, @cat, @bud, @goal, @amt, @note, @date)"

            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@acc", Convert.ToInt32(cmbAkun.SelectedValue))
                CMD.Parameters.AddWithValue("@cat", SelectedCategoryID)

                ' Perbaikan Fatal Error: Explicitly set parameter value
                CMD.Parameters.AddWithValue("@bud", idBudget)
                CMD.Parameters.AddWithValue("@goal", idGoal)

                CMD.Parameters.AddWithValue("@amt", nominal)
                CMD.Parameters.AddWithValue("@note", txtJudul.Text)
                CMD.Parameters.AddWithValue("@date", dtpTanggal.Value)

                CMD.ExecuteNonQuery()
            End Using

            ' 6. Update Saldo Akun
            Dim sqlUpd As String = "UPDATE accounts SET balance = balance + @amt WHERE id = @acc"
            Using CMD As New MySqlCommand(sqlUpd, Conn)
                CMD.Parameters.AddWithValue("@amt", nominal)
                CMD.Parameters.AddWithValue("@acc", Convert.ToInt32(cmbAkun.SelectedValue))
                CMD.ExecuteNonQuery()
            End Using

            MsgBox("Transaksi Berhasil!", MsgBoxStyle.Information)
            Me.Close()

        Catch ex As Exception
            ' Tampilkan pesan error lengkap biar ketahuan salahnya dimana
            MsgBox("Gagal Simpan: " & ex.Message & vbCrLf & "Source: " & ex.Source, MsgBoxStyle.Critical)
        Finally
            ' Jangan tutup koneksi di sini kalau kamu pakai Module global yang koneksinya satu untuk semua
            ' Tapi kalau mau aman, biarkan terbuka karena logic frmMain butuh koneksi juga
        End Try
    End Sub

End Class