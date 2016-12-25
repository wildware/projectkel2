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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_informasi))
        Dim Id_informasiLabel As System.Windows.Forms.Label
        Dim DOSEN_id_dosenLabel As System.Windows.Forms.Label
        Dim MATA_KULIAH_id_matakuliahLabel As System.Windows.Forms.Label
        Dim MATA_KULIAH_DOSEN_id_dosenLabel As System.Windows.Forms.Label
        Dim JudulLabel As System.Windows.Forms.Label
        Dim InfoLabel As System.Windows.Forms.Label
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim HariLabel As System.Windows.Forms.Label
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
        Me.InformasiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_informasiTextBox = New System.Windows.Forms.TextBox()
        Me.DOSEN_id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.MATA_KULIAH_id_matakuliahTextBox = New System.Windows.Forms.TextBox()
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.JudulTextBox = New System.Windows.Forms.TextBox()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalTextBox = New System.Windows.Forms.TextBox()
        Me.HariTextBox = New System.Windows.Forms.TextBox()
        Me.InformasiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_informasiLabel = New System.Windows.Forms.Label()
        DOSEN_id_dosenLabel = New System.Windows.Forms.Label()
        MATA_KULIAH_id_matakuliahLabel = New System.Windows.Forms.Label()
        MATA_KULIAH_DOSEN_id_dosenLabel = New System.Windows.Forms.Label()
        JudulLabel = New System.Windows.Forms.Label()
        InfoLabel = New System.Windows.Forms.Label()
        TanggalLabel = New System.Windows.Forms.Label()
        HariLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InformasiBindingNavigator.SuspendLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit_butt
        '
        Me.exit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.Location = New System.Drawing.Point(12, 186)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(75, 23)
        Me.exit_butt.TabIndex = 13
        Me.exit_butt.Text = "exit"
        Me.exit_butt.UseVisualStyleBackColor = True
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(12, 157)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 12
        Me.refresh_butt.Text = "refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(12, 128)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 11
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(12, 99)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 10
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(12, 70)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 9
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(12, 41)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 8
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(12, 12)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 7
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
        Me.InformasiBindingNavigator.Size = New System.Drawing.Size(882, 25)
        Me.InformasiBindingNavigator.TabIndex = 14
        Me.InformasiBindingNavigator.Text = "BindingNavigator1"
        Me.InformasiBindingNavigator.Visible = False
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
        'InformasiBindingNavigatorSaveItem
        '
        Me.InformasiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InformasiBindingNavigatorSaveItem.Image = CType(resources.GetObject("InformasiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InformasiBindingNavigatorSaveItem.Name = "InformasiBindingNavigatorSaveItem"
        Me.InformasiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.InformasiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_informasiLabel
        '
        Id_informasiLabel.AutoSize = True
        Id_informasiLabel.Location = New System.Drawing.Point(99, 16)
        Id_informasiLabel.Name = "Id_informasiLabel"
        Id_informasiLabel.Size = New System.Drawing.Size(62, 13)
        Id_informasiLabel.TabIndex = 14
        Id_informasiLabel.Text = "id informasi:"
        '
        'Id_informasiTextBox
        '
        Me.Id_informasiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "id_informasi", True))
        Me.Id_informasiTextBox.Location = New System.Drawing.Point(271, 13)
        Me.Id_informasiTextBox.Name = "Id_informasiTextBox"
        Me.Id_informasiTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_informasiTextBox.TabIndex = 15
        '
        'DOSEN_id_dosenLabel
        '
        DOSEN_id_dosenLabel.AutoSize = True
        DOSEN_id_dosenLabel.Location = New System.Drawing.Point(99, 42)
        DOSEN_id_dosenLabel.Name = "DOSEN_id_dosenLabel"
        DOSEN_id_dosenLabel.Size = New System.Drawing.Size(91, 13)
        DOSEN_id_dosenLabel.TabIndex = 16
        DOSEN_id_dosenLabel.Text = "DOSEN id dosen:"
        '
        'DOSEN_id_dosenTextBox
        '
        Me.DOSEN_id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "DOSEN_id_dosen", True))
        Me.DOSEN_id_dosenTextBox.Location = New System.Drawing.Point(271, 39)
        Me.DOSEN_id_dosenTextBox.Name = "DOSEN_id_dosenTextBox"
        Me.DOSEN_id_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DOSEN_id_dosenTextBox.TabIndex = 17
        '
        'MATA_KULIAH_id_matakuliahLabel
        '
        MATA_KULIAH_id_matakuliahLabel.AutoSize = True
        MATA_KULIAH_id_matakuliahLabel.Location = New System.Drawing.Point(99, 68)
        MATA_KULIAH_id_matakuliahLabel.Name = "MATA_KULIAH_id_matakuliahLabel"
        MATA_KULIAH_id_matakuliahLabel.Size = New System.Drawing.Size(147, 13)
        MATA_KULIAH_id_matakuliahLabel.TabIndex = 18
        MATA_KULIAH_id_matakuliahLabel.Text = "MATA KULIAH id matakuliah:"
        '
        'MATA_KULIAH_id_matakuliahTextBox
        '
        Me.MATA_KULIAH_id_matakuliahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "MATA_KULIAH_id_matakuliah", True))
        Me.MATA_KULIAH_id_matakuliahTextBox.Location = New System.Drawing.Point(271, 65)
        Me.MATA_KULIAH_id_matakuliahTextBox.Name = "MATA_KULIAH_id_matakuliahTextBox"
        Me.MATA_KULIAH_id_matakuliahTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MATA_KULIAH_id_matakuliahTextBox.TabIndex = 19
        '
        'MATA_KULIAH_DOSEN_id_dosenLabel
        '
        MATA_KULIAH_DOSEN_id_dosenLabel.AutoSize = True
        MATA_KULIAH_DOSEN_id_dosenLabel.Location = New System.Drawing.Point(99, 94)
        MATA_KULIAH_DOSEN_id_dosenLabel.Name = "MATA_KULIAH_DOSEN_id_dosenLabel"
        MATA_KULIAH_DOSEN_id_dosenLabel.Size = New System.Drawing.Size(166, 13)
        MATA_KULIAH_DOSEN_id_dosenLabel.TabIndex = 20
        MATA_KULIAH_DOSEN_id_dosenLabel.Text = "MATA KULIAH DOSEN id dosen:"
        '
        'MATA_KULIAH_DOSEN_id_dosenTextBox
        '
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "MATA_KULIAH_DOSEN_id_dosen", True))
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Location = New System.Drawing.Point(271, 91)
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Name = "MATA_KULIAH_DOSEN_id_dosenTextBox"
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MATA_KULIAH_DOSEN_id_dosenTextBox.TabIndex = 21
        '
        'JudulLabel
        '
        JudulLabel.AutoSize = True
        JudulLabel.Location = New System.Drawing.Point(99, 120)
        JudulLabel.Name = "JudulLabel"
        JudulLabel.Size = New System.Drawing.Size(32, 13)
        JudulLabel.TabIndex = 22
        JudulLabel.Text = "judul:"
        '
        'JudulTextBox
        '
        Me.JudulTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "judul", True))
        Me.JudulTextBox.Location = New System.Drawing.Point(271, 117)
        Me.JudulTextBox.Name = "JudulTextBox"
        Me.JudulTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JudulTextBox.TabIndex = 23
        '
        'InfoLabel
        '
        InfoLabel.AutoSize = True
        InfoLabel.Location = New System.Drawing.Point(99, 146)
        InfoLabel.Name = "InfoLabel"
        InfoLabel.Size = New System.Drawing.Size(27, 13)
        InfoLabel.TabIndex = 24
        InfoLabel.Text = "info:"
        '
        'InfoTextBox
        '
        Me.InfoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "info", True))
        Me.InfoTextBox.Location = New System.Drawing.Point(271, 143)
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InfoTextBox.TabIndex = 25
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(99, 172)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(45, 13)
        TanggalLabel.TabIndex = 26
        TanggalLabel.Text = "tanggal:"
        '
        'TanggalTextBox
        '
        Me.TanggalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "tanggal", True))
        Me.TanggalTextBox.Location = New System.Drawing.Point(271, 169)
        Me.TanggalTextBox.Name = "TanggalTextBox"
        Me.TanggalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TanggalTextBox.TabIndex = 27
        '
        'HariLabel
        '
        HariLabel.AutoSize = True
        HariLabel.Location = New System.Drawing.Point(99, 198)
        HariLabel.Name = "HariLabel"
        HariLabel.Size = New System.Drawing.Size(27, 13)
        HariLabel.TabIndex = 28
        HariLabel.Text = "hari:"
        '
        'HariTextBox
        '
        Me.HariTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InformasiBindingSource, "hari", True))
        Me.HariTextBox.Location = New System.Drawing.Point(271, 195)
        Me.HariTextBox.Name = "HariTextBox"
        Me.HariTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HariTextBox.TabIndex = 29
        '
        'InformasiDataGridView
        '
        Me.InformasiDataGridView.AutoGenerateColumns = False
        Me.InformasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InformasiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.InformasiDataGridView.DataSource = Me.InformasiBindingSource
        Me.InformasiDataGridView.Location = New System.Drawing.Point(377, 12)
        Me.InformasiDataGridView.Name = "InformasiDataGridView"
        Me.InformasiDataGridView.Size = New System.Drawing.Size(505, 203)
        Me.InformasiDataGridView.TabIndex = 29
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
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "hari"
        Me.DataGridViewTextBoxColumn8.HeaderText = "hari"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Form_informasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 262)
        Me.Controls.Add(Me.InformasiDataGridView)
        Me.Controls.Add(Id_informasiLabel)
        Me.Controls.Add(Me.Id_informasiTextBox)
        Me.Controls.Add(DOSEN_id_dosenLabel)
        Me.Controls.Add(Me.DOSEN_id_dosenTextBox)
        Me.Controls.Add(MATA_KULIAH_id_matakuliahLabel)
        Me.Controls.Add(Me.MATA_KULIAH_id_matakuliahTextBox)
        Me.Controls.Add(MATA_KULIAH_DOSEN_id_dosenLabel)
        Me.Controls.Add(Me.MATA_KULIAH_DOSEN_id_dosenTextBox)
        Me.Controls.Add(JudulLabel)
        Me.Controls.Add(Me.JudulTextBox)
        Me.Controls.Add(InfoLabel)
        Me.Controls.Add(Me.InfoTextBox)
        Me.Controls.Add(TanggalLabel)
        Me.Controls.Add(Me.TanggalTextBox)
        Me.Controls.Add(HariLabel)
        Me.Controls.Add(Me.HariTextBox)
        Me.Controls.Add(Me.InformasiBindingNavigator)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.refresh_butt)
        Me.Controls.Add(Me.cancel_butt)
        Me.Controls.Add(Me.save_butt)
        Me.Controls.Add(Me.delete_butt)
        Me.Controls.Add(Me.edit_butt)
        Me.Controls.Add(Me.add_butt)
        Me.Name = "Form_informasi"
        Me.Text = "Form_informasi"
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InformasiBindingNavigator.ResumeLayout(False)
        Me.InformasiBindingNavigator.PerformLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Id_informasiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOSEN_id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MATA_KULIAH_id_matakuliahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MATA_KULIAH_DOSEN_id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JudulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HariTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InformasiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
