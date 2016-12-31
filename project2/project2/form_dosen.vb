Public Class Form_dosen

    Private Sub DosenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DosenBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DosenBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_dosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Universitas_informatikaDataSet.dosen)
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

        Id_dosenTextBox.Enabled = True
        Nama_dosenTextBox.Enabled = True
        Email_dosenTextBox.Enabled = True
        User_nameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Link_fbTextBox.Enabled = True
        WibsiteTextBox.Enabled = True

        DosenBindingSource.AddNew()
    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_dosenTextBox.Enabled = True
        Nama_dosenTextBox.Enabled = True
        Email_dosenTextBox.Enabled = True
        User_nameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Link_fbTextBox.Enabled = True
        WibsiteTextBox.Enabled = True
    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click
        If MessageBox.Show("Delete data ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DosenBindingSource.RemoveCurrent()

            Me.Validate()
            Me.DosenBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

            MessageBox.Show("Data Was Deleted !")
        End If
    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

        MessageBox.Show("Data has been saved")

        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False

        Id_dosenTextBox.Enabled = True
        Nama_dosenTextBox.Enabled = True
        Email_dosenTextBox.Enabled = True
        User_nameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Link_fbTextBox.Enabled = True
        WibsiteTextBox.Enabled = True
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False

        DosenBindingSource.CancelEdit()
    End Sub

    Private Sub refresh_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_butt.Click
        Me.DosenTableAdapter.Fill(Me.Universitas_informatikaDataSet.dosen)
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DosenBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DosenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub exit_butt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_butt.Click
        Me.Close()
    End Sub
End Class