Imports System.IO
Public Class FrmPescados
    Private Function control() As Boolean
        Dim TodoOk As Boolean = False
        If txt_altapescados.Text.Trim <> "" Then
            TodoOk = True
        Else
            MessageBox.Show("Espacio sin completar!!", "Atención datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return TodoOk
    End Function
    Private Sub txt_altapescados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_altapescados.TextChanged

    End Sub

    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        Dim existe As Boolean = False
        Dim ArchivoPescados As FileStream
        Dim Grabar As StreamWriter
        Dim Revisar As StreamReader
        Dim nuevo As String

        If control() = True Then
            If File.Exists("Pescados.txt") = True Then
                ArchivoPescados = New FileStream("Pescados.txt", FileMode.Open)
                Revisar = New StreamReader(ArchivoPescados)
                While Revisar.EndOfStream = False
                    nuevo = Revisar.ReadLine()
                    If nuevo = txt_altapescados.Text Then
                        existe = True
                    End If
                End While
                Revisar.Close()
                ArchivoPescados.Close()
            End If
            If existe = False Then
                ArchivoPescados = New FileStream("Pescados.txt", FileMode.Append)
                Grabar = New StreamWriter(ArchivoPescados)
                Grabar.WriteLine(txt_altapescados.Text)
                Grabar.Close()
                ArchivoPescados.Close()
            Else
                MessageBox.Show("El tipo de pez que desea ingresar ya se encuentra registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class