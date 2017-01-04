Public Class Form_view_nilai

    Private Sub Form_view_nilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.nilai' table. You can move, or remove it, as needed.
        Me.NilaiTableAdapter.Fill(Me.Universitas_informatikaDataSet.nilai)

    End Sub

    Private Sub NilaiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NilaiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub cari_but_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cari_but.Click
        NilaiTableAdapter.carinilai(Universitas_informatikaDataSet.nilai, "%" & box_cari.Text & "%")
    End Sub
End Class