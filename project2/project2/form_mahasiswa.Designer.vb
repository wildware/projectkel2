<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mahasiswa
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Dim Nama_mhsLabel As System.Windows.Forms.Label
        Dim Nim_mhsLabel As System.Windows.Forms.Label
        Dim Tgl_lahir_mhsLabel As System.Windows.Forms.Label
        Dim Email_mhsLabel As System.Windows.Forms.Label
        Dim Alamat_mhsLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Dim Id_MAHASISWALabel As System.Windows.Forms.Label
        Me.Universitas_bersamaDataSet = New project2.universitas_bersamaDataSet()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New project2.universitas_bersamaDataSetTableAdapters.mahasiswaTableAdapter()
        Me.TableAdapterManager = New project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager()
        Me.exit_but = New System.Windows.Forms.Button()
        Me.refresh_but = New System.Windows.Forms.Button()
        Me.cancel_but = New System.Windows.Forms.Button()
        Me.save_but = New System.Windows.Forms.Button()
        Me.delete_but = New System.Windows.Forms.Button()
        Me.edit_but = New System.Windows.Forms.Button()
        Me.add_but = New System.Windows.Forms.Button()
        Me.Id_MAHASISWATextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PaswordTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Nim_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_lahir_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Email_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Alamat_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.No_telpTextBox = New System.Windows.Forms.TextBox()
        Me.MahasiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        UsernameLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        Nama_mhsLabel = New System.Windows.Forms.Label()
        Nim_mhsLabel = New System.Windows.Forms.Label()
        Tgl_lahir_mhsLabel = New System.Windows.Forms.Label()
        Email_mhsLabel = New System.Windows.Forms.Label()
        Alamat_mhsLabel = New System.Windows.Forms.Label()
        No_telpLabel = New System.Windows.Forms.Label()
        Id_MAHASISWALabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_bersamaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(105, 43)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 29
        UsernameLabel.Text = "username:"
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(105, 69)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(50, 13)
        PaswordLabel.TabIndex = 31
        PaswordLabel.Text = "pasword:"
        '
        'Nama_mhsLabel
        '
        Nama_mhsLabel.AutoSize = True
        Nama_mhsLabel.Location = New System.Drawing.Point(105, 95)
        Nama_mhsLabel.Name = "Nama_mhsLabel"
        Nama_mhsLabel.Size = New System.Drawing.Size(58, 13)
        Nama_mhsLabel.TabIndex = 33
        Nama_mhsLabel.Text = "nama mhs:"
        '
        'Nim_mhsLabel
        '
        Nim_mhsLabel.AutoSize = True
        Nim_mhsLabel.Location = New System.Drawing.Point(105, 121)
        Nim_mhsLabel.Name = "Nim_mhsLabel"
        Nim_mhsLabel.Size = New System.Drawing.Size(48, 13)
        Nim_mhsLabel.TabIndex = 35
        Nim_mhsLabel.Text = "nim mhs:"
        '
        'Tgl_lahir_mhsLabel
        '
        Tgl_lahir_mhsLabel.AutoSize = True
        Tgl_lahir_mhsLabel.Location = New System.Drawing.Point(105, 147)
        Tgl_lahir_mhsLabel.Name = "Tgl_lahir_mhsLabel"
        Tgl_lahir_mhsLabel.Size = New System.Drawing.Size(65, 13)
        Tgl_lahir_mhsLabel.TabIndex = 37
        Tgl_lahir_mhsLabel.Text = "tgl lahir mhs:"
        '
        'Email_mhsLabel
        '
        Email_mhsLabel.AutoSize = True
        Email_mhsLabel.Location = New System.Drawing.Point(105, 173)
        Email_mhsLabel.Name = "Email_mhsLabel"
        Email_mhsLabel.Size = New System.Drawing.Size(56, 13)
        Email_mhsLabel.TabIndex = 39
        Email_mhsLabel.Text = "email mhs:"
        '
        'Alamat_mhsLabel
        '
        Alamat_mhsLabel.AutoSize = True
        Alamat_mhsLabel.Location = New System.Drawing.Point(105, 199)
        Alamat_mhsLabel.Name = "Alamat_mhsLabel"
        Alamat_mhsLabel.Size = New System.Drawing.Size(63, 13)
        Alamat_mhsLabel.TabIndex = 41
        Alamat_mhsLabel.Text = "alamat mhs:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(105, 225)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(42, 13)
        No_telpLabel.TabIndex = 43
        No_telpLabel.Text = "no telp:"
        '
        'Universitas_bersamaDataSet
        '
        Me.Universitas_bersamaDataSet.DataSetName = "universitas_bersamaDataSet"
        Me.Universitas_bersamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.Universitas_bersamaDataSet
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.informasiTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Me.MahasiswaTableAdapter
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.nilaiTableAdapter = Nothing
        Me.TableAdapterManager.peserta_mkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'exit_but
        '
        Me.exit_but.Location = New System.Drawing.Point(12, 196)
        Me.exit_but.Name = "exit_but"
        Me.exit_but.Size = New System.Drawing.Size(75, 23)
        Me.exit_but.TabIndex = 27
        Me.exit_but.Text = "Exit"
        Me.exit_but.UseVisualStyleBackColor = True
        '
        'refresh_but
        '
        Me.refresh_but.Location = New System.Drawing.Point(12, 166)
        Me.refresh_but.Name = "refresh_but"
        Me.refresh_but.Size = New System.Drawing.Size(75, 23)
        Me.refresh_but.TabIndex = 26
        Me.refresh_but.Text = "Refresh"
        Me.refresh_but.UseVisualStyleBackColor = True
        '
        'cancel_but
        '
        Me.cancel_but.Location = New System.Drawing.Point(12, 136)
        Me.cancel_but.Name = "cancel_but"
        Me.cancel_but.Size = New System.Drawing.Size(75, 23)
        Me.cancel_but.TabIndex = 25
        Me.cancel_but.Text = "Cancel"
        Me.cancel_but.UseVisualStyleBackColor = True
        '
        'save_but
        '
        Me.save_but.Location = New System.Drawing.Point(12, 105)
        Me.save_but.Name = "save_but"
        Me.save_but.Size = New System.Drawing.Size(75, 23)
        Me.save_but.TabIndex = 24
        Me.save_but.Text = "Save"
        Me.save_but.UseVisualStyleBackColor = True
        '
        'delete_but
        '
        Me.delete_but.Location = New System.Drawing.Point(12, 74)
        Me.delete_but.Name = "delete_but"
        Me.delete_but.Size = New System.Drawing.Size(75, 23)
        Me.delete_but.TabIndex = 23
        Me.delete_but.Text = "Delete"
        Me.delete_but.UseVisualStyleBackColor = True
        '
        'edit_but
        '
        Me.edit_but.Location = New System.Drawing.Point(12, 43)
        Me.edit_but.Name = "edit_but"
        Me.edit_but.Size = New System.Drawing.Size(75, 23)
        Me.edit_but.TabIndex = 22
        Me.edit_but.Text = "Edit"
        Me.edit_but.UseVisualStyleBackColor = True
        '
        'add_but
        '
        Me.add_but.Location = New System.Drawing.Point(12, 12)
        Me.add_but.Name = "add_but"
        Me.add_but.Size = New System.Drawing.Size(75, 23)
        Me.add_but.TabIndex = 21
        Me.add_but.Text = "Add"
        Me.add_but.UseVisualStyleBackColor = True
        '
        'Id_MAHASISWATextBox
        '
        Me.Id_MAHASISWATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "id MAHASISWA", True))
        Me.Id_MAHASISWATextBox.Location = New System.Drawing.Point(198, 14)
        Me.Id_MAHASISWATextBox.Name = "Id_MAHASISWATextBox"
        Me.Id_MAHASISWATextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_MAHASISWATextBox.TabIndex = 28
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(198, 40)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 30
        '
        'PaswordTextBox
        '
        Me.PaswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "pasword", True))
        Me.PaswordTextBox.Location = New System.Drawing.Point(198, 66)
        Me.PaswordTextBox.Name = "PaswordTextBox"
        Me.PaswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextBox.TabIndex = 32
        '
        'Nama_mhsTextBox
        '
        Me.Nama_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nama_mhs", True))
        Me.Nama_mhsTextBox.Location = New System.Drawing.Point(198, 92)
        Me.Nama_mhsTextBox.Name = "Nama_mhsTextBox"
        Me.Nama_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_mhsTextBox.TabIndex = 34
        '
        'Nim_mhsTextBox
        '
        Me.Nim_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nim_mhs", True))
        Me.Nim_mhsTextBox.Location = New System.Drawing.Point(198, 118)
        Me.Nim_mhsTextBox.Name = "Nim_mhsTextBox"
        Me.Nim_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nim_mhsTextBox.TabIndex = 36
        '
        'Tgl_lahir_mhsTextBox
        '
        Me.Tgl_lahir_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "tgl_lahir_mhs", True))
        Me.Tgl_lahir_mhsTextBox.Location = New System.Drawing.Point(198, 144)
        Me.Tgl_lahir_mhsTextBox.Name = "Tgl_lahir_mhsTextBox"
        Me.Tgl_lahir_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tgl_lahir_mhsTextBox.TabIndex = 38
        '
        'Email_mhsTextBox
        '
        Me.Email_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "email_mhs", True))
        Me.Email_mhsTextBox.Location = New System.Drawing.Point(198, 170)
        Me.Email_mhsTextBox.Name = "Email_mhsTextBox"
        Me.Email_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_mhsTextBox.TabIndex = 40
        '
        'Alamat_mhsTextBox
        '
        Me.Alamat_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "alamat_mhs", True))
        Me.Alamat_mhsTextBox.Location = New System.Drawing.Point(198, 196)
        Me.Alamat_mhsTextBox.Name = "Alamat_mhsTextBox"
        Me.Alamat_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Alamat_mhsTextBox.TabIndex = 42
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "no_telp", True))
        Me.No_telpTextBox.Location = New System.Drawing.Point(198, 222)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_telpTextBox.TabIndex = 44
        '
        'Id_MAHASISWALabel
        '
        Id_MAHASISWALabel.AutoSize = True
        Id_MAHASISWALabel.Location = New System.Drawing.Point(105, 17)
        Id_MAHASISWALabel.Name = "Id_MAHASISWALabel"
        Id_MAHASISWALabel.Size = New System.Drawing.Size(87, 13)
        Id_MAHASISWALabel.TabIndex = 27
        Id_MAHASISWALabel.Text = "id MAHASISWA:"
        '
        'MahasiswaDataGridView
        '
        Me.MahasiswaDataGridView.AutoGenerateColumns = False
        Me.MahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MahasiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MahasiswaDataGridView.DataSource = Me.MahasiswaBindingSource
        Me.MahasiswaDataGridView.Location = New System.Drawing.Point(313, 12)
        Me.MahasiswaDataGridView.Name = "MahasiswaDataGridView"
        Me.MahasiswaDataGridView.Size = New System.Drawing.Size(718, 230)
        Me.MahasiswaDataGridView.TabIndex = 44
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id MAHASISWA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id MAHASISWA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "pasword"
        Me.DataGridViewTextBoxColumn3.HeaderText = "pasword"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nama_mhs"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nama_mhs"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nim_mhs"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nim_mhs"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tgl_lahir_mhs"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tgl_lahir_mhs"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email_mhs"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email_mhs"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "alamat_mhs"
        Me.DataGridViewTextBoxColumn8.HeaderText = "alamat_mhs"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "no_telp"
        Me.DataGridViewTextBoxColumn9.HeaderText = "no_telp"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'form_mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 260)
        Me.Controls.Add(Me.MahasiswaDataGridView)
        Me.Controls.Add(Id_MAHASISWALabel)
        Me.Controls.Add(Me.Id_MAHASISWATextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PaswordLabel)
        Me.Controls.Add(Me.PaswordTextBox)
        Me.Controls.Add(Nama_mhsLabel)
        Me.Controls.Add(Me.Nama_mhsTextBox)
        Me.Controls.Add(Nim_mhsLabel)
        Me.Controls.Add(Me.Nim_mhsTextBox)
        Me.Controls.Add(Tgl_lahir_mhsLabel)
        Me.Controls.Add(Me.Tgl_lahir_mhsTextBox)
        Me.Controls.Add(Email_mhsLabel)
        Me.Controls.Add(Me.Email_mhsTextBox)
        Me.Controls.Add(Alamat_mhsLabel)
        Me.Controls.Add(Me.Alamat_mhsTextBox)
        Me.Controls.Add(No_telpLabel)
        Me.Controls.Add(Me.No_telpTextBox)
        Me.Controls.Add(Me.exit_but)
        Me.Controls.Add(Me.refresh_but)
        Me.Controls.Add(Me.cancel_but)
        Me.Controls.Add(Me.save_but)
        Me.Controls.Add(Me.delete_but)
        Me.Controls.Add(Me.edit_but)
        Me.Controls.Add(Me.add_but)
        Me.Name = "form_mahasiswa"
        Me.Text = "form_mahasiswa"
        CType(Me.Universitas_bersamaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Universitas_bersamaDataSet As project2.universitas_bersamaDataSet
    Friend WithEvents MahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MahasiswaTableAdapter As project2.universitas_bersamaDataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents exit_but As System.Windows.Forms.Button
    Friend WithEvents refresh_but As System.Windows.Forms.Button
    Friend WithEvents cancel_but As System.Windows.Forms.Button
    Friend WithEvents save_but As System.Windows.Forms.Button
    Friend WithEvents delete_but As System.Windows.Forms.Button
    Friend WithEvents edit_but As System.Windows.Forms.Button
    Friend WithEvents add_but As System.Windows.Forms.Button
    Friend WithEvents Id_MAHASISWATextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nim_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tgl_lahir_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Alamat_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MahasiswaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
