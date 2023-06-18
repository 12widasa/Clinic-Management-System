<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pwt_periksa
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
        Label8 = New Label()
        RD_perempuan = New RadioButton()
        RD_laki = New RadioButton()
        Label7 = New Label()
        Label3 = New Label()
        txt_telepon_periksa = New TextBox()
        Label6 = New Label()
        txt_alamat_periksa = New TextBox()
        btn_delete = New Button()
        btn_edit = New Button()
        Label5 = New Label()
        txt_resep_periksa = New TextBox()
        Label4 = New Label()
        txt_diagnosa_periksa = New TextBox()
        Label2 = New Label()
        txt_nama_periksa = New TextBox()
        Label1 = New Label()
        txt_id_periksa = New TextBox()
        DGV_periksa = New DataGridView()
        btn_tambah = New Button()
        Label9 = New Label()
        txt_keterangan_periksa = New TextBox()
        cmb_dokter = New ComboBox()
        Label10 = New Label()
        txt_no_antrean = New TextBox()
        CType(DGV_periksa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(74, 358)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 20)
        Label8.TabIndex = 98
        Label8.Text = "Jenis kelamin"
        ' 
        ' RD_perempuan
        ' 
        RD_perempuan.AutoSize = True
        RD_perempuan.Location = New Point(289, 358)
        RD_perempuan.Name = "RD_perempuan"
        RD_perempuan.Size = New Size(104, 24)
        RD_perempuan.TabIndex = 97
        RD_perempuan.TabStop = True
        RD_perempuan.Text = "Perempuan"
        RD_perempuan.UseVisualStyleBackColor = True
        ' 
        ' RD_laki
        ' 
        RD_laki.AutoSize = True
        RD_laki.Location = New Point(200, 358)
        RD_laki.Name = "RD_laki"
        RD_laki.Size = New Size(83, 24)
        RD_laki.TabIndex = 96
        RD_laki.TabStop = True
        RD_laki.Text = "Laki laki"
        RD_laki.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(420, 266)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 20)
        Label7.TabIndex = 95
        Label7.Text = "Dokter"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 93
        Label3.Text = "Nomor telepon"
        ' 
        ' txt_telepon_periksa
        ' 
        txt_telepon_periksa.Location = New Point(200, 309)
        txt_telepon_periksa.Name = "txt_telepon_periksa"
        txt_telepon_periksa.Size = New Size(188, 27)
        txt_telepon_periksa.TabIndex = 92
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(420, 312)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 91
        Label6.Text = "Alamat"
        ' 
        ' txt_alamat_periksa
        ' 
        txt_alamat_periksa.Location = New Point(510, 312)
        txt_alamat_periksa.Name = "txt_alamat_periksa"
        txt_alamat_periksa.Size = New Size(188, 27)
        txt_alamat_periksa.TabIndex = 90
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(185, 596)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(132, 31)
        btn_delete.TabIndex = 89
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(358, 596)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(132, 31)
        btn_edit.TabIndex = 88
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(420, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 87
        Label5.Text = "Resep"
        ' 
        ' txt_resep_periksa
        ' 
        txt_resep_periksa.Location = New Point(510, 221)
        txt_resep_periksa.Name = "txt_resep_periksa"
        txt_resep_periksa.Size = New Size(188, 27)
        txt_resep_periksa.TabIndex = 86
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(420, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 85
        Label4.Text = "Diagnosa"
        ' 
        ' txt_diagnosa_periksa
        ' 
        txt_diagnosa_periksa.Location = New Point(510, 176)
        txt_diagnosa_periksa.Name = "txt_diagnosa_periksa"
        txt_diagnosa_periksa.Size = New Size(188, 27)
        txt_diagnosa_periksa.TabIndex = 84
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 83
        Label2.Text = "Nama Pasien"
        ' 
        ' txt_nama_periksa
        ' 
        txt_nama_periksa.Location = New Point(200, 267)
        txt_nama_periksa.Name = "txt_nama_periksa"
        txt_nama_periksa.Size = New Size(188, 27)
        txt_nama_periksa.TabIndex = 82
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 81
        Label1.Text = "ID"
        ' 
        ' txt_id_periksa
        ' 
        txt_id_periksa.Location = New Point(200, 179)
        txt_id_periksa.Name = "txt_id_periksa"
        txt_id_periksa.Size = New Size(188, 27)
        txt_id_periksa.TabIndex = 80
        ' 
        ' DGV_periksa
        ' 
        DGV_periksa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_periksa.Location = New Point(150, 416)
        DGV_periksa.Name = "DGV_periksa"
        DGV_periksa.RowHeadersWidth = 51
        DGV_periksa.RowTemplate.Height = 29
        DGV_periksa.Size = New Size(548, 161)
        DGV_periksa.TabIndex = 79
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(532, 596)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(132, 31)
        btn_tambah.TabIndex = 78
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(420, 362)
        Label9.Name = "Label9"
        Label9.Size = New Size(85, 20)
        Label9.TabIndex = 102
        Label9.Text = "Keterangan"
        ' 
        ' txt_keterangan_periksa
        ' 
        txt_keterangan_periksa.Location = New Point(510, 359)
        txt_keterangan_periksa.Name = "txt_keterangan_periksa"
        txt_keterangan_periksa.Size = New Size(188, 27)
        txt_keterangan_periksa.TabIndex = 101
        ' 
        ' cmb_dokter
        ' 
        cmb_dokter.FormattingEnabled = True
        cmb_dokter.Location = New Point(510, 266)
        cmb_dokter.Name = "cmb_dokter"
        cmb_dokter.Size = New Size(188, 28)
        cmb_dokter.TabIndex = 103
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(74, 227)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 20)
        Label10.TabIndex = 105
        Label10.Text = "No Antrean"
        ' 
        ' txt_no_antrean
        ' 
        txt_no_antrean.Location = New Point(200, 224)
        txt_no_antrean.Name = "txt_no_antrean"
        txt_no_antrean.Size = New Size(188, 27)
        txt_no_antrean.TabIndex = 104
        ' 
        ' pwt_periksa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label10)
        Controls.Add(txt_no_antrean)
        Controls.Add(cmb_dokter)
        Controls.Add(Label9)
        Controls.Add(txt_keterangan_periksa)
        Controls.Add(Label8)
        Controls.Add(RD_perempuan)
        Controls.Add(RD_laki)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(txt_telepon_periksa)
        Controls.Add(Label6)
        Controls.Add(txt_alamat_periksa)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(Label5)
        Controls.Add(txt_resep_periksa)
        Controls.Add(Label4)
        Controls.Add(txt_diagnosa_periksa)
        Controls.Add(Label2)
        Controls.Add(txt_nama_periksa)
        Controls.Add(Label1)
        Controls.Add(txt_id_periksa)
        Controls.Add(DGV_periksa)
        Controls.Add(btn_tambah)
        Name = "pwt_periksa"
        Size = New Size(818, 668)
        CType(DGV_periksa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents RD_perempuan As RadioButton
    Friend WithEvents RD_laki As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_telepon_periksa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_alamat_periksa As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_resep_periksa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_diagnosa_periksa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_periksa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_periksa As TextBox
    Friend WithEvents DGV_periksa As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_keterangan_periksa As TextBox
    Friend WithEvents cmb_dokter As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_no_antrean As TextBox
End Class
