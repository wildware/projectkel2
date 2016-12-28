<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mahasiswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mahasiswa))
        Dim Id_mahasiswaLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Nama_mahasiswaLabel As System.Windows.Forms.Label
        Dim Nim_mahasiswaLabel As System.Windows.Forms.Label
        Dim Tgl_lahir_mhsLabel As System.Windows.Forms.Label
        Dim Email_mhsLabel As System.Windows.Forms.Label
        Dim Alamat_mhsLabel As System.Windows.Forms.Label
        Dim Notelp_mhsLabel As System.Windows.Forms.Label
        Me.exit_butt = New System.Windows.Forms.Button()
        Me.refresh_butt = New System.Windows.Forms.Button()
        Me.cancel_butt = New System.Windows.Forms.Button()
        Me.save_butt = New System.Windows.Forms.Button()
        Me.delete_butt = New System.Windows.Forms.Button()
        Me.edit_butt = New System.Windows.Forms.Button()
        Me.add_butt = New System.Windows.Forms.Button()
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.mahasiswaTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Me.MahasiswaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MahasiswaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_mahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_mahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.Nim_mahasiswaTextBox = New System.Windows.Forms.TextBox()
        Me.Tgl_lahir_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Email_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Alamat_mhsTextBox = New System.Windows.Forms.TextBox()
        Me.Notelp_mhsTextBox = New System.Windows.Forms.TextBox()
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
        Id_mahasiswaLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Nama_mahasiswaLabel = New System.Windows.Forms.Label()
        Nim_mahasiswaLabel = New System.Windows.Forms.Label()
        Tgl_lahir_mhsLabel = New System.Windows.Forms.Label()
        Email_mhsLabel = New System.Windows.Forms.Label()
        Alamat_mhsLabel = New System.Windows.Forms.Label()
        Notelp_mhsLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MahasiswaBindingNavigator.SuspendLayout()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit_butt
        '
        Me.exit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.Location = New System.Drawing.Point(12, 186)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(75, 23)
        Me.exit_butt.TabIndex = 34
        Me.exit_butt.Text = "exit"
        Me.exit_butt.UseVisualStyleBackColor = True
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(12, 157)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 33
        Me.refresh_butt.Text = "refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(12, 128)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 32
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(12, 99)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 31
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(12, 70)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 30
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(12, 41)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 29
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(12, 12)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 28
        Me.add_butt.Text = " Add"
        Me.add_butt.UseVisualStyleBackColor = True
        '
        'Universitas_informatikaDataSet
        '
        Me.Universitas_informatikaDataSet.DataSetName = "universitas_informatikaDataSet"
        Me.Universitas_informatikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.Universitas_informatikaDataSet
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
        Me.TableAdapterManager.UpdateOrder = project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MahasiswaBindingNavigator
        '
        Me.MahasiswaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MahasiswaBindingNavigator.BindingSource = Me.MahasiswaBindingSource
        Me.MahasiswaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MahasiswaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MahasiswaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MahasiswaBindingNavigatorSaveItem})
        Me.MahasiswaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MahasiswaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MahasiswaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MahasiswaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MahasiswaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MahasiswaBindingNavigator.Name = "MahasiswaBindingNavigator"
        Me.MahasiswaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MahasiswaBindingNavigator.Size = New System.Drawing.Size(889, 25)
        Me.MahasiswaBindingNavigator.TabIndex = 35
        Me.MahasiswaBindingNavigator.Text = "BindingNavigator1"
        Me.MahasiswaBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MahasiswaBindingNavigatorSaveItem
        '
        Me.MahasiswaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MahasiswaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MahasiswaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MahasiswaBindingNavigatorSaveItem.Name = "MahasiswaBindingNavigatorSaveItem"
        Me.MahasiswaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MahasiswaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_mahasiswaLabel
        '
        Id_mahasiswaLabel.AutoSize = True
        Id_mahasiswaLabel.Location = New System.Drawing.Point(103, 11)
        Id_mahasiswaLabel.Name = "Id_mahasiswaLabel"
        Id_mahasiswaLabel.Size = New System.Drawing.Size(73, 13)
        Id_mahasiswaLabel.TabIndex = 35
        Id_mahasiswaLabel.Text = "id mahasiswa:"
        '
        'Id_mahasiswaTextBox
        '
        Me.Id_mahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "id_mahasiswa", True))
        Me.Id_mahasiswaTextBox.Location = New System.Drawing.Point(200, 8)
        Me.Id_mahasiswaTextBox.Name = "Id_mahasiswaTextBox"
        Me.Id_mahasiswaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_mahasiswaTextBox.TabIndex = 36
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(103, 37)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 37
        UsernameLabel.Text = "username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(200, 34)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 38
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(103, 63)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 39
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(200, 60)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 40
        '
        'Nama_mahasiswaLabel
        '
        Nama_mahasiswaLabel.AutoSize = True
        Nama_mahasiswaLabel.Location = New System.Drawing.Point(103, 89)
        Nama_mahasiswaLabel.Name = "Nama_mahasiswaLabel"
        Nama_mahasiswaLabel.Size = New System.Drawing.Size(91, 13)
        Nama_mahasiswaLabel.TabIndex = 41
        Nama_mahasiswaLabel.Text = "nama mahasiswa:"
        '
        'Nama_mahasiswaTextBox
        '
        Me.Nama_mahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nama_mahasiswa", True))
        Me.Nama_mahasiswaTextBox.Location = New System.Drawing.Point(200, 86)
        Me.Nama_mahasiswaTextBox.Name = "Nama_mahasiswaTextBox"
        Me.Nama_mahasiswaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_mahasiswaTextBox.TabIndex = 42
        '
        'Nim_mahasiswaLabel
        '
        Nim_mahasiswaLabel.AutoSize = True
        Nim_mahasiswaLabel.Location = New System.Drawing.Point(103, 115)
        Nim_mahasiswaLabel.Name = "Nim_mahasiswaLabel"
        Nim_mahasiswaLabel.Size = New System.Drawing.Size(81, 13)
        Nim_mahasiswaLabel.TabIndex = 43
        Nim_mahasiswaLabel.Text = "nim mahasiswa:"
        '
        'Nim_mahasiswaTextBox
        '
        Me.Nim_mahasiswaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "nim_mahasiswa", True))
        Me.Nim_mahasiswaTextBox.Location = New System.Drawing.Point(200, 112)
        Me.Nim_mahasiswaTextBox.Name = "Nim_mahasiswaTextBox"
        Me.Nim_mahasiswaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nim_mahasiswaTextBox.TabIndex = 44
        '
        'Tgl_lahir_mhsLabel
        '
        Tgl_lahir_mhsLabel.AutoSize = True
        Tgl_lahir_mhsLabel.Location = New System.Drawing.Point(103, 141)
        Tgl_lahir_mhsLabel.Name = "Tgl_lahir_mhsLabel"
        Tgl_lahir_mhsLabel.Size = New System.Drawing.Size(65, 13)
        Tgl_lahir_mhsLabel.TabIndex = 45
        Tgl_lahir_mhsLabel.Text = "tgl lahir mhs:"
        '
        'Tgl_lahir_mhsTextBox
        '
        Me.Tgl_lahir_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "tgl_lahir_mhs", True))
        Me.Tgl_lahir_mhsTextBox.Location = New System.Drawing.Point(200, 138)
        Me.Tgl_lahir_mhsTextBox.Name = "Tgl_lahir_mhsTextBox"
        Me.Tgl_lahir_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tgl_lahir_mhsTextBox.TabIndex = 46
        '
        'Email_mhsLabel
        '
        Email_mhsLabel.AutoSize = True
        Email_mhsLabel.Location = New System.Drawing.Point(103, 167)
        Email_mhsLabel.Name = "Email_mhsLabel"
        Email_mhsLabel.Size = New System.Drawing.Size(56, 13)
        Email_mhsLabel.TabIndex = 47
        Email_mhsLabel.Text = "email mhs:"
        '
        'Email_mhsTextBox
        '
        Me.Email_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "email_mhs", True))
        Me.Email_mhsTextBox.Location = New System.Drawing.Point(200, 164)
        Me.Email_mhsTextBox.Name = "Email_mhsTextBox"
        Me.Email_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_mhsTextBox.TabIndex = 48
        '
        'Alamat_mhsLabel
        '
        Alamat_mhsLabel.AutoSize = True
        Alamat_mhsLabel.Location = New System.Drawing.Point(103, 193)
        Alamat_mhsLabel.Name = "Alamat_mhsLabel"
        Alamat_mhsLabel.Size = New System.Drawing.Size(63, 13)
        Alamat_mhsLabel.TabIndex = 49
        Alamat_mhsLabel.Text = "alamat mhs:"
        '
        'Alamat_mhsTextBox
        '
        Me.Alamat_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "alamat_mhs", True))
        Me.Alamat_mhsTextBox.Location = New System.Drawing.Point(200, 190)
        Me.Alamat_mhsTextBox.Name = "Alamat_mhsTextBox"
        Me.Alamat_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Alamat_mhsTextBox.TabIndex = 50
        '
        'Notelp_mhsLabel
        '
        Notelp_mhsLabel.AutoSize = True
        Notelp_mhsLabel.Location = New System.Drawing.Point(103, 219)
        Notelp_mhsLabel.Name = "Notelp_mhsLabel"
        Notelp_mhsLabel.Size = New System.Drawing.Size(61, 13)
        Notelp_mhsLabel.TabIndex = 51
        Notelp_mhsLabel.Text = "notelp mhs:"
        '
        'Notelp_mhsTextBox
        '
        Me.Notelp_mhsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "notelp_mhs", True))
        Me.Notelp_mhsTextBox.Location = New System.Drawing.Point(200, 216)
        Me.Notelp_mhsTextBox.Name = "Notelp_mhsTextBox"
        Me.Notelp_mhsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Notelp_mhsTextBox.TabIndex = 52
        '
        'MahasiswaDataGridView
        '
        Me.MahasiswaDataGridView.AutoGenerateColumns = False
        Me.MahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MahasiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MahasiswaDataGridView.DataSource = Me.MahasiswaBindingSource
        Me.MahasiswaDataGridView.Location = New System.Drawing.Point(306, 8)
        Me.MahasiswaDataGridView.Name = "MahasiswaDataGridView"
        Me.MahasiswaDataGridView.Size = New System.Drawing.Size(571, 220)
        Me.MahasiswaDataGridView.TabIndex = 52
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_mahasiswa"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_mahasiswa"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nama_mahasiswa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nama_mahasiswa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "nim_mahasiswa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "nim_mahasiswa"
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
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "notelp_mhs"
        Me.DataGridViewTextBoxColumn9.HeaderText = "notelp_mhs"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Form_mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 294)
        Me.Controls.Add(Me.MahasiswaDataGridView)
        Me.Controls.Add(Id_mahasiswaLabel)
        Me.Controls.Add(Me.Id_mahasiswaTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Nama_mahasiswaLabel)
        Me.Controls.Add(Me.Nama_mahasiswaTextBox)
        Me.Controls.Add(Nim_mahasiswaLabel)
        Me.Controls.Add(Me.Nim_mahasiswaTextBox)
        Me.Controls.Add(Tgl_lahir_mhsLabel)
        Me.Controls.Add(Me.Tgl_lahir_mhsTextBox)
        Me.Controls.Add(Email_mhsLabel)
        Me.Controls.Add(Me.Email_mhsTextBox)
        Me.Controls.Add(Alamat_mhsLabel)
        Me.Controls.Add(Me.Alamat_mhsTextBox)
        Me.Controls.Add(Notelp_mhsLabel)
        Me.Controls.Add(Me.Notelp_mhsTextBox)
        Me.Controls.Add(Me.MahasiswaBindingNavigator)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.refresh_butt)
        Me.Controls.Add(Me.cancel_butt)
        Me.Controls.Add(Me.save_butt)
        Me.Controls.Add(Me.delete_butt)
        Me.Controls.Add(Me.edit_butt)
        Me.Controls.Add(Me.add_butt)
        Me.Name = "Form_mahasiswa"
        Me.Text = "Form_mahasiswa"
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MahasiswaBindingNavigator.ResumeLayout(False)
        Me.MahasiswaBindingNavigator.PerformLayout()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exit_butt As System.Windows.Forms.Button
    Friend WithEvents refresh_butt As System.Windows.Forms.Button
    Friend WithEvents cancel_butt As System.Windows.Forms.Button
    Friend WithEvents save_butt As System.Windows.Forms.Button
    Friend WithEvents delete_butt As System.Windows.Forms.Button
    Friend WithEvents edit_butt As System.Windows.Forms.Button
    Friend WithEvents add_butt As System.Windows.Forms.Button
    Friend WithEvents Universitas_informatikaDataSet As project2.universitas_informatikaDataSet
    Friend WithEvents MahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MahasiswaTableAdapter As project2.universitas_informatikaDataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MahasiswaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MahasiswaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_mahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_mahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nim_mahasiswaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tgl_lahir_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Alamat_mhsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Notelp_mhsTextBox As System.Windows.Forms.TextBox
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
