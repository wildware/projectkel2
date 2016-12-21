Public Class form_mahasiswa

    Private Sub MahasiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_bersamaDataSet)

    End Sub

    Private Sub from_mahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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