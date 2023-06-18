<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perawat
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
        pn_button_title = New Panel()
        btn_beranda = New Button()
        btn_periksa = New Button()
        pn_title = New Panel()
        lbl_id_perawat = New Label()
        lbl_nama_perawat = New Label()
        pn_button_title.SuspendLayout()
        pn_title.SuspendLayout()
        SuspendLayout()
        ' 
        ' pn_button_title
        ' 
        pn_button_title.BackColor = SystemColors.ActiveBorder
        pn_button_title.Controls.Add(btn_beranda)
        pn_button_title.Controls.Add(btn_periksa)
        pn_button_title.Dock = DockStyle.Top
        pn_button_title.Location = New Point(0, 58)
        pn_button_title.Name = "pn_button_title"
        pn_button_title.Size = New Size(800, 69)
        pn_button_title.TabIndex = 19
        ' 
        ' btn_beranda
        ' 
        btn_beranda.Location = New Point(16, 17)
        btn_beranda.Name = "btn_beranda"
        btn_beranda.Size = New Size(95, 36)
        btn_beranda.TabIndex = 9
        btn_beranda.Text = "Beranda"
        btn_beranda.UseVisualStyleBackColor = True
        ' 
        ' btn_periksa
        ' 
        btn_periksa.Location = New Point(133, 17)
        btn_periksa.Name = "btn_periksa"
        btn_periksa.Size = New Size(95, 36)
        btn_periksa.TabIndex = 11
        btn_periksa.Text = "Periksa"
        btn_periksa.UseVisualStyleBackColor = True
        ' 
        ' pn_title
        ' 
        pn_title.BackColor = SystemColors.ActiveCaption
        pn_title.Controls.Add(lbl_id_perawat)
        pn_title.Controls.Add(lbl_nama_perawat)
        pn_title.Dock = DockStyle.Top
        pn_title.Location = New Point(0, 0)
        pn_title.Name = "pn_title"
        pn_title.Size = New Size(800, 58)
        pn_title.TabIndex = 18
        ' 
        ' lbl_id_perawat
        ' 
        lbl_id_perawat.AutoSize = True
        lbl_id_perawat.Location = New Point(118, 22)
        lbl_id_perawat.Name = "lbl_id_perawat"
        lbl_id_perawat.Size = New Size(22, 20)
        lbl_id_perawat.TabIndex = 9
        lbl_id_perawat.Text = "Id"
        ' 
        ' lbl_nama_perawat
        ' 
        lbl_nama_perawat.AutoSize = True
        lbl_nama_perawat.Location = New Point(16, 22)
        lbl_nama_perawat.Name = "lbl_nama_perawat"
        lbl_nama_perawat.Size = New Size(61, 20)
        lbl_nama_perawat.TabIndex = 8
        lbl_nama_perawat.Text = "Perawat"
        ' 
        ' perawat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 621)
        Controls.Add(pn_button_title)
        Controls.Add(pn_title)
        Name = "perawat"
        Text = "perawat"
        pn_button_title.ResumeLayout(False)
        pn_title.ResumeLayout(False)
        pn_title.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pn_button_title As Panel
    Friend WithEvents btn_dokter As Button
    Friend WithEvents btn_beranda As Button
    Friend WithEvents btn_periksa As Button
    Friend WithEvents btn_kasir As Button
    Friend WithEvents pn_title As Panel
    Friend WithEvents lbl_nama_perawat As Label
    Friend WithEvents lbl_id_perawat As Label
End Class
