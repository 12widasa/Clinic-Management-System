Imports System.Data.SqlClient
Imports System.Globalization

Public Class list_obat

    Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"

    Private idKasir As String
    Private namaKasir As String

    Public Sub New(idKasir As String, namaKasir As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.idKasir = idKasir
        Me.namaKasir = namaKasir
    End Sub

    Private Sub list_obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub DGV_obat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_obat.CellClick
        ' Ambil baris yang dipilih '
        Dim selectedRow As DataGridViewRow = DGV_obat.Rows(e.RowIndex)

        ' Isi textbox dengan data dari baris yang dipilih '
        txt_id_obat.Text = selectedRow.Cells("ID").Value.ToString()
        txt_obat.Text = selectedRow.Cells("Nama_Obat").Value.ToString()
        txt_types.Text = selectedRow.Cells("Tipe").Value.ToString()
        txt_harga_obat.Text = selectedRow.Cells("Harga").Value.ToString().Replace("Rp", "").Replace(",", "")
    End Sub

    Private Sub RefreshData()
        ' Buat koneksi ke database '
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Buat pernyataan SQL SELECT untuk mengambil semua data dari tabel obat '
            Dim query As String = "SELECT * FROM tabel_obat_pasien"

            ' Buat objek SqlCommand '
            Using command As New SqlCommand(query, connection)
                ' Buat objek SqlDataAdapter untuk mengisi DataSet dengan data dari tabel obat '
                Using adapter As New SqlDataAdapter(command)
                    ' Buat objek DataSet '
                    Using dataset As New DataSet()
                        ' Isi DataSet dengan data dari tabel obat '
                        adapter.Fill(dataset, "tabel_obat_pasien")

                        ' Set data source DataGridView ke tabel obat dalam DataSet '
                        DGV_obat.DataSource = dataset.Tables("tabel_obat_pasien")
                        DGV_obat.Columns("Harga").DefaultCellStyle.Format = "C2"
                        DGV_obat.Columns("Harga").DefaultCellStyle.FormatProvider = New CultureInfo("id-ID")

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim id_obat As String = txt_id_obat.Text
        Dim obat As String = txt_obat.Text
        Dim types As String = txt_types.Text
        Dim harga_obat As Integer = Integer.Parse(txt_harga_obat.Text)

        ' Lakukan validasi input jika diperlukan '

        ' Buat koneksi ke database '
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Buat pernyataan SQL INSERT untuk menambahkan data ke tabel obat '
            Dim query As String = "INSERT INTO tabel_obat_pasien (ID, Nama_Obat, Tipe, Harga, Id_Kasir_History, Nama_Kasir_History) VALUES (@ID, @Nama_Obat, @Tipe, @Harga, @ID_Kasir, @Nama_Kasir)"

            ' Buat objek SqlCommand '
            Using command As New SqlCommand(query, connection)
                ' Tambahkan parameter dengan nilai yang diambil dari textbox '
                command.Parameters.AddWithValue("@ID", id_obat)
                command.Parameters.AddWithValue("@Nama_Obat", obat)
                command.Parameters.AddWithValue("@Tipe", types)
                command.Parameters.AddWithValue("@Harga", harga_obat)
                command.Parameters.AddWithValue("@ID_Kasir", idKasir)
                command.Parameters.AddWithValue("@Nama_Kasir", namaKasir)

                ' Jalankan pernyataan SQL '
                command.ExecuteNonQuery()

                ' Berikan pesan bahwa data berhasil ditambahkan '
                MessageBox.Show("Data obat berhasil ditambahkan.")

                ' Bersihkan nilai textbox setelah data ditambahkan '
                txt_id_obat.Text = ""
                txt_obat.Text = ""
                txt_types.Text = ""
                txt_harga_obat.Text = ""
            End Using
        End Using

        ' Perbarui data di DataGridView '
        RefreshData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim id_obat As String = txt_id_obat.Text
        Dim obat As String = txt_obat.Text
        Dim types As String = txt_types.Text
        Dim harga_obat As Integer = Integer.Parse(txt_harga_obat.Text)

        ' Lakukan validasi input jika diperlukan '

        ' Buat koneksi ke database '
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Buat pernyataan SQL UPDATE untuk memperbarui data pada tabel obat '
            Dim query As String = "UPDATE tabel_obat_pasien SET Nama_Obat = @Nama_Obat, Tipe = @Tipe, Harga = @Harga WHERE ID = @ID"

            ' Buat objek SqlCommand '
            Using command As New SqlCommand(query, connection)
                ' Tambahkan parameter dengan nilai yang diambil dari textbox '
                command.Parameters.AddWithValue("@Nama_Obat", obat)
                command.Parameters.AddWithValue("@Tipe", types)
                command.Parameters.AddWithValue("@Harga", harga_obat)
                command.Parameters.AddWithValue("@ID", id_obat)

                ' Jalankan pernyataan SQL '
                command.ExecuteNonQuery()

                ' Berikan pesan bahwa data berhasil diperbarui '
                MessageBox.Show("Data obat berhasil diperbarui.")
            End Using
        End Using

        ' Perbarui data di DataGridView '
        RefreshData()
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        ' Ambil kata kunci pencarian dari textbox '
        Dim keyword As String = txt_cari.Text

        ' Buat koneksi ke database '
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Buat pernyataan SQL SELECT untuk mencari data berdasarkan kata kunci '
            Dim query As String = "SELECT * FROM tabel_obat_pasien WHERE Nama_Obat LIKE @keyword OR Tipe LIKE @keyword"

            ' Buat objek SqlCommand '
            Using command As New SqlCommand(query, connection)
                ' Tambahkan parameter dengan nilai yang diambil dari textbox '
                command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")

                ' Buat objek SqlDataAdapter untuk mengisi DataSet dengan data hasil pencarian '
                Using adapter As New SqlDataAdapter(command)
                    ' Buat objek DataSet '
                    Using dataset As New DataSet()
                        ' Isi DataSet dengan data hasil pencarian '
                        adapter.Fill(dataset, "tabel_obat_pasien")

                        ' Set data source DataGridView ke hasil pencarian '
                        DGV_obat.DataSource = dataset.Tables("tabel_obat_pasien")
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        ' Ambil ID obat yang akan dihapus dari textbox '
        Dim id_obat As String = txt_id_obat.Text

        ' Buat koneksi ke database '
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Buat pernyataan SQL DELETE untuk menghapus data dari tabel obat berdasarkan ID '
            Dim query As String = "DELETE FROM tabel_obat_pasien WHERE ID = @ID"

            ' Buat objek SqlCommand '
            Using command As New SqlCommand(query, connection)
                ' Tambahkan parameter dengan nilai ID obat yang diambil dari textbox '
                command.Parameters.AddWithValue("@ID", id_obat)

                ' Jalankan pernyataan SQL '
                command.ExecuteNonQuery()

                ' Berikan pesan bahwa data berhasil dihapus '
                MessageBox.Show("Data obat berhasil dihapus.")

                ' Bersihkan nilai textbox setelah data dihapus '
                txt_id_obat.Text = ""
                txt_obat.Text = ""
                txt_types.Text = ""
                txt_harga_obat.Text = ""
            End Using
        End Using

        ' Perbarui data di DataGridView '
        RefreshData()
    End Sub


End Class