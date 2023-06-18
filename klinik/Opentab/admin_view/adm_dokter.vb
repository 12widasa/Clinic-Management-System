Imports System.Data.SqlClient

Public Class adm_dokter
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
    Private jenisKelaminDokter As String = ""

    Private Sub adm_dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDokterData()
    End Sub

    Private Sub LoadDokterData()
        Dim dataTable As New DataTable()
        ShowDokterData(dataTable)
        DGV_dokter.DataSource = dataTable
    End Sub

    Private Sub ShowDokterData(ByRef dataTable As DataTable)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, Nama, Spesialisasi, Alamat, Telepon, Jenis_Kelamin, Gaji FROM users WHERE User_Type = 'dokter'"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using
    End Sub

    Private Sub DGV_dokter_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_dokter.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_dokter.Rows(e.RowIndex)
            txt_id_dokter.Text = selectedRow.Cells("ID").Value.ToString()
            txt_nama_dokter.Text = selectedRow.Cells("Nama").Value.ToString()
            txt_spesialisasi_dokter.Text = selectedRow.Cells("Spesialisasi").Value.ToString()
            txt_alamat_dokter.Text = selectedRow.Cells("Alamat").Value.ToString()
            txt_telepon_dokter.Text = selectedRow.Cells("Telepon").Value.ToString()
            txt_gaji.Text = selectedRow.Cells("Gaji").Value.ToString()

            ' Mengatur nilai jenis kelamin sesuai dengan data yang dipilih
            jenisKelaminDokter = selectedRow.Cells("Jenis_Kelamin").Value.ToString()
            If jenisKelaminDokter = "Laki-Laki" Then
                RD_dkt_laki.Checked = True
            ElseIf jenisKelaminDokter = "Perempuan" Then
                RD_dkt_perempuan.Checked = True
            End If
        End If
    End Sub

    Private Sub ClearTextboxes()
        txt_nama_dokter.Text = ""
        txt_spesialisasi_dokter.Text = ""
        txt_alamat_dokter.Text = ""
        txt_telepon_dokter.Text = ""
        txt_gaji.Text = ""
        RD_dkt_laki.Checked = False
        RD_dkt_perempuan.Checked = False
    End Sub

    Private Sub AddOrUpdateDokterData(query As String, idDokter As String, namaDokter As String, spesialisasiDokter As String, alamatDokter As String, teleponDokter As String, gajiDokter As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idDokter", idDokter)
                command.Parameters.AddWithValue("@namaDokter", namaDokter)
                command.Parameters.AddWithValue("@spesialisasiDokter", spesialisasiDokter)
                command.Parameters.AddWithValue("@alamatDokter", alamatDokter)
                command.Parameters.AddWithValue("@teleponDokter", teleponDokter)
                command.Parameters.AddWithValue("@jenisKelaminDokter", jenisKelaminDokter)
                command.Parameters.AddWithValue("@gajiDokter", gajiDokter)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data dokter berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadDokterData()
        ClearTextboxes()
    End Sub

    Private Function IsInputValid(idDokter As String, namaDokter As String, spesialisasiDokter As String, alamatDokter As String, teleponDokter As String, gajiDokter As String) As Boolean
        If String.IsNullOrEmpty(idDokter) OrElse String.IsNullOrEmpty(namaDokter) OrElse String.IsNullOrEmpty(spesialisasiDokter) OrElse
            String.IsNullOrEmpty(alamatDokter) OrElse String.IsNullOrEmpty(teleponDokter) OrElse
            String.IsNullOrEmpty(jenisKelaminDokter) OrElse String.IsNullOrEmpty(gajiDokter) Then
            MessageBox.Show("Harap lengkapi semua data dokter.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim idDokter As String = txt_id_dokter.Text
        Dim namaDokter As String = txt_nama_dokter.Text
        Dim spesialisasiDokter As String = txt_spesialisasi_dokter.Text
        Dim alamatDokter As String = txt_alamat_dokter.Text
        Dim teleponDokter As String = txt_telepon_dokter.Text
        Dim gajiDokter As String = txt_gaji.Text

        If RD_dkt_laki.Checked Then
            jenisKelaminDokter = "Laki-Laki"
        ElseIf RD_dkt_perempuan.Checked Then
            jenisKelaminDokter = "Perempuan"
        End If

        ' Validasi input data
        If Not IsInputValid(idDokter, namaDokter, spesialisasiDokter, alamatDokter, teleponDokter, gajiDokter) Then
            Return
        End If

        ' Lanjutkan dengan operasi tambah data
        Dim query As String = "INSERT INTO users (ID, Nama, Spesialisasi, Alamat, Telepon, Jenis_Kelamin, User_Type, Gaji) VALUES (@idDokter, @namaDokter, @spesialisasiDokter, @alamatDokter, @teleponDokter, @jenisKelaminDokter, 'dokter', @gajiDokter)"
        AddOrUpdateDokterData(query, idDokter, namaDokter, spesialisasiDokter, alamatDokter, teleponDokter, gajiDokter)

        ' Atur nilai textbox txt_usertype_dokter
        txt_usertype_dokter.Text = "dokter"
        txt_usertype_dokter.ReadOnly = True
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim idDokter As String = txt_id_dokter.Text
        Dim namaDokter As String = txt_nama_dokter.Text
        Dim spesialisasiDokter As String = txt_spesialisasi_dokter.Text
        Dim alamatDokter As String = txt_alamat_dokter.Text
        Dim teleponDokter As String = txt_telepon_dokter.Text
        Dim gajiDokter As String = txt_gaji.Text

        If String.IsNullOrEmpty(idDokter) Then
            MessageBox.Show("Silakan pilih dokter yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If RD_dkt_laki.Checked Then
            jenisKelaminDokter = "Laki-Laki"
        ElseIf RD_dkt_perempuan.Checked Then
            jenisKelaminDokter = "Perempuan"
        End If

        If Not IsInputValid(idDokter, namaDokter, spesialisasiDokter, alamatDokter, teleponDokter, gajiDokter) Then
            Return
        End If

        Dim query As String = "UPDATE users SET Nama = @namaDokter, Spesialisasi = @spesialisasiDokter, Alamat = @alamatDokter, Telepon = @teleponDokter, Jenis_Kelamin = @jenisKelaminDokter, Gaji = @gajiDokter WHERE ID = @idDokter AND User_Type = 'dokter'"
        AddOrUpdateDokterData(query, idDokter, namaDokter, spesialisasiDokter, alamatDokter, teleponDokter, gajiDokter)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim idDokter As String = txt_id_dokter.Text

        If String.IsNullOrEmpty(idDokter) Then
            MessageBox.Show("Silakan pilih dokter yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data dokter ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM users WHERE ID = @idDokter AND User_Type = 'dokter'"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idDokter", idDokter)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data dokter berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadDokterData()
            ClearTextboxes()
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Dim keyword As String = txt_cari.Text.Trim()

        Dim dataTable As DataTable = CType(DGV_dokter.DataSource, DataTable)

        If Not String.IsNullOrEmpty(keyword) Then
            Dim filteredData As DataTable = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each column As DataColumn In dataTable.Columns
                    If row(column.ColumnName).ToString().ToLower().Contains(keyword.ToLower()) Then
                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            DGV_dokter.DataSource = filteredData
        Else
            LoadDokterData()
        End If
    End Sub
End Class
