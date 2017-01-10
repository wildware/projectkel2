<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mata_kuliah
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
        Dim Id_matakuliahLabel As System.Windows.Forms.Label
        Dim DOSEN_id_dosenLabel As System.Windows.Forms.Label
        Dim SksLabel As System.Windows.Forms.Label
        Dim MATA_KULIAHLabel As System.Windows.Forms.Label
        Dim KodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mata_kuliah))
        Me.exit_butt = New System.Windows.Forms.Button()
        Me.refresh_butt = New System.Windows.Forms.Button()
        Me.cancel_butt = New System.Windows.Forms.Button()
        Me.save_butt = New System.Windows.Forms.Button()
        Me.delete_butt = New System.Windows.Forms.Button()
        Me.edit_butt = New System.Windows.Forms.Button()
        Me.add_butt = New System.Windows.Forms.Button()
        Me.Mata_kuliahBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Mata_kuliahBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_matakuliahTextBox = New System.Windows.Forms.TextBox()
        Me.DOSEN_id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.SksTextBox = New System.Windows.Forms.TextBox()
        Me.MATA_KULIAHTextBox = New System.Windows.Forms.TextBox()
        Me.KodeTextBox = New System.Windows.Forms.TextBox()
        Me.Mata_kuliahDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mata_kuliahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.Mata_kuliahTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.mata_kuliahTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Id_matakuliahLabel = New System.Windows.Forms.Label()
        DOSEN_id_dosenLabel = New System.Windows.Forms.Label()
        SksLabel = New System.Windows.Forms.Label()
        MATA_KULIAHLabel = New System.Windows.Forms.Label()
        KodeLabel = New System.Windows.Forms.Label()
        CType(Me.Mata_kuliahBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mata_kuliahBindingNavigator.SuspendLayout()
        CType(Me.Mata_kuliahDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mata_kuliahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_matakuliahLabel
        '
        Id_matakuliahLabel.AutoSize = True
        Id_matakuliahLabel.Location = New System.Drawing.Point(95, 74)
        Id_matakuliahLabel.Name = "Id_matakuliahLabel"
        Id_matakuliahLabel.Size = New System.Drawing.Size(72, 13)
        Id_matakuliahLabel.TabIndex = 28
        Id_matakuliahLabel.Text = "id matakuliah:"
        '
        'DOSEN_id_dosenLabel
        '
        DOSEN_id_dosenLabel.AutoSize = True
        DOSEN_id_dosenLabel.Location = New System.Drawing.Point(95, 100)
        DOSEN_id_dosenLabel.Name = "DOSEN_id_dosenLabel"
        DOSEN_id_dosenLabel.Size = New System.Drawing.Size(91, 13)
        DOSEN_id_dosenLabel.TabIndex = 30
        DOSEN_id_dosenLabel.Text = "DOSEN id dosen:"
        '
        'SksLabel
        '
        SksLabel.AutoSize = True
        SksLabel.Location = New System.Drawing.Point(95, 126)
        SksLabel.Name = "SksLabel"
        SksLabel.Size = New System.Drawing.Size(26, 13)
        SksLabel.TabIndex = 32
        SksLabel.Text = "sks:"
        '
        'MATA_KULIAHLabel
        '
        MATA_KULIAHLabel.AutoSize = True
        MATA_KULIAHLabel.Location = New System.Drawing.Point(95, 152)
        MATA_KULIAHLabel.Name = "MATA_KULIAHLabel"
        MATA_KULIAHLabel.Size = New System.Drawing.Size(82, 13)
        MATA_KULIAHLabel.TabIndex = 34
        MATA_KULIAHLabel.Text = "MATA KULIAH:"
        '
        'KodeLabel
        '
        KodeLabel.AutoSize = True
        KodeLabel.Location = New System.Drawing.Point(95, 178)
        KodeLabel.Name = "KodeLabel"
        KodeLabel.Size = New System.Drawing.Size(34, 13)
        KodeLabel.TabIndex = 36
        KodeLabel.Text = "kode:"
        '
        'exit_butt
        '
        Me.exit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.Location = New System.Drawing.Point(12, 216)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(75, 23)
        Me.exit_butt.TabIndex = 27
        Me.exit_butt.Text = "exit"
        Me.exit_butt.UseVisualStyleBackColor = True
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(735, 323)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 26
        Me.refresh_butt.Text = "refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(12, 187)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 25
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(12, 158)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 24
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(12, 129)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 23
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(12, 100)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 22
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(12, 71)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 21
        Me.add_butt.Text = " Add"
        Me.add_butt.UseVisualStyleBackColor = True
        '
        'Mata_kuliahBindingNavigator
        '
        Me.Mata_kuliahBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Mata_kuliahBindingNavigator.BindingSource = Me.Mata_kuliahBindingSource
        Me.Mata_kuliahBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Mata_kuliahBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Mata_kuliahBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Mata_kuliahBindingNavigatorSaveItem})
        Me.Mata_kuliahBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Mata_kuliahBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Mata_kuliahBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Mata_kuliahBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Mata_kuliahBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Mata_kuliahBindingNavigator.Name = "Mata_kuliahBindingNavigator"
        Me.Mata_kuliahBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Mata_kuliahBindingNavigator.Size = New System.Drawing.Size(873, 25)
        Me.Mata_kuliahBindingNavigator.TabIndex = 28
        Me.Mata_kuliahBindingNavigator.Text = "BindingNavigator1"
        Me.Mata_kuliahBindingNavigator.Visible = False
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
        'Mata_kuliahBindingNavigatorSaveItem
        '
        Me.Mata_kuliahBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Mata_kuliahBindingNavigatorSaveItem.Image = CType(resources.GetObject("Mata_kuliahBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Mata_kuliahBindingNavigatorSaveItem.Name = "Mata_kuliahBindingNavigatorSaveItem"
        Me.Mata_kuliahBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Mata_kuliahBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_matakuliahTextBox
        '
        Me.Id_matakuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "id_matakuliah", True))
        Me.Id_matakuliahTextBox.Location = New System.Drawing.Point(192, 71)
        Me.Id_matakuliahTextBox.Name = "Id_matakuliahTextBox"
        Me.Id_matakuliahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_matakuliahTextBox.TabIndex = 29
        '
        'DOSEN_id_dosenTextBox
        '
        Me.DOSEN_id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "DOSEN_id_dosen", True))
        Me.DOSEN_id_dosenTextBox.Location = New System.Drawing.Point(192, 97)
        Me.DOSEN_id_dosenTextBox.Name = "DOSEN_id_dosenTextBox"
        Me.DOSEN_id_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DOSEN_id_dosenTextBox.TabIndex = 31
        '
        'SksTextBox
        '
        Me.SksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "sks", True))
        Me.SksTextBox.Location = New System.Drawing.Point(192, 123)
        Me.SksTextBox.Name = "SksTextBox"
        Me.SksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SksTextBox.TabIndex = 33
        '
        'MATA_KULIAHTextBox
        '
        Me.MATA_KULIAHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "MATA_KULIAH", True))
        Me.MATA_KULIAHTextBox.Location = New System.Drawing.Point(192, 149)
        Me.MATA_KULIAHTextBox.Name = "MATA_KULIAHTextBox"
        Me.MATA_KULIAHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MATA_KULIAHTextBox.TabIndex = 35
        '
        'KodeTextBox
        '
        Me.KodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mata_kuliahBindingSource, "kode", True))
        Me.KodeTextBox.Location = New System.Drawing.Point(192, 175)
        Me.KodeTextBox.Name = "KodeTextBox"
        Me.KodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodeTextBox.TabIndex = 37
        '
        'Mata_kuliahDataGridView
        '
        Me.Mata_kuliahDataGridView.AutoGenerateColumns = False
        Me.Mata_kuliahDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mata_kuliahDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Mata_kuliahDataGridView.DataSource = Me.Mata_kuliahBindingSource
        Me.Mata_kuliahDataGridView.Location = New System.Drawing.Point(307, 70)
        Me.Mata_kuliahDataGridView.Name = "Mata_kuliahDataGridView"
        Me.Mata_kuliahDataGridView.Size = New System.Drawing.Size(554, 220)
        Me.Mata_kuliahDataGridView.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(494, 323)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 20)
        Me.TextBox1.TabIndex = 60
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(413, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(452, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Penambahan dan Penggantian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Mata Kuliah"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_matakuliah"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_matakuliah"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "sks"
        Me.DataGridViewTextBoxColumn3.HeaderText = "sks"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MATA_KULIAH"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MATA_KULIAH"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "kode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "kode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Mata_kuliahBindingSource
        '
        Me.Mata_kuliahBindingSource.DataMember = "mata_kuliah"
        Me.Mata_kuliahBindingSource.DataSource = Me.Universitas_informatikaDataSet
        '
        'Universitas_informatikaDataSet
        '
        Me.Universitas_informatikaDataSet.DataSetName = "universitas_informatikaDataSet"
        Me.Universitas_informatikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mata_kuliahTableAdapter
        '
        Me.Mata_kuliahTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.informasiTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Me.Mata_kuliahTableAdapter
        Me.TableAdapterManager.nilaiTableAdapter = Nothing
        Me.TableAdapterManager.peserta_mkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form_mata_kuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 394)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Mata_kuliahDataGridView)
        Me.Controls.Add(Id_matakuliahLabel)
        Me.Controls.Add(Me.Id_matakuliahTextBox)
        Me.Controls.Add(DOSEN_id_dosenLabel)
        Me.Controls.Add(Me.DOSEN_id_dosenTextBox)
        Me.Controls.Add(SksLabel)
        Me.Controls.Add(Me.SksTextBox)
        Me.Controls.Add(MATA_KULIAHLabel)
        Me.Controls.Add(Me.MATA_KULIAHTextBox)
        Me.Controls.Add(KodeLabel)
        Me.Controls.Add(Me.KodeTextBox)
        Me.Controls.Add(Me.Mata_kuliahBindingNavigator)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.refresh_butt)
        Me.Controls.Add(Me.cancel_butt)
        Me.Controls.Add(Me.save_butt)
        Me.Controls.Add(Me.delete_butt)
        Me.Controls.Add(Me.edit_butt)
        Me.Controls.Add(Me.add_butt)
        Me.Name = "Form_mata_kuliah"
        Me.Text = "Form_mata_kuliah"
        CType(Me.Mata_kuliahBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mata_kuliahBindingNavigator.ResumeLayout(False)
        Me.Mata_kuliahBindingNavigator.PerformLayout()
        CType(Me.Mata_kuliahDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mata_kuliahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Mata_kuliahBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mata_kuliahTableAdapter As project2.universitas_informatikaDataSetTableAdapters.mata_kuliahTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mata_kuliahBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Mata_kuliahBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_matakuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOSEN_id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MATA_KULIAHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mata_kuliahDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
