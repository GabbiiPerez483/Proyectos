Imports System.IO
Public Class FrmList

    Private Sub FrmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim archivopeces As FileStream
        Dim leerpeces As StreamReader
        archivopeces = New FileStream("Pescados.txt", FileMode.Open)
        leerpeces = New StreamReader(archivopeces)
        While leerpeces.EndOfStream = False
            cmb_buscartipopez.Items.Add(leerpeces.ReadLine)
        End While
        cmb_buscartipopez.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_buscartipopez.SelectedIndex = 0
        leerpeces.Close()
        archivopeces.Close()


        Dim Archivo As FileStream
        Dim Leer As StreamReader
        Dim cadena As String
        Dim Vector(6) As String
        Archivo = New FileStream("Pescas.txt", FileMode.Open)
        Leer = New StreamReader(Archivo)
        lv_clientes.View = View.Details
        lv_clientes.Columns.Add("Nombre")
        lv_clientes.Columns.Add("Tipo de Pez")
        lv_clientes.Columns.Add("Horario")
        lv_clientes.Columns.Add("Devolvió")
        lv_clientes.Columns.Add("Kg.")
        lv_clientes.Columns.Add("Fecha de Pesca")
        While Leer.EndOfStream = False
            cadena = Leer.ReadLine()
            Vector = cadena.Split(";")
            lv_clientes.Items.Add(Vector(0))
            lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(1))
            lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(2))
            lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(3))
            lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(4))
            lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(5))
        End While
        Leer.Close()
        Archivo.Close()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        Dim Archivo As FileStream
        Dim Leer As StreamReader
        Dim cadena As String
        Dim Vector(6) As String
        Archivo = New FileStream("Pescas.txt", FileMode.Open)
        Leer = New StreamReader(Archivo)
        lv_clientes.Clear()
        lv_clientes.View = View.Details
        lv_clientes.Columns.Add("Nombre")
        lv_clientes.Columns.Add("Tipo de Pez")
        lv_clientes.Columns.Add("Horario")
        lv_clientes.Columns.Add("Devolvió")
        lv_clientes.Columns.Add("Kg.")
        lv_clientes.Columns.Add("Fecha de Pesca")
        While Leer.EndOfStream = False
            cadena = Leer.ReadLine()
            Vector = cadena.Split(";")
            If Vector(1) = cmb_buscartipopez.Text Then
                lv_clientes.Items.Add(Vector(0))
                lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(1))
                lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(2))
                lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(3))
                lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(4))
                lv_clientes.Items(lv_clientes.Items.Count - 1).SubItems.Add(Vector(5))
            End If
        End While
        Leer.Close()
        Archivo.Close()
    End Sub
End Class