Imports System.IO
Public Class Form1

    Private Sub cmb_pez_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_pez.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim archivopeces As FileStream
        Dim leerpeces As StreamReader
        archivopeces = New FileStream("Pescados.txt", FileMode.Open)
        leerpeces = New StreamReader(archivopeces)
        While leerpeces.EndOfStream = False
            cmb_pez.Items.Add(leerpeces.ReadLine)
        End While
        'cmb_pez.Items.Add("Dorado")
        'cmb_pez.Items.Add("Boga")
        cmb_pez.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_pez.SelectedIndex = 0
        rb_mañana.Checked = True
        chk_si.Checked = False
        'lbl_autor.Text = autor
        leerpeces.Close()
        archivopeces.Close()
    End Sub

    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        Dim mensaje As String
        Dim Archivo As FileStream
        Dim Grabar As StreamWriter
        Archivo = New FileStream("Pescas.txt", FileMode.OpenOrCreate)
        If controlar() = True Then
            mensaje = "Pescador:" & txt_pescador.Text & ";" & cmb_pez.Text & ";"
            If rb_mañana.Checked Then
                mensaje = mensaje & "Horario:Mañana"
            ElseIf rb_tarde.Checked Then
                mensaje = mensaje & "Horario:Tarde"
            Else
                mensaje = mensaje & "Horario:Noche"
            End If
            If chk_si.Checked Then
                mensaje = mensaje & ";" & "Devolvió:Si"
            Else
                mensaje = mensaje & ";" & "Devolvió:No"
            End If
            mensaje = mensaje & ";" & "Kg:" & txt_kg.Text & ";" & "Fecha Pesca:" & dtm_fechapesca.Value.ToShortDateString()
            Grabar = New StreamWriter(Archivo)
            Archivo.Seek(Archivo.Length, SeekOrigin.Begin)
            Grabar.WriteLine(mensaje)
            Grabar.Close()
            Archivo.Close()
            '    MessageBox.Show(mensaje, "Resultado de la Pesca", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function controlar() As Boolean
        Dim TodoOk As Boolean = False
        Dim Kg As Single 'Single es float
        If txt_pescador.Text.Trim <> "" Then
            If Single.TryParse(txt_kg.Text, Kg) Then
                TodoOk = True
            Else
                MessageBox.Show("Peso mal ingresado", "Atención datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Debe completar el nombre del pescador", "Atención datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return TodoOk
    End Function

    Private Sub txt_pescador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pescador.TextChanged

    End Sub
End Class
