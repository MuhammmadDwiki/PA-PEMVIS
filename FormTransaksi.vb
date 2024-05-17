Imports MySql.Data.MySqlClient
Public Class FormTransaksi

    Private Sub HalamanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.koneksi()
        tampilbarang()
    End Sub

    Private Sub tampilbarang()
        DataGridviewPembelian.Rows.Clear()
        Module1.CMD = New MySqlCommand("SELECT * FROM barang", Module1.CONN)
        Module1.RD = Module1.CMD.ExecuteReader()

        While Module1.RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridviewPembelian)
            row.Cells(0).Value = Module1.RD("id_barang")
            row.Cells(1).Value = Module1.RD("nama_barang")
            row.Cells(2).Value = Module1.RD("jenis_barang")
            row.Cells(3).Value = Module1.RD("stok_barang")
            row.Cells(4).Value = Module1.RD("harga_barang")
            DataGridviewPembelian.Rows.Add(row)
        End While

        Module1.RD.Close()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Dim namaBarang As String = tbNamaBarang.Text.Trim()
        Dim jumlahBarang As Integer

        If Integer.TryParse(tbJumlah.Text, jumlahBarang) Then
            Module1.CMD = New MySqlCommand("SELECT stok_barang, harga_barang FROM barang WHERE nama_barang = @namaBarang", Module1.CONN)
            Module1.CMD.Parameters.AddWithValue("@namaBarang", namaBarang)
            Module1.RD = Module1.CMD.ExecuteReader()

            If Module1.RD.HasRows Then
                Module1.RD.Read()
                Dim stokBarang As Integer = Module1.RD("stok_barang")
                Dim hargaBarang As Decimal = Module1.RD("harga_barang")

                If jumlahBarang > stokBarang Then
                    MessageBox.Show("Jumlah barang melebihi stok yang tersedia. Silakan masukkan jumlah yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim totalHarga As Decimal = jumlahBarang * hargaBarang
                    tbTotal.Text = totalHarga.ToString()

                    Dim query As String = "INSERT INTO pembelian (nama_barang, jumlah, total_harga) VALUES (@namaBarang, @jumlahBarang, @totalHarga)"
                    Module1.CMD = New MySqlCommand(query, Module1.CONN)
                    Module1.CMD.Parameters.AddWithValue("@namaBarang", namaBarang)
                    Module1.CMD.Parameters.AddWithValue("@jumlahBarang", jumlahBarang)
                    Module1.CMD.Parameters.AddWithValue("@totalHarga", totalHarga)

                    Try
                        Module1.CMD.ExecuteNonQuery()
                        MessageBox.Show("Pembelian berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim updateQuery As String = "UPDATE barang SET stok_barang = stok_barang - @jumlahBarang WHERE nama_barang = @namaBarang"
                        Module1.CMD = New MySqlCommand(updateQuery, Module1.CONN)
                        Module1.CMD.Parameters.AddWithValue("@jumlahBarang", jumlahBarang)
                        Module1.CMD.Parameters.AddWithValue("@namaBarang", namaBarang)
                        Module1.CMD.ExecuteNonQuery()


                        tbNamaBarang.Clear()
                        tbJumlah.Clear()
                        tbTotal.Clear()

                        tampilbarang()
                    Catch ex As MySqlException
                        MessageBox.Show("Terjadi kesalahan saat menyimpan data pembelian: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("Nama barang tidak ditemukan dalam database. Silakan masukkan nama barang yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Module1.RD.Close()
        Else
            MessageBox.Show("Jumlah barang yang dimasukkan tidak valid. Silakan masukkan angka yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim formutama As New FormUtamaUser()
        formutama.Show()
        Me.Hide()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

    End Sub
End Class