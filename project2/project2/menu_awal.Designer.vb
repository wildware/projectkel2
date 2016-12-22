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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA UNIVERSITAS INFORMATIKA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(461, 24)
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
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DosenToolStripMenuItem.Text = "dosen"
        '
        'InformasiToolStripMenuItem
        '
        Me.InformasiToolStripMenuItem.Name = "InformasiToolStripMenuItem"
        Me.InformasiToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InformasiToolStripMenuItem.Text = "informasi"
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
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MataKuliahToolStripMenuItem.Text = "mata kuliah"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NilaiToolStripMenuItem.Text = "nilai"
        '
        'PesertaMKToolStripMenuItem
        '
        Me.PesertaMKToolStripMenuItem.Name = "PesertaMKToolStripMenuItem"
        Me.PesertaMKToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.GroupBox1.Location = New System.Drawing.Point(112, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 182)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
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
        Me.but_exit.Location = New System.Drawing.Point(161, 146)
        Me.but_exit.Name = "but_exit"
        Me.but_exit.Size = New System.Drawing.Size(54, 23)
        Me.but_exit.TabIndex = 4
        Me.but_exit.Text = "Exit"
        Me.but_exit.UseVisualStyleBackColor = True
        '
        'But_ref
        '
        Me.But_ref.Location = New System.Drawing.Point(86, 146)
        Me.But_ref.Name = "But_ref"
        Me.But_ref.Size = New System.Drawing.Size(54, 23)
        Me.But_ref.TabIndex = 3
        Me.But_ref.Text = "Refresh"
        Me.But_ref.UseVisualStyleBackColor = True
        '
        'but_log
        '
        Me.but_log.Location = New System.Drawing.Point(12, 146)
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
        'menu_awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 323)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu_awal"
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
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

End Class
