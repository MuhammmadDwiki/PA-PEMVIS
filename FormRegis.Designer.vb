<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegis
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
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbNotel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbUsername
        '
        Me.tbUsername.BackColor = System.Drawing.Color.DimGray
        Me.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbUsername.Location = New System.Drawing.Point(256, 249)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(192, 23)
        Me.tbUsername.TabIndex = 21
        '
        'tbNama
        '
        Me.tbNama.BackColor = System.Drawing.Color.DimGray
        Me.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNama.Location = New System.Drawing.Point(256, 164)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(192, 23)
        Me.tbNama.TabIndex = 20
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.DimGray
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnKembali.Location = New System.Drawing.Point(231, 414)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(237, 29)
        Me.btnKembali.TabIndex = 26
        Me.btnKembali.Text = "Sudah Regis? Klik Disini Untuk Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'tbEmail
        '
        Me.tbEmail.BackColor = System.Drawing.Color.DimGray
        Me.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmail.Location = New System.Drawing.Point(256, 208)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(192, 23)
        Me.tbEmail.TabIndex = 27
        '
        'btnRegis
        '
        Me.btnRegis.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegis.ForeColor = System.Drawing.Color.White
        Me.btnRegis.Location = New System.Drawing.Point(256, 373)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(192, 29)
        Me.btnRegis.TabIndex = 25
        Me.btnRegis.Text = "Regis"
        Me.btnRegis.UseVisualStyleBackColor = False
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.DimGray
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPassword.Location = New System.Drawing.Point(256, 289)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(192, 23)
        Me.tbPassword.TabIndex = 28
        '
        'tbNotel
        '
        Me.tbNotel.BackColor = System.Drawing.Color.DimGray
        Me.tbNotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNotel.Location = New System.Drawing.Point(256, 329)
        Me.tbNotel.Name = "tbNotel"
        Me.tbNotel.Size = New System.Drawing.Size(192, 23)
        Me.tbNotel.TabIndex = 29
        '
        'FormRegis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = Global.PAPEM.My.Resources.Resources.Beige_Minimalist_Casual_New_Collection_Bag_Desktop_Prototype__11_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(691, 493)
        Me.Controls.Add(Me.tbNotel)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnRegis)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.tbNama)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRegis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRegis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnRegis As System.Windows.Forms.Button
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents tbNotel As System.Windows.Forms.TextBox
End Class
