Public Class administrator


    Private Sub btn_beranda_Click(sender As Object, e As EventArgs) Handles btn_beranda.Click
        Dim berandaForm As New adm_beranda()
        Me.Controls.Clear()
        Me.Controls.Add(Pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(Pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(berandaForm)
    End Sub

    Private Sub btn_dokter_Click(sender As Object, e As EventArgs) Handles btn_dokter.Click
        Dim dokterForm As New adm_dokter()
        Me.Controls.Clear()
        Me.Controls.Add(Pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(Pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(dokterForm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim perawatForm As New adm_perawat()
        Me.Controls.Clear()
        Me.Controls.Add(Pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(Pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(perawatForm)
    End Sub

    Private Sub btn_kasir_Click(sender As Object, e As EventArgs) Handles btn_kasir.Click
        Dim kasirForm As New adm_kasir()
        Me.Controls.Clear()
        Me.Controls.Add(Pn_button_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(Pn_title) ' Menambahkan kembali panel pada form administrator
        Me.Controls.Add(kasirForm)
    End Sub


End Class