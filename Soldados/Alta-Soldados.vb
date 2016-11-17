Public Class frm_altasoldados
    Private EstoyCargando As Boolean

    Private Function Validar() As Boolean  'Mask complete'
        Dim Ok As Boolean
        Ok = False
        If txt_apellido.Text.Trim <> "" Then
            Ok = True
            If txt_nombre.Text.Trim <> "" Then
                Ok = True
                If cmb_provnac.SelectedValue Then
                    Ok = True

                    If cmb_locres.SelectedValue Then
                        Ok = True

                        If msk_legajo.MaskCompleted Then
                            Ok = True

                        Else
                            MessageBox.Show("No Ingresó un apellido valido", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("No ingreso un nombre valido", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Seleccione una localidad", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Seleccione una localidad", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Legajo incorrecto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



        Return Ok
    End Function



    Private Sub frm_altasoldados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable
        EstoyCargando = True
        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter("select * from Provincias", Conexion)
        DT = New DataTable
        DA.Fill(DT)
        cmb_provnac.DataSource = DT
        cmb_provnac.ValueMember = "IDProvincia"
        cmb_provnac.DisplayMember = "Provincia"

        DT = New DataTable
        DA.Fill(DT)
        cmb_provres.DataSource = DT
        cmb_provres.ValueMember = "IDProvincia"
        cmb_provres.DisplayMember = "Provincia"


        EstoyCargando = False
    End Sub

    Private Sub cmb_provnac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_provnac.SelectedIndexChanged

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        If EstoyCargando = False Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            DA = New SqlClient.SqlDataAdapter("select * from Localidades where IDProvincia=" & cmb_provnac.SelectedValue, Conexion)
            DT = New DataTable
            DA.Fill(DT)
            cmb_locnac.DataSource = DT
            cmb_locnac.ValueMember = "IDLocalidad"
            cmb_locnac.DisplayMember = "Localidad"

        End If
    End Sub

    Private Sub cmb_provres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_provres.SelectedIndexChanged


        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        If EstoyCargando = False Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            DA = New SqlClient.SqlDataAdapter("select * from Localidades where IDProvincia=" & cmb_provres.SelectedValue, Conexion)
            DT = New DataTable
            DA.Fill(DT)
            cmb_locres.DataSource = DT
            cmb_locres.ValueMember = "IDLocalidad"
            cmb_locres.DisplayMember = "Localidad"

        End If


    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        Dim Conexion As SqlClient.SqlConnection
        Dim DAsoldado As SqlClient.SqlDataAdapter
        Dim CBDsoldado As SqlClient.SqlCommandBuilder
        Dim Fila As DataRow
        Dim DTsoldado As DataTable

        If Validar() = True Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            DAsoldado = New SqlClient.SqlDataAdapter("select * from Personal where legajo = '" & msk_legajo.Text & "'", Conexion)
            CBDsoldado = New SqlClient.SqlCommandBuilder(DAsoldado)
            DTsoldado = New DataTable
            DAsoldado.Fill(DTsoldado)
            If DTsoldado.Rows.Count = 0 Then
                Fila = DTsoldado.NewRow()
                Fila("Apellido") = txt_apellido.Text
                Fila("Nombre") = txt_nombre.Text
                Fila("IDlocalidadnac") = cmb_locnac.SelectedValue
                Fila("legajo") = msk_legajo.Text
                Fila("fechanac") = dtp_fecha.Value
                Fila("IDlocalidadres") = cmb_locres.SelectedValue
                Fila("direccion") = txt_direccion.Text
                Fila("telefono") = txt_telefono.Text
                Fila("activo") = chk_activo.Checked




                DTsoldado.Rows.Add(Fila)
                DAsoldado.Update(DTsoldado)
                MessageBox.Show("Carga correcta!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                

            Else
                MessageBox.Show("El numero de legajo es existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

        ''BORRAR TODO
        txt_apellido.Clear()
        txt_nombre.Clear()
        msk_legajo.Clear()
        txt_direccion.Clear()
        txt_telefono.Clear()
        chk_activo.Checked = False
        cmb_locnac.SelectedIndex = 0
        cmb_locres.SelectedIndex = 0
        cmb_provnac.SelectedIndex = 0
        cmb_provres.SelectedIndex = 0



    End Sub

   
End Class