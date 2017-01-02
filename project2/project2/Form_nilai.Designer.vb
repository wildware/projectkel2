<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_nilai
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
        Dim Id_nilaiLabel As System.Windows.Forms.Label
        Dim PERSERTA_MK_id_pesertaLabel As System.Windows.Forms.Label
        Dim TugasLabel As System.Windows.Forms.Label
        Dim UtsLabel As System.Windows.Forms.Label
        Dim UasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_nilai))
        Me.refresh_butt = New System.Windows.Forms.Button()
        Me.cancel_butt = New System.Windows.Forms.Button()
        Me.save_butt = New System.Windows.Forms.Button()
        Me.delete_butt = New System.Windows.Forms.Button()
        Me.edit_butt = New System.Windows.Forms.Button()
        Me.add_butt = New System.Windows.Forms.Button()
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.NilaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NilaiTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.nilaiTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Me.NilaiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NilaiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_nilaiTextBox = New System.Windows.Forms.TextBox()
        Me.PERSERTA_MK_id_pesertaTextBox = New System.Windows.Forms.TextBox()
        Me.TugasTextBox = New System.Windows.Forms.TextBox()
        Me.UtsTextBox = New System.Windows.Forms.TextBox()
        Me.UasTextBox = New System.Windows.Forms.TextBox()
        Me.NilaiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_nilaiLabel = New System.Windows.Forms.Label()
        PERSERTA_MK_id_pesertaLabel = New System.Windows.Forms.Label()
        TugasLabel = New System.Windows.Forms.Label()
        UtsLabel = New System.Windows.Forms.Label()
        UasLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NilaiBindingNavigator.SuspendLayout()
        CType(Me.NilaiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_nilaiLabel
        '
        Id_nilaiLabel.AutoSize = True
        Id_nilaiLabel.Location = New System.Drawing.Point(12, 20)
        Id_nilaiLabel.Name = "Id_nilaiLabel"
        Id_nilaiLabel.Size = New System.Drawing.Size(39, 13)
        Id_nilaiLabel.TabIndex = 42
        Id_nilaiLabel.Text = "id nilai:"
        '
        'PERSERTA_MK_id_pesertaLabel
        '
        PERSERTA_MK_id_pesertaLabel.AutoSize = True
        PERSERTA_MK_id_pesertaLabel.Location = New System.Drawing.Point(12, 46)
        PERSERTA_MK_id_pesertaLabel.Name = "PERSERTA_MK_id_pesertaLabel"
        PERSERTA_MK_id_pesertaLabel.Size = New System.Drawing.Size(56, 13)
        PERSERTA_MK_id_pesertaLabel.TabIndex = 44
        PERSERTA_MK_id_pesertaLabel.Text = "id peserta:"
        '
        'TugasLabel
        '
        TugasLabel.AutoSize = True
        TugasLabel.Location = New System.Drawing.Point(12, 72)
        TugasLabel.Name = "TugasLabel"
        TugasLabel.Size = New System.Drawing.Size(36, 13)
        TugasLabel.TabIndex = 46
        TugasLabel.Text = "tugas:"
        '
        'UtsLabel
        '
        UtsLabel.AutoSize = True
        UtsLabel.Location = New System.Drawing.Point(12, 98)
        UtsLabel.Name = "UtsLabel"
        UtsLabel.Size = New System.Drawing.Size(24, 13)
        UtsLabel.TabIndex = 48
        UtsLabel.Text = "uts:"
        '
        'UasLabel
        '
        UasLabel.AutoSize = True
        UasLabel.Location = New System.Drawing.Point(12, 124)
        UasLabel.Name = "UasLabel"
        UasLabel.Size = New System.Drawing.Size(27, 13)
        UasLabel.TabIndex = 50
        UasLabel.Text = "uas:"
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(40, 38)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 40
        Me.refresh_butt.Text = "refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(15, 124)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 39
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(15, 67)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 38
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(15, 96)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 37
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(15, 41)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 36
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(15, 15)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 35
        Me.add_butt.Text = " Add"
        Me.add_butt.UseVisualStyleBackColor = True
        '
        'Universitas_informatikaDataSet
        '
        Me.Universitas_informatikaDataSet.DataSetName = "universitas_informatikaDataSet"
        Me.Universitas_informatikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NilaiBindingSource
        '
        Me.NilaiBindingSource.DataMember = "nilai"
        Me.NilaiBindingSource.DataSource = Me.Universitas_informatikaDataSet
        '
        'NilaiTableAdapter
        '
        Me.NilaiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Nothing
        Me.TableAdapterManager.informasiTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.nilaiTableAdapter = Me.NilaiTableAdapter
        Me.TableAdapterManager.peserta_mkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NilaiBindingNavigator
        '
        Me.NilaiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NilaiBindingNavigator.BindingSource = Me.NilaiBindingSource
        Me.NilaiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NilaiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NilaiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NilaiBindingNavigatorSaveItem})
        Me.NilaiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NilaiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NilaiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NilaiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NilaiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NilaiBindingNavigator.Name = "NilaiBindingNavigator"
        Me.NilaiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NilaiBindingNavigator.Size = New System.Drawing.Size(831, 25)
        Me.NilaiBindingNavigator.TabIndex = 42
        Me.NilaiBindingNavigator.Text = "BindingNavigator1"
        Me.NilaiBindingNavigator.Visible = False
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
        'NilaiBindingNavigatorSaveItem
        '
        Me.NilaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NilaiBindingNavigatorSaveItem.Image = CType(resources.GetObject("NilaiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NilaiBindingNavigatorSaveItem.Name = "NilaiBindingNavigatorSaveItem"
        Me.NilaiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NilaiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_nilaiTextBox
        '
        Me.Id_nilaiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NilaiBindingSource, "id_nilai", True))
        Me.Id_nilaiTextBox.Enabled = False
        Me.Id_nilaiTextBox.Location = New System.Drawing.Point(98, 17)
        Me.Id_nilaiTextBox.Name = "Id_nilaiTextBox"
        Me.Id_nilaiTextBox.Size = New System.Drawing.Size(144, 20)
        Me.Id_nilaiTextBox.TabIndex = 43
        '
        'PERSERTA_MK_id_pesertaTextBox
        '
        Me.PERSERTA_MK_id_pesertaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NilaiBindingSource, "PERSERTA_MK_id_peserta", True))
        Me.PERSERTA_MK_id_pesertaTextBox.Enabled = False
        Me.PERSERTA_MK_id_pesertaTextBox.Location = New System.Drawing.Point(98, 43)
        Me.PERSERTA_MK_id_pesertaTextBox.Name = "PERSERTA_MK_id_pesertaTextBox"
        Me.PERSERTA_MK_id_pesertaTextBox.Size = New System.Drawing.Size(144, 20)
        Me.PERSERTA_MK_id_pesertaTextBox.TabIndex = 45
        '
        'TugasTextBox
        '
        Me.TugasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NilaiBindingSource, "tugas", True))
        Me.TugasTextBox.Enabled = False
        Me.TugasTextBox.Location = New System.Drawing.Point(98, 69)
        Me.TugasTextBox.Name = "TugasTextBox"
        Me.TugasTextBox.Size = New System.Drawing.Size(144, 20)
        Me.TugasTextBox.TabIndex = 47
        '
        'UtsTextBox
        '
        Me.UtsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NilaiBindingSource, "uts", True))
        Me.UtsTextBox.Enabled = False
        Me.UtsTextBox.Location = New System.Drawing.Point(98, 95)
        Me.UtsTextBox.Name = "UtsTextBox"
        Me.UtsTextBox.Size = New System.Drawing.Size(144, 20)
        Me.UtsTextBox.TabIndex = 49
        '
        'UasTextBox
        '
        Me.UasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NilaiBindingSource, "uas", True))
        Me.UasTextBox.Enabled = False
        Me.UasTextBox.Location = New System.Drawing.Point(98, 121)
        Me.UasTextBox.Name = "UasTextBox"
        Me.UasTextBox.Size = New System.Drawing.Size(144, 20)
        Me.UasTextBox.TabIndex = 51
        '
        'NilaiDataGridView
        '
        Me.NilaiDataGridView.AutoGenerateColumns = False
        Me.NilaiDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.NilaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NilaiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.NilaiDataGridView.DataSource = Me.NilaiBindingSource
        Me.NilaiDataGridView.Location = New System.Drawing.Point(40, 67)
        Me.NilaiDataGridView.Name = "NilaiDataGridView"
        Me.NilaiDataGridView.Size = New System.Drawing.Size(674, 276)
        Me.NilaiDataGridView.TabIndex = 51
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_nilai"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_nilai"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PERSERTA_MK_id_peserta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PERSERTA_MK_id_peserta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tugas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tugas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "uts"
        Me.DataGridViewTextBoxColumn4.HeaderText = "uts"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "uas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "uas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(PERSERTA_MK_id_pesertaLabel)
        Me.GroupBox1.Controls.Add(Me.UasTextBox)
        Me.GroupBox1.Controls.Add(Id_nilaiLabel)
        Me.GroupBox1.Controls.Add(UasLabel)
        Me.GroupBox1.Controls.Add(Me.Id_nilaiTextBox)
        Me.GroupBox1.Controls.Add(Me.UtsTextBox)
        Me.GroupBox1.Controls.Add(UtsLabel)
        Me.GroupBox1.Controls.Add(Me.PERSERTA_MK_id_pesertaTextBox)
        Me.GroupBox1.Controls.Add(Me.TugasTextBox)
        Me.GroupBox1.Controls.Add(TugasLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 365)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 156)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.edit_butt)
        Me.GroupBox2.Controls.Add(Me.add_butt)
        Me.GroupBox2.Controls.Add(Me.delete_butt)
        Me.GroupBox2.Controls.Add(Me.save_butt)
        Me.GroupBox2.Controls.Add(Me.cancel_butt)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 365)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 156)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(343, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 31)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Nilai"
        '
        'Form_nilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(763, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NilaiDataGridView)
        Me.Controls.Add(Me.NilaiBindingNavigator)
        Me.Controls.Add(Me.refresh_butt)
        Me.Name = "Form_nilai"
        Me.Text = "Nilai"
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NilaiBindingNavigator.ResumeLayout(False)
        Me.NilaiBindingNavigator.PerformLayout()
        CType(Me.NilaiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents refresh_butt As System.Windows.Forms.Button
    Friend WithEvents cancel_butt As System.Windows.Forms.Button
    Friend WithEvents save_butt As System.Windows.Forms.Button
    Friend WithEvents delete_butt As System.Windows.Forms.Button
    Friend WithEvents edit_butt As System.Windows.Forms.Button
    Friend WithEvents add_butt As System.Windows.Forms.Button
    Friend WithEvents Universitas_informatikaDataSet As project2.universitas_informatikaDataSet
    Friend WithEvents NilaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NilaiTableAdapter As project2.universitas_informatikaDataSetTableAdapters.nilaiTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NilaiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents NilaiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_nilaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PERSERTA_MK_id_pesertaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TugasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UtsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NilaiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
