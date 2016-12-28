Public Class Form_view_informasi

    Private Sub InformasiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_view_informasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.informasi' table. You can move, or remove it, as needed.
        Me.InformasiTableAdapter.Fill(Me.Universitas_informatikaDataSet.informasi)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        InformasiTableAdapter.cariquery(Universitas_informatikaDataSet.informasi, "&" & TextBox1.Text & "%")
    End Sub

    Private Sub cari_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_but.Click
        InformasiTableAdapter.cariquery(Universitas_informatikaDataSet.informasi, "&" & TextBox1.Text & "%")
    End Sub
End Class