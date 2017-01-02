Public Class Form_nilai

    Private Sub NilaiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.NilaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_nilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.nilai' table. You can move, or remove it, as needed.
        Me.NilaiTableAdapter.Fill(Me.Universitas_informatikaDataSet.nilai)
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.nilai' table. You can move, or remove it, as needed.
        Me.NilaiTableAdapter.Fill(Me.Universitas_informatikaDataSet.nilai)

    End Sub

    Private Sub add_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_nilaiTextBox.Enabled = True
        PERSERTA_MK_id_pesertaTextBox.Enabled = True
        TugasTextBox.Enabled = True
        UtsTextBox.Enabled = True
        UasTextBox.Enabled = True

        NilaiBindingSource.AddNew()
    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_nilaiTextBox.Enabled = True
        PERSERTA_MK_id_pesertaTextBox.Enabled = True
        TugasTextBox.Enabled = True
        UtsTextBox.Enabled = True
        UasTextBox.Enabled = True
    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click
        If MessageBox.Show("Delete data ?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            NilaiBindingSource.RemoveCurrent()

            Me.Validate()
            Me.NilaiBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

            MessageBox.Show("Data Was Deleted !")
        End If
    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        
        Id_nilaiTextBox.Enabled = True
        PERSERTA_MK_id_pesertaTextBox.Enabled = True
        TugasTextBox.Enabled = True
        UtsTextBox.Enabled = True
        UasTextBox.Enabled = True
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False

        NilaiBindingSource.CancelEdit()
    End Sub

    Private Sub refresh_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_butt.Click
        Me.NilaiTableAdapter.Fill(Me.Universitas_informatikaDataSet.nilai)
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub NilaiBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NilaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class