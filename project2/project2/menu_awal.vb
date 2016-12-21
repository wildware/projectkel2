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
End Class
