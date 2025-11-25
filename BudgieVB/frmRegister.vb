Imports MySql.Data.MySqlClient

Public Class frmRegister

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' 1. Validasi Input
        If txtNama.Text = "" Or txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Semua data harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtPass.Text <> txtConfirm.Text Then
            MsgBox("Konfirmasi password tidak cocok!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Try
            BukaDB()

            ' 2. Cek apakah username sudah ada
            Dim cekSQL As String = "SELECT COUNT(*) FROM users WHERE username = @u"
            Using cmdCek As New MySqlCommand(cekSQL, Conn)
                cmdCek.Parameters.AddWithValue("@u", txtUser.Text)
                Dim count = Convert.ToInt32(cmdCek.ExecuteScalar())
                If count > 0 Then
                    MsgBox("Username sudah dipakai orang lain!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End Using

            ' 3. Insert User Baru (Password di-Hash MD5)
            Dim passHash As String = GetMD5(txtPass.Text)
            Dim sqlInsert As String = "INSERT INTO users (username, password_hash, full_name) VALUES (@u, @p, @n); SELECT LAST_INSERT_ID();"

            Dim newUserID As Integer = 0
            Using cmdInsert As New MySqlCommand(sqlInsert, Conn)
                cmdInsert.Parameters.AddWithValue("@u", txtUser.Text)
                cmdInsert.Parameters.AddWithValue("@p", passHash)
                cmdInsert.Parameters.AddWithValue("@n", txtNama.Text)

                ' Ambil ID user yang baru saja dibuat
                newUserID = Convert.ToInt32(cmdInsert.ExecuteScalar())
            End Using

            ' 4. SEEDING DATA (Modal Awal User Baru)
            ' Berikan dia 2 akun default biar gak bingung
            Dim sqlSeed As String = "INSERT INTO accounts (user_id, name, currency_code, balance, color_hex) VALUES " &
                                    "(" & newUserID & ", 'Dompet Tunai', 'IDR', 0, '#2ECC71'), " &
                                    "(" & newUserID & ", 'Bank BCA', 'IDR', 0, '#3498DB')"

            Using cmdSeed As New MySqlCommand(sqlSeed, Conn)
                cmdSeed.ExecuteNonQuery()
            End Using

            MsgBox("Registrasi Berhasil! Silakan Login.")

            ' Pindah ke Form Login
            Dim frm As New frmLogin
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error Register: " & ex.Message)
        End Try
    End Sub

    ' Navigasi ke Login
    Private Sub lblToLogin_Click(sender As Object, e As EventArgs) Handles lblToLogin.Click
        Dim frm As New frmLogin
        frm.Show()
        Me.Hide()
    End Sub
End Class