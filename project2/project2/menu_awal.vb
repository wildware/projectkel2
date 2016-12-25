Public Class menu_awal

    Private Sub box_user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles box_user.TextChanged

    End Sub

    Private Sub but_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_exit.Click
        End
    End Sub

    Private Sub but_log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_log.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If box_user.Text = "admin" And box_pass.Text = "1234" Then
            Timer1.Stop()
            MsgBox("Selamat Datang", MsgBoxStyle.Information)
            GroupBox1.Visible = False
            MenuStrip1.Visible = True
        Else
            Timer1.Stop()
            MsgBox("Login Gagal", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DosenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenToolStripMenuItem.Click
        Form_dosen.ShowDialog()
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaToolStripMenuItem.Click
        Form_mahasiswa.ShowDialog()
    End Sub

    Private Sub InformasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiToolStripMenuItem.Click
        Form_informasi.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MataKuliahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MataKuliahToolStripMenuItem.Click

    End Sub

    Private Sub NilaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiToolStripMenuItem.Click

    End Sub

    Private Sub PesertaMKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesertaMKToolStripMenuItem.Click

    End Sub

    Private Sub But_ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ref.Click
        box_user.Text = ""
        box_pass.Text = ""
    End Sub
End Class
