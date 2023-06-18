<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_perawat
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
        txt_cari = New TextBox()
        btn_delete = New Button()
        btn_edit = New Button()
        Label5 = New Label()
        txt_telepon_perawat = New TextBox()
        Label4 = New Label()
        txt_alamat_perawat = New TextBox()
        Label2 = New Label()
        txt_username_perawat = New TextBox()
        Label1 = New Label()
        txt_id_perawat = New TextBox()
        GroupBox1 = New GroupBox()
        DGV_perawat = New DataGridView()
        btn_tambah = New Button()
        Label3 = New Label()
        txt_password_perawat = New TextBox()
        Label7 = New Label()
        txt_usertype_perawat = New TextBox()
        Label8 = New Label()
        RD_pwt_perempuan = New RadioButton()
        RD_pwt_laki = New RadioButton()
        Label9 = New Label()
        txt_gaji = New TextBox()
        CType(DGV_perawat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(261, 366)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 49
        Label6.Text = "Cari"
        ' 
        ' txt_cari
        ' 
        txt_cari.Location = New Point(351, 366)
        txt_cari.Name = "txt_cari"
        txt_cari.Size = New Size(188, 27)
        txt_cari.TabIndex = 48
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(178, 590)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(132, 31)
        btn_delete.TabIndex = 47
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(351, 590)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(132, 31)
        btn_edit.TabIndex = 46
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(413, 195)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 45
        Label5.Text = "Telepon"
        ' 
        ' txt_telepon_perawat
        ' 
        txt_telepon_perawat.Location = New Point(503, 192)
        txt_telepon_perawat.Name = "txt_telepon_perawat"
        txt_telepon_perawat.Size = New Size(188, 27)
        txt_telepon_perawat.TabIndex = 44
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(413, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 43
        Label4.Text = "Alamat"
        ' 
        ' txt_alamat_perawat
        ' 
        txt_alamat_perawat.Location = New Point(503, 147)
        txt_alamat_perawat.Name = "txt_alamat_perawat"
        txt_alamat_perawat.Size = New Size(188, 27)
        txt_alamat_perawat.TabIndex = 42
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 39
        Label2.Text = "Username"
        ' 
        ' txt_username_perawat
        ' 
        txt_username_perawat.Location = New Point(193, 192)
        txt_username_perawat.Name = "txt_username_perawat"
        txt_username_perawat.Size = New Size(188, 27)
        txt_username_perawat.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 37
        Label1.Text = "ID"
        ' 
        ' txt_id_perawat
        ' 
        txt_id_perawat.Location = New Point(193, 150)
        txt_id_perawat.Name = "txt_id_perawat"
        txt_id_perawat.Size = New Size(188, 27)
        txt_id_perawat.TabIndex = 36
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(375, 641)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(8, 8)
        GroupBox1.TabIndex = 35
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' DGV_perawat
        ' 
        DGV_perawat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_perawat.Location = New Point(143, 410)
        DGV_perawat.Name = "DGV_perawat"
        DGV_perawat.RowHeadersWidth = 51
        DGV_perawat.RowTemplate.Height = 29
        DGV_perawat.Size = New Size(548, 161)
        DGV_perawat.TabIndex = 34
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(525, 590)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(132, 31)
        btn_tambah.TabIndex = 33
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 51
        Label3.Text = "Password"
        ' 
        ' txt_password_perawat
        ' 
        txt_password_perawat.Location = New Point(193, 234)
        txt_password_perawat.Name = "txt_password_perawat"
        txt_password_perawat.Size = New Size(188, 27)
        txt_password_perawat.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(413, 237)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 53
        Label7.Text = "User type"
        ' 
        ' txt_usertype_perawat
        ' 
        txt_usertype_perawat.Location = New Point(503, 234)
        txt_usertype_perawat.Name = "txt_usertype_perawat"
        txt_usertype_perawat.PlaceholderText = "perawat"
        txt_usertype_perawat.ReadOnly = True
        txt_usertype_perawat.Size = New Size(188, 27)
        txt_usertype_perawat.TabIndex = 52
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(67, 283)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 20)
        Label8.TabIndex = 77
        Label8.Text = "Jenis kelamin"
        ' 
        ' RD_pwt_perempuan
        ' 
        RD_pwt_perempuan.AutoSize = True
        RD_pwt_perempuan.Location = New Point(282, 283)
        RD_pwt_perempuan.Name = "RD_pwt_perempuan"
        RD_pwt_perempuan.Size = New Size(104, 24)
        RD_pwt_perempuan.TabIndex = 76
        RD_pwt_perempuan.TabStop = True
        RD_pwt_perempuan.Text = "Perempuan"
        RD_pwt_perempuan.UseVisualStyleBackColor = True
        ' 
        ' RD_pwt_laki
        ' 
        RD_pwt_laki.AutoSize = True
        RD_pwt_laki.Location = New Point(193, 283)
        RD_pwt_laki.Name = "RD_pwt_laki"
        RD_pwt_laki.Size = New Size(83, 24)
        RD_pwt_laki.TabIndex = 75
        RD_pwt_laki.TabStop = True
        RD_pwt_laki.Text = "Laki laki"
        RD_pwt_laki.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(413, 283)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 20)
        Label9.TabIndex = 86
        Label9.Text = "Gaji"
        ' 
        ' txt_gaji
        ' 
        txt_gaji.Location = New Point(503, 280)
        txt_gaji.Name = "txt_gaji"
        txt_gaji.Size = New Size(188, 27)
        txt_gaji.TabIndex = 85
        ' 
        ' adm_perawat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label9)
        Controls.Add(txt_gaji)
        Controls.Add(Label8)
        Controls.Add(RD_pwt_perempuan)
        Controls.Add(RD_pwt_laki)
        Controls.Add(Label7)
        Controls.Add(txt_usertype_perawat)
        Controls.Add(Label3)
        Controls.Add(txt_password_perawat)
        Controls.Add(Label6)
        Controls.Add(txt_cari)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(Label5)
        Controls.Add(txt_telepon_perawat)
        Controls.Add(Label4)
        Controls.Add(txt_alamat_perawat)
        Controls.Add(Label2)
        Controls.Add(txt_username_perawat)
        Controls.Add(Label1)
        Controls.Add(txt_id_perawat)
        Controls.Add(GroupBox1)
        Controls.Add(DGV_perawat)
        Controls.Add(btn_tambah)
        Name = "adm_perawat"
        Size = New Size(818, 668)
        CType(DGV_perawat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telepon_perawat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_perawat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username_perawat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_perawat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_perawat As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password_perawat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_usertype_perawat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RD_pwt_perempuan As RadioButton
    Friend WithEvents RD_pwt_laki As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_gaji As TextBox
End Class
