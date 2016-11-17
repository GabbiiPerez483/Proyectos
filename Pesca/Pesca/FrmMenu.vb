Public Class FrmMenu

    Private Sub mnu_registropesca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_registropesca.Click
        Form1.MdiParent = Me 'No salga de la ventana
        Form1.Show() 'showdialog: Bloquea el form anterior, con show me deja usar el otro
    End Sub

    Private Sub mnu_registropescados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_registropescados.Click
        FrmPescados.Show()
    End Sub

    Private Sub mnu_listadodepesca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_listadodepesca.Click
        FrmList.MdiParent = Me
        FrmList.Show()
    End Sub
End Class