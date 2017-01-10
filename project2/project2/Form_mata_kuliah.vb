Public Class Form_mata_kuliah

    Private Sub Mata_kuliahBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Mata_kuliahBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_mata_kuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.mata_kuliah' table. You can move, or remove it, as needed.
        Me.Mata_kuliahTableAdapter.Fill(Me.Universitas_informatikaDataSet.mata_kuliah)
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.mata_kuliah' table. You can move, or remove it, as needed.
        Me.Mata_kuliahTableAdapter.Fill(Me.Universitas_informatikaDataSet.mata_kuliah)

    End Sub

    Private Sub add_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_matakuliahTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        SksTextBox.Enabled = True
        MATA_KULIAHTextBox.Enabled = True
        KodeTextBox.Enabled = True

        Mata_kuliahBindingSource.AddNew()
    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_matakuliahTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        SksTextBox.Enabled = True
        MATA_KULIAHTextBox.Enabled = True
        KodeTextBox.Enabled = True
    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click
        If MessageBox.Show("Delete data ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Mata_kuliahBindingSource.RemoveCurrent()

            Me.Validate()
            Me.Mata_kuliahBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

            MessageBox.Show("Data Was Deleted !")

        End If
    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        Me.Validate()
        Me.Mata_kuliahBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

        MessageBox.Show("Data has been saved")

        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True


        Id_matakuliahTextBox.Enabled = True
        DOSEN_id_dosenTextBox.Enabled = True
        SksTextBox.Enabled = True
        MATA_KULIAHTextBox.Enabled = True
        KodeTextBox.Enabled = True
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False

        Mata_kuliahBindingSource.CancelEdit()
    End Sub

    Private Sub refresh_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_butt.Click
        Me.Mata_kuliahTableAdapter.Fill(Me.Universitas_informatikaDataSet.mata_kuliah)
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub

    Private Sub Mata_kuliahBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mata_kuliahBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Mata_kuliahBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Mata_kuliahTableAdapter.carimatkul(Universitas_informatikaDataSet.mata_kuliah, "%" & TextBox1.Text & "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class