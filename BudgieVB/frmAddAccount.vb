Imports MySql.Data.MySqlClient

Public Class frmAddAccount
    ' Variabel nyimpen warna pilihan user (Default Biru)
    Dim SelectedColorHex As String = "#6495ED"

    Private Sub frmAddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrencies()
    End Sub

    Sub LoadCurrencies()
        ' Load data mata uang dari tabel currencies
        Try
            BukaDB()
            Dim dt As New DataTable
            Using DA As New MySqlDataAdapter("SELECT code, name FROM currencies", Conn)
                DA.Fill(dt)
            End Using

            cmbCurrency.DataSource = dt
            cmbCurrency.DisplayMember = "code" ' Tampil: IDR, USD
            cmbCurrency.ValueMember = "code"
        Catch ex As Exception
        End Try
    End Sub

    ' Fitur Pilih Warna (Color Picker)
    Private Sub btnWarna_Click(sender As Object, e As EventArgs) Handles btnWarna.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            btnWarna.BackColor = cd.Color
            ' Convert warna ke Hex Code (#RRGGBB) buat disimpan di database
            SelectedColorHex = "#" & cd.Color.R.ToString("X2") & cd.Color.G.ToString("X2") & cd.Color.B.ToString("X2")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Then
            MsgBox("Nama akun wajib diisi!")
            Exit Sub
        End If

        Try
            BukaDB()
            Dim sql As String = "INSERT INTO accounts (user_id, name, currency_code, balance, color_hex) VALUES (@uid, @nm, @cur, @bal, @col)"

            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@nm", txtNama.Text)
                CMD.Parameters.AddWithValue("@cur", cmbCurrency.SelectedValue)
                CMD.Parameters.AddWithValue("@bal", numSaldo.Value)
                CMD.Parameters.AddWithValue("@col", SelectedColorHex)
                CMD.ExecuteNonQuery()
            End Using

            MsgBox("Akun berhasil dibuat!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class