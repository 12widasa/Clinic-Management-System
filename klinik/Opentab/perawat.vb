Public Class perawat

    Private userId As String
    Private userName As String

    Public Sub New(id As String, name As String)
        InitializeComponent() 'Ini merupakan method bawaan windows form untuk inisialisasi komponen, jangan hapus ini.

        Me.userId = id
        Me.userName = name
    End Sub

    Private Sub btn_periksa_Click(sender As Object, e As EventArgs) Handles btn_periksa.Click
        Dim formPwtPeriksa As New pwt_periksa(Me.userId, Me.userName)
        Me.Controls.Clear()
        Me.Controls.Add(pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(formPwtPeriksa)
    End Sub


    Private Sub perawat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_id_perawat.Text = Me.userId
        lbl_nama_perawat.Text = Me.userName
    End Sub

    Private Sub btn_beranda_Click(sender As Object, e As EventArgs) Handles btn_beranda.Click

    End Sub
End Class
