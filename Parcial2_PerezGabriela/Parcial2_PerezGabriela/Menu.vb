Public Class Menu

    
    Private Sub ListadoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        ListProd.MdiParent = Me
        ListProd.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class