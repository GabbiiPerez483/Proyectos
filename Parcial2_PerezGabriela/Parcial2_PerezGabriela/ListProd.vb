Public Class ListProd
    Public Sub CargarGrilla()
        Dim DA As SqlClient.SqlDataAdapter
        Dim Conexion As SqlClient.SqlConnection
        Dim DT As DataTable
        Dim cadena As String

        'Conexion = New SqlClient.SqlConnection(cadcon)
        'Conexion.ConnectionString = cadcon
        'Conexion.Open()

        If txt_nomb_prod.Text = "" Then
            cadena = ("select * from Productos, TipoDeProducto where Productos.IdTipoDeProducto = TipoDeProducto.IdTipoDeProducto")
        Else
            cadena = ("select * from TipoDeProducto where TipoDeProducto = '" & txt_nomb_prod.Text)
        End If

        'DA = New SqlClient.SqlDataAdapter(cadena, Conexion)
        'DT = New DataTable
        'DA.Fill(DT)
        'dgv_prod.DataSource = DT

    End Sub
    Private Sub ListProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_sucursal.Items.Add("Todas")
        cmb_sucursal.Items.Add("San Nicolas")
        cmb_sucursal.Items.Add("Tigre")
        cmb_sucursal.Items.Add("Ramallo")
        cmb_sucursal.Items.Add("Pergamino")
        cmb_sucursal.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_sucursal.SelectedIndex = 0
        CargarGrilla()
    End Sub

    Private Sub dgv_mov_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_mov.CellContentClick
        CargarMov()
    End Sub

    Private Sub btn_filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_filtrar.Click
        CargarGrilla()
    End Sub

    Private Sub CargarMov()
        Dim conexion As SqlClient.SqlConnection
        Dim DAmov As SqlClient.SqlDataAdapter
        Dim DTmov As DataTable
        Dim cadena As String

        conexion = New SqlClient.SqlConnection
        conexion.ConnectionString = cadcon
        conexion.Open()

        cadena = "select * from "

        DAmov = New SqlClient.SqlDataAdapter(cadena, conexion)
        DTmov = New DataTable
        DAmov.Fill(DTmov)
        dgv_mov.DataSource = DTmov

    End Sub
End Class