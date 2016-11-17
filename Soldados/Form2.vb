Public Class Form2


    Private Function Validar_Loc() As Boolean
        Dim OkLoc As Boolean
        OkLoc = False
        If txt_localidad.Text.Trim <> "" Then
            OkLoc = True
            If txt_cp.Text.Trim <> "" Then
                OkLoc = True
                If cmb_provincia.SelectedValue Then
                    OkLoc = True
                Else
                    MessageBox.Show("Seleccione una Provincia!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Ingrese un Código Postal!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese una Localidad!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return OkLoc
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter("select * from Provincias", Conexion)
        DT = New DataTable
        DA.Fill(DT)
        cmb_provincia.DataSource = DT
        cmb_provincia.ValueMember = "IDProvincia"
        cmb_provincia.DisplayMember = "Provincia"

    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Dim Conexion As SqlClient.SqlConnection
        Dim DALoc As SqlClient.SqlDataAdapter
        Dim CBDLoc As SqlClient.SqlCommandBuilder
        Dim Fila As DataRow
        Dim DTLoc As DataTable

        If Validar_Loc() = True Then
            Conexion = New SqlClient.SqlConnection
            Conexion.ConnectionString = cad_con
            Conexion.Open()

            DALoc = New SqlClient.SqlDataAdapter("select * from Localidades where Localidad = '" & txt_localidad.Text & "' or Cod_Postal = '" & txt_cp.Text & "'", Conexion)
            CBDLoc = New SqlClient.SqlCommandBuilder(DALoc)
            DTLoc = New DataTable
            DALoc.Fill(DTLoc)
            If DTLoc.Rows.Count = 0 Then
                Fila = DTLoc.NewRow()
                Fila("Localidad") = txt_localidad.Text
                Fila("Cod_Postal") = txt_cp.Text
                Fila("IDProvincia") = cmb_provincia.SelectedValue
                DTLoc.Rows.Add(Fila)
                DALoc.Update(DTLoc)
                MessageBox.Show("Carga correcta!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("La Localidad ya existe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txt_localidad.Clear()
        End If
    End Sub
End Class