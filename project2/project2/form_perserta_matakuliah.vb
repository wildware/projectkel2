Public Class perserta_matakuliah

    Private Sub Peserta_mkBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Peserta_mkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Peserta_mkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_bersamaDataSet)

    End Sub

    Private Sub perserta_matakuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_bersamaDataSet.peserta_mk' table. You can move, or remove it, as needed.
        Me.Peserta_mkTableAdapter.Fill(Me.Universitas_bersamaDataSet.peserta_mk)

    End Sub
End Class