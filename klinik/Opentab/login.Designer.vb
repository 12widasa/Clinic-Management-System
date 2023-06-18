<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        txt_username = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txt_password = New TextBox()
        Label3 = New Label()
        combo_userType = New ComboBox()
        Label4 = New Label()
        btn_login = New Button()
        SuspendLayout()
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(345, 145)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(151, 27)
        txt_username.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 252)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(345, 249)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(151, 27)
        txt_password.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(259, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 5
        Label3.Text = "Level"
        ' 
        ' combo_userType
        ' 
        combo_userType.FormattingEnabled = True
        combo_userType.Items.AddRange(New Object() {"admin ", "perawat", "kasir"})
        combo_userType.Location = New Point(345, 198)
        combo_userType.Name = "combo_userType"
        combo_userType.Size = New Size(151, 28)
        combo_userType.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(345, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 7
        Label4.Text = "Login Session"
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(402, 301)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(94, 29)
        btn_login.TabIndex = 8
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_login)
        Controls.Add(Label4)
        Controls.Add(combo_userType)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_password)
        Controls.Add(Label1)
        Controls.Add(txt_username)
        Name = "login"
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_userType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_login As Button
End Class
