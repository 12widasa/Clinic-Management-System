Imports System.Data.SqlClient

Public Class kasir
    Private userId As String
    Private userName As String
    Public Sub New(id As String, name As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.userId = id
        Me.userName = name
    End Sub
    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        Dim formTransaksi As New transaksi(lbl_id_kasir.Text, lbl_nama_kasir.Text)
        Me.Controls.Clear()
        Me.Controls.Add(pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(formTransaksi)
    End Sub

    Private Sub btn_list_obat_Click(sender As Object, e As EventArgs) Handles btn_list_obat.Click
        Dim formListObat As New list_obat(lbl_id_kasir.Text, lbl_nama_kasir.Text)
        Me.Controls.Clear()
        Me.Controls.Add(pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(formListObat)
    End Sub
    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_id_kasir.Text = Me.userId
        lbl_nama_kasir.Text = Me.userName
    End Sub

End Class
