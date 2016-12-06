<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(barang))
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim Harga_barangLabel As System.Windows.Forms.Label
        Dim DiskonLabel As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Dim Start_timeLabel As System.Windows.Forms.Label
        Dim Update_timeLabel As System.Windows.Forms.Label
        Me.Db_penjualanDataSet = New aplikasitoko.db_penjualanDataSet()
        Me.Tb_sembakoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_sembakoTableAdapter = New aplikasitoko.db_penjualanDataSetTableAdapters.tb_sembakoTableAdapter()
        Me.TableAdapterManager = New aplikasitoko.db_penjualanDataSetTableAdapters.TableAdapterManager()
        Me.Tb_sembakoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_sembakoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_sembakoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Harga_barangTextBox = New System.Windows.Forms.TextBox()
        Me.DiskonTextBox = New System.Windows.Forms.TextBox()
        Me.StokTextBox = New System.Windows.Forms.TextBox()
        Me.Start_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Update_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        Harga_barangLabel = New System.Windows.Forms.Label()
        DiskonLabel = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        Start_timeLabel = New System.Windows.Forms.Label()
        Update_timeLabel = New System.Windows.Forms.Label()
        CType(Me.Db_penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_sembakoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_sembakoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_sembakoBindingNavigator.SuspendLayout()
        CType(Me.Tb_sembakoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Db_penjualanDataSet
        '
        Me.Db_penjualanDataSet.DataSetName = "db_penjualanDataSet"
        Me.Db_penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_sembakoBindingSource
        '
        Me.Tb_sembakoBindingSource.DataMember = "tb_sembako"
        Me.Tb_sembakoBindingSource.DataSource = Me.Db_penjualanDataSet
        '
        'Tb_sembakoTableAdapter
        '
        Me.Tb_sembakoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_sembakoTableAdapter = Me.Tb_sembakoTableAdapter
        Me.TableAdapterManager.UpdateOrder = aplikasitoko.db_penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_sembakoBindingNavigator
        '
        Me.Tb_sembakoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_sembakoBindingNavigator.BindingSource = Me.Tb_sembakoBindingSource
        Me.Tb_sembakoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_sembakoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_sembakoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_sembakoBindingNavigatorSaveItem})
        Me.Tb_sembakoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_sembakoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_sembakoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_sembakoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_sembakoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_sembakoBindingNavigator.Name = "Tb_sembakoBindingNavigator"
        Me.Tb_sembakoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_sembakoBindingNavigator.Size = New System.Drawing.Size(1106, 25)
        Me.Tb_sembakoBindingNavigator.TabIndex = 0
        Me.Tb_sembakoBindingNavigator.Text = "BindingNavigator1"
        Me.Tb_sembakoBindingNavigator.Visible = False
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tb_sembakoBindingNavigatorSaveItem
        '
        Me.Tb_sembakoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_sembakoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_sembakoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_sembakoBindingNavigatorSaveItem.Name = "Tb_sembakoBindingNavigatorSaveItem"
        Me.Tb_sembakoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_sembakoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_sembakoDataGridView
        '
        Me.Tb_sembakoDataGridView.AutoGenerateColumns = False
        Me.Tb_sembakoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_sembakoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Tb_sembakoDataGridView.DataSource = Me.Tb_sembakoBindingSource
        Me.Tb_sembakoDataGridView.Location = New System.Drawing.Point(349, 44)
        Me.Tb_sembakoDataGridView.Name = "Tb_sembakoDataGridView"
        Me.Tb_sembakoDataGridView.Size = New System.Drawing.Size(745, 220)
        Me.Tb_sembakoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "harga_barang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "harga_barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "diskon"
        Me.DataGridViewTextBoxColumn4.HeaderText = "diskon"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "stok"
        Me.DataGridViewTextBoxColumn5.HeaderText = "stok"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "start_time"
        Me.DataGridViewTextBoxColumn6.HeaderText = "start_time"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "update_time"
        Me.DataGridViewTextBoxColumn7.HeaderText = "update_time"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Nama_barangLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_barangTextBox)
        Me.GroupBox1.Controls.Add(Harga_barangLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_barangTextBox)
        Me.GroupBox1.Controls.Add(DiskonLabel)
        Me.GroupBox1.Controls.Add(Me.DiskonTextBox)
        Me.GroupBox1.Controls.Add(StokLabel)
        Me.GroupBox1.Controls.Add(Me.StokTextBox)
        Me.GroupBox1.Controls.Add(Start_timeLabel)
        Me.GroupBox1.Controls.Add(Me.Start_timeDateTimePicker)
        Me.GroupBox1.Controls.Add(Update_timeLabel)
        Me.GroupBox1.Controls.Add(Me.Update_timeDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 284)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(15, 30)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_sembakoBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(94, 27)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(15, 56)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(72, 13)
        Nama_barangLabel.TabIndex = 2
        Nama_barangLabel.Text = "nama barang:"
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_sembakoBindingSource, "nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(94, 53)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nama_barangTextBox.TabIndex = 3
        '
        'Harga_barangLabel
        '
        Harga_barangLabel.AutoSize = True
        Harga_barangLabel.Location = New System.Drawing.Point(15, 82)
        Harga_barangLabel.Name = "Harga_barangLabel"
        Harga_barangLabel.Size = New System.Drawing.Size(73, 13)
        Harga_barangLabel.TabIndex = 4
        Harga_barangLabel.Text = "harga barang:"
        '
        'Harga_barangTextBox
        '
        Me.Harga_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_sembakoBindingSource, "harga_barang", True))
        Me.Harga_barangTextBox.Location = New System.Drawing.Point(94, 79)
        Me.Harga_barangTextBox.Name = "Harga_barangTextBox"
        Me.Harga_barangTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Harga_barangTextBox.TabIndex = 5
        '
        'DiskonLabel
        '
        DiskonLabel.AutoSize = True
        DiskonLabel.Location = New System.Drawing.Point(15, 108)
        DiskonLabel.Name = "DiskonLabel"
        DiskonLabel.Size = New System.Drawing.Size(41, 13)
        DiskonLabel.TabIndex = 6
        DiskonLabel.Text = "diskon:"
        '
        'DiskonTextBox
        '
        Me.DiskonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_sembakoBindingSource, "diskon", True))
        Me.DiskonTextBox.Location = New System.Drawing.Point(94, 105)
        Me.DiskonTextBox.Name = "DiskonTextBox"
        Me.DiskonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DiskonTextBox.TabIndex = 7
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(15, 134)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(30, 13)
        StokLabel.TabIndex = 8
        StokLabel.Text = "stok:"
        '
        'StokTextBox
        '
        Me.StokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_sembakoBindingSource, "stok", True))
        Me.StokTextBox.Location = New System.Drawing.Point(94, 131)
        Me.StokTextBox.Name = "StokTextBox"
        Me.StokTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StokTextBox.TabIndex = 9
        '
        'Start_timeLabel
        '
        Start_timeLabel.AutoSize = True
        Start_timeLabel.Location = New System.Drawing.Point(15, 161)
        Start_timeLabel.Name = "Start_timeLabel"
        Start_timeLabel.Size = New System.Drawing.Size(52, 13)
        Start_timeLabel.TabIndex = 10
        Start_timeLabel.Text = "start time:"
        '
        'Start_timeDateTimePicker
        '
        Me.Start_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_sembakoBindingSource, "start_time", True))
        Me.Start_timeDateTimePicker.Location = New System.Drawing.Point(94, 157)
        Me.Start_timeDateTimePicker.Name = "Start_timeDateTimePicker"
        Me.Start_timeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Start_timeDateTimePicker.TabIndex = 11
        '
        'Update_timeLabel
        '
        Update_timeLabel.AutoSize = True
        Update_timeLabel.Location = New System.Drawing.Point(15, 187)
        Update_timeLabel.Name = "Update_timeLabel"
        Update_timeLabel.Size = New System.Drawing.Size(65, 13)
        Update_timeLabel.TabIndex = 12
        Update_timeLabel.Text = "update time:"
        '
        'Update_timeDateTimePicker
        '
        Me.Update_timeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_sembakoBindingSource, "update_time", True))
        Me.Update_timeDateTimePicker.Location = New System.Drawing.Point(94, 183)
        Me.Update_timeDateTimePicker.Name = "Update_timeDateTimePicker"
        Me.Update_timeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Update_timeDateTimePicker.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(99, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(180, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(18, 249)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Hapus"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(99, 249)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 416)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tb_sembakoDataGridView)
        Me.Controls.Add(Me.Tb_sembakoBindingNavigator)
        Me.Name = "barang"
        Me.Text = "barang"
        CType(Me.Db_penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_sembakoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_sembakoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_sembakoBindingNavigator.ResumeLayout(False)
        Me.Tb_sembakoBindingNavigator.PerformLayout()
        CType(Me.Tb_sembakoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Db_penjualanDataSet As aplikasitoko.db_penjualanDataSet
    Friend WithEvents Tb_sembakoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_sembakoTableAdapter As aplikasitoko.db_penjualanDataSetTableAdapters.tb_sembakoTableAdapter
    Friend WithEvents TableAdapterManager As aplikasitoko.db_penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_sembakoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tb_sembakoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tb_sembakoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_barangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiskonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StokTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Start_timeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Update_timeDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
