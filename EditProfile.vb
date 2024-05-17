Imports MySql.Data.MySqlClient

Public Class EditProfile
    ' Properti untuk menyimpan ID pengguna yang sedang diedit
    Private userId As Integer

    ' Constructor yang menerima ID pengguna
    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        userId = id
    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi data profil saat form dimuat
        LoadProfileData()
        koneksi()
    End Sub

    Private Sub LoadProfileData()
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "SELECT Nama, Email, nomor_telepon, Username, Password FROM akun WHERE idUSer = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNama.Text = reader("Nama").ToString()
                            txtEmail.Text = reader("email").ToString()
                            txtNoHP.Text = reader("nomor_telepon").ToString()
                            txtUsername.Text = reader("username").ToString()
                            txtPassword.Text = reader("password").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data profil: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connStr As String = "server=localhost;user=root;password=;database=tokopancing"
        Using conn As New MySqlConnection(connStr)
            Try
                conn.Open()
                Dim query As String = "UPDATE akun SET Nama = @nama, Email = @Email, NoHP = @NoHP, Username = @username, Password = @password WHERE isUser = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idUser", userId)
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@nomor_telepon", txtNoHP.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Profil berhasil diperbarui.")
                    Me.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Gagal memperbarui profil: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FormUtamaUser.Show()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

    End Sub
End Class
