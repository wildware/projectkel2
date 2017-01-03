Public Class menu_awal
    Dim image(7) As Bitmap
    Dim ImageNum As Integer = 1

    Dim tulisan(2) As String
    Dim i, j As Integer

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
            MsgBox("Welcome Admin", MsgBoxStyle.Information)
            GroupBox1.Visible = False
            MenuStrip1.Visible = True
            GroupBox2.Visible = True
            Button2.Visible = False
            Lab_dat.Visible = True
            Lab_wel.Visible = False
            Button3.Visible = True
        ElseIf box_user.Text = "arie" And box_pass.Text = "2102" Then
            Timer1.Stop()
            MsgBox("Welcome Admin", MsgBoxStyle.Information)
            GroupBox1.Visible = False
            MenuStrip1.Visible = True
            GroupBox2.Visible = True
            Button2.Visible = False
            Lab_dat.Visible = True
            Lab_wel.Visible = False
            Button3.Visible = True
        Else
            Timer1.Stop()
            MsgBox("Login Failed", MsgBoxStyle.Critical)
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
        Form_mata_kuliah.ShowDialog()
    End Sub

    Private Sub NilaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiToolStripMenuItem.Click

    End Sub

    Private Sub PesertaMKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesertaMKToolStripMenuItem.Click

    End Sub

    Private Sub But_ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_ref.Click
        box_user.Text = ""
        box_pass.Text = ""
    End Sub

    Private Sub AddAndAditDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_informasi.ShowDialog()
    End Sub

    Private Sub ViewDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MasterDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterDataToolStripMenuItem.Click

    End Sub

    Private Sub AddAndEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_dosen.ShowDialog()
    End Sub

    Private Sub ViewAndSeacrhToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer2.Enabled = True
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Picbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picbox.Click
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ImageNum = ImageNum + 1
        If ImageNum > 7 Then ImageNum = 1

        Select Case ImageNum
            Case 1
                Picbox.Image = My.Resources.a1
            Case 2
                Picbox.Image = My.Resources.a2
            Case 3
                Picbox.Image = My.Resources.a3
            Case 4
                Picbox.Image = My.Resources.a4
            Case 5
                Picbox.Image = My.Resources.a5
            Case 6
                Picbox.Image = My.Resources.a6
        End Select
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Call Button1_Click(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Apakah anda yakin keluar?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        End If
        Lab_wel.Visible = True
        GroupBox2.Visible = True
        Button2.Visible = True
        MenuStrip1.Visible = False
        Button3.Visible = False
        Lab_dat.Visible = False
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub menu_awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tulisan(0) = "Aplikasi ini dibuat untuk mempermudah pegawai kampus untuk menyimpan data Universitas                              "
        tulisan(1) = "Created by : Arie Syarwani , Fazri Rahmad Risky , Hanafi Kambivi , Putri Yus Andayani                              "
        tulisan(2) = "Ver.001                              "
        Label1.Text = tulisan(j)
        timer_text_berjalan.Start()
    End Sub

    Private Sub timer_text_berjalan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_text_berjalan.Tick
        If i.Equals(tulisan(j).Length) Then
            Me.Label1.Text = ""
            If j < tulisan.Length - 1 Then
                j = j + 1
            Else
                j = 0
            End If
            i = 0
        End If
        Label1.Text = tulisan(j).Substring(0, i)
        i = i + 1
    End Sub

    Private Sub ViewAndSearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAndSearchToolStripMenuItem.Click
        Form_view_nilai.ShowDialog()
    End Sub

    Private Sub AddAndEditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAndEditToolStripMenuItem1.Click
        Form_nilai.ShowDialog()
    End Sub
End Class
