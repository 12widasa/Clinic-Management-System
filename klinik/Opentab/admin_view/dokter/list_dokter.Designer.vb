<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_dokter
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
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        btn_list_dokter = New Button()
        GroupBox2 = New GroupBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(382, 442)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(8, 8)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(140, 223)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(548, 161)
        DataGridView1.TabIndex = 12
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(299, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 31)
        Button2.TabIndex = 11
        Button2.Text = "Tambah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_list_dokter
        ' 
        btn_list_dokter.Location = New Point(140, 169)
        btn_list_dokter.Name = "btn_list_dokter"
        btn_list_dokter.Size = New Size(132, 31)
        btn_list_dokter.TabIndex = 10
        btn_list_dokter.Text = "List Dokter"
        btn_list_dokter.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(126, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(580, 289)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' list_dokter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(btn_list_dokter)
        Controls.Add(GroupBox2)
        Name = "list_dokter"
        Size = New Size(818, 497)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_list_dokter As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
