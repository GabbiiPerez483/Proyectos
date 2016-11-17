Public Class frm_alta_usuario

    Private Function Validar() As Boolean
        Dim Ok As Boolean
        Ok = False
        If txt_apellido.Text.Trim <> "" Then
            Ok = True
            If txt_nombre.Text.Trim <> "" Then
                Ok = True
                If txt_usuario.Text.Trim <> "" Then
                    Ok = True

                    If txt_contraseña.Text.Trim <> "" And txt_contraseña.Text = txt_confirmar.Text Then
                        Ok = True



                    Else
                        MessageBox.Show("No Ingresó un apellido valido", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No ingreso un nombre valido", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Else
                MessageBox.Show("Ingrese un nombre de usuario", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
            MessageBox.Show("Error al ingresar la contraseña", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        



        Return Ok
    End Function




    Private Sub frm_alta_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()


        DA = New SqlClient.SqlDataAdapter("select * from grupos", Conexion)
        DT = New DataTable
        DA.Fill(DT)
        cmb_grupo.DataSource = DT
        cmb_grupo.ValueMember = "IDgrupo"
        cmb_grupo.DisplayMember = "Grupo"


        If operacion_alta = False Then
            Conexion = New SqlClient.SqlConnection()
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            DA = New SqlClient.SqlDataAdapter("select * from usuarios where idusuario=" & id_seleccionado, Conexion)
            DT = New DataTable
            DA.Fill(DT)
            txt_apellido.Text = DT.Rows(0)("Apellido").ToString()
            txt_nombre.Text = DT.Rows(0)("Nombre").ToString()
            txt_usuario.Text = DT.Rows(0)("Usuario").ToString()
            txt_contraseña.Text = DT.Rows(0)("Pass").ToString()
            txt_confirmar.Text = DT.Rows(0)("Pass").ToString()
            txt_contraseña.Enabled = False
            txt_confirmar.Enabled = False
            cmb_grupo.SelectedValue = DT.Rows(0)("Idgrupo").ToString()

        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim CB As SqlClient.SqlCommandBuilder
        Dim Fila As DataRow
        Dim DT As DataTable

        If Validar() = True Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()



            If operacion_alta = True Then



                DA = New SqlClient.SqlDataAdapter("select * from usuarios where usuario = '" & txt_usuario.Text & "'", Conexion)
                CB = New SqlClient.SqlCommandBuilder(DA)
                DT = New DataTable
                DA.Fill(DT)


                If DT.Rows.Count = 0 Then
                    Fila = DT.NewRow()
                    Fila("Apellido") = txt_apellido.Text
                    Fila("Nombre") = txt_nombre.Text
                    Fila("Usuario") = txt_usuario.Text
                    Fila("Pass") = txt_contraseña.Text
                    Fila("Idgrupo") = cmb_grupo.SelectedValue
                    Fila("Logfallidos") = 0
                    Fila("Bloqueado") = False

                    DT.Rows.Add(Fila)
                    DA.Update(DT)
                    MessageBox.Show("Carga correcta!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                    txt_apellido.Text = ""
                    txt_contraseña.Text = ""
                    txt_nombre.Text = ""
                    txt_usuario.Text = ""



                Else
                    MessageBox.Show("El nombre de usuario'" & txt_usuario.Text & "' ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else

                Conexion = New SqlClient.SqlConnection()
                Conexion.ConnectionString = cad_con
                Conexion.Open()

                DT = New DataTable()
                DA = New SqlClient.SqlDataAdapter("select * from usuarios where usuario='" & txt_usuario.Text & "' and idusuario <>" & id_seleccionado, Conexion)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    DA = New SqlClient.SqlDataAdapter("select * from usuarios where idusuario =" & id_seleccionado, Conexion)
                    CB = New SqlClient.SqlCommandBuilder(DA)
                    DT = New DataTable()
                    DA.Fill(DT)
                    DT.Rows(0)("Usuario") = txt_usuario.Text
                    DA.Update(DT)
                    Me.Close()
                Else
                    MessageBox.Show("Ese usuario ya existe")
                End If


            End If

        End If

        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class