Public Class frm_menu

    Private Sub ProvinciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvinciasToolStripMenuItem.Click

    End Sub

    Private Sub ProvinciasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvinciasToolStripMenuItem1.Click
        Form1.Show()
    End Sub

    Private Sub AgregarLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarLocalidadesToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub ListadoProvinciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoProvinciasToolStripMenuItem.Click
        frm_ListadoProvincias.MdiParent = Me
        frm_ListadoProvincias.Show()
    End Sub

    Private Sub ListadoLocalidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoLocalidadesToolStripMenuItem.Click
        frm_ListadoLocalidades.MdiParent = Me
        frm_ListadoLocalidades.Show()
    End Sub

    Private Sub AltaSoldadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaSoldadoToolStripMenuItem.Click
        frm_altasoldados.MdiParent = Me
        frm_altasoldados.Show()

    End Sub

    Private Sub SoldadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoldadosToolStripMenuItem.Click
        Frm_soldados.MdiParent = Me
        Frm_soldados.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        frm_usuarios.Show()
    End Sub
End Class