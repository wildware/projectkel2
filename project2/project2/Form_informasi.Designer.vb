<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_informasi
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
        Dim Id_informasiLabel As System.Windows.Forms.Label
        Dim DOSEN_id_dosenLabel As System.Windows.Forms.Label
        Dim MATA_KULIAH_id_matakuliahLabel As System.Windows.Forms.Label
        Dim MATA_KULIAH_DOSEN_id_dosenLabel As System.Windows.Forms.Label
        Dim JudulLabel As System.Windows.Forms.Label
        Dim InfoLabel As System.Windows.Forms.Label
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_informasi))
        Me.exit_butt = New System.Windows.Forms.Button()
        Me.refresh_butt = New System.Windows.Forms.Button()
        Me.cancel_butt = New System.Windows.Forms.Button()
        Me.save_butt = New System.Windows.Forms.Button()
        Me.delete_butt = New System.Windows.Forms.Button()
        Me.edit_butt = New System.Windows.Forms.Button()
        Me.add_butt = New System.Windows.Forms.Button()
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.InformasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformasiTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.informasiTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Me.InformasiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InformasiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InformasiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_informasiTextBox = New System.Windows.Forms.TextBox()
        Me.DOSEN_id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.MATA_KULIAH_id_matakuliahTextBox = New System.Windows.Forms.TextBox()
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.JudulTextBox = New System.Windows.Forms.TextBox()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Id_informasiLabel = New System.Windows.Forms.Label()
        DOSEN_id_dosenLabel = New System.Windows.Forms.Label()
        MATA_KULIAH_id_matakuliahLabel = New System.Windows.Forms.Label()
        MATA_KULIAH_DOSEN_id_dosenLabel = New System.Windows.Forms.Label()
        JudulLabel = New System.Windows.Forms.Label()
        InfoLabel = New System.Windows.Forms.Label()
        TanggalLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InformasiBindingNavigator.SuspendLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_informasiLabel
        '
        Id_informasiLabel.AutoSize = True
        Id_informasiLabel.BackColor = System.Drawing.SystemColors.Window
        Id_informasiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_informasiLabel.Location = New System.Drawing.Point(6, 16)
        Id_informasiLabel.Name = "Id_informasiLabel"
        Id_informasiLabel.Size = New System.Drawing.Size(87, 15)
        Id_informasiLabel.TabIndex = 28
        Id_informasiLabel.Text = "id informasi:"
        '
        'DOSEN_id_dosenLabel
        '
        DOSEN_id_dosenLabel.AutoSize = True
        DOSEN_id_dosenLabel.BackColor = System.Drawing.SystemColors.Window
        DOSEN_id_dosenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOSEN_id_dosenLabel.Location = New System.Drawing.Point(6, 42)
        DOSEN_id_dosenLabel.Name = "DOSEN_id_dosenLabel"
        DOSEN_id_dosenLabel.Size = New System.Drawing.Size(118, 15)
        DOSEN_id_dosenLabel.TabIndex = 30
        DOSEN_id_dosenLabel.Text = "DOSEN id dosen:"
        '
        'MATA_KULIAH_id_matakuliahLabel
        '
        MATA_KULIAH_id_matakuliahLabel.AutoSize = True
        MATA_KULIAH_id_matakuliahLabel.BackColor = System.Drawing.SystemColors.Window
        MATA_KULIAH_id_matakuliahLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MATA_KULIAH_id_matakuliahLabel.Location = New System.Drawing.Point(6, 68)
        MATA_KULIAH_id_matakuliahLabel.Name = "MATA_KULIAH_id_matakuliahLabel"
        MATA_KULIAH_id_matakuliahLabel.Size = New System.Drawing.Size(191, 15)
        MATA_KULIAH_id_matakuliahLabel.TabIndex = 32
        MATA_KULIAH_id_matakuliahLabel.Text = "MATA KULIAH id matakuliah:"
        '
        'MATA_KULIAH_DOSEN_id_dosenLabel
        '
        MATA_KULIAH_DOSEN_id_dosenLabel.AutoSize = True
        MATA_KULIAH_DOSEN_id_dosenLabel.BackColor = System.Drawing.SystemColors.Window
        MATA_KULIAH_DOSEN_id_dosenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MATA_KULIAH_DOSEN_id_dosenLabel.Location = New System.Drawing.Point(6, 94)
        MATA_KULIAH_DOSEN_id_dosenLabel.Name = "MATA_KULIAH_DOSEN_id_dosenLabel"
        MATA_KULIAH_DOSEN_id_dosenLabel.Size = New System.Drawing.Size(211, 15)
        MATA_KULIAH_DOSEN_id_dosenLabel.TabIndex = 34
        MATA_KULIAH_DOSEN_id_dosenLabel.Text = "MATA KULIAH DOSEN id dosen:"
        '
        'JudulLabel
        '
        JudulLabel.AutoSize = True
        JudulLabel.BackColor = System.Drawing.SystemColors.Window
        JudulLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JudulLabel.Location = New System.Drawing.Point(6, 120)
        JudulLabel.Name = "JudulLabel"
        JudulLabel.Size = New System.Drawing.Size(43, 15)
        JudulLabel.TabIndex = 36
        JudulLabel.Text = "judul:"
        '
        'InfoLabel
        '
        InfoLabel.AutoSize = True
        InfoLabel.BackColor = System.Drawing.SystemColors.Window
        InfoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InfoLabel.Location = New System.Drawing.Point(6, 146)
        InfoLabel.Name = "InfoLabel"
        InfoLabel.Size = New System.Drawing.Size(35, 15)
        InfoLabel.TabIndex = 38
        InfoLabel.Text = "info:"
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.BackColor = System.Drawing.SystemColors.Window
        TanggalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TanggalLabel.Location = New System.Drawing.Point(6, 173)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(59, 15)
        TanggalLabel.TabIndex = 40
        TanggalLabel.Text = "tanggal:"
        '
        'exit_butt
        '
        Me.exit_butt.Cursor = System.Windows.Forms.Cursors.Default
        Me.exit_butt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.ForeColor = System.Drawing.Color.Red
        Me.exit_butt.Location = New System.Drawing.Point(729, -2)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(43, 38)
        Me.exit_butt.TabIndex = 27
        Me.exit_butt.Text = "X"
        Me.exit_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.exit_butt.UseVisualStyleBackColor = True
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(27, 50)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 26
        Me.refresh_butt.Text = "Refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(16, 135)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 25
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(16, 106)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 24
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(16, 77)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 23
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(16, 48)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 22
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(16, 19)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 21
        Me.add_butt.Text = " Add"
        Me.add_butt.UseVisualStyleBackColor = True
        '
        'Universitas_informatikaDataSet
        '
        Me.Universitas_informatikaDataSet.DataSetName = "universitas_informatikaDataSet"
        Me.Universitas_informatikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InformasiBindingSource
        '
        Me.InformasiBindingSource.DataMember = "informasi"
        Me.InformasiBindingSource.DataSource = Me.Universitas_informatikaDataSet
        '
        'InformasiTableAdapter
        '
        Me.InformasiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.informasiTableAdapter = Me.InformasiTableAdapter
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.nilaiTableAdapter = Nothing
        Me.TableAdapterManager.peserta_mkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InformasiBindingNavigator
        '
        Me.InformasiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InformasiBindingNavigator.BindingSource = Me.InformasiBindingSource
        Me.InformasiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InformasiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InformasiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InformasiBindingNavigatorSaveItem})
        Me.InformasiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InformasiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InformasiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InformasiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InformasiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InformasiBindingNavigator.Name = "InformasiBindingNavigator"
        Me.InformasiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InformasiBindingNavigator.Size = New System.Drawing.Size(901, 25)
        Me.InformasiBindingNavigator.TabIndex = 28
        Me.InformasiBindingNavigator.Text = "BindingNavigator1"
        Me.InformasiBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InformasiBindingNavigatorSaveItem
        '
        Me.InformasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InformasiBindingNavigatorSaveItem.Image = CType(resources.GetObject("InformasiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InformasiBindingNavigatorSaveItem.Name = "InformasiBindingNavigatorSaveItem"
        Me.InformasiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InformasiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InformasiDataGridView
        '
        Me.InformasiDataGridView.AutoGenerateColumns = False
        Me.InformasiDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.InformasiDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InformasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InformasiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InformasiDataGridView.DataSource = Me.InformasiBindingSource
        Me.InformasiDataGridView.Location = New System.Drawing.Point(14, 79)
        Me.InformasiDataGridView.Name = "InformasiDataGridView"
        Me.InformasiDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.InformasiDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_informasi"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_informasi"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DOSEN_id_dosen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DOSEN_id_dosen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MATA_KULIAH_id_matakuliah"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MATA_KULIAH_id_matakuliah"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MATA_KULIAH_DOSEN_id_dosen"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MATA_KULIAH_DOSEN_id_dosen"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "judul"
        Me.DataGridViewTextBoxColumn5.HeaderText = "judul"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "info"
        Me.DataGridViewTextBoxColumn6.HeaderText = "info"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tanggal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tanggal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Id_informasiTextBox
        '
        Me.Id_informasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "id_informasi", True))
        Me.Id_informasiTextBox.Location = New System.Drawing.Point(224, 15)
        Me.Id_informasiTextBox.Name = "Id_informasiTextBox"
        Me.Id_informasiTextBox.Size = New System.Drawing.Size(266, 20)
        Me.Id_informasiTextBox.TabIndex = 29
        '
        'DOSEN_id_dosenTextBox
        '
        Me.DOSEN_id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "DOSEN_id_dosen", True))
        Me.DOSEN_id_dosenTextBox.Location = New System.Drawing.Point(224, 42)
        Me.DOSEN_id_dosenTextBox.Name = "DOSEN_id_dosenTextBox"
        Me.DOSEN_id_dosenTextBox.Size = New System.Drawing.Size(266, 20)
        Me.DOSEN_id_dosenTextBox.TabIndex = 31
        '
        'MATA_KULIAH_id_matakuliahTextBox
        '
        Me.MATA_KULIAH_id_matakuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "MATA_KULIAH_id_matakuliah", True))
        Me.MATA_KULIAH_id_matakuliahTextBox.Location = New System.Drawing.Point(224, 68)
        Me.MATA_KULIAH_id_matakuliahTextBox.Name = "MATA_KULIAH_id_matakuliahTextBox"
        Me.MATA_KULIAH_id_matakuliahTextBox.Size = New System.Drawing.Size(266, 20)
        Me.MATA_KULIAH_id_matakuliahTextBox.TabIndex = 33
        '
        'MATA_KULIAH_DOSEN_id_dosenTextBox
        '
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "MATA_KULIAH_DOSEN_id_dosen", True))
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Location = New System.Drawing.Point(224, 94)
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Name = "MATA_KULIAH_DOSEN_id_dosenTextBox"
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Size = New System.Drawing.Size(266, 20)
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.TabIndex = 35
        '
        'JudulTextBox
        '
        Me.JudulTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "judul", True))
        Me.JudulTextBox.Location = New System.Drawing.Point(224, 120)
        Me.JudulTextBox.Name = "JudulTextBox"
        Me.JudulTextBox.Size = New System.Drawing.Size(266, 20)
        Me.JudulTextBox.TabIndex = 37
        '
        'InfoTextBox
        '
        Me.InfoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "info", True))
        Me.InfoTextBox.Location = New System.Drawing.Point(224, 146)
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.InfoTextBox.TabIndex = 39
        '
        'TanggalDateTimePicker
        '
        Me.TanggalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InformasiBindingSource, "tanggal", True))
        Me.TanggalDateTimePicker.Location = New System.Drawing.Point(224, 172)
        Me.TanggalDateTimePicker.Name = "TanggalDateTimePicker"
        Me.TanggalDateTimePicker.Size = New System.Drawing.Size(266, 20)
        Me.TanggalDateTimePicker.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(239, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Penambahan dan Penggantian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Informasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Id_informasiTextBox)
        Me.GroupBox1.Controls.Add(Me.TanggalDateTimePicker)
        Me.GroupBox1.Controls.Add(Id_informasiLabel)
        Me.GroupBox1.Controls.Add(Me.InfoTextBox)
        Me.GroupBox1.Controls.Add(DOSEN_id_dosenLabel)
        Me.GroupBox1.Controls.Add(MATA_KULIAH_id_matakuliahLabel)
        Me.GroupBox1.Controls.Add(Me.JudulTextBox)
        Me.GroupBox1.Controls.Add(MATA_KULIAH_DOSEN_id_dosenLabel)
        Me.GroupBox1.Controls.Add(Me.MATA_KULIAH_DOSEN_id_dosenTextBox)
        Me.GroupBox1.Controls.Add(JudulLabel)
        Me.GroupBox1.Controls.Add(Me.DOSEN_id_dosenTextBox)
        Me.GroupBox1.Controls.Add(InfoLabel)
        Me.GroupBox1.Controls.Add(Me.MATA_KULIAH_id_matakuliahTextBox)
        Me.GroupBox1.Controls.Add(TanggalLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 201)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.add_butt)
        Me.GroupBox2.Controls.Add(Me.edit_butt)
        Me.GroupBox2.Controls.Add(Me.delete_butt)
        Me.GroupBox2.Controls.Add(Me.save_butt)
        Me.GroupBox2.Controls.Add(Me.cancel_butt)
        Me.GroupBox2.Location = New System.Drawing.Point(85, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 170)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'Form_informasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(768, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InformasiDataGridView)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.refresh_butt)
        Me.Controls.Add(Me.InformasiBindingNavigator)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_informasi"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InformasiBindingNavigator.ResumeLayout(False)
        Me.InformasiBindingNavigator.PerformLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Universitas_informatikaDataSet As project2.universitas_informatikaDataSet
    Friend WithEvents InformasiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformasiTableAdapter As project2.universitas_informatikaDataSetTableAdapters.informasiTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InformasiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InformasiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents InformasiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_informasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOSEN_id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MATA_KULIAH_id_matakuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MATA_KULIAH_DOSEN_id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JudulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
