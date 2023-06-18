Imports System.Data.SqlClient

Public Class Form12
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connectionString As String = "Data Source=DESKTOP-KBLLHAM;User ID=sa;Password=12345678;Integrated Security=True;Database=HAG3"
        Dim query As String = "SELECT * FROM pasien"

        Try
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable

                MessageBox.Show("Koneksi berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
