Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then Exit Sub

        Try
            BukaDB()

            Dim passHash As String = GetMD5(txtPass.Text)
            Dim sql As String = "SELECT id, full_name FROM users WHERE username=@u AND password_hash=@p"

            ' Variabel penampung sementara
            Dim loginBerhasil As Boolean = False
            Dim idUser As Integer = 0
            Dim namaUser As String = ""

            ' 1. CEK LOGIN (Reader Buka -> Ambil Data -> Reader Tutup)
            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@u", txtUser.Text)
                CMD.Parameters.AddWithValue("@p", passHash)

                Using RD As MySqlDataReader = CMD.ExecuteReader
                    If RD.Read() Then
                        loginBerhasil = True
                        idUser = RD("id")
                        namaUser = RD("full_name").ToString
                    End If
                End Using ' <--- DI SINI READER OTOMATIS TERTUTUP
            End Using

            ' 2. EKSEKUSI PINDAH FORM (Setelah Reader Tertutup)
            If loginBerhasil Then
                ' Simpan ke variabel global
                CurrentUser_ID = idUser

                MsgBox("Selamat Datang, " & namaUser & "!", MsgBoxStyle.Information)

                ' Sekarang aman buka form baru karena koneksi sudah nganggur
                Dim frm As New Budgie
                frm.Show()
                Me.Hide()
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Gagal Login: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frm As New frmRegister
        frm.Show()
        Me.Hide()
    End Sub

End Class