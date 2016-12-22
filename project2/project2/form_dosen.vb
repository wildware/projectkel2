Public Class Form_dosen

    Private Sub DosenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_dosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Universitas_informatikaDataSet.dosen)

    End Sub

    Private Sub add_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True
    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True
    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click

    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub
End Class