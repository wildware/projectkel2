Public Class form_informansi

    Private Sub InformasiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_bersamaDataSet)

    End Sub

    Private Sub form_informansi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_bersamaDataSet.informasi' table. You can move, or remove it, as needed.
        Me.InformasiTableAdapter.Fill(Me.Universitas_bersamaDataSet.informasi)

    End Sub

    Private Sub add_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_but.Click
        add_but.Enabled = False
        delete_but.Enabled = False
        edit_but.Enabled = False
        save_but.Enabled = True
        refresh_but.Enabled = False
        cancel_but.Enabled = True
    End Sub

    Private Sub edit_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_but.Click
        add_but.Enabled = False
        delete_but.Enabled = False
        edit_but.Enabled = False
        save_but.Enabled = True
        refresh_but.Enabled = False
        cancel_but.Enabled = True
    End Sub

    Private Sub delete_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_but.Click
        
    End Sub

    Private Sub save_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_but.Click
        add_but.Enabled = True
        delete_but.Enabled = True
        edit_but.Enabled = True
        save_but.Enabled = False
    End Sub

    Private Sub cancel_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_but.Click
        add_but.Enabled = True
        delete_but.Enabled = True
        edit_but.Enabled = True
        save_but.Enabled = False
        refresh_but.Enabled = True
        cancel_but.Enabled = False
    End Sub
End Class