﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_dosen
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
        Dim Id_dosenLabel As System.Windows.Forms.Label
        Dim Nama_dosenLabel As System.Windows.Forms.Label
        Dim Email_dosenLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Link_fbLabel As System.Windows.Forms.Label
        Dim WibsiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_dosen))
        Me.refresh_butt = New System.Windows.Forms.Button()
        Me.cancel_butt = New System.Windows.Forms.Button()
        Me.save_butt = New System.Windows.Forms.Button()
        Me.delete_butt = New System.Windows.Forms.Button()
        Me.edit_butt = New System.Windows.Forms.Button()
        Me.add_butt = New System.Windows.Forms.Button()
        Me.Universitas_informatikaDataSet = New project2.universitas_informatikaDataSet()
        Me.DosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DosenTableAdapter = New project2.universitas_informatikaDataSetTableAdapters.dosenTableAdapter()
        Me.TableAdapterManager = New project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager()
        Me.DosenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DosenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.Email_dosenTextBox = New System.Windows.Forms.TextBox()
        Me.User_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.exit_butt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Id_dosenLabel = New System.Windows.Forms.Label()
        Nama_dosenLabel = New System.Windows.Forms.Label()
        Email_dosenLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Link_fbLabel = New System.Windows.Forms.Label()
        WibsiteLabel = New System.Windows.Forms.Label()
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DosenBindingNavigator.SuspendLayout()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_dosenLabel
        '
        Id_dosenLabel.AutoSize = True
        Id_dosenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_dosenLabel.Location = New System.Drawing.Point(6, 15)
        Id_dosenLabel.Name = "Id_dosenLabel"
        Id_dosenLabel.Size = New System.Drawing.Size(66, 15)
        Id_dosenLabel.TabIndex = 21
        Id_dosenLabel.Text = "id dosen:"
        '
        'Nama_dosenLabel
        '
        Nama_dosenLabel.AutoSize = True
        Nama_dosenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nama_dosenLabel.Location = New System.Drawing.Point(6, 41)
        Nama_dosenLabel.Name = "Nama_dosenLabel"
        Nama_dosenLabel.Size = New System.Drawing.Size(90, 15)
        Nama_dosenLabel.TabIndex = 23
        Nama_dosenLabel.Text = "nama dosen:"
        '
        'Email_dosenLabel
        '
        Email_dosenLabel.AutoSize = True
        Email_dosenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_dosenLabel.Location = New System.Drawing.Point(6, 67)
        Email_dosenLabel.Name = "Email_dosenLabel"
        Email_dosenLabel.Size = New System.Drawing.Size(90, 15)
        Email_dosenLabel.TabIndex = 25
        Email_dosenLabel.Text = "email dosen:"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_nameLabel.Location = New System.Drawing.Point(6, 93)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(81, 15)
        User_nameLabel.TabIndex = 27
        User_nameLabel.Text = "User name:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(6, 119)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(72, 15)
        PasswordLabel.TabIndex = 29
        PasswordLabel.Text = "password:"
        '
        'Link_fbLabel
        '
        Link_fbLabel.AutoSize = True
        Link_fbLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Link_fbLabel.Location = New System.Drawing.Point(6, 145)
        Link_fbLabel.Name = "Link_fbLabel"
        Link_fbLabel.Size = New System.Drawing.Size(50, 15)
        Link_fbLabel.TabIndex = 31
        Link_fbLabel.Text = "link fb:"
        '
        'WibsiteLabel
        '
        WibsiteLabel.AutoSize = True
        WibsiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WibsiteLabel.Location = New System.Drawing.Point(6, 171)
        WibsiteLabel.Name = "WibsiteLabel"
        WibsiteLabel.Size = New System.Drawing.Size(56, 15)
        WibsiteLabel.TabIndex = 33
        WibsiteLabel.Text = "wibsite:"
        '
        'refresh_butt
        '
        Me.refresh_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_butt.Location = New System.Drawing.Point(25, 45)
        Me.refresh_butt.Name = "refresh_butt"
        Me.refresh_butt.Size = New System.Drawing.Size(75, 23)
        Me.refresh_butt.TabIndex = 19
        Me.refresh_butt.Text = "Refresh"
        Me.refresh_butt.UseVisualStyleBackColor = True
        '
        'cancel_butt
        '
        Me.cancel_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_butt.Location = New System.Drawing.Point(17, 135)
        Me.cancel_butt.Name = "cancel_butt"
        Me.cancel_butt.Size = New System.Drawing.Size(75, 23)
        Me.cancel_butt.TabIndex = 18
        Me.cancel_butt.Text = "cancel"
        Me.cancel_butt.UseVisualStyleBackColor = True
        '
        'save_butt
        '
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.Location = New System.Drawing.Point(17, 106)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.Size = New System.Drawing.Size(75, 23)
        Me.save_butt.TabIndex = 17
        Me.save_butt.Text = "Save"
        Me.save_butt.UseVisualStyleBackColor = True
        '
        'delete_butt
        '
        Me.delete_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_butt.Location = New System.Drawing.Point(17, 77)
        Me.delete_butt.Name = "delete_butt"
        Me.delete_butt.Size = New System.Drawing.Size(75, 23)
        Me.delete_butt.TabIndex = 16
        Me.delete_butt.Text = "delete"
        Me.delete_butt.UseVisualStyleBackColor = True
        '
        'edit_butt
        '
        Me.edit_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_butt.Location = New System.Drawing.Point(17, 48)
        Me.edit_butt.Name = "edit_butt"
        Me.edit_butt.Size = New System.Drawing.Size(75, 23)
        Me.edit_butt.TabIndex = 15
        Me.edit_butt.Text = "edit"
        Me.edit_butt.UseVisualStyleBackColor = True
        '
        'add_butt
        '
        Me.add_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_butt.Location = New System.Drawing.Point(17, 19)
        Me.add_butt.Name = "add_butt"
        Me.add_butt.Size = New System.Drawing.Size(75, 23)
        Me.add_butt.TabIndex = 14
        Me.add_butt.Text = " Add"
        Me.add_butt.UseVisualStyleBackColor = True
        '
        'Universitas_informatikaDataSet
        '
        Me.Universitas_informatikaDataSet.DataSetName = "universitas_informatikaDataSet"
        Me.Universitas_informatikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DosenBindingSource
        '
        Me.DosenBindingSource.DataMember = "dosen"
        Me.DosenBindingSource.DataSource = Me.Universitas_informatikaDataSet
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
        Me.TableAdapterManager.UpdateOrder = project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.DosenBindingNavigator.Size = New System.Drawing.Size(896, 25)
        Me.DosenBindingNavigator.TabIndex = 21
        Me.DosenBindingNavigator.Text = "BindingNavigator1"
        Me.DosenBindingNavigator.Visible = False
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
        'DosenBindingNavigatorSaveItem
        '
        Me.DosenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DosenBindingNavigatorSaveItem.Image = CType(resources.GetObject("DosenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DosenBindingNavigatorSaveItem.Name = "DosenBindingNavigatorSaveItem"
        Me.DosenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DosenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Id_dosenTextBox
        '
        Me.Id_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "id_dosen", True))
        Me.Id_dosenTextBox.Location = New System.Drawing.Point(162, 15)
        Me.Id_dosenTextBox.Name = "Id_dosenTextBox"
        Me.Id_dosenTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Id_dosenTextBox.TabIndex = 22
        '
        'Nama_dosenTextBox
        '
        Me.Nama_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "nama_dosen", True))
        Me.Nama_dosenTextBox.Location = New System.Drawing.Point(162, 41)
        Me.Nama_dosenTextBox.Name = "Nama_dosenTextBox"
        Me.Nama_dosenTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Nama_dosenTextBox.TabIndex = 24
        '
        'Email_dosenTextBox
        '
        Me.Email_dosenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "email_dosen", True))
        Me.Email_dosenTextBox.Location = New System.Drawing.Point(162, 67)
        Me.Email_dosenTextBox.Name = "Email_dosenTextBox"
        Me.Email_dosenTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Email_dosenTextBox.TabIndex = 26
        '
        'User_nameTextBox
        '
        Me.User_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "User_name", True))
        Me.User_nameTextBox.Location = New System.Drawing.Point(162, 93)
        Me.User_nameTextBox.Name = "User_nameTextBox"
        Me.User_nameTextBox.Size = New System.Drawing.Size(229, 20)
        Me.User_nameTextBox.TabIndex = 28
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(162, 119)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(229, 20)
        Me.PasswordTextBox.TabIndex = 30
        '
        'Link_fbTextBox
        '
        Me.Link_fbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "link_fb", True))
        Me.Link_fbTextBox.Location = New System.Drawing.Point(162, 145)
        Me.Link_fbTextBox.Name = "Link_fbTextBox"
        Me.Link_fbTextBox.Size = New System.Drawing.Size(229, 20)
        Me.Link_fbTextBox.TabIndex = 32
        '
        'WibsiteTextBox
        '
        Me.WibsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "wibsite", True))
        Me.WibsiteTextBox.Location = New System.Drawing.Point(162, 171)
        Me.WibsiteTextBox.Name = "WibsiteTextBox"
        Me.WibsiteTextBox.Size = New System.Drawing.Size(229, 20)
        Me.WibsiteTextBox.TabIndex = 34
        '
        'DosenDataGridView
        '
        Me.DosenDataGridView.AutoGenerateColumns = False
        Me.DosenDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DosenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DosenDataGridView.DataSource = Me.DosenBindingSource
        Me.DosenDataGridView.Location = New System.Drawing.Point(12, 74)
        Me.DosenDataGridView.Name = "DosenDataGridView"
        Me.DosenDataGridView.Size = New System.Drawing.Size(745, 220)
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "User_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User_name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "password"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.add_butt)
        Me.GroupBox1.Controls.Add(Me.edit_butt)
        Me.GroupBox1.Controls.Add(Me.delete_butt)
        Me.GroupBox1.Controls.Add(Me.save_butt)
        Me.GroupBox1.Controls.Add(Me.cancel_butt)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 168)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Id_dosenTextBox)
        Me.GroupBox2.Controls.Add(Me.WibsiteTextBox)
        Me.GroupBox2.Controls.Add(WibsiteLabel)
        Me.GroupBox2.Controls.Add(Id_dosenLabel)
        Me.GroupBox2.Controls.Add(Me.Link_fbTextBox)
        Me.GroupBox2.Controls.Add(Link_fbLabel)
        Me.GroupBox2.Controls.Add(Nama_dosenLabel)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox2.Controls.Add(PasswordLabel)
        Me.GroupBox2.Controls.Add(Me.Nama_dosenTextBox)
        Me.GroupBox2.Controls.Add(Me.User_nameTextBox)
        Me.GroupBox2.Controls.Add(Email_dosenLabel)
        Me.GroupBox2.Controls.Add(User_nameLabel)
        Me.GroupBox2.Controls.Add(Me.Email_dosenTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 205)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'exit_butt
        '
        Me.exit_butt.Cursor = System.Windows.Forms.Cursors.Default
        Me.exit_butt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_butt.ForeColor = System.Drawing.Color.Red
        Me.exit_butt.Location = New System.Drawing.Point(733, 0)
        Me.exit_butt.Name = "exit_butt"
        Me.exit_butt.Size = New System.Drawing.Size(43, 30)
        Me.exit_butt.TabIndex = 35
        Me.exit_butt.Text = "X"
        Me.exit_butt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.exit_butt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 42)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Penambahan dan Penggantian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Dosen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form_dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(771, 522)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exit_butt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DosenDataGridView)
        Me.Controls.Add(Me.refresh_butt)
        Me.Controls.Add(Me.DosenBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_dosen"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Universitas_informatikaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DosenBindingNavigator.ResumeLayout(False)
        Me.DosenBindingNavigator.PerformLayout()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents DosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DosenTableAdapter As project2.universitas_informatikaDataSetTableAdapters.dosenTableAdapter
    Friend WithEvents TableAdapterManager As project2.universitas_informatikaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents User_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents exit_butt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
