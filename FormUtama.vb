Public Class FormUtamaAdmin

    Private Sub btnTambahData_Click(sender As Object, e As EventArgs) Handles btnTambahData.Click
        FormTambahDataBarang.Show()
        Me.Close()


    End Sub

    Private Sub FormUtamaAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()

        Me.Close()
    End Sub
End Class