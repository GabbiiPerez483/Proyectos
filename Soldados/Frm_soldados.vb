Imports System.IO
Public Class Frm_soldados

    Private Sub CargarGrilla()
        Dim Conexion As SqlClient.SqlConnection
        Dim DAListProv As SqlClient.SqlDataAdapter
        Dim DTListProv As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        If txt_filtrar.Text.Trim = "" Then
            cadena = "select *,localidad  from personal, localidades where idlocalidadres = idlocalidad order by apellido"
        Else
            cadena = "select *,localidad  from personal, localidades where idlocalidadres = idlocalidad and apellido=" & txt_filtrar.Text & "%'"
        End If

        DAListProv = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DTListProv = New DataTable
        DAListProv.Fill(DTListProv)
        dgv_soldados.DataSource = DTListProv
        dgv_soldados.Columns("idpersonal").Visible = False
        dgv_soldados.Columns("idlocalidadnac").Visible = False
        dgv_soldados.Columns("idlocalidadres").Visible = False
        dgv_soldados.Columns("idlocalidad").Visible = False



    End Sub

    Private Sub Frm_soldados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrilla()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        CargarGrilla()
    End Sub

    Private Sub dgv_soldados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_soldados.CellContentClick

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        
        cadena = "select habilidad from Habilidades inner join PersonalHabilidad on Habilidades.IDhabilidad = PersonalHabilidad.IDhabilidad where idpersonal = " & dgv_soldados.CurrentRow.Cells("idpersonal").Value
        DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        dgv_habilidades.DataSource = DT


        



    End Sub

   
    
    
    

    
    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If dgv_soldados.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un soldado")

        Else
            id_seleccionado = dgv_soldados.CurrentRow.Cells("idpersonal").Value
            frm_misiones.Show()
        End If
    End Sub
End Class