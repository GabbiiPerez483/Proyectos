Public Class Form1

    Private Function validar() As Boolean
        Dim ok As Boolean
        ok = False
        If txt_provincia.Text.Trim <> "" Then
            ok = True
        Else
            MessageBox.Show("El campo esta vacio")

        End If

        Return ok
    End Function



    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        Dim conexion As SqlClient.SqlConnection
        Dim sqladap As SqlClient.SqlDataAdapter
        Dim cbprov As SqlClient.SqlCommandBuilder
        Dim tprov As New DataTable
        Dim fila As DataRow



        If validar() = True Then



            If operacion_alta = True Then



                conexion = New SqlClient.SqlConnection()
                conexion.ConnectionString = cad_con
                conexion.Open()

                sqladap = New SqlClient.SqlDataAdapter("select * from provincias where provincia='" & txt_provincia.Text & "'", conexion)
                cbprov = New SqlClient.SqlCommandBuilder(sqladap)

                tprov = New DataTable()
                sqladap.Fill(tprov)


                If tprov.Rows.Count = 0 Then

                    ' Parte que graba
                    fila = tprov.NewRow()
                    fila("provincia") = txt_provincia.Text
                    tprov.Rows.Add(fila)
                    sqladap.Update(tprov)
                    txt_provincia.Text = ""
                Else
                    MessageBox.Show("Error al cargar la provincia, ya existe el registro")
                    txt_provincia.Text = ""

                End If

            Else
                conexion = New SqlClient.SqlConnection()
                conexion.ConnectionString = cad_con
                conexion.Open()

                sqladap = New SqlClient.SqlDataAdapter("select * from provincias where provincia='" & txt_provincia.Text & "' and idprovincia <>" & id_seleccionado, conexion)
                sqladap.Fill(tprov)

                If tprov.Rows.Count = 0 Then
                    sqladap = New SqlClient.SqlDataAdapter("select * from provincias where idprovincia =" & id_seleccionado, conexion)
                    cbprov = New SqlClient.SqlCommandBuilder(sqladap)
                    tprov = New DataTable()
                    sqladap.Fill(tprov)
                    tprov.Rows(0)("provincia") = txt_provincia.Text
                    sqladap.Update(tprov)
                    Me.Close()
                Else
                    MessageBox.Show("Esa provincia ya existe")
                End If


            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexion As SqlClient.SqlConnection
        Dim sqladap As SqlClient.SqlDataAdapter
        Dim tprov As New DataTable



        If operacion_alta = False Then
            conexion = New SqlClient.SqlConnection()
            conexion.ConnectionString = cad_con
            conexion.Open()

            sqladap = New SqlClient.SqlDataAdapter("select * from provincias where idprovincia='" & id_seleccionado & "'", conexion)

            sqladap.Fill(tprov)
            txt_provincia.Text = tprov.Rows(0)("provincia").ToString()


        End If


    End Sub
End Class
