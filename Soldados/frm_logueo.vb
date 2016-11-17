Imports System.IO
Public Class frm_logueo

    Public Function Validar() As Boolean
        Dim Ok As Boolean
        Dim reg As System.Text.RegularExpressions.Regex

        Ok = False
        If txt_usuario.Text.Trim <> "" Then
            Ok = True
            If reg.IsMatch(txt_usuario.Text, "[a-zA-Z]") Then
                Ok = True
            Else
                MessageBox.Show("Error al ingresar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If
        End If
        Return Ok
    End Function

    Private Sub frm_logueo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim CB As SqlClient.SqlCommandBuilder
        Dim Fila As DataRow
        Dim DT As DataTable
        Dim cadena As String

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()



        If Validar() = True Then


            cadena = "select * from usuarios where usuarios.Usuario = '" & txt_usuario.Text & "'"

            DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
            DT = New DataTable

            CB = New SqlClient.SqlCommandBuilder(DA)

            DA.Fill(DT)

            If DT.Rows.Count = 1 Then


                If DT.Rows(0)("Logfallidos") >= 3 Then

                    MessageBox.Show("Su cuenta se encuentra bloqueada, pongase en contacto con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                Else

                    If DT.Rows(0)("pass").ToString() = txt_clave.Text.ToString Then


                        DT.Rows(0)("Logfallidos") = 0
                        DA.Update(DT)
                        frm_menu.Show()
                        Me.Visible = False

                    Else

                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DT.Rows(0)("Logfallidos") = DT.Rows(0)("Logfallidos") + 1
                        txt_clave.Clear()
                        DA.Update(DT)

                    End If
                End If
            Else
                MessageBox.Show("El usuario no existe", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_usuario.Clear()
                txt_clave.Clear()
            End If
        End If

        usuario_log = txt_usuario.Text
    End Sub

    Private Sub txt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_modificar.Click
        frm_cambiar_cont_usuario.Show()
        Me.Visible = False
    End Sub
End Class