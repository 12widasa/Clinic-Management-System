<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_kasir
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
        Label7 = New Label()
        txt_usertype_kasir = New TextBox()
        Label3 = New Label()
        txt_password_kasir = New TextBox()
        Label6 = New Label()
        txt_cari = New TextBox()
        btn_delete = New Button()
        btn_edit = New Button()
        Label5 = New Label()
        txt_telepon_kasir = New TextBox()
        Label4 = New Label()
        txt_alamat_kasir = New TextBox()
        Label2 = New Label()
        txt_username_kasir = New TextBox()
        Label1 = New Label()
        txt_id_kasir = New TextBox()
        DGV_kasir = New DataGridView()
        btn_tambah = New Button()
        RD_laki = New RadioButton()
        RD_perempuan = New RadioButton()
        Label8 = New Label()
        Label10 = New Label()
        txt_gaji = New TextBox()
        CType(DGV_kasir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(442, 208)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 71
        Label7.Text = "User type"
        ' 
        ' txt_usertype_kasir
        ' 
        txt_usertype_kasir.Location = New Point(532, 205)
        txt_usertype_kasir.Name = "txt_usertype_kasir"
        txt_usertype_kasir.PlaceholderText = "kasir"
        txt_usertype_kasir.ReadOnly = True
        txt_usertype_kasir.Size = New Size(188, 27)
        txt_usertype_kasir.TabIndex = 70
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 69
        Label3.Text = "Password"
        ' 
        ' txt_password_kasir
        ' 
        txt_password_kasir.Location = New Point(222, 205)
        txt_password_kasir.Name = "txt_password_kasir"
        txt_password_kasir.Size = New Size(188, 27)
        txt_password_kasir.TabIndex = 68
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(293, 359)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 67
        Label6.Text = "Cari"
        ' 
        ' txt_cari
        ' 
        txt_cari.Location = New Point(347, 356)
        txt_cari.Name = "txt_cari"
        txt_cari.Size = New Size(188, 27)
        txt_cari.TabIndex = 66
        ' 
        ' btn_delete
        ' 
        btn_delete.Location = New Point(174, 588)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(132, 31)
        btn_delete.TabIndex = 65
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(347, 588)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(132, 31)
        btn_edit.TabIndex = 64
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(442, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 20)
        Label5.TabIndex = 63
        Label5.Text = "Telepon"
        ' 
        ' txt_telepon_kasir
        ' 
        txt_telepon_kasir.Location = New Point(532, 163)
        txt_telepon_kasir.Name = "txt_telepon_kasir"
        txt_telepon_kasir.Size = New Size(188, 27)
        txt_telepon_kasir.TabIndex = 62
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(442, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 61
        Label4.Text = "Alamat"
        ' 
        ' txt_alamat_kasir
        ' 
        txt_alamat_kasir.Location = New Point(532, 118)
        txt_alamat_kasir.Name = "txt_alamat_kasir"
        txt_alamat_kasir.Size = New Size(188, 27)
        txt_alamat_kasir.TabIndex = 60
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 59
        Label2.Text = "Username"
        ' 
        ' txt_username_kasir
        ' 
        txt_username_kasir.Location = New Point(222, 163)
        txt_username_kasir.Name = "txt_username_kasir"
        txt_username_kasir.Size = New Size(188, 27)
        txt_username_kasir.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 57
        Label1.Text = "ID"
        ' 
        ' txt_id_kasir
        ' 
        txt_id_kasir.Location = New Point(222, 121)
        txt_id_kasir.Name = "txt_id_kasir"
        txt_id_kasir.Size = New Size(188, 27)
        txt_id_kasir.TabIndex = 56
        ' 
        ' DGV_kasir
        ' 
        DGV_kasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_kasir.Location = New Point(139, 408)
        DGV_kasir.Name = "DGV_kasir"
        DGV_kasir.RowHeadersWidth = 51
        DGV_kasir.RowTemplate.Height = 29
        DGV_kasir.Size = New Size(548, 161)
        DGV_kasir.TabIndex = 55
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(521, 588)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(132, 31)
        btn_tambah.TabIndex = 54
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' RD_laki
        ' 
        RD_laki.AutoSize = True
        RD_laki.Location = New Point(222, 261)
        RD_laki.Name = "RD_laki"
        RD_laki.Size = New Size(83, 24)
        RD_laki.TabIndex = 72
        RD_laki.TabStop = True
        RD_laki.Text = "Laki laki"
        RD_laki.UseVisualStyleBackColor = True
        ' 
        ' RD_perempuan
        ' 
        RD_perempuan.AutoSize = True
        RD_perempuan.Location = New Point(311, 261)
        RD_perempuan.Name = "RD_perempuan"
        RD_perempuan.Size = New Size(104, 24)
        RD_perempuan.TabIndex = 73
        RD_perempuan.TabStop = True
        RD_perempuan.Text = "Perempuan"
        RD_perempuan.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(96, 261)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 20)
        Label8.TabIndex = 74
        Label8.Text = "Jenis kelamin"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(442, 263)
        Label10.Name = "Label10"
        Label10.Size = New Size(35, 20)
        Label10.TabIndex = 90
        Label10.Text = "Gaji"
        ' 
        ' txt_gaji
        ' 
        txt_gaji.Location = New Point(532, 260)
        txt_gaji.Name = "txt_gaji"
        txt_gaji.Size = New Size(188, 27)
        txt_gaji.TabIndex = 89
        ' 
        ' adm_kasir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Label10)
        Controls.Add(txt_gaji)
        Controls.Add(Label8)
        Controls.Add(RD_perempuan)
        Controls.Add(RD_laki)
        Controls.Add(Label7)
        Controls.Add(txt_usertype_kasir)
        Controls.Add(Label3)
        Controls.Add(txt_password_kasir)
        Controls.Add(Label6)
        Controls.Add(txt_cari)
        Controls.Add(btn_delete)
        Controls.Add(btn_edit)
        Controls.Add(Label5)
        Controls.Add(txt_telepon_kasir)
        Controls.Add(Label4)
        Controls.Add(txt_alamat_kasir)
        Controls.Add(Label2)
        Controls.Add(txt_username_kasir)
        Controls.Add(Label1)
        Controls.Add(txt_id_kasir)
        Controls.Add(DGV_kasir)
        Controls.Add(btn_tambah)
        Name = "adm_kasir"
        Size = New Size(818, 668)
        CType(DGV_kasir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txt_usertype_kasir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password_kasir As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telepon_kasir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_alamat_kasir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username_kasir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_kasir As TextBox
    Friend WithEvents DGV_kasir As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents RD_laki As RadioButton
    Friend WithEvents RD_perempuan As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_gaji As TextBox
End Class
