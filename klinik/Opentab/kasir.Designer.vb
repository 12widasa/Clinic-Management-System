<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        pn_title = New Panel()
        lbl_id_kasir = New Label()
        lbl_nama_kasir = New Label()
        pn_button_title = New Panel()
        Button1 = New Button()
        btn_transaksi = New Button()
        btn_list_obat = New Button()
        pn_title.SuspendLayout()
        pn_button_title.SuspendLayout()
        SuspendLayout()
        ' 
        ' pn_title
        ' 
        pn_title.BackColor = SystemColors.ActiveCaption
        pn_title.Controls.Add(lbl_id_kasir)
        pn_title.Controls.Add(lbl_nama_kasir)
        pn_title.Dock = DockStyle.Top
        pn_title.Location = New Point(0, 0)
        pn_title.Name = "pn_title"
        pn_title.Size = New Size(800, 58)
        pn_title.TabIndex = 20
        ' 
        ' lbl_id_kasir
        ' 
        lbl_id_kasir.AutoSize = True
        lbl_id_kasir.Location = New Point(440, 19)
        lbl_id_kasir.Name = "lbl_id_kasir"
        lbl_id_kasir.Size = New Size(22, 20)
        lbl_id_kasir.TabIndex = 11
        lbl_id_kasir.Text = "Id"
        ' 
        ' lbl_nama_kasir
        ' 
        lbl_nama_kasir.AutoSize = True
        lbl_nama_kasir.Location = New Point(338, 19)
        lbl_nama_kasir.Name = "lbl_nama_kasir"
        lbl_nama_kasir.Size = New Size(41, 20)
        lbl_nama_kasir.TabIndex = 10
        lbl_nama_kasir.Text = "Kasir"
        ' 
        ' pn_button_title
        ' 
        pn_button_title.BackColor = SystemColors.ActiveBorder
        pn_button_title.Controls.Add(Button1)
        pn_button_title.Controls.Add(btn_transaksi)
        pn_button_title.Controls.Add(btn_list_obat)
        pn_button_title.Dock = DockStyle.Top
        pn_button_title.Location = New Point(0, 58)
        pn_button_title.Name = "pn_button_title"
        pn_button_title.Size = New Size(800, 69)
        pn_button_title.TabIndex = 133
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(253, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 36)
        Button1.TabIndex = 12
        Button1.Text = "List Transaksi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btn_transaksi
        ' 
        btn_transaksi.Location = New Point(16, 17)
        btn_transaksi.Name = "btn_transaksi"
        btn_transaksi.Size = New Size(95, 36)
        btn_transaksi.TabIndex = 9
        btn_transaksi.Text = "Transaksi"
        btn_transaksi.UseVisualStyleBackColor = True
        ' 
        ' btn_list_obat
        ' 
        btn_list_obat.Location = New Point(133, 17)
        btn_list_obat.Name = "btn_list_obat"
        btn_list_obat.Size = New Size(95, 36)
        btn_list_obat.TabIndex = 11
        btn_list_obat.Text = "List Obat"
        btn_list_obat.UseVisualStyleBackColor = True
        ' 
        ' kasir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 621)
        Controls.Add(pn_button_title)
        Controls.Add(pn_title)
        Name = "kasir"
        Text = "kasir"
        pn_title.ResumeLayout(False)
        pn_title.PerformLayout()
        pn_button_title.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pn_title As Panel
    Friend WithEvents pn_button_title As Panel
    Friend WithEvents btn_transaksi As Button
    Friend WithEvents btn_list_obat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_id_kasir As Label
    Friend WithEvents lbl_nama_kasir As Label
End Class
