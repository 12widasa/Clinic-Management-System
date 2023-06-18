<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label6 = New Label()
        txt_alamat = New TextBox()
        btn_cari = New Button()
        Label5 = New Label()
        txt_diagnosa = New TextBox()
        Label1 = New Label()
        txt_no_antrean = New TextBox()
        Label9 = New Label()
        Label2 = New Label()
        txt_nama_pasien = New TextBox()
        Label10 = New Label()
        txt_id_pasien = New TextBox()
        DGV_kasir = New DataGridView()
        btn_bayar = New Button()
        lbl_total_transaksi = New Label()
        Label3 = New Label()
        cmb_tambahan = New ComboBox()
        btn_clear = New Button()
        CType(DGV_kasir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(408, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 147
        Label6.Text = "Alamat"
        ' 
        ' txt_alamat
        ' 
        txt_alamat.Location = New Point(544, 246)
        txt_alamat.Name = "txt_alamat"
        txt_alamat.Size = New Size(188, 27)
        txt_alamat.TabIndex = 146
        ' 
        ' btn_cari
        ' 
        btn_cari.Location = New Point(525, 137)
        btn_cari.Name = "btn_cari"
        btn_cari.Size = New Size(94, 29)
        btn_cari.TabIndex = 145
        btn_cari.Text = "Cari"
        btn_cari.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(408, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 144
        Label5.Text = "Diagnosa"
        ' 
        ' txt_diagnosa
        ' 
        txt_diagnosa.Location = New Point(544, 198)
        txt_diagnosa.Name = "txt_diagnosa"
        txt_diagnosa.Size = New Size(188, 27)
        txt_diagnosa.TabIndex = 143
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(221, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 142
        Label1.Text = "Cari Pasien"
        ' 
        ' txt_no_antrean
        ' 
        txt_no_antrean.Location = New Point(314, 138)
        txt_no_antrean.Name = "txt_no_antrean"
        txt_no_antrean.Size = New Size(188, 27)
        txt_no_antrean.TabIndex = 141
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(89, 312)
        Label9.Name = "Label9"
        Label9.Size = New Size(42, 20)
        Label9.TabIndex = 140
        Label9.Text = "Total"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 138
        Label2.Text = "Nama Pasien"
        ' 
        ' txt_nama_pasien
        ' 
        txt_nama_pasien.Location = New Point(191, 245)
        txt_nama_pasien.Name = "txt_nama_pasien"
        txt_nama_pasien.Size = New Size(188, 27)
        txt_nama_pasien.TabIndex = 137
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(76, 206)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 20)
        Label10.TabIndex = 136
        Label10.Text = "ID"
        ' 
        ' txt_id_pasien
        ' 
        txt_id_pasien.Location = New Point(191, 203)
        txt_id_pasien.Name = "txt_id_pasien"
        txt_id_pasien.Size = New Size(188, 27)
        txt_id_pasien.TabIndex = 135
        ' 
        ' DGV_kasir
        ' 
        DGV_kasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_kasir.Location = New Point(89, 379)
        DGV_kasir.Name = "DGV_kasir"
        DGV_kasir.RowHeadersWidth = 51
        DGV_kasir.RowTemplate.Height = 29
        DGV_kasir.Size = New Size(624, 161)
        DGV_kasir.TabIndex = 134
        ' 
        ' btn_bayar
        ' 
        btn_bayar.Location = New Point(556, 565)
        btn_bayar.Name = "btn_bayar"
        btn_bayar.Size = New Size(132, 31)
        btn_bayar.TabIndex = 133
        btn_bayar.Text = "Bayar"
        btn_bayar.UseVisualStyleBackColor = True
        ' 
        ' lbl_total_transaksi
        ' 
        lbl_total_transaksi.AutoSize = True
        lbl_total_transaksi.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_total_transaksi.Location = New Point(150, 302)
        lbl_total_transaksi.Name = "lbl_total_transaksi"
        lbl_total_transaksi.Size = New Size(60, 46)
        lbl_total_transaksi.TabIndex = 148
        lbl_total_transaksi.Text = "Rp"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(408, 294)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 150
        Label3.Text = "Biaya Tambahan"
        ' 
        ' cmb_tambahan
        ' 
        cmb_tambahan.FormattingEnabled = True
        cmb_tambahan.Location = New Point(544, 291)
        cmb_tambahan.Name = "cmb_tambahan"
        cmb_tambahan.Size = New Size(188, 28)
        cmb_tambahan.TabIndex = 151
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(408, 565)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(132, 31)
        btn_clear.TabIndex = 152
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' transaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(btn_clear)
        Controls.Add(cmb_tambahan)
        Controls.Add(Label3)
        Controls.Add(lbl_total_transaksi)
        Controls.Add(Label6)
        Controls.Add(txt_alamat)
        Controls.Add(btn_cari)
        Controls.Add(Label5)
        Controls.Add(txt_diagnosa)
        Controls.Add(Label1)
        Controls.Add(txt_no_antrean)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(txt_nama_pasien)
        Controls.Add(Label10)
        Controls.Add(txt_id_pasien)
        Controls.Add(DGV_kasir)
        Controls.Add(btn_bayar)
        Name = "transaksi"
        Size = New Size(818, 668)
        CType(DGV_kasir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents btn_cari As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_diagnosa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_no_antrean As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_pasien As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_id_pasien As TextBox
    Friend WithEvents DGV_kasir As DataGridView
    Friend WithEvents btn_bayar As Button
    Friend WithEvents lbl_total_transaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tambahan As ComboBox
    Friend WithEvents btn_clear As Button
End Class
