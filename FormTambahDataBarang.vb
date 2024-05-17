Imports MySql.Data.MySqlClient

Public Class FormTambahDataBarang

    Sub Kosong()
        txtNgaran.Clear()
        txtIdbarang.Clear()
        txtHarga.Clear()
        txtMerk.Clear()
        txtNgaran.Focus()
        cboTipe.SelectedIndex = -1
    End Sub

    Sub isi()
        txtNgaran.Clear()
        txtNgaran.Focus()
    End Sub

    Sub tampilBarang()
        DataGridViewAdmin.Rows.Clear()
        CMD = New MySqlCommand("select * from barang", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridViewAdmin)
            row.Cells(0).Value = RD("id_barang")
            row.Cells(1).Value = RD("nama_barang")
            row.Cells(2).Value = RD("jenis_barang")
            row.Cells(3).Value = RD("merek")
            row.Cells(4).Value = RD("stok_barang")
            row.Cells(5).Value = RD("harga_barang")
            DataGridViewAdmin.Rows.Add(row)
        End While
        RD.Close()
    End Sub

    Private Sub nonInput()
        txtIdbarang.Enabled = False
        txtNgaran.Enabled = False
        txtHarga.Enabled = False
        txtMerk.Enabled = False
        txtStok.Enabled = False
        btnTambah.Enabled = False
    End Sub

    Private Sub allowInput()
        txtIdbarang.Enabled = True
        txtNgaran.Enabled = True
        txtHarga.Enabled = True
        txtMerk.Enabled = True
        txtStok.Enabled = True
        btnTambah.Enabled = True
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub FormTambahDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'nonInput()
        Kosong()
        koneksi()
        tampilBarang()
    End Sub

    Private Sub DataGridViewAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAdmin.CellClick
        If DataGridViewAdmin.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewAdmin.SelectedRows(0)

            txtIdbarang.Text = row.Cells(0).Value
            txtNgaran.Text = row.Cells(1).Value
            cboTipe.Text = row.Cells(2).Value
            txtMerk.Text = row.Cells(3).Value
            txtStok.Text = row.Cells(4).Value
            txtHarga.Text = row.Cells(5).Value

        End If
    End Sub

    Private Sub DataGridViewAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAdmin.CellContentClick
       
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNgaran.Text = "" Then
            MsgBox("ID Barang belum diisi")
            txtIdbarang.Focus()
        Else
            Dim ubah As String = "UPDATE barang SET nama_barang = '" & txtNgaran.Text & "', merek = '" & txtMerk.Text & "', stok_barang = '" & txtStok.Text & "', jenis_barang = '" & cboTipe.Text & "', harga_barang = '" & txtHarga.Text & "' WHERE id_barang = '" & txtIdbarang.Text & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diubah")
            tampilBarang()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNgaran.Text = Nothing Then
            MsgBox("Id Barang belum diisi")
            txtIdbarang.Focus()
        Else
            Dim ubah As String = "delete from barang where id_barang = '" & txtIdbarang.Text & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            tampilBarang()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        tampilBarang()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text <> Nothing Then
            CMD = New MySqlCommand("select * from barang where nama_barang like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DataGridViewAdmin.Rows.Clear()
                While RD.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(DataGridViewAdmin)
                    row.Cells(0).Value = RD("id_barang")
                    row.Cells(1).Value = RD("nama_barang")
                    row.Cells(2).Value = RD("jenis_barang")
                    row.Cells(3).Value = RD("merek")
                    row.Cells(4).Value = RD("stok_barang")
                    row.Cells(5).Value = RD("harga_barang")
                    DataGridViewAdmin.Rows.Add(row)
                End While
            Else
                MsgBox("Data tidak ditemukan")
            End If
            RD.Close()
        Else
            tampilBarang()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        allowInput()
    End Sub

    Private Function IsInputValid() As Boolean
        If String.IsNullOrEmpty(txtIdbarang.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(txtNgaran.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(txtMerk.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(txtHarga.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(cboTipe.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrEmpty(txtStok.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub txtIdbarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdbarang.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("select * from barang", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                txtIdbarang.Text = RD("jenis_barang")
                txtIdbarang.Focus()
            Else
                isi()
                txtIdbarang.Focus()
            End If
        End If
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ControlChars.Back Then
            MessageBox.Show("Masukkan dalam bentuk angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If IsInputValid() Then
            If txtIdbarang.Text = Nothing And txtNgaran.Text = Nothing And txtStok.Text = Nothing And cboTipe.Text = Nothing And txtHarga.Text = Nothing Then
                MsgBox("Data Belum Lengkap")
                txtIdbarang.Focus()
            Else
                CMD = New MySqlCommand("Select * from barang where id_barang ='" & txtIdbarang.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    RD.Close()
                    CMD = New MySqlCommand("insert into barang values('" & txtIdbarang.Text & "', '" & txtNgaran.Text & "', '" & txtMerk.Text & "', '" & txtStok.Text & "', '" & cboTipe.Text & "', '" & txtHarga.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    tampilBarang()
                    Kosong()
                    MsgBox("Simpan Data Sukses!")
                    txtIdbarang.Focus()
                    nonInput()
                Else
                    RD.Close()
                    MsgBox("Data Tersebut Sudah Ada")
                End If
            End If
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> ControlChars.Back Then
            MessageBox.Show("Masukkan dalam bentuk angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub txtNgaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNgaran.KeyPress
        txtNgaran.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            txtNgaran.Text = UCase(txtNgaran.Text)
        End If
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " AndAlso Not e.KeyChar = "," AndAlso Not e.KeyChar = "." Then
            e.Handled = True
            MsgBox("Inputan Hanya Bisa Huruf, Angka, Koma, dan Titik Saja")
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FormUtamaAdmin.Show()
    End Sub
End Class