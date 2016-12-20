Public Class form_mahasiswa

    Private Sub MahasiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_bersamaDataSet)

    End Sub

    Private Sub mahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_bersamaDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.Universitas_bersamaDataSet.mahasiswa)

    End Sub
End Class