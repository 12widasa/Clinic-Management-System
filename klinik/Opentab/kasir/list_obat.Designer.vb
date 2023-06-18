<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_obat
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
        txt_cari = New TextBox()
        txt_harga = New Label()
        txt_harga_obat = New TextBox()
        txt_tipe = New Label()
        txt_types = New TextBox()
        txt_nama_obat = New Label()
        txt_obat = New TextBox()
        Label1 = New Label()
        txt_id_obat = New TextBox()
        DGV_obat = New DataGridView()
        btn_tambah = New Button()
        btn_edit = New Button()
        btn_hapus = New Button()
        CType(DGV_obat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_cari
        ' 
        txt_cari.Location = New Point(311, 244)
        txt_cari.Name = "txt_cari"
        txt_cari.Size = New Size(188, 27)
        txt_cari.TabIndex = 90
        ' 
        ' txt_harga
        ' 
        txt_harga.AutoSize = True
        txt_harga.Location = New Point(429, 345)
        txt_harga.Name = "txt_harga"
        txt_harga.Size = New Size(50, 20)
        txt_harga.TabIndex = 87
        txt_harga.Text = "Harga"
        ' 
        ' txt_harga_obat
        ' 
        txt_harga_obat.Location = New Point(519, 342)
        txt_harga_obat.Name = "txt_harga_obat"
        txt_harga_obat.Size = New Size(188, 27)
        txt_harga_obat.TabIndex = 86
        ' 
        ' txt_tipe
        ' 
        txt_tipe.AutoSize = True
        txt_tipe.Location = New Point(429, 300)
        txt_tipe.Name = "txt_tipe"
        txt_tipe.Size = New Size(38, 20)
        txt_tipe.TabIndex = 85
        txt_tipe.Text = "Tipe"
        ' 
        ' txt_types
        ' 
        txt_types.Location = New Point(519, 297)
        txt_types.Name = "txt_types"
        txt_types.Size = New Size(188, 27)
        txt_types.TabIndex = 84
        ' 
        ' txt_nama_obat
        ' 
        txt_nama_obat.AutoSize = True
        txt_nama_obat.Location = New Point(83, 345)
        txt_nama_obat.Name = "txt_nama_obat"
        txt_nama_obat.Size = New Size(86, 20)
        txt_nama_obat.TabIndex = 83
        txt_nama_obat.Text = "Nama Obat"
        ' 
        ' txt_obat
        ' 
        txt_obat.Location = New Point(209, 342)
        txt_obat.Name = "txt_obat"
        txt_obat.Size = New Size(188, 27)
        txt_obat.TabIndex = 82
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 303)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 81
        Label1.Text = "ID"
        ' 
        ' txt_id_obat
        ' 
        txt_id_obat.Location = New Point(209, 300)
        txt_id_obat.Name = "txt_id_obat"
        txt_id_obat.Size = New Size(188, 27)
        txt_id_obat.TabIndex = 80
        ' 
        ' DGV_obat
        ' 
        DGV_obat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_obat.Location = New Point(159, 409)
        DGV_obat.Name = "DGV_obat"
        DGV_obat.RowHeadersWidth = 51
        DGV_obat.RowTemplate.Height = 29
        DGV_obat.Size = New Size(548, 161)
        DGV_obat.TabIndex = 79
        ' 
        ' btn_tambah
        ' 
        btn_tambah.Location = New Point(541, 589)
        btn_tambah.Name = "btn_tambah"
        btn_tambah.Size = New Size(132, 31)
        btn_tambah.TabIndex = 78
        btn_tambah.Text = "Tambah"
        btn_tambah.UseVisualStyleBackColor = True
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(378, 589)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(132, 31)
        btn_edit.TabIndex = 91
        btn_edit.Text = "Edit"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_hapus
        ' 
        btn_hapus.Location = New Point(209, 589)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(132, 31)
        btn_hapus.TabIndex = 92
        btn_hapus.Text = "Hapus"
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' list_obat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_hapus)
        Controls.Add(btn_edit)
        Controls.Add(txt_cari)
        Controls.Add(txt_harga)
        Controls.Add(txt_harga_obat)
        Controls.Add(txt_tipe)
        Controls.Add(txt_types)
        Controls.Add(txt_nama_obat)
        Controls.Add(txt_obat)
        Controls.Add(Label1)
        Controls.Add(txt_id_obat)
        Controls.Add(DGV_obat)
        Controls.Add(btn_tambah)
        Name = "list_obat"
        Size = New Size(818, 668)
        CType(DGV_obat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_cari As TextBox
    Friend WithEvents txt_harga As Label
    Friend WithEvents txt_harga_obat As TextBox
    Friend WithEvents txt_tipe As Label
    Friend WithEvents txt_types As TextBox
    Friend WithEvents txt_nama_obat As Label
    Friend WithEvents txt_obat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id_obat As TextBox
    Friend WithEvents DGV_obat As DataGridView
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_hapus As Button
End Class
