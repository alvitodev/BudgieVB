Imports MySql.Data.MySqlClient

Public Class frmAddTransaction
    Dim SelectedCategoryID As Integer = 0

    Private Sub frmAddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Saat form dibuka, load data dari DB
        LoadCategories()
        LoadAccounts()

        ' Set default tanggal hari ini
        dtpTanggal.Value = Date.Now

        ' Sembunyikan Header TabControl (Supaya user gak bisa klik tab sembarangan)
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed
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
        TabControl1.SelectedIndex = 1 ' Pindah ke Tab Kategori
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        If SelectedCategoryID = 0 Then
            MsgBox("Pilih kategori dulu!")
            Exit Sub
        End If
        TabControl1.SelectedIndex = 2 ' Pindah ke Tab Nominal
    End Sub

    ' Logic Numpad (Hubungkan semua tombol angka 0-9 ke event ini)
    Private Sub Numpad_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
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
        If lblNominalDisplay.Text = "" Or cmbAkun.SelectedValue Is Nothing Then Exit Sub

        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            Dim nominal As Decimal = Decimal.Parse(lblNominalDisplay.Text)

            ' Cek tipe kategori (Income/Expense) untuk menentukan tanda +/-
            ' Kita perlu query cek tipe kategori dulu
            Dim tipe As String = ""
            Using cmdCek As New MySqlCommand("SELECT type FROM categories WHERE id=" & SelectedCategoryID, Conn)
                tipe = cmdCek.ExecuteScalar().ToString
            End Using

            If tipe = "Expense" Then nominal = nominal * -1

            ' 1. Insert Transaksi
            Dim sql As String = "INSERT INTO transactions (user_id, account_id, category_id, amount, note, transaction_date) VALUES (@uid, @acc, @cat, @amt, @note, @date)"
            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@acc", cmbAkun.SelectedValue)
                CMD.Parameters.AddWithValue("@cat", SelectedCategoryID)
                CMD.Parameters.AddWithValue("@amt", nominal)
                CMD.Parameters.AddWithValue("@note", txtJudul.Text)
                CMD.Parameters.AddWithValue("@date", dtpTanggal.Value)
                CMD.ExecuteNonQuery()
            End Using

            ' 2. Update Saldo Akun
            Dim sqlUpd As String = "UPDATE accounts SET balance = balance + @amt WHERE id = @acc"
            Using CMD As New MySqlCommand(sqlUpd, Conn)
                CMD.Parameters.AddWithValue("@amt", nominal)
                CMD.Parameters.AddWithValue("@acc", cmbAkun.SelectedValue)
                CMD.ExecuteNonQuery()
            End Using

            MsgBox("Transaksi berhasil disimpan!")
            Me.Close() ' Tutup form wizard

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class