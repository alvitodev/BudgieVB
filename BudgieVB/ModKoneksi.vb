Imports MySql.Data.MySqlClient

Module ModKoneksi
    ' Sesuaikan password jika ada
    Public StrKoneksi As String = "Server=localhost;Database=budgie;Uid=root;Pwd=;"
    Public Conn As New MySqlConnection(StrKoneksi)
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public CurrentUser_ID As Integer = 1 ' Menyimpan ID user yang login

    Public Sub BukaDB()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()
        Catch ex As Exception
            MsgBox("Gagal koneksi: " & ex.Message)
        End Try
    End Sub
End Module