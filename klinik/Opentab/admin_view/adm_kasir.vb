Imports System.Data.SqlClient

Public Class adm_kasir
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
    Private selectedRowData As DataRow

    Private Sub adm_kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKasirData()
        txt_usertype_kasir.Text = "kasir"
        txt_usertype_kasir.ForeColor = Color.Gray
    End Sub

    Private Sub txt_usertype_kasir_GotFocus(sender As Object, e As EventArgs) Handles txt_usertype_kasir.GotFocus
        If txt_usertype_kasir.Text = "kasir" Then
            txt_usertype_kasir.Text = ""
            txt_usertype_kasir.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_usertype_kasir_LostFocus(sender As Object, e As EventArgs) Handles txt_usertype_kasir.LostFocus
        If String.IsNullOrEmpty(txt_usertype_kasir.Text.Trim()) Then
            txt_usertype_kasir.Text = "kasir"
            txt_usertype_kasir.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub LoadKasirData()
        Dim dataTable As New DataTable()
        ShowKasirData(dataTable)
        DGV_kasir.DataSource = dataTable.DefaultView
    End Sub

    Private Sub ShowKasirData(ByRef dataTable As DataTable)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, Username, Password, Alamat, Telepon, Jenis_Kelamin, Gaji FROM users WHERE User_Type = 'kasir'"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                dataTable.Load(command.ExecuteReader())
            End Using
        End Using
    End Sub

    Private Sub DGV_kasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_kasir.CellClick
        If e.RowIndex >= 0 Then
            selectedRowData = (TryCast(DGV_kasir.DataSource, DataView))(e.RowIndex).Row
            txt_id_kasir.Text = selectedRowData("ID").ToString()
            txt_username_kasir.Text = selectedRowData("Username").ToString()
            txt_alamat_kasir.Text = selectedRowData("Alamat").ToString()
            txt_telepon_kasir.Text = selectedRowData("Telepon").ToString()
            txt_gaji.Text = selectedRowData("Gaji").ToString()

            ' Mengatur nilai jenis kelamin sesuai dengan data yang dipilih
            Dim jenisKelaminKasir As String = selectedRowData("Jenis_Kelamin").ToString()
            If jenisKelaminKasir = "Laki-Laki" Then
                RD_laki.Checked = True
            ElseIf jenisKelaminKasir = "Perempuan" Then
                RD_perempuan.Checked = True
            End If
        End If
    End Sub

    Private Sub ClearTextboxes()
        txt_username_kasir.Text = ""
        txt_alamat_kasir.Text = ""
        txt_telepon_kasir.Text = ""
        txt_password_kasir.Text = ""
        txt_gaji.Text = ""
        RD_laki.Checked = False
        RD_perempuan.Checked = False
    End Sub

    Private Sub AddOrUpdateKasirData(query As String, idKasir As String, namaKasir As String, usernameKasir As String, passwordKasir As String, alamatKasir As String, teleponKasir As String, jenisKelaminKasir As String, userTypeKasir As String, gajiKasir As Integer)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@idKasir", idKasir)
                command.Parameters.AddWithValue("@namaKasir", namaKasir)
                command.Parameters.AddWithValue("@usernameKasir", usernameKasir)
                command.Parameters.AddWithValue("@passwordKasir", passwordKasir)
                command.Parameters.AddWithValue("@alamatKasir", alamatKasir)
                command.Parameters.AddWithValue("@teleponKasir", teleponKasir)
                command.Parameters.AddWithValue("@jenisKelaminKasir", jenisKelaminKasir)
                command.Parameters.AddWithValue("@userTypeKasir", userTypeKasir)
                command.Parameters.AddWithValue("@gajiKasir", gajiKasir)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data kasir berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadKasirData()
        ClearTextboxes()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim idKasir As String = txt_id_kasir.Text
        Dim usernameKasir As String = txt_username_kasir.Text
        Dim passwordKasir As String = txt_password_kasir.Text
        Dim alamatKasir As String = txt_alamat_kasir.Text
        Dim teleponKasir As String = txt_telepon_kasir.Text
        Dim userTypeKasir As String = txt_usertype_kasir.Text
        Dim jenisKelaminKasir As String = ""

        ' Mengatur nilai jenis kelamin berdasarkan RadioButton yang dipilih
        If RD_laki.Checked Then
            jenisKelaminKasir = "Laki-Laki"
        ElseIf RD_perempuan.Checked Then
            jenisKelaminKasir = "Perempuan"
        End If

        ' Validasi input data
        If String.IsNullOrEmpty(usernameKasir) OrElse String.IsNullOrEmpty(passwordKasir) OrElse
        String.IsNullOrEmpty(alamatKasir) OrElse String.IsNullOrEmpty(teleponKasir) OrElse String.IsNullOrEmpty(jenisKelaminKasir) Then
            MessageBox.Show("Harap lengkapi semua data kasir.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lanjutkan dengan operasi tambah data
        Dim query As String = "INSERT INTO users (ID, Nama, Username, Password, Alamat, Telepon, Jenis_Kelamin, User_Type, Gaji) VALUES (@idKasir, '', @usernameKasir, @passwordKasir, @alamatKasir, @teleponKasir, @jenisKelaminKasir, @userTypeKasir, @gajiKasir)"
        Dim gajiKasir As Integer = 0
        Integer.TryParse(txt_gaji.Text, gajiKasir)
        AddOrUpdateKasirData(query, idKasir, "", usernameKasir, passwordKasir, alamatKasir, teleponKasir, jenisKelaminKasir, userTypeKasir, gajiKasir)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim idKasir As String = txt_id_kasir.Text
        Dim usernameKasir As String = txt_username_kasir.Text
        Dim passwordKasir As String = txt_password_kasir.Text
        Dim alamatKasir As String = txt_alamat_kasir.Text
        Dim teleponKasir As String = txt_telepon_kasir.Text
        Dim userTypeKasir As String = txt_usertype_kasir.Text
        Dim jenisKelaminKasir As String = ""

        If String.IsNullOrEmpty(idKasir) Then
            MessageBox.Show("Silakan pilih kasir yang akan diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(usernameKasir) OrElse String.IsNullOrEmpty(passwordKasir) OrElse
        String.IsNullOrEmpty(alamatKasir) OrElse String.IsNullOrEmpty(teleponKasir) Then
            MessageBox.Show("Harap lengkapi semua data kasir.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Mengatur nilai jenis kelamin berdasarkan RadioButton yang dipilih
        If RD_laki.Checked Then
            jenisKelaminKasir = "Laki-Laki"
        ElseIf RD_perempuan.Checked Then
            jenisKelaminKasir = "Perempuan"
        End If

        ' Ubah data pada DataRow
        selectedRowData("Username") = usernameKasir
        selectedRowData("Password") = passwordKasir
        selectedRowData("Alamat") = alamatKasir
        selectedRowData("Telepon") = teleponKasir
        selectedRowData("Jenis_Kelamin") = jenisKelaminKasir

        ' Update data pada database
        Dim query As String = "UPDATE users SET Username = @usernameKasir, Password = @passwordKasir, Alamat = @alamatKasir, Telepon = @teleponKasir, Jenis_Kelamin = @jenisKelaminKasir, Gaji = @gajiKasir WHERE ID = @idKasir"
        Dim gajiKasir As Integer = 0
        Integer.TryParse(txt_gaji.Text, gajiKasir)
        AddOrUpdateKasirData(query, idKasir, "", usernameKasir, passwordKasir, alamatKasir, teleponKasir, jenisKelaminKasir, userTypeKasir, gajiKasir)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim idKasir As String = txt_id_kasir.Text

        If String.IsNullOrEmpty(idKasir) Then
            MessageBox.Show("Silakan pilih kasir yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data kasir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "DELETE FROM users WHERE ID = @idKasir"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idKasir", idKasir)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Data kasir berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadKasirData()
            ClearTextboxes()
        End If
    End Sub

    Private Sub txt_cari_TextChanged(sender As Object, e As EventArgs) Handles txt_cari.TextChanged
        Dim keyword As String = txt_cari.Text.Trim()

        Dim dataTable As DataTable = CType(DGV_kasir.DataSource, DataTable)

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

            DGV_kasir.DataSource = filteredData
        Else
            LoadKasirData()
        End If
    End Sub

End Class
