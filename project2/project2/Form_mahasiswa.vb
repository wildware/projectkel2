﻿Public Class Form_mahasiswa

    Private Sub MahasiswaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Form_mahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.Universitas_informatikaDataSet.mahasiswa)
        'TODO: This line of code loads data into the 'Universitas_informatikaDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.Universitas_informatikaDataSet.mahasiswa)

    End Sub

    Private Sub add_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_mahasiswaTextBox.Enabled = True
        UsernameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Nama_mahasiswaTextBox.Enabled = True
        Nim_mahasiswaTextBox.Enabled = True
        Tgl_lahir_mhsDateTimePicker.Enabled = True
        Email_mhsTextBox.Enabled = True
        Alamat_mhsTextBox.Enabled = True
        Notelp_mhsTextBox.Enabled = True

        MahasiswaBindingSource.AddNew()
    End Sub

    Private Sub edit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit_butt.Click
        add_butt.Enabled = False
        delete_butt.Enabled = False
        edit_butt.Enabled = False
        save_butt.Enabled = True
        refresh_butt.Enabled = False
        cancel_butt.Enabled = True

        Id_mahasiswaTextBox.Enabled = True
        UsernameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Nama_mahasiswaTextBox.Enabled = True
        Nim_mahasiswaTextBox.Enabled = True
        Tgl_lahir_mhsDateTimePicker.Enabled = True
        Email_mhsTextBox.Enabled = True
        Alamat_mhsTextBox.Enabled = True
        Notelp_mhsTextBox.Enabled = True

    End Sub

    Private Sub delete_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_butt.Click
        If MessageBox.Show("Delete data ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MahasiswaBindingSource.RemoveCurrent()

            Me.Validate()
            Me.MahasiswaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

            MessageBox.Show("Data Was Deleted !")
        End If
    End Sub

    Private Sub save_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_butt.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

        MessageBox.Show("Data has been saved")

        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False

        Id_mahasiswaTextBox.Enabled = True
        UsernameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Nama_mahasiswaTextBox.Enabled = True
        Nim_mahasiswaTextBox.Enabled = True
        Tgl_lahir_mhsDateTimePicker.Enabled = True
        Email_mhsTextBox.Enabled = True
        Alamat_mhsTextBox.Enabled = True
        Notelp_mhsTextBox.Enabled = True
    End Sub

    Private Sub cancel_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_butt.Click
        add_butt.Enabled = True
        delete_butt.Enabled = True
        edit_butt.Enabled = True
        save_butt.Enabled = False
        refresh_butt.Enabled = True
        cancel_butt.Enabled = False

        Id_mahasiswaTextBox.Enabled = True
        UsernameTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        Nama_mahasiswaTextBox.Enabled = True
        Nim_mahasiswaTextBox.Enabled = True
        Tgl_lahir_mhsDateTimePicker.Enabled = True
        Email_mhsTextBox.Enabled = True
        Alamat_mhsTextBox.Enabled = True
        Notelp_mhsTextBox.Enabled = True

        MahasiswaBindingSource.CancelEdit()
    End Sub

    Private Sub exit_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub refresh_butt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_butt.Click
        Me.MahasiswaTableAdapter.Fill(Me.Universitas_informatikaDataSet.mahasiswa)
    End Sub

    Private Sub MahasiswaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Universitas_informatikaDataSet)

    End Sub

    Private Sub Notelp_mhsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notelp_mhsTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MahasiswaTableAdapter.carimahasiswa(Universitas_informatikaDataSet.mahasiswa, "%" & TextBox1.Text & "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class