<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administrator
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
        btn_beranda = New Button()
        btn_dokter = New Button()
        Button3 = New Button()
        btn_kasir = New Button()
        Pn_button_title = New Panel()
        Pn_title = New Panel()
        lbl_nama_admin = New Label()
        Pn_button_title.SuspendLayout()
        Pn_title.SuspendLayout()
        SuspendLayout()
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
        ' btn_dokter
        ' 
        btn_dokter.Location = New Point(134, 17)
        btn_dokter.Name = "btn_dokter"
        btn_dokter.Size = New Size(95, 36)
        btn_dokter.TabIndex = 10
        btn_dokter.Text = "Dokter"
        btn_dokter.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(250, 17)
        Button3.Name = "Button3"
        Button3.Size = New Size(95, 36)
        Button3.TabIndex = 11
        Button3.Text = "Nurse"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btn_kasir
        ' 
        btn_kasir.Location = New Point(362, 17)
        btn_kasir.Name = "btn_kasir"
        btn_kasir.Size = New Size(95, 36)
        btn_kasir.TabIndex = 12
        btn_kasir.Text = "Kasir"
        btn_kasir.UseVisualStyleBackColor = True
        ' 
        ' Pn_button_title
        ' 
        Pn_button_title.BackColor = SystemColors.ActiveBorder
        Pn_button_title.Controls.Add(btn_dokter)
        Pn_button_title.Controls.Add(btn_beranda)
        Pn_button_title.Controls.Add(Button3)
        Pn_button_title.Controls.Add(btn_kasir)
        Pn_button_title.Dock = DockStyle.Top
        Pn_button_title.Location = New Point(0, 58)
        Pn_button_title.Name = "Pn_button_title"
        Pn_button_title.Size = New Size(800, 69)
        Pn_button_title.TabIndex = 17
        ' 
        ' Pn_title
        ' 
        Pn_title.BackColor = SystemColors.ActiveCaption
        Pn_title.Controls.Add(lbl_nama_admin)
        Pn_title.Dock = DockStyle.Top
        Pn_title.Location = New Point(0, 0)
        Pn_title.Name = "Pn_title"
        Pn_title.Size = New Size(800, 58)
        Pn_title.TabIndex = 16
        ' 
        ' lbl_nama_admin
        ' 
        lbl_nama_admin.AutoSize = True
        lbl_nama_admin.Location = New Point(16, 20)
        lbl_nama_admin.Name = "lbl_nama_admin"
        lbl_nama_admin.Size = New Size(53, 20)
        lbl_nama_admin.TabIndex = 12
        lbl_nama_admin.Text = "Admin"
        ' 
        ' administrator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 621)
        Controls.Add(Pn_button_title)
        Controls.Add(Pn_title)
        Name = "administrator"
        Text = "administrator"
        Pn_button_title.ResumeLayout(False)
        Pn_title.ResumeLayout(False)
        Pn_title.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btn_beranda As Button
    Friend WithEvents btn_dokter As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_kasir As Button
    Friend WithEvents Pn_button_title As Panel
    Friend WithEvents Pn_title As Panel
    Friend WithEvents lbl_nama_admin As Label
End Class
