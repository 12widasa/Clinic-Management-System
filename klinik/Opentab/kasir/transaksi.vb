Imports System.Data.SqlClient
Public Class transaksi
    Private idKasir As String
    Private namaKasir As String

    Public Sub New(idKasir As String, namaKasir As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idKasir = idKasir
        Me.namaKasir = namaKasir
    End Sub

    Private Sub transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Membuat kolom-kolom pada DataGridView
        DGV_kasir.Columns.Add("Resep", "Resep")
        DGV_kasir.Columns.Add("Qty", "Qty")
        DGV_kasir.Columns.Add("Harga", "Harga")

        ' Mengisi ComboBox dengan data dari tabel_obat_pasien
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
        Dim query As String = "SELECT Nama_Obat FROM tabel_obat_pasien WHERE Tipe = 'Administrasi'"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    cmb_tambahan.Items.Add(reader("Nama_Obat").ToString())
                End While
                reader.Close()
            End Using
            connection.Close()
        End Using
    End Sub
    Private Sub cmb_tambahan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tambahan.SelectedIndexChanged
        If cmb_tambahan.SelectedItem Is Nothing Then
            Return
        End If
        ' Menambahkan item yang dipilih dari ComboBox ke DataGridView
        Dim namaObat As String = cmb_tambahan.SelectedItem.ToString()

        ' Mengambil harga obat dari database
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
        Dim hargaObat As Decimal = 0
        Dim query As String = "SELECT Harga FROM tabel_obat_pasien WHERE Nama_Obat = @namaObat"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@namaObat", namaObat)
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Mengambil harga obat dan mengubah formatnya dari "Rp50.000" menjadi 50000
                    hargaObat = Decimal.Parse(reader("Harga").ToString().Replace("Rp", "").Replace(".", ""))
                End If
                reader.Close()
            End Using
            connection.Close()
        End Using

        DGV_kasir.Rows.Insert(0, namaObat, 1, String.Format("Rp{0:N0}", hargaObat)) ' Menambahkan baris baru di awal DataGridView dengan harga obat
        UpdateTotalTransaksi()
    End Sub

    Private Sub UpdateTotalTransaksi()
        Dim totalTransaksi As Decimal = 0
        For Each row As DataGridViewRow In DGV_kasir.Rows
            If row.Cells("Harga").Value IsNot Nothing Then
                Dim harga As Decimal
                If Decimal.TryParse(row.Cells("Harga").Value.ToString().Replace("Rp", "").Replace(".", ""), harga) Then
                    totalTransaksi += harga
                Else
                    MessageBox.Show("Invalid format for Harga: " & row.Cells("Harga").Value.ToString())
                End If
                ' Hapus atau komentari baris berikut
                'Else
                '    MessageBox.Show("Harga cell is null in row " & row.Index)
            End If
        Next
        lbl_total_transaksi.Text = String.Format("Rp{0:N0}", totalTransaksi)
    End Sub

    Private Sub DGV_kasir_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_kasir.CellContentClick
        ' Menangani acara klik sel pada DataGridView
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DGV_kasir.Rows(e.RowIndex)

            ' Mengambil nilai dari sel yang diklik
            Dim resep As String = selectedRow.Cells("Resep").Value.ToString()
            Dim qty As Integer = Convert.ToInt32(selectedRow.Cells("Qty").Value)
            Dim harga As Decimal = Convert.ToDecimal(selectedRow.Cells("Harga").Value)

            ' Lakukan sesuatu dengan nilai yang diambil, contohnya:
            MessageBox.Show($"Resep: {resep}, Qty: {qty}, Harga: {harga}")
        End If
    End Sub

    Private Sub ClearForm()
        ' Membersihkan semua TextBox
        txt_id_pasien.Clear()
        txt_nama_pasien.Clear()
        txt_diagnosa.Clear()
        txt_alamat.Clear()
        txt_no_antrean.Clear()

        ' Membersihkan semua baris di DataGridView
        DGV_kasir.Rows.Clear()

        ' Menghapus pilihan saat ini dari ComboBox
        cmb_tambahan.SelectedIndex = -1

        ' Reset label total transaksi
        lbl_total_transaksi.Text = "Rp0"
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearForm()
    End Sub



    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"

        ' Kode untuk mengambil data dari tabel pemeriksaan
        Dim query As String = "SELECT TOP 1 ID, Nama_Pasien, Resep, Diagnosa, Alamat FROM pemeriksaan WHERE No_Antrean = @noAntrean ORDER BY Tanggal_Pemeriksaan DESC"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                ' Menambahkan parameter untuk query
                command.Parameters.AddWithValue("@noAntrean", txt_no_antrean.Text) ' <-- Menambahkan parameter @noAntrean
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Menampilkan data ke TextBox sesuai dengan nama kolomnya
                    txt_id_pasien.Text = reader("ID").ToString()
                    txt_nama_pasien.Text = reader("Nama_Pasien").ToString()
                    txt_diagnosa.Text = reader("Diagnosa").ToString()
                    txt_alamat.Text = reader("Alamat").ToString()

                    ' Mengambil data resep dan memisahkan menjadi kolom baru
                    Dim resep As String = reader("Resep").ToString()
                    Dim resepArray() As String = resep.Split(","c)

                    ' Tutup reader sebelum kita membuka yang lain
                    reader.Close()
                    Dim totalTransaksi As Decimal = 0
                    For Each item As String In resepArray
                        Dim resepQty As String() = item.Split("="c)
                        Dim namaResep As String = resepQty(0).Trim()
                        Dim qty As Integer = Integer.Parse(resepQty(1).Trim())

                        Dim hargaObat As Decimal = 0

                        ' Mencari harga obat berdasarkan resep di tabel_obat_pasien
                        Dim queryObat As String = "SELECT Harga FROM tabel_obat_pasien WHERE Nama_Obat = @namaObat"
                        Using commandObat As New SqlCommand(queryObat, connection)
                            commandObat.Parameters.AddWithValue("@namaObat", namaResep)

                            Dim readerObat As SqlDataReader = commandObat.ExecuteReader()
                            If readerObat.Read() Then
                                ' Mengambil harga obat dan mengubah formatnya dari "Rp50.000" menjadi 50000
                                hargaObat = Decimal.Parse(readerObat("Harga").ToString().Replace("Rp", "").Replace(".", ""))
                            End If
                            readerObat.Close()
                        End Using

                        ' Menghitung total harga berdasarkan qty dan harga obat
                        Dim totalHarga As Decimal = qty * hargaObat
                        totalTransaksi += totalHarga
                        DGV_kasir.Rows.Add(namaResep, qty, String.Format("Rp{0:N0}", totalHarga)) ' Menambahkan baris baru dengan nilai resep, qty, dan total harga


                    Next
                    lbl_total_transaksi.Text = String.Format("Rp{0:N0}", totalTransaksi)
                End If
            End Using
            connection.Close()
        End Using
    End Sub

    Private Sub btn_bayar_Click(sender As Object, e As EventArgs) Handles btn_bayar.Click
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
        Dim query As String = "INSERT INTO transaksi_pasien (Tanggal, ID_Pasien, Nama_Pasien, Diagnosa, Resep, Qty, Alamat, Harga, Total_Harga, ID_Kasir_History, Nama_Kasir_History) VALUES (@Tanggal, @ID_Pasien, @Nama_Pasien, @Diagnosa, @Resep, @Qty, @Alamat, @Harga, @Total_Harga, @ID_Kasir, @Nama_Kasir)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            For Each row As DataGridViewRow In DGV_kasir.Rows
                ' Pastikan baris tidak kosong
                If Not row.IsNewRow Then
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Tanggal", DateTime.Now)
                        command.Parameters.AddWithValue("@ID_Pasien", txt_id_pasien.Text)
                        command.Parameters.AddWithValue("@Nama_Pasien", txt_nama_pasien.Text)
                        command.Parameters.AddWithValue("@Diagnosa", txt_diagnosa.Text)
                        command.Parameters.AddWithValue("@Resep", row.Cells("Resep").Value)
                        command.Parameters.AddWithValue("@Qty", row.Cells("Qty").Value)
                        command.Parameters.AddWithValue("@Alamat", txt_alamat.Text)
                        command.Parameters.AddWithValue("@ID_Kasir", idKasir)
                        command.Parameters.AddWithValue("@Nama_Kasir", namaKasir)


                        Dim harga As Decimal = 0
                        If Decimal.TryParse(row.Cells("Harga").Value.ToString().Replace("Rp", "").Replace(".", ""), harga) Then
                            command.Parameters.AddWithValue("@Harga", harga)
                        Else
                            MessageBox.Show("Invalid format for Harga: " & row.Cells("Harga").Value.ToString())
                            Return
                        End If

                        ' Mengambil total transaksi dari label dan mengubah formatnya dari "Rp50.000" menjadi 50000
                        Dim totalHarga As Decimal = 0
                        If Decimal.TryParse(lbl_total_transaksi.Text.Replace("Rp", "").Replace(".", ""), totalHarga) Then
                            command.Parameters.AddWithValue("@Total_Harga", totalHarga)
                        Else
                            MessageBox.Show("Invalid format for Total Harga: " & lbl_total_transaksi.Text)
                            Return
                        End If

                        command.ExecuteNonQuery()
                    End Using
                End If
            Next

            connection.Close()
        End Using

        ' Menampilkan pesan bahwa data berhasil disimpan
        MessageBox.Show("Data transaksi berhasil disimpan.")
        ' Membersihkan semua TextBox dan DataGridView setelah transaksi berhasil ditambahkan
        ClearForm()
    End Sub

End Class