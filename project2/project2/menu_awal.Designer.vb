<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_awal
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
        Me.components = New System.ComponentModel.Container()
        Me.Lab_dat = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAndEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAndSeacrhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAndAditDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesertaMKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.but_exit = New System.Windows.Forms.Button()
        Me.But_ref = New System.Windows.Forms.Button()
        Me.but_log = New System.Windows.Forms.Button()
        Me.box_pass = New System.Windows.Forms.TextBox()
        Me.box_user = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Picbox = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_wel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lab_dat
        '
        Me.Lab_dat.AutoSize = True
        Me.Lab_dat.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_dat.Location = New System.Drawing.Point(210, 57)
        Me.Lab_dat.Name = "Lab_dat"
        Me.Lab_dat.Size = New System.Drawing.Size(387, 25)
        Me.Lab_dat.TabIndex = 0
        Me.Lab_dat.Text = "DATA UNIVERSITAS INFORMATIKA"
        Me.Lab_dat.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(797, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosenToolStripMenuItem, Me.InformasiToolStripMenuItem, Me.MahasiswaToolStripMenuItem, Me.MataKuliahToolStripMenuItem, Me.NilaiToolStripMenuItem, Me.PesertaMKToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DosenToolStripMenuItem
        '
        Me.DosenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAndEditToolStripMenuItem, Me.ViewAndSeacrhToolStripMenuItem})
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DosenToolStripMenuItem.Text = "dosen"
        '
        'AddAndEditToolStripMenuItem
        '
        Me.AddAndEditToolStripMenuItem.Name = "AddAndEditToolStripMenuItem"
        Me.AddAndEditToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddAndEditToolStripMenuItem.Text = "Add and Edit "
        '
        'ViewAndSeacrhToolStripMenuItem
        '
        Me.ViewAndSeacrhToolStripMenuItem.Name = "ViewAndSeacrhToolStripMenuItem"
        Me.ViewAndSeacrhToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ViewAndSeacrhToolStripMenuItem.Text = "View and Seacrh"
        '
        'InformasiToolStripMenuItem
        '
        Me.InformasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAndAditDataToolStripMenuItem, Me.ViewDataToolStripMenuItem})
        Me.InformasiToolStripMenuItem.Name = "InformasiToolStripMenuItem"
        Me.InformasiToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InformasiToolStripMenuItem.Text = "informasi"
        '
        'AddAndAditDataToolStripMenuItem
        '
        Me.AddAndAditDataToolStripMenuItem.Name = "AddAndAditDataToolStripMenuItem"
        Me.AddAndAditDataToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AddAndAditDataToolStripMenuItem.Text = "Add and Edit"
        '
        'ViewDataToolStripMenuItem
        '
        Me.ViewDataToolStripMenuItem.Name = "ViewDataToolStripMenuItem"
        Me.ViewDataToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ViewDataToolStripMenuItem.Text = "View and Search"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MahasiswaToolStripMenuItem.Text = "mahasiswa"
        '
        'MataKuliahToolStripMenuItem
        '
        Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MataKuliahToolStripMenuItem.Text = "mata kuliah"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NilaiToolStripMenuItem.Text = "nilai"
        '
        'PesertaMKToolStripMenuItem
        '
        Me.PesertaMKToolStripMenuItem.Name = "PesertaMKToolStripMenuItem"
        Me.PesertaMKToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.PesertaMKToolStripMenuItem.Text = "peserta MK"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.but_exit)
        Me.GroupBox1.Controls.Add(Me.But_ref)
        Me.GroupBox1.Controls.Add(Me.but_log)
        Me.GroupBox1.Controls.Add(Me.box_pass)
        Me.GroupBox1.Controls.Add(Me.box_user)
        Me.GroupBox1.Location = New System.Drawing.Point(289, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 164)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        Me.GroupBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'but_exit
        '
        Me.but_exit.Location = New System.Drawing.Point(163, 124)
        Me.but_exit.Name = "but_exit"
        Me.but_exit.Size = New System.Drawing.Size(54, 23)
        Me.but_exit.TabIndex = 4
        Me.but_exit.Text = "Exit"
        Me.but_exit.UseVisualStyleBackColor = True
        '
        'But_ref
        '
        Me.But_ref.Location = New System.Drawing.Point(88, 124)
        Me.But_ref.Name = "But_ref"
        Me.But_ref.Size = New System.Drawing.Size(54, 23)
        Me.But_ref.TabIndex = 3
        Me.But_ref.Text = "Refresh"
        Me.But_ref.UseVisualStyleBackColor = True
        '
        'but_log
        '
        Me.but_log.AutoEllipsis = True
        Me.but_log.Location = New System.Drawing.Point(14, 124)
        Me.but_log.Name = "but_log"
        Me.but_log.Size = New System.Drawing.Size(54, 23)
        Me.but_log.TabIndex = 2
        Me.but_log.Text = "Login"
        Me.but_log.UseVisualStyleBackColor = True
        '
        'box_pass
        '
        Me.box_pass.Location = New System.Drawing.Point(35, 89)
        Me.box_pass.Name = "box_pass"
        Me.box_pass.Size = New System.Drawing.Size(162, 20)
        Me.box_pass.TabIndex = 1
        Me.box_pass.UseSystemPasswordChar = True
        '
        'box_user
        '
        Me.box_user.Location = New System.Drawing.Point(35, 38)
        Me.box_user.Name = "box_user"
        Me.box_user.Size = New System.Drawing.Size(162, 20)
        Me.box_user.TabIndex = 0
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Picbox)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(797, 313)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(716, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Sign-up"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(650, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Picbox
        '
        Me.Picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picbox.Location = New System.Drawing.Point(72, 19)
        Me.Picbox.Name = "Picbox"
        Me.Picbox.Size = New System.Drawing.Size(659, 246)
        Me.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picbox.TabIndex = 0
        Me.Picbox.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Lab_wel
        '
        Me.Lab_wel.AutoSize = True
        Me.Lab_wel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_wel.Location = New System.Drawing.Point(241, 7)
        Me.Lab_wel.Name = "Lab_wel"
        Me.Lab_wel.Size = New System.Drawing.Size(321, 50)
        Me.Lab_wel.TabIndex = 4
        Me.Lab_wel.Text = "Welcome to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UNIVERSITAS INFORMATIKA"
        Me.Lab_wel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(721, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Log Out"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'menu_awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 404)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Lab_wel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lab_dat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "menu_awal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lab_dat As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents but_exit As System.Windows.Forms.Button
    Friend WithEvents But_ref As System.Windows.Forms.Button
    Friend WithEvents but_log As System.Windows.Forms.Button
    Friend WithEvents box_pass As System.Windows.Forms.TextBox
    Friend WithEvents box_user As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MataKuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesertaMKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAndAditDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAndEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAndSeacrhToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Picbox As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lab_wel As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
