Public Class FormUtamaUser
    Private userId As Integer
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()

        Me.Close()
    End Sub

    Private Sub FormUtamaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        FormTransaksi.Show()
    End Sub

    Private Sub EditProfile_Click(sender As Object, e As EventArgs) Handles btnEditPorifle.Click
        Dim editProfileForm As New EditProfile(userId) ' userId adalah ID pengguna yang sedang login
        editProfileForm.ShowDialog()
    End Sub
End Class