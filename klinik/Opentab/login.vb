Imports System.Data.SqlClient

Public Class login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=klinik"
        Dim username As String = txt_username.Text
        Dim password As String = txt_password.Text
        Dim userType As String = combo_userType.SelectedItem.ToString()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password AND user_type=@userType"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            command.Parameters.AddWithValue("@userType", userType)

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim user_type As String = reader("user_type").ToString()

                Select Case user_type
                    Case "admin"
                        MessageBox.Show("Login sukses sebagai Admin")
                        ' Lakukan navigasi ke form Administrator
                        Dim adminForm As New administrator()
                        adminForm.Show()
                        Me.Hide()

                    Case "perawat"
                        MessageBox.Show("Login sukses sebagai Perawat")
                        Dim id As String = reader("ID").ToString() ' Ambil id user dari database
                        Dim name As String = reader("Nama").ToString() ' Ambil name user dari database
                        Dim nurseForm As New perawat(id, name)
                        nurseForm.Show()
                        Me.Hide()

                    Case "kasir"
                        MessageBox.Show("Login sukses sebagai Kasir")
                        Dim id As String = reader("ID").ToString() ' Ambil id user dari database
                        Dim name As String = reader("Nama").ToString() ' Ambil name user dari database
                        Dim kasirForm As New kasir(id, name) 'Pass id dan name ke form kasir
                        kasirForm.Show()
                        Me.Hide()
                End Select
            Else
                MessageBox.Show("Login gagal. Periksa username dan password Anda.")
            End If

            reader.Close()
        End Using
    End Sub


End Class
