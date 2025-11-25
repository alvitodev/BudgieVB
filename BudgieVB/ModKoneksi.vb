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
    ' Fungsi untuk mengubah password jadi kode acak (Enkripsi MD5)
    Public Function GetMD5(ByVal text As String) As String
        Using md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()
            Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(text)
            Dim hash As Byte() = md5.ComputeHash(bytes)

            Dim sb As New System.Text.StringBuilder()
            For i As Integer = 0 To hash.Length - 1
                sb.Append(hash(i).ToString("X2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Module