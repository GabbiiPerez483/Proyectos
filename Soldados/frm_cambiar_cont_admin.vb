Public Class frm_cambiar_cont_admin

    Private Sub frm_cambiar_cont_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter("select * from usuarios where idusuario = " & id_seleccionado, Conexion)
        DT = New DataTable
        DA.Fill(DT)

        lbl_usuario.Text = DT.Rows(0)("Usuario").ToString



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim CB As SqlClient.SqlCommandBuilder
        Dim DT As DataTable

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()

        DA = New SqlClient.SqlDataAdapter("select * from usuarios where idusuario = " & id_seleccionado, Conexion)
        CB = New SqlClient.SqlCommandBuilder(DA)
        DT = New DataTable
        DA.Fill(DT)


        If (txt_contaseña.Text.Length >= 8 And txt_contaseña.Text = txt_confirmar.Text) Then

            DT.Rows(0)("Pass") = txt_contaseña.Text
            MessageBox.Show("La contraseña se cambio con exito")
            DA.Update(DT)

        Else
            MessageBox.Show("Contraseña invalida")
        End If



    End Sub
End Class