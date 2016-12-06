Public Class barang

    Private Sub Tb_sembakoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tb_sembakoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_sembakoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_penjualanDataSet)

    End Sub

    Private Sub barang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_penjualanDataSet.tb_sembako' table. You can move, or remove it, as needed.
        Me.Tb_sembakoTableAdapter.Fill(Me.Db_penjualanDataSet.tb_sembako)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tb_sembakoBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.Tb_sembakoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_penjualanDataSet)
    End Sub
End Class