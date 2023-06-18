<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_dokter
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
        GroupBox1 = New GroupBox()
        DGV_dokter = New DataGridView()
        btn_tambah = New Button()
        txt_id_dokter = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt_nama_dokter = New TextBox()
        Label3 = New Label()
        txt_spesialisasi_dokter = New TextBox()
        Label4 = New Label()
        txt_alamat_dokter = New TextBox()
        Label5 = New Label()
        txt_telepon_dokter = New TextBox()
        btn_edit = New Button()
        btn_delete = New Button()
        Label6 = New Label()
        txt_cari = New TextBox()
        Label8 = New Label()
        RD_dkt_perempuan = New RadioButton()
        RD_dkt_laki = New RadioButton()
        Label7 = New Label()
        txt_usertype_dokter = New TextBox()
        Label9 = New Label()
        txt_gaji = New TextBox()
        CType(DGV_dokter, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(374, 632)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(8, 8)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' DGV_dokter
        ' 
        DGV_dokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_dokter.Location = New Point(132, 413)
        DGV_dokter.Name = "DGV_dokter"
        DGV_dokter.RowHeadersWidth = 51
        DGV_dokter.RowTemplate.Height = 29
        DGV_dokter.Size = New Size(548, 161)
        DGV_dokter.TabIndex = 17
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(514, 593)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(132, 31)
        btn_tambah.TabIndex = 16
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' txt_id_dokter
        ' 
        txt_id_dokter.Location = New Point(180, 156)
        txt_id_dokter.Name = "txt_id_dokter"
        txt_id_dokter.Size = New Size(188, 27)
        txt_id_dokter.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(103, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 20
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(103, 201)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 22
        Label2.Text = "Nama"
        ' 
        ' txt_nama_dokter
        ' 
        txt_nama_dokter.Location = New Point(180, 198)
        txt_nama_dokter.Name = "txt_nama_dokter"
        txt_nama_dokter.Size = New Size(188, 27)
        txt_nama_dokter.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 24
        Label3.Text = "Spesialisasi"
        ' 
        ' txt_spesialisasi_dokter
        ' 
        txt_spesialisasi_dokter.Location = New Point(180, 245)
        txt_spesialisasi_dokter.Name = "txt_spesialisasi_dokter"
        txt_spesialisasi_dokter.Size = New Size(188, 27)
        txt_spesialisasi_dokter.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(398, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 26
        Label4.Text = "Alamat"
        ' 
        ' txt_alamat_dokter
        ' 
        txt_alamat_dokter.Location = New Point(526, 156)
        txt_alamat_dokter.Name = "txt_alamat_dokter"
        txt_alamat_dokter.Size = New Size(188, 27)
        txt_alamat_dokter.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(398, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 28
        Label5.Text = "Telepon"
        ' 
        ' txt_telepon_dokter
        ' 
        txt_telepon_dokter.Location = New Point(526, 201)
        txt_telepon_dokter.Name = "txt_telepon_dokter"
        txt_telepon_dokter.Size = New Size(188, 27)
        txt_telepon_dokter.TabIndex = 27
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(340, 593)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(132, 31)
        btn_edit.TabIndex = 29
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(167, 593)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(132, 31)
        btn_delete.TabIndex = 30
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(260, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 32
        Label6.Text = "Cari"
        ' 
        ' txt_cari
        ' 
        txt_cari.Location = New Point(350, 356)
        txt_cari.Name = "txt_cari"
        txt_cari.Size = New Size(188, 27)
        txt_cari.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(56, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 20)
        Label8.TabIndex = 80
        Label8.Text = "Jenis kelamin"
        ' 
        ' RD_dkt_perempuan
        ' 
        RD_dkt_perempuan.AutoSize = True
        RD_dkt_perempuan.Location = New Point(271, 295)
        RD_dkt_perempuan.Name = "RD_dkt_perempuan"
        RD_dkt_perempuan.Size = New Size(104, 24)
        RD_dkt_perempuan.TabIndex = 79
        RD_dkt_perempuan.TabStop = True
        RD_dkt_perempuan.Text = "Perempuan"
        RD_dkt_perempuan.UseVisualStyleBackColor = True
        ' 
        ' RD_dkt_laki
        ' 
        RD_dkt_laki.AutoSize = True
        RD_dkt_laki.Location = New Point(182, 295)
        RD_dkt_laki.Name = "RD_dkt_laki"
        RD_dkt_laki.Size = New Size(83, 24)
        RD_dkt_laki.TabIndex = 78
        RD_dkt_laki.TabStop = True
        RD_dkt_laki.Text = "Laki laki"
        RD_dkt_laki.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(400, 251)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 82
        Label7.Text = "User type"
        ' 
        ' txt_usertype_dokter
        ' 
        txt_usertype_dokter.Location = New Point(526, 248)
        txt_usertype_dokter.Name = "txt_usertype_dokter"
        txt_usertype_dokter.PlaceholderText = "dokter"
        txt_usertype_dokter.ReadOnly = True
        txt_usertype_dokter.Size = New Size(188, 27)
        txt_usertype_dokter.TabIndex = 81
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(436, 295)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 20)
        Label9.TabIndex = 84
        Label9.Text = "Gaji"
        ' 
        ' txt_gaji
        ' 
        txt_gaji.Location = New Point(526, 292)
        txt_gaji.Name = "txt_gaji"
        txt_gaji.Size = New Size(188, 27)
        txt_gaji.TabIndex = 83
        ' 
        ' adm_dokter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label9)
        Controls.Add(txt_gaji)
        Controls.Add(Label7)
        Controls.Add(txt_usertype_dokter)
        Controls.Add(Label8)
        Controls.Add(RD_dkt_perempuan)
        Controls.Add(RD_dkt_laki)
        Controls.Add(Label6)
        Controls.Add(txt_cari)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(Label5)
        Controls.Add(txt_telepon_dokter)
        Controls.Add(Label4)
        Controls.Add(txt_alamat_dokter)
        Controls.Add(Label3)
        Controls.Add(txt_spesialisasi_dokter)
        Controls.Add(Label2)
        Controls.Add(txt_nama_dokter)
        Controls.Add(Label1)
        Controls.Add(txt_id_dokter)
        Controls.Add(GroupBox1)
        Controls.Add(DGV_dokter)
        Controls.Add(btn_tambah)
        Name = "adm_dokter"
        Size = New Size(818, 668)
        CType(DGV_dokter, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_dokter As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents txt_id_dokter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama_dokter As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_spesialisasi_dokter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_dokter As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telepon_dokter As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RD_dkt_perempuan As RadioButton
    Friend WithEvents RD_dkt_laki As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_usertype_dokter As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_gaji As TextBox
End Class
