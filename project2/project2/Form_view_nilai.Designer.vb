<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_view_nilai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_view_nilai))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refresh_but = New System.Windows.Forms.Button()
        Me.box_cari = New System.Windows.Forms.TextBox()
        Me.cari_but = New System.Windows.Forms.Button()
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.NilaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NilaiTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.nilaiTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Me.NilaiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NilaiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.NilaiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NilaiBindingNavigator.SuspendLayout()
        CType(Me.NilaiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "View And Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Nilai" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'refresh_but
        '
        Me.refresh_but.Location = New System.Drawing.Point(325, 70)
        Me.refresh_but.Name = "refresh_but"
        Me.refresh_but.Size = New System.Drawing.Size(75, 22)
        Me.refresh_but.TabIndex = 9
        Me.refresh_but.Text = "Refresh"
        Me.refresh_but.UseVisualStyleBackColor = True
        '
        'box_cari
        '
        Me.box_cari.Location = New System.Drawing.Point(12, 70)
        Me.box_cari.Name = "box_cari"
        Me.box_cari.Size = New System.Drawing.Size(222, 20)
        Me.box_cari.TabIndex = 8
        '
        'cari_but
        '
        Me.cari_but.Location = New System.Drawing.Point(244, 70)
        Me.cari_but.Name = "cari_but"
        Me.cari_but.Size = New System.Drawing.Size(75, 22)
        Me.cari_but.TabIndex = 7
        Me.cari_but.Text = "Cari"
        Me.cari_but.UseVisualStyleBackColor = True
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
        Me.NilaiBindingNavigator.Size = New System.Drawing.Size(692, 25)
        Me.NilaiBindingNavigator.TabIndex = 11
        Me.NilaiBindingNavigator.Text = "BindingNavigator1"
        Me.NilaiBindingNavigator.Visible = False
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NilaiDataGridView
        '
        Me.NilaiDataGridView.AutoGenerateColumns = False
        Me.NilaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NilaiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.NilaiDataGridView.DataSource = Me.NilaiBindingSource
        Me.NilaiDataGridView.Location = New System.Drawing.Point(12, 98)
        Me.NilaiDataGridView.Name = "NilaiDataGridView"
        Me.NilaiDataGridView.Size = New System.Drawing.Size(553, 220)
        Me.NilaiDataGridView.TabIndex = 11
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
        'NilaiBindingNavigatorSaveItem
        '
        Me.NilaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NilaiBindingNavigatorSaveItem.Image = CType(resources.GetObject("NilaiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NilaiBindingNavigatorSaveItem.Name = "NilaiBindingNavigatorSaveItem"
        Me.NilaiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NilaiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form_view_nilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 329)
        Me.Controls.Add(Me.NilaiDataGridView)
        Me.Controls.Add(Me.NilaiBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.refresh_but)
        Me.Controls.Add(Me.box_cari)
        Me.Controls.Add(Me.cari_but)
        Me.Name = "Form_view_nilai"
        Me.Text = "Form_view_nilai"
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NilaiBindingNavigator.ResumeLayout(False)
        Me.NilaiBindingNavigator.PerformLayout()
        CType(Me.NilaiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents refresh_but As System.Windows.Forms.Button
    Friend WithEvents box_cari As System.Windows.Forms.TextBox
    Friend WithEvents cari_but As System.Windows.Forms.Button
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
    Friend WithEvents NilaiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
