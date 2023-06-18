Imports System.Data.SqlClient

Public Class adm_perawat

    Private ReadOnly connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
    Private selectedRowData As DataRow

    Private Sub adm_perawat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPerawatData()
    End Sub

    Private Sub LoadPerawatData()
        Dim dataTable As New DataTable()
        ShowPerawatData(dataTable)
        DGV_perawat.DataSource = dataTable
    End Sub

    Private Sub ShowPerawatData(ByRef dataTable As DataTable)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, Username, Password, Alamat, Telepon, Jenis_Kelamin, Gaji FROM users WHERE User_Type = 'perawat'"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using
    End Sub

    Private Sub DGV_perawat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_perawat.CellClick
        If e.RowIndex >= 0 Then
            selectedRowData = (TryCast(DGV_perawat.DataSource, DataTable)).Rows(e.RowIndex)
            txt_id_perawat.Text = selectedRowData("ID").ToString()
            txt_username_perawat.Text = selectedRowData("Username").ToString()
            txt_alamat_perawat.Text = selectedRowData("Alamat").ToString()
            txt_telepon_perawat.Text = selectedRowData("Telepon").ToString()
            txt_gaji.Text = selectedRowData("Gaji").ToString()

            ' Mengatur nilai jenis kelamin sesuai dengan data yang dipilih
            Dim jenisKelaminPerawat As String = selectedRowData("Jenis_Kelamin").ToString()
            If jenisKelaminPerawat = "Laki-Laki" Then
                RD_pwt_laki.Checked = True
            ElseIf jenisKelaminPerawat = "Perempuan" Then
                RD_pwt_perempuan.Checked = True
            End If
        End If
    End Sub


    Private Sub ClearTextboxes()
        txt_username_perawat.Text = ""
        txt_alamat_perawat.Text = ""
        txt_telepon_perawat.Text = ""
        txt_password_perawat.Text = ""
        txt_gaji.Text = ""
        RD_pwt_laki.Checked = False
        RD_pwt_perempuan.Checked = False
    End Sub

    Private Sub AddOrUpdatePerawatData(query As String, idPerawat As String, usernamePerawat As String, passwordPerawat As String, alamatPerawat As String, teleponPerawat As String, jenisKelaminPerawat As String, gajiPerawat As Integer, userTypePerawat As String)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idPerawat", idPerawat)
                command.Parameters.AddWithValue("@usernamePerawat", usernamePerawat)
                command.Parameters.AddWithValue("@passwordPerawat", passwordPerawat)
                command.Parameters.AddWithValue("@alamatPerawat", alamatPerawat)
                command.Parameters.AddWithValue("@teleponPerawat", teleponPerawat)
                command.Parameters.AddWithValue("@jenisKelaminPerawat", jenisKelaminPerawat)
                command.Parameters.AddWithValue("@gajiPerawat", gajiPerawat)
                command.Parameters.AddWithValue("@userTypePerawat", userTypePerawat)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data perawat berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadPerawatData()
        ClearTextboxes()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim idPerawat As String = txt_id_perawat.Text
        Dim usernamePerawat As String = txt_username_perawat.Text
        Dim passwordPerawat As String = txt_password_perawat.Text
        Dim alamatPerawat As String = txt_alamat_perawat.Text
        Dim teleponPerawat As String = txt_telepon_perawat.Text
        Dim jenisKelaminPerawat As String = ""
        Dim gajiPerawat As Integer = 0
        Dim userTypePerawat As String = "perawat"

        If Integer.TryParse(txt_gaji.Text, gajiPerawat) = False Then
            MessageBox.Show("Harap masukkan angka pada kolom gaji.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If RD_pwt_laki.Checked Then
            jenisKelaminPerawat = "Laki-Laki"
        ElseIf RD_pwt_perempuan.Checked Then
            jenisKelaminPerawat = "Perempuan"
        End If

        If String.IsNullOrEmpty(usernamePerawat) OrElse String.IsNullOrEmpty(passwordPerawat) OrElse
            String.IsNullOrEmpty(alamatPerawat) OrElse String.IsNullOrEmpty(teleponPerawat) OrElse
            String.IsNullOrEmpty(jenisKelaminPerawat) Then
            MessageBox.Show("Harap lengkapi semua data perawat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lanjutkan dengan operasi tambah data
        Dim query As String = "INSERT INTO users (ID, Nama, Username, Password, Alamat, Telepon, Jenis_Kelamin, User_Type, Gaji) VALUES (@idPerawat, '', @usernamePerawat, @passwordPerawat, @alamatPerawat, @teleponPerawat, @jenisKelaminPerawat, @userTypePerawat, @gajiPerawat)"
        AddOrUpdatePerawatData(query, idPerawat, usernamePerawat, passwordPerawat, alamatPerawat, teleponPerawat, jenisKelaminPerawat, gajiPerawat, userTypePerawat)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If selectedRowData IsNot Nothing Then
            Dim idPerawat As String = txt_id_perawat.Text
            Dim usernamePerawat As String = txt_username_perawat.Text
            Dim passwordPerawat As String = txt_password_perawat.Text
            Dim alamatPerawat As String = txt_alamat_perawat.Text
            Dim teleponPerawat As String = txt_telepon_perawat.Text
            Dim jenisKelaminPerawat As String = ""
            Dim gajiPerawat As Integer = 0
            Dim userTypePerawat As String = "perawat"


            If Integer.TryParse(txt_gaji.Text, gajiPerawat) = False Then
                MessageBox.Show("Harap masukkan angka pada kolom gaji.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(idPerawat) Then
                MessageBox.Show("Silakan pilih perawat yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrEmpty(usernamePerawat) OrElse String.IsNullOrEmpty(passwordPerawat) OrElse
            String.IsNullOrEmpty(alamatPerawat) OrElse String.IsNullOrEmpty(teleponPerawat) Then
                MessageBox.Show("Harap lengkapi semua data perawat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If RD_pwt_laki.Checked Then
                jenisKelaminPerawat = "Laki-Laki"
            ElseIf RD_pwt_perempuan.Checked Then
                jenisKelaminPerawat = "Perempuan"
            End If

            ' Ubah data pada DataRow
            selectedRowData("Username") = usernamePerawat
            selectedRowData("Password") = passwordPerawat
            selectedRowData("Alamat") = alamatPerawat
            selectedRowData("Telepon") = teleponPerawat
            selectedRowData("Jenis_Kelamin") = jenisKelaminPerawat
            selectedRowData("Gaji") = gajiPerawat

            ' Update data pada database
            Dim query As String = "UPDATE users SET Username = @usernamePerawat, Password = @passwordPerawat, Alamat = @alamatPerawat, Telepon = @teleponPerawat, Jenis_Kelamin = @jenisKelaminPerawat, Gaji = @gajiPerawat WHERE ID = @idPerawat"
            AddOrUpdatePerawatData(query, idPerawat, usernamePerawat, passwordPerawat, alamatPerawat, teleponPerawat, jenisKelaminPerawat, gajiPerawat, userTypePerawat)

            ' Tampilkan perubahan terbaru pada DataGridView
            DGV_perawat.Refresh()
        Else
            MessageBox.Show("Silakan pilih perawat yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim idPerawat As String = txt_id_perawat.Text

        If String.IsNullOrEmpty(idPerawat) Then
            MessageBox.Show("Silakan pilih perawat yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data perawat ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM users WHERE ID = @idPerawat"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idPerawat", idPerawat)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data perawat berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadPerawatData()
            ClearTextboxes()
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Dim keyword As String = txt_cari.Text.Trim()

        Dim dataTable As DataTable = CType(DGV_perawat.DataSource, DataTable)

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

            DGV_perawat.DataSource = filteredData
        Else
            LoadPerawatData()
        End If
    End Sub

End Class