Public Class frm_ListadoLocalidades

    Private Sub CargarGrilla()

        Dim Conexion As SqlClient.SqlConnection
        Dim DAListLocal As SqlClient.SqlDataAdapter
        Dim DTListLocal As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        If txt_filtrar.Text.Trim = "" Then
            cadena = "select localidades.* ,provincia  from Localidades, provincias where provincias.idprovincia = localidades.idprovincia"
        Else
            cadena = "select localidades.*, provincia from Localidades,provincias where provincias.idprovincia = localidades.idlocalidad and Localidad like '" & txt_filtrar.Text & "%'"
        End If

        SQLfiltrada = "select localidades.*, provincia from Localidades,provincias where provincias.idprovincia = localidades.idlocalidad and Localidad like '" & txt_filtrar.Text & "%'"

        DAListLocal = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DTListLocal = New DataTable
        DAListLocal.Fill(DTListLocal)
        dgv_localidades.DataSource = DTListLocal
        dgv_localidades.Columns("idlocalidad").Visible = False
        dgv_localidades.Columns("idprovincia").Visible = False


    End Sub

    Private Sub frm_ListadoLocalidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarGrilla()

    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        CargarGrilla()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        operacion_alta = True
        Form2.Show()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If dgv_localidades.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar la Localidad a modificar")
            operacion_alta = False

        Else
            id_seleccionado = dgv_localidades.CurrentRow.Cells("idlocalidad").Value
            operacion_alta = False
            Form2.ShowDialog()
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Reporte_local.Show()
    End Sub
End Class