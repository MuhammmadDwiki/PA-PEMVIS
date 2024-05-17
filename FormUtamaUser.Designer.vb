<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtamaUser
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
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.btnEditPorifle = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTransaksi
        '
        Me.btnTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.Location = New System.Drawing.Point(40, 266)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(159, 26)
        Me.btnTransaksi.TabIndex = 1
        Me.btnTransaksi.Text = "Beli Barang"
        Me.btnTransaksi.UseVisualStyleBackColor = False
        '
        'btnEditPorifle
        '
        Me.btnEditPorifle.BackColor = System.Drawing.Color.Transparent
        Me.btnEditPorifle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditPorifle.FlatAppearance.BorderSize = 0
        Me.btnEditPorifle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditPorifle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditPorifle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPorifle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPorifle.Location = New System.Drawing.Point(40, 221)
        Me.btnEditPorifle.Name = "btnEditPorifle"
        Me.btnEditPorifle.Size = New System.Drawing.Size(159, 26)
        Me.btnEditPorifle.TabIndex = 2
        Me.btnEditPorifle.Text = "Ganti Profil"
        Me.btnEditPorifle.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(40, 310)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(159, 26)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'FormUtamaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PAPEM.My.Resources.Resources.Beige_Minimalist_Casual_New_Collection_Bag_Desktop_Prototype__8_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 496)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnEditPorifle)
        Me.Controls.Add(Me.btnTransaksi)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUtamaUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUtamaUser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTransaksi As System.Windows.Forms.Button
    Friend WithEvents btnEditPorifle As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
