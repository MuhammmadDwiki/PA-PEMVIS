<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.cbSee = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnRegis
        '
        Me.btnRegis.BackColor = System.Drawing.Color.DimGray
        Me.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegis.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegis.Location = New System.Drawing.Point(219, 391)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(252, 29)
        Me.btnRegis.TabIndex = 19
        Me.btnRegis.Text = "Don’t Have Account? Regis"
        Me.btnRegis.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.DimGray
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Location = New System.Drawing.Point(250, 269)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(192, 23)
        Me.txtPass.TabIndex = 14
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DimGray
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(250, 328)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(192, 29)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.DimGray
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Location = New System.Drawing.Point(250, 197)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(192, 23)
        Me.txtNama.TabIndex = 20
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.BackgroundImage = Global.PAPEM.My.Resources.Resources.X_Ikon_Vektor__Vektor__Ilustrasi__Desain_PNG_dan_Vektor_dengan_Background_Transparan_untuk_Unduh_Gratis_removebg_preview
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Location = New System.Drawing.Point(413, 50)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(116, 108)
        Me.btnKeluar.TabIndex = 21
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'cbSee
        '
        Me.cbSee.AutoSize = True
        Me.cbSee.Location = New System.Drawing.Point(340, 298)
        Me.cbSee.Name = "cbSee"
        Me.cbSee.Size = New System.Drawing.Size(102, 19)
        Me.cbSee.TabIndex = 22
        Me.cbSee.Text = "See Password"
        Me.cbSee.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PAPEM.My.Resources.Resources.Beige_Minimalist_Casual_New_Collection_Bag_Desktop_Prototype__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 493)
        Me.Controls.Add(Me.cbSee)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnRegis)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegis As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents cbSee As System.Windows.Forms.CheckBox

End Class
