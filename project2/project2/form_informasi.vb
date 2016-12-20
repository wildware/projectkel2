Public Class informasi

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_bersamaDataSet.informasi' table. You can move, or remove it, as needed.
        Me.InformasiTableAdapter.Fill(Me.Universitas_bersamaDataSet.informasi)

    End Sub

    Private Sub InformasiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InformasiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_bersamaDataSet)

    End Sub
End Class