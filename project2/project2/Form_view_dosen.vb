Public Class Form_view_dosen

    Private Sub DosenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub From_view_dosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Universitas_informatikaDataSet.dosen)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        DosenTableAdapter.caridosen(Universitas_informatikaDataSet.dosen, "&" & TextBox1.Text & "%")
    End Sub

    Private Sub cari_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_but.Click
        DosenTableAdapter.caridosen(Universitas_informatikaDataSet.dosen, "&" & TextBox1.Text & "%")
    End Sub

    Private Sub refresh_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_but.Click
        Me.DosenTableAdapter.Fill(Me.Universitas_informatikaDataSet.dosen)
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub
End Class