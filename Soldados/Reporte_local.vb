Public Class Reporte_local

    Private Sub Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Conexion As SqlClient.SqlConnection
        Dim DA As SqlClient.SqlDataAdapter
        Dim DT As DataTable
        Dim lista As New List(Of Microsoft.Reporting.WinForms.ReportParameter)()

        Conexion = New SqlClient.SqlConnection
        Conexion.ConnectionString = cad_con
        Conexion.Open()
        '"SELECT * FROM vista_localidades"
        DA = New SqlClient.SqlDataAdapter(SQLfiltrada, Conexion)
        DT = New DataTable
        DA.Fill(DT)
        lista.Add(New Microsoft.Reporting.WinForms.ReportParameter("Nombre", usuario_log))
        ReportViewer1.LocalReport.ReportPath = "C:\Users\rsimiani\Documents\Visual Studio 2008\Projects\Soldados\Soldados\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("RegimientoDataSet_vista_localidades", DT))
        ReportViewer1.LocalReport.SetParameters(lista)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class