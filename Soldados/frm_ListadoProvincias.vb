Imports System.IO
Public Class frm_ListadoProvincias

    Private Sub CargarGrilla()
        Dim Conexion As SqlClient.SqlConnection
        Dim DAListProv As SqlClient.SqlDataAdapter
        Dim DTListProv As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        If txt_filtrar.Text.Trim = "" Then
            cadena = "select * from Provincias"
        Else
            cadena = "select * from Provincias where Provincia like '" & txt_filtrar.Text & "%'"
        End If

        DAListProv = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DTListProv = New DataTable
        DAListProv.Fill(DTListProv)
        dgv_prov.DataSource = DTListProv



    End Sub



    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        CargarGrilla()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_alta.Click
        operacion_alta = True
        Form1.Show()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click


        If dgv_prov.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar la provincia a modificar")
            operacion_alta = False
        Else
            id_seleccionado = dgv_prov.CurrentRow.Cells("idprovincia").Value
            operacion_alta = False
            Form1.ShowDialog()
        End If
    End Sub

    Private Sub frm_ListadoProvincias_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        CargarGrilla()
    End Sub


   


    Private Sub AltaDeProvinciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeProvinciaToolStripMenuItem.Click
        operacion_alta = True
        Form1.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        If dgv_prov.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar la provincia a modificar")
            operacion_alta = False
        Else
            id_seleccionado = dgv_prov.CurrentRow.Cells("idprovincia").Value
            operacion_alta = False
            Form1.ShowDialog()
        End If
    End Sub

    Private Sub ExportarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarToolStripMenuItem.Click

        Dim cadena As String
        Dim archivo As FileStream
        Dim streamgrabar As StreamWriter

        SaveFileDialog1.Filter = "Archivo de texto (*.txt)|*.txt"
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.InitialDirectory = Application.StartupPath
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            archivo = New FileStream(SaveFileDialog1.FileName, FileMode.Append)
            streamgrabar = New StreamWriter(archivo)
            pb_exportar.Minimum = 0
            pb_exportar.Maximum = dgv_prov.RowCount
            pb_exportar.Value = 0
            pb_exportar.Visible = True

            For f As Integer = 0 To dgv_prov.RowCount - 1

                cadena = dgv_prov.Rows(f).Cells("IDProvincia").Value
                cadena = cadena & ";" & dgv_prov.Rows(f).Cells("Provincia").Value


                streamgrabar.WriteLine(cadena)
                pb_exportar.Value = pb_exportar.Value + 1

                If pb_exportar.Value = pb_exportar.Maximum Then
                    MessageBox.Show("El Archivo se grabó con exito")
                End If


            Next
            streamgrabar.Close()
            archivo.Close()
        End If

    End Sub

    
    
    
    
    Private Sub frm_ListadoProvincias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class