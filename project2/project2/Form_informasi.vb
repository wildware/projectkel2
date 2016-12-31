Public Class Form_informasi

    Private Sub InformasiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_informasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.informasi' table. You can move, or remove it, as needed.
        Me.InformasiTableAdapter.Fill(Me.Universitas_informatikaDataSet.informasi)
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.informasi' table. You can move, or remove it, as needed.
        Me.InformasiTableAdapter.Fill(Me.Universitas_informatikaDataSet.informasi)
    End Sub

    Private Sub add_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_butt.Click

        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_informasiTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        MATA_KULIAH_id_matakuliahTextBox.Enabled = True
        MATA_KULIAH_DOSEN_id_dosenTextBox.Enabled = True
        JudulTextBox.Enabled = True
        InfoTextBox.Enabled = True
        TanggalDateTimePicker.Enabled = True

        InformasiBindingSource.AddNew()

    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_informasiTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        MATA_KULIAH_id_matakuliahTextBox.Enabled = True
        MATA_KULIAH_DOSEN_id_dosenTextBox.Enabled = True
        JudulTextBox.Enabled = True
        InfoTextBox.Enabled = True
        TanggalDateTimePicker.Enabled = True
    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click
        If MessageBox.Show("Delete data ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            InformasiBindingSource.RemoveCurrent()

            Me.Validate()
            Me.InformasiBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

            MessageBox.Show("Data Was Deleted !")
        End If
    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

        MessageBox.Show("Data has been saved")

        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False

        Id_informasiTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        MATA_KULIAH_id_matakuliahTextBox.Enabled = True
        MATA_KULIAH_DOSEN_id_dosenTextBox.Enabled = True
        JudulTextBox.Enabled = True
        InfoTextBox.Enabled = True
        TanggalDateTimePicker.Enabled = True
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False

        InformasiBindingSource.CancelEdit()
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub

    Private Sub refresh_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_butt.Click
        Me.InformasiTableAdapter.Fill(Me.Universitas_informatikaDataSet.informasi)
    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub InformasiDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class