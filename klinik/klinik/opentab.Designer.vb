<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opentab
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
        btn_login = New Button()
        btn_conn = New Button()
        SuspendLayout()
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(339, 124)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(94, 29)
        btn_login.TabIndex = 0
        btn_login.Text = "Login tab"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' btn_conn
        ' 
        btn_conn.Location = New Point(339, 180)
        btn_conn.Name = "btn_conn"
        btn_conn.Size = New Size(94, 29)
        btn_conn.TabIndex = 1
        btn_conn.Text = "Conn tab"
        btn_conn.UseVisualStyleBackColor = True
        ' 
        ' opentab
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_conn)
        Controls.Add(btn_login)
        Name = "opentab"
        Size = New Size(773, 388)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents btn_conn As Button
End Class
