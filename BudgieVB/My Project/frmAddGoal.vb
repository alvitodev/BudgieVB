Imports MySql.Data.MySqlClient

Public Class frmAddGoal
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or numTarget.Value <= 0 Then
            MsgBox("Isi data yang lengkap!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            BukaDB()
            ' Insert Goal Baru (Default type='Income' alias nabung)
            Dim sql As String = "INSERT INTO goals (user_id, name, target_amount, target_date, type) VALUES (@uid, @name, @amt, @date, 'Income')"

            Using CMD As New MySqlCommand(sql, Conn)
                CMD.Parameters.AddWithValue("@uid", CurrentUser_ID)
                CMD.Parameters.AddWithValue("@name", txtNama.Text)
                CMD.Parameters.AddWithValue("@amt", numTarget.Value)
                CMD.Parameters.AddWithValue("@date", dtpTarget.Value)
                CMD.ExecuteNonQuery()
            End Using

            MsgBox("Goal berhasil dibuat! Semangat nabung!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class