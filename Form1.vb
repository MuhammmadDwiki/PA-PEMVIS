Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (asumsikan ada metode koneksi terpisah)
        koneksi()

        ' Pastikan password tersembunyi pada saat form load
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT UserType FROM akun WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtNama.Text)
                    cmd.Parameters.AddWithValue("@password", txtPass.Text)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim userType As String = reader("UserType").ToString()

                            If userType = "admin" Then
                                MessageBox.Show("Login berhasil sebagai admin!")
                                Me.Hide()
                                Dim formUtama As New FormUtamaAdmin()
                                formUtama.ShowDialog()
                                'Me.Show()
                            ElseIf userType = "user" Then
                                MessageBox.Show("Login berhasil sebagai user!")
                                Me.Hide()
                                Dim formUtamaUser As New FormUtamaUser()
                                formUtamaUser.ShowDialog()
                                Me.Show()
                            End If
                        Else
                            MessageBox.Show("Login gagal. Periksa kembali username dan password Anda.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Login gagal: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        FormRegis.Show()
        Me.Hide() ' Sembunyikan form login
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub

    Private Sub cbSee_CheckedChanged(sender As Object, e As EventArgs) Handles cbSee.CheckedChanged
        ' Mengatur apakah password terlihat atau tidak berdasarkan status checkbox
        If cbSee.Checked Then
            txtPass.UseSystemPasswordChar = False ' Password terlihat
        Else
            txtPass.UseSystemPasswordChar = True ' Password tersembunyi
        End If
    End Sub

End Class
