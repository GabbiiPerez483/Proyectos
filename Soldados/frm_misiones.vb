Public Class frm_misiones
    Private cargandocombo As Boolean
    Private Function Validar() As Boolean  'Mask complete'

        Dim i As Integer
        Dim selected As Boolean
        selected = False
        For i = 0 To chk_habilidades.Items.Count - 1
            If (chk_habilidades.GetItemChecked(i)) Then
                selected = True
            End If
        Next

        Return selected


    End Function

    Private Sub frm_misiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable
        Dim cadena As String


        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()


        cadena = "select habilidad from Habilidades inner join PersonalHabilidad on Habilidades.IDhabilidad = PersonalHabilidad.IDhabilidad where idpersonal = " & Frm_soldados.dgv_soldados.CurrentRow.Cells("idpersonal").Value

        ' CARGAR CHK
        cadena = "select PersonalHabilidad.idhabilidad, habilidad from Habilidades inner join PersonalHabilidad on Habilidades.IDhabilidad = PersonalHabilidad.IDhabilidad where idpersonal = " & Frm_soldados.dgv_soldados.CurrentRow.Cells("idpersonal").Value
        DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        chk_habilidades.DataSource = DT
        chk_habilidades.ValueMember = "IDhabilidad"
        chk_habilidades.DisplayMember = "habilidad"

        'CARGAR COMBO
        cargandocombo = True
        DA = New SqlClient.SqlDataAdapter("select * from misiones", Conexion)
        DT = New DataTable
        DA.Fill(DT)
        cmb_mision.DataSource = DT
        cmb_mision.ValueMember = "IDmision"
        cmb_mision.DisplayMember = "Mision"
        cargandocombo = False

        DA = New SqlClient.SqlDataAdapter("select * from personal where idpersonal=" & id_seleccionado, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        lbl_legajo.Text = DT.Rows(0)("legajo").ToString()
        lbl_nombre.Text = DT.Rows(0)("apellido").ToString()

        SeleccionarHabilidades()

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim CB As SqlClient.SqlCommandBuilder
        Dim Fila As DataRow
        Dim DT As DataTable
        Dim item As DataRowView

        If Validar() = True Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            For i = 0 To chk_habilidades.Items.Count - 1
                item = CType(chk_habilidades.Items(i), DataRowView)
                DA = New SqlClient.SqlDataAdapter("select * from PersonalMisiones where IDmision = " & cmb_mision.SelectedValue & " and IDpersonal=" & id_seleccionado & " and IDhabilidad = " & item("idhabilidad"), Conexion)
                CB = New SqlClient.SqlCommandBuilder(DA)
                DT = New DataTable
                DA.Fill(DT)

                If chk_habilidades.GetItemChecked(i) Then    
                    If DT.Rows.Count = 0 Then
                        Fila = DT.NewRow()
                        Fila("IDmision") = cmb_mision.SelectedValue
                        Fila("IDpersonal") = id_seleccionado
                        Fila("IDhabilidad") = item("idhabilidad")
                        DT.Rows.Add(Fila)
                        DA.Update(DT)
                        MessageBox.Show("Mision Asignada Correctamente")

                    End If
                Else
                    If DT.Rows.Count = 1 Then
                        DT.Rows(0).Delete()
                        DA.Update(DT)
                        MessageBox.Show("La mision se canceló")
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub SeleccionarHabilidades()
        Dim cadena As String
        Dim Conexion As SqlClient.SqlConnection
        Dim da As SqlClient.SqlDataAdapter
        Dim dt As DataTable
        Dim encontrado As Boolean
        Dim k As Integer
        Dim item As DataRowView

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        cadena = "select * from Personalmisiones where idpersonal = " & id_seleccionado & " and idmision = " & cmb_mision.SelectedValue
        DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
        DT = New DataTable
        da.Fill(dt)

        For i = 0 To chk_habilidades.Items.Count - 1
            chk_habilidades.SetItemChecked(i, False)
        Next

        For i = 0 To dt.Rows.Count - 1
            encontrado = False
            K = 0
            While k < chk_habilidades.Items.Count And encontrado = False
                item = CType(chk_habilidades.Items(k), DataRowView)
                If item("idhabilidad") = dt.Rows(i)("idhabilidad") Then
                    chk_habilidades.SetItemChecked(k, True)
                    encontrado = True
                End If
                k = k + 1
            End While
        Next

    End Sub
    Private Sub cmb_mision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mision.SelectedIndexChanged
        If cargandocombo = False Then
            SeleccionarHabilidades()
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class