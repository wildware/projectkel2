<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_view_informasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_view_informasi))
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
        Me.cari_but = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.refresh_but = New System.Windows.Forms.Button()
        Me.Keluar_but = New System.Windows.Forms.Button()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InformasiBindingNavigator.SuspendLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.InformasiBindingNavigator.Size = New System.Drawing.Size(811, 25)
        Me.InformasiBindingNavigator.TabIndex = 0
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
        Me.InformasiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InformasiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InformasiDataGridView.DataSource = Me.InformasiBindingSource
        Me.InformasiDataGridView.Location = New System.Drawing.Point(27, 42)
        Me.InformasiDataGridView.Name = "InformasiDataGridView"
        Me.InformasiDataGridView.Size = New System.Drawing.Size(754, 266)
        Me.InformasiDataGridView.TabIndex = 1
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
        'cari_but
        '
        Me.cari_but.Location = New System.Drawing.Point(319, 15)
        Me.cari_but.Name = "cari_but"
        Me.cari_but.Size = New System.Drawing.Size(75, 22)
        Me.cari_but.TabIndex = 2
        Me.cari_but.Text = "Cari"
        Me.cari_but.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(268, 20)
        Me.TextBox1.TabIndex = 3
        '
        'refresh_but
        '
        Me.refresh_but.Location = New System.Drawing.Point(400, 15)
        Me.refresh_but.Name = "refresh_but"
        Me.refresh_but.Size = New System.Drawing.Size(75, 22)
        Me.refresh_but.TabIndex = 4
        Me.refresh_but.Text = "Refresh"
        Me.refresh_but.UseVisualStyleBackColor = True
        '
        'Keluar_but
        '
        Me.Keluar_but.Location = New System.Drawing.Point(481, 15)
        Me.Keluar_but.Name = "Keluar_but"
        Me.Keluar_but.Size = New System.Drawing.Size(75, 23)
        Me.Keluar_but.TabIndex = 5
        Me.Keluar_but.Text = "Keluar"
        Me.Keluar_but.UseVisualStyleBackColor = True
        '
        'Form_view_informasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 322)
        Me.Controls.Add(Me.Keluar_but)
        Me.Controls.Add(Me.refresh_but)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cari_but)
        Me.Controls.Add(Me.InformasiDataGridView)
        Me.Controls.Add(Me.InformasiBindingNavigator)
        Me.Name = "Form_view_informasi"
        Me.Text = "Form_view_informasi"
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InformasiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InformasiBindingNavigator.ResumeLayout(False)
        Me.InformasiBindingNavigator.PerformLayout()
        CType(Me.InformasiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents cari_but As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents refresh_but As System.Windows.Forms.Button
    Friend WithEvents Keluar_but As System.Windows.Forms.Button
End Class
