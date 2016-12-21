<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_dosen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_dosen))
        Dim Id_dosenLabel As System.Windows.Forms.Label
        Dim Nama_dosenLabel As System.Windows.Forms.Label
        Dim Email_dosenLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim PaswordLabel As System.Windows.Forms.Label
        Dim Link_fbLabel As System.Windows.Forms.Label
        Dim WibsiteLabel As System.Windows.Forms.Label
        Me.exit_but = New System.Windows.Forms.Button()
        Me.refresh_but = New System.Windows.Forms.Button()
        Me.cancel_but = New System.Windows.Forms.Button()
        Me.save_but = New System.Windows.Forms.Button()
        Me.delete_but = New System.Windows.Forms.Button()
        Me.edit_but = New System.Windows.Forms.Button()
        Me.add_but = New System.Windows.Forms.Button()
        Me.Universitas_bersamaDataSet = New project2.universitas_bersamaDataSet()
        Me.DosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DosenTableAdapter = New project2.universitas_bersamaDataSetTableAdapters.dosenTableAdapter()
        Me.TableAdapterManager = New project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager()
        Me.DosenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DosenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.Email_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PaswordTextBox = New System.Windows.Forms.TextBox()
        Me.Link_fbTextBox = New System.Windows.Forms.TextBox()
        Me.WibsiteTextBox = New System.Windows.Forms.TextBox()
        Me.DosenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Id_dosenLabel = New System.Windows.Forms.Label()
        Nama_dosenLabel = New System.Windows.Forms.Label()
        Email_dosenLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        PaswordLabel = New System.Windows.Forms.Label()
        Link_fbLabel = New System.Windows.Forms.Label()
        WibsiteLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_bersamaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DosenBindingNavigator.SuspendLayout()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit_but
        '
        Me.exit_but.Location = New System.Drawing.Point(12, 196)
        Me.exit_but.Name = "exit_but"
        Me.exit_but.Size = New System.Drawing.Size(75, 23)
        Me.exit_but.TabIndex = 20
        Me.exit_but.Text = "Exit"
        Me.exit_but.UseVisualStyleBackColor = True
        '
        'refresh_but
        '
        Me.refresh_but.Location = New System.Drawing.Point(12, 166)
        Me.refresh_but.Name = "refresh_but"
        Me.refresh_but.Size = New System.Drawing.Size(75, 23)
        Me.refresh_but.TabIndex = 19
        Me.refresh_but.Text = "Refresh"
        Me.refresh_but.UseVisualStyleBackColor = True
        '
        'cancel_but
        '
        Me.cancel_but.Location = New System.Drawing.Point(12, 136)
        Me.cancel_but.Name = "cancel_but"
        Me.cancel_but.Size = New System.Drawing.Size(75, 23)
        Me.cancel_but.TabIndex = 18
        Me.cancel_but.Text = "Cancel"
        Me.cancel_but.UseVisualStyleBackColor = True
        '
        'save_but
        '
        Me.save_but.Location = New System.Drawing.Point(12, 105)
        Me.save_but.Name = "save_but"
        Me.save_but.Size = New System.Drawing.Size(75, 23)
        Me.save_but.TabIndex = 17
        Me.save_but.Text = "Save"
        Me.save_but.UseVisualStyleBackColor = True
        '
        'delete_but
        '
        Me.delete_but.Location = New System.Drawing.Point(12, 74)
        Me.delete_but.Name = "delete_but"
        Me.delete_but.Size = New System.Drawing.Size(75, 23)
        Me.delete_but.TabIndex = 16
        Me.delete_but.Text = "Delete"
        Me.delete_but.UseVisualStyleBackColor = True
        '
        'edit_but
        '
        Me.edit_but.Location = New System.Drawing.Point(12, 43)
        Me.edit_but.Name = "edit_but"
        Me.edit_but.Size = New System.Drawing.Size(75, 23)
        Me.edit_but.TabIndex = 15
        Me.edit_but.Text = "Edit"
        Me.edit_but.UseVisualStyleBackColor = True
        '
        'add_but
        '
        Me.add_but.Location = New System.Drawing.Point(12, 12)
        Me.add_but.Name = "add_but"
        Me.add_but.Size = New System.Drawing.Size(75, 23)
        Me.add_but.TabIndex = 14
        Me.add_but.Text = "Add"
        Me.add_but.UseVisualStyleBackColor = True
        '
        'Universitas_bersamaDataSet
        '
        Me.Universitas_bersamaDataSet.DataSetName = "universitas_bersamaDataSet"
        Me.Universitas_bersamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DosenBindingSource
        '
        Me.DosenBindingSource.DataMember = "dosen"
        Me.DosenBindingSource.DataSource = Me.Universitas_bersamaDataSet
        '
        'DosenTableAdapter
        '
        Me.DosenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dosenTableAdapter = Me.DosenTableAdapter
        Me.TableAdapterManager.informasiTableAdapter = Nothing
        Me.TableAdapterManager.mahasiswaTableAdapter = Nothing
        Me.TableAdapterManager.mata_kuliahTableAdapter = Nothing
        Me.TableAdapterManager.nilaiTableAdapter = Nothing
        Me.TableAdapterManager.peserta_mkTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DosenBindingNavigator
        '
        Me.DosenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DosenBindingNavigator.BindingSource = Me.DosenBindingSource
        Me.DosenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DosenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DosenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DosenBindingNavigatorSaveItem})
        Me.DosenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DosenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DosenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DosenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DosenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DosenBindingNavigator.Name = "DosenBindingNavigator"
        Me.DosenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DosenBindingNavigator.Size = New System.Drawing.Size(561, 25)
        Me.DosenBindingNavigator.TabIndex = 21
        Me.DosenBindingNavigator.Text = "BindingNavigator1"
        Me.DosenBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
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
        'DosenBindingNavigatorSaveItem
        '
        Me.DosenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DosenBindingNavigatorSaveItem.Image = CType(resources.GetObject("DosenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DosenBindingNavigatorSaveItem.Name = "DosenBindingNavigatorSaveItem"
        Me.DosenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DosenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_dosenLabel
        '
        Id_dosenLabel.AutoSize = True
        Id_dosenLabel.Location = New System.Drawing.Point(101, 17)
        Id_dosenLabel.Name = "Id_dosenLabel"
        Id_dosenLabel.Size = New System.Drawing.Size(50, 13)
        Id_dosenLabel.TabIndex = 21
        Id_dosenLabel.Text = "id dosen:"
        '
        'Id_dosenTextBox
        '
        Me.Id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "id_dosen", True))
        Me.Id_dosenTextBox.Location = New System.Drawing.Point(175, 14)
        Me.Id_dosenTextBox.Name = "Id_dosenTextBox"
        Me.Id_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_dosenTextBox.TabIndex = 22
        '
        'Nama_dosenLabel
        '
        Nama_dosenLabel.AutoSize = True
        Nama_dosenLabel.Location = New System.Drawing.Point(101, 43)
        Nama_dosenLabel.Name = "Nama_dosenLabel"
        Nama_dosenLabel.Size = New System.Drawing.Size(68, 13)
        Nama_dosenLabel.TabIndex = 23
        Nama_dosenLabel.Text = "nama dosen:"
        '
        'Nama_dosenTextBox
        '
        Me.Nama_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "nama_dosen", True))
        Me.Nama_dosenTextBox.Location = New System.Drawing.Point(175, 40)
        Me.Nama_dosenTextBox.Name = "Nama_dosenTextBox"
        Me.Nama_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nama_dosenTextBox.TabIndex = 24
        '
        'Email_dosenLabel
        '
        Email_dosenLabel.AutoSize = True
        Email_dosenLabel.Location = New System.Drawing.Point(101, 69)
        Email_dosenLabel.Name = "Email_dosenLabel"
        Email_dosenLabel.Size = New System.Drawing.Size(66, 13)
        Email_dosenLabel.TabIndex = 25
        Email_dosenLabel.Text = "email dosen:"
        '
        'Email_dosenTextBox
        '
        Me.Email_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "email_dosen", True))
        Me.Email_dosenTextBox.Location = New System.Drawing.Point(175, 66)
        Me.Email_dosenTextBox.Name = "Email_dosenTextBox"
        Me.Email_dosenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Email_dosenTextBox.TabIndex = 26
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(101, 95)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(63, 13)
        UserNameLabel.TabIndex = 27
        UserNameLabel.Text = "User Name:"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "UserName", True))
        Me.UserNameTextBox.Location = New System.Drawing.Point(175, 92)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 28
        '
        'PaswordLabel
        '
        PaswordLabel.AutoSize = True
        PaswordLabel.Location = New System.Drawing.Point(101, 121)
        PaswordLabel.Name = "PaswordLabel"
        PaswordLabel.Size = New System.Drawing.Size(50, 13)
        PaswordLabel.TabIndex = 29
        PaswordLabel.Text = "pasword:"
        '
        'PaswordTextBox
        '
        Me.PaswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "pasword", True))
        Me.PaswordTextBox.Location = New System.Drawing.Point(175, 118)
        Me.PaswordTextBox.Name = "PaswordTextBox"
        Me.PaswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaswordTextBox.TabIndex = 30
        '
        'Link_fbLabel
        '
        Link_fbLabel.AutoSize = True
        Link_fbLabel.Location = New System.Drawing.Point(101, 147)
        Link_fbLabel.Name = "Link_fbLabel"
        Link_fbLabel.Size = New System.Drawing.Size(38, 13)
        Link_fbLabel.TabIndex = 31
        Link_fbLabel.Text = "link fb:"
        '
        'Link_fbTextBox
        '
        Me.Link_fbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "link_fb", True))
        Me.Link_fbTextBox.Location = New System.Drawing.Point(175, 144)
        Me.Link_fbTextBox.Name = "Link_fbTextBox"
        Me.Link_fbTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Link_fbTextBox.TabIndex = 32
        '
        'WibsiteLabel
        '
        WibsiteLabel.AutoSize = True
        WibsiteLabel.Location = New System.Drawing.Point(101, 173)
        WibsiteLabel.Name = "WibsiteLabel"
        WibsiteLabel.Size = New System.Drawing.Size(42, 13)
        WibsiteLabel.TabIndex = 33
        WibsiteLabel.Text = "wibsite:"
        '
        'WibsiteTextBox
        '
        Me.WibsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "wibsite", True))
        Me.WibsiteTextBox.Location = New System.Drawing.Point(175, 170)
        Me.WibsiteTextBox.Name = "WibsiteTextBox"
        Me.WibsiteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WibsiteTextBox.TabIndex = 34
        '
        'DosenDataGridView
        '
        Me.DosenDataGridView.AutoGenerateColumns = False
        Me.DosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DosenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DosenDataGridView.DataSource = Me.DosenBindingSource
        Me.DosenDataGridView.Location = New System.Drawing.Point(281, 12)
        Me.DosenDataGridView.Name = "DosenDataGridView"
        Me.DosenDataGridView.Size = New System.Drawing.Size(749, 207)
        Me.DosenDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_dosen"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_dosen"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_dosen"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_dosen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "email_dosen"
        Me.DataGridViewTextBoxColumn3.HeaderText = "email_dosen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "pasword"
        Me.DataGridViewTextBoxColumn5.HeaderText = "pasword"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "link_fb"
        Me.DataGridViewTextBoxColumn6.HeaderText = "link_fb"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "wibsite"
        Me.DataGridViewTextBoxColumn7.HeaderText = "wibsite"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'form_dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 236)
        Me.Controls.Add(Me.DosenDataGridView)
        Me.Controls.Add(Id_dosenLabel)
        Me.Controls.Add(Me.Id_dosenTextBox)
        Me.Controls.Add(Nama_dosenLabel)
        Me.Controls.Add(Me.Nama_dosenTextBox)
        Me.Controls.Add(Email_dosenLabel)
        Me.Controls.Add(Me.Email_dosenTextBox)
        Me.Controls.Add(UserNameLabel)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(PaswordLabel)
        Me.Controls.Add(Me.PaswordTextBox)
        Me.Controls.Add(Link_fbLabel)
        Me.Controls.Add(Me.Link_fbTextBox)
        Me.Controls.Add(WibsiteLabel)
        Me.Controls.Add(Me.WibsiteTextBox)
        Me.Controls.Add(Me.DosenBindingNavigator)
        Me.Controls.Add(Me.exit_but)
        Me.Controls.Add(Me.refresh_but)
        Me.Controls.Add(Me.cancel_but)
        Me.Controls.Add(Me.save_but)
        Me.Controls.Add(Me.delete_but)
        Me.Controls.Add(Me.edit_but)
        Me.Controls.Add(Me.add_but)
        Me.Name = "form_dosen"
        Me.Text = "form_dosen"
        CType(Me.Universitas_bersamaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DosenBindingNavigator.ResumeLayout(False)
        Me.DosenBindingNavigator.PerformLayout()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exit_but As System.Windows.Forms.Button
    Friend WithEvents refresh_but As System.Windows.Forms.Button
    Friend WithEvents cancel_but As System.Windows.Forms.Button
    Friend WithEvents save_but As System.Windows.Forms.Button
    Friend WithEvents delete_but As System.Windows.Forms.Button
    Friend WithEvents edit_but As System.Windows.Forms.Button
    Friend WithEvents add_but As System.Windows.Forms.Button
    Friend WithEvents Universitas_bersamaDataSet As project2.universitas_bersamaDataSet
    Friend WithEvents DosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DosenTableAdapter As project2.universitas_bersamaDataSetTableAdapters.dosenTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_bersamaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DosenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DosenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_dosenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Link_fbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WibsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DosenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
