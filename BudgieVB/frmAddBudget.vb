Imports MySql.Data.MySqlClient

Public Class frmAddBudget
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or numLimit.Value <= 0 Then
            MsgBox("Nama dan Limit harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            BukaDB() ' Pastikan koneksi terbuka

            Dim sql As String = "INSERT INTO budgets (user_id, name, amount_limit, period, start_date) VALUES (@uid, @name, @limit, 'Monthly', @date)"
            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@name", txtNama.Text)
                CMD.Parameters.AddWithValue("@limit", numLimit.Value)
                CMD.Parameters.AddWithValue("@date", Date.Now.ToString("yyyy-MM-dd")) ' Mulai hari ini

                CMD.ExecuteNonQuery()
            End Using

            MsgBox("Budget berhasil dibuat!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Gagal simpan: " & ex.Message)
        End Try
    End Sub
End Class