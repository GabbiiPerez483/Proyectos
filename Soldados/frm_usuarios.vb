Public Class frm_usuarios

    Private Sub CargarGrilla()
        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        If txt_filtrar.Text.Trim = "" Then
            cadena = "select usuarios.*, grupo from usuarios,grupos where usuarios.idgrupo = grupos.idgrupo"
        Else
            cadena = "select usuarios.*, grupo from usuarios,grupos where usuarios.idgrupo = grupos.idgrupo and apellido like '" & txt_filtrar.Text & "'"
        End If


        DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        dgv_usuarios.DataSource = DT
        dgv_usuarios.Columns("idusuario").Visible = False
        dgv_usuarios.Columns("idgrupo").Visible = False

    End Sub

    Private Sub frm_usuarios_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub



    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        CargarGrilla()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        operacion_alta = True
        frm_alta_usuario.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        If dgv_usuarios.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar el usuario a modificar")
            operacion_alta = False
        Else
            id_seleccionado = dgv_usuarios.CurrentRow.Cells("idusuario").Value
            frm_alta_usuario.Show()
            operacion_alta = False
        End If

    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        If dgv_usuarios.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un usuario")

        Else
            id_seleccionado = dgv_usuarios.CurrentRow.Cells("idusuario").Value
            frm_cambiar_cont_admin.Show()

        End If
    End Sub

    
    
    Private Sub CambiarContraseñaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem1.Click
        frm_cambiar_cont_usuario.Show()
    End Sub
End Class