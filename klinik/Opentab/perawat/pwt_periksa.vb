Imports System.Data.SqlClient

Public Class pwt_periksa
    Private idPerawat As String
    Private namaPerawat As String
    Private connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"

    Public Sub New(id As String, name As String)
        InitializeComponent() 'Ini merupakan method bawaan windows form untuk inisialisasi komponen, jangan hapus ini.

        Me.idPerawat = id
        Me.namaPerawat = name
    End Sub

    Private Sub pwt_periksa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        LoadDokterData()
    End Sub

    Private Sub LoadData()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("SELECT * FROM pemeriksaan ORDER BY ID DESC", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DGV_periksa.DataSource = dataTable
                DGV_periksa.FirstDisplayedScrollingRowIndex = 0
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub RefreshDataGridView()
        LoadData()
        DGV_periksa.FirstDisplayedScrollingRowIndex = 0 ' Mengatur tampilan agar data yang diubah ditampilkan di bagian paling atas
    End Sub

    Private Sub DGV_periksa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_periksa.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_periksa.Rows(e.RowIndex)
            txt_id_periksa.Text = row.Cells("ID").Value.ToString()
            txt_nama_periksa.Text = row.Cells("Nama_Pasien").Value.ToString()
            txt_diagnosa_periksa.Text = row.Cells("Diagnosa").Value.ToString()
            txt_resep_periksa.Text = row.Cells("Resep").Value.ToString()
            txt_telepon_periksa.Text = row.Cells("Nomor_Telepon").Value.ToString()
            txt_alamat_periksa.Text = row.Cells("Alamat").Value.ToString()
            txt_keterangan_periksa.Text = row.Cells("Keterangan").Value.ToString()
            txt_no_antrean.Text = row.Cells("No_Antrean").Value.ToString()

            If row.Cells("ID").Value IsNot Nothing Then
                txt_id_periksa.Text = row.Cells("ID").Value.ToString()
            End If

            Dim jenisKelamin As String = row.Cells("Jenis_Kelamin").Value.ToString()
            If jenisKelamin = "Laki-laki" Then
                RD_laki.Checked = True
            ElseIf jenisKelamin = "Perempuan" Then
                RD_perempuan.Checked = True
            Else
                RD_laki.Checked = False
                RD_perempuan.Checked = False
            End If

            Dim dokterSpesialisasi As String = row.Cells("Dokter").Value.ToString() & " - " & row.Cells("Spesialisasi").Value.ToString()
            cmb_dokter.SelectedItem = dokterSpesialisasi
        End If
    End Sub

    Private Sub ClearForm()
        txt_id_periksa.Text = ""
        txt_nama_periksa.Text = ""
        txt_diagnosa_periksa.Text = ""
        txt_resep_periksa.Text = ""
        txt_telepon_periksa.Text = ""
        txt_alamat_periksa.Text = ""
        txt_keterangan_periksa.Text = ""
        txt_no_antrean.Text = ""
        RD_laki.Checked = False
        RD_perempuan.Checked = False
        cmb_dokter.SelectedIndex = -1
    End Sub

    Private Sub LoadDokterData()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("SELECT Nama, Spesialisasi FROM users WHERE User_Type = 'dokter'", connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim dokter As String = reader("Nama") & " - " & reader("Spesialisasi")
                    cmb_dokter.Items.Add(dokter)
                End While
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim idPeriksa As String = txt_id_periksa.Text
        Dim namaPeriksa As String = txt_nama_periksa.Text
        Dim diagnosaPeriksa As String = txt_diagnosa_periksa.Text
        Dim resepPeriksa As String = txt_resep_periksa.Text
        Dim teleponPeriksa As String = txt_telepon_periksa.Text
        Dim alamatPeriksa As String = txt_alamat_periksa.Text
        Dim keteranganPeriksa As String = txt_keterangan_periksa.Text
        Dim selectedDokter = cmb_dokter.SelectedItem?.ToString().Split("-")
        Dim dokterPeriksa As String = selectedDokter?.FirstOrDefault()?.Trim()
        Dim spesialisasiDokter As String = selectedDokter?.LastOrDefault()?.Trim()
        Dim noAntrean As String = txt_no_antrean.Text
        Dim jenisKelamin As String = If(RD_laki.Checked, "Laki-laki", If(RD_perempuan.Checked, "Perempuan", ""))

        If String.IsNullOrEmpty(noAntrean) Then
            MessageBox.Show("Harap masukkan nomor antrean.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim command As New SqlCommand("INSERT INTO pemeriksaan (ID, Nama_Pasien, Diagnosa, Resep, Jenis_Kelamin, Tanggal_Pemeriksaan, Nomor_Telepon, Keterangan, Alamat, Dokter, Spesialisasi, No_Antrean, Id_Perawat_History, Nama_Perawat_History) " &
                                  "VALUES (@ID, @Nama_Pasien, @Diagnosa, @Resep, @Jenis_Kelamin, GETDATE(), @Nomor_Telepon, @Keterangan, @Alamat, @Dokter, @Spesialisasi, @No_Antrean, @idPerawat, @namaPerawat)", connection)

                command.Parameters.AddWithValue("@ID", idPeriksa)
                command.Parameters.AddWithValue("@Nama_Pasien", namaPeriksa)
                command.Parameters.AddWithValue("@Diagnosa", diagnosaPeriksa)
                command.Parameters.AddWithValue("@Resep", resepPeriksa)
                command.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin)
                command.Parameters.AddWithValue("@Nomor_Telepon", teleponPeriksa)
                command.Parameters.AddWithValue("@Keterangan", keteranganPeriksa)
                command.Parameters.AddWithValue("@Alamat", alamatPeriksa)
                command.Parameters.AddWithValue("@Dokter", dokterPeriksa)
                command.Parameters.AddWithValue("@Spesialisasi", spesialisasiDokter)
                command.Parameters.AddWithValue("@No_Antrean", noAntrean)
                command.Parameters.AddWithValue("@idPerawat", Me.idPerawat)
                command.Parameters.AddWithValue("@namaPerawat", Me.namaPerawat)

                command.ExecuteNonQuery()

                MessageBox.Show("Data berhasil ditambahkan ke dalam tabel pemeriksaan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearForm()
                RefreshDataGridView()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menambahkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim noAntrean As String = txt_no_antrean.Text

        If String.IsNullOrEmpty(noAntrean) Then
            MessageBox.Show("Pilih data yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("DELETE FROM pemeriksaan WHERE No_Antrean = @No_Antrean", connection)
                command.Parameters.AddWithValue("@No_Antrean", noAntrean)
                command.ExecuteNonQuery()
                MessageBox.Show("Data berhasil dihapus dari tabel pemeriksaan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim idPeriksa As String = txt_id_periksa.Text
        Dim namaPeriksa As String = txt_nama_periksa.Text
        Dim diagnosaPeriksa As String = txt_diagnosa_periksa.Text
        Dim resepPeriksa As String = txt_resep_periksa.Text
        Dim teleponPeriksa As String = txt_telepon_periksa.Text
        Dim alamatPeriksa As String = txt_alamat_periksa.Text
        Dim keteranganPeriksa As String = txt_keterangan_periksa.Text
        Dim selectedDokter = cmb_dokter.SelectedItem?.ToString().Split("-")
        Dim dokterPeriksa As String = selectedDokter?.FirstOrDefault()?.Trim()
        Dim spesialisasiDokter As String = selectedDokter?.LastOrDefault()?.Trim()
        Dim noAntrean As String = txt_no_antrean.Text
        Dim jenisKelamin As String = If(RD_laki.Checked, "Laki-laki", If(RD_perempuan.Checked, "Perempuan", ""))

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New SqlCommand("UPDATE pemeriksaan SET Nama_Pasien = @Nama_Pasien, Diagnosa = @Diagnosa, Resep = @Resep, " &
                                              "Jenis_Kelamin = @Jenis_Kelamin, Tanggal_Pemeriksaan = GETDATE(), Nomor_Telepon = @Nomor_Telepon, " &
                                              "Keterangan = @Keterangan, Alamat = @Alamat, Dokter = @Dokter, Spesialisasi = @Spesialisasi, " &
                                              "No_Antrean = @No_Antrean WHERE ID = @ID", connection)

                command.Parameters.AddWithValue("@ID", idPeriksa)
                command.Parameters.AddWithValue("@Nama_Pasien", namaPeriksa)
                command.Parameters.AddWithValue("@Diagnosa", diagnosaPeriksa)
                command.Parameters.AddWithValue("@Resep", resepPeriksa)
                command.Parameters.AddWithValue("@Jenis_Kelamin", jenisKelamin)
                command.Parameters.AddWithValue("@Nomor_Telepon", teleponPeriksa)
                command.Parameters.AddWithValue("@Keterangan", keteranganPeriksa)
                command.Parameters.AddWithValue("@Alamat", alamatPeriksa)
                command.Parameters.AddWithValue("@Dokter", dokterPeriksa)
                command.Parameters.AddWithValue("@Spesialisasi", spesialisasiDokter)
                command.Parameters.AddWithValue("@No_Antrean", noAntrean)

                command.ExecuteNonQuery()

                MessageBox.Show("Data pemeriksaan berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearForm()
                RefreshDataGridView()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengupdate data pemeriksaan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class
