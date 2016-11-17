Public Class frm_altalocalidad

    Private Function validar() As Boolean
        Dim ok As Boolean
        ok = False
        If txt_localidad.Text.Trim <> "" And txt_codpostal.Text.Trim <> "" Then
            ok = True
        Else
            MessageBox.Show("Hay campos vacios")

        End If

        Return ok
    End Function

    Private Sub frm_altalocalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexion As SqlClient.SqlConnection
        Dim sqladap As SqlClient.SqlDataAdapter
        Dim tloc As New DataTable

        If operacion_alta = False Then
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = cad_con
            conexion.Open()

            sqladap = New SqlClient.SqlDataAdapter("select * from localidades where idlocalidad='" & id_seleccionado & "'", conexion)
            sqladap.Fill(tloc)
            txt_localidad.Text = tloc.Rows(0)("localidad").ToString()
            txt_codpostal.Text = tloc.Rows(0)("cod_postal").ToString()




        End If

    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        Dim conexion As SqlClient.SqlConnection
        Dim sqladap As SqlClient.SqlDataAdapter
        Dim cbloc As SqlClient.SqlCommandBuilder
        Dim tloc As New DataTable
        Dim fila As DataRow




        If validar() = True Then



            If operacion_alta = True Then



                conexion = New SqlClient.SqlConnection()
                conexion.ConnectionString = cad_con
                conexion.Open()

                sqladap = New SqlClient.SqlDataAdapter("select * from localidades where localidad='" & txt_localidad.Text & "'", conexion)
                cbloc = New SqlClient.SqlCommandBuilder(sqladap)

                tloc = New DataTable()
                sqladap.Fill(tloc)


                If tloc.Rows.Count = 0 Then

                    ' Parte que graba
                    fila = tloc.NewRow()
                    fila("localidad") = txt_localidad.Text
                    fila("cod_postal") = txt_codpostal.Text

                    tloc.Rows.Add(fila)
                    sqladap.Update(tloc)
                    txt_localidad.Text = ""
                Else
                    MessageBox.Show("Error al cargar la Localidad, ya existe el registro")
                    txt_localidad.Text = ""

                End If

            Else
                conexion = New SqlClient.SqlConnection()
                conexion.ConnectionString = cad_con
                conexion.Open()

                sqladap = New SqlClient.SqlDataAdapter("select * from localidades where localidad='" & txt_localidad.Text & "' and idlocalidad <>" & id_seleccionado, conexion)
                sqladap.Fill(tloc)

                If tloc.Rows.Count = 0 Then
                    sqladap = New SqlClient.SqlDataAdapter("select * from localidades where idlocalidad =" & id_seleccionado, conexion)
                    cbloc = New SqlClient.SqlCommandBuilder(sqladap)
                    tloc = New DataTable()
                    sqladap.Fill(tloc)
                    tloc.Rows(0)("localidad") = txt_localidad.Text
                    sqladap.Update(tloc)
                    Me.Close()
                Else
                    MessageBox.Show("Esa Localidad ya existe")
                End If


            End If

        End If

    End Sub
End Class