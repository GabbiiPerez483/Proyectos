<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnu_archivo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_registropesca = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_registropescados = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_listadodepesca = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_archivo})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(336, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_archivo
        '
        Me.mnu_archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_registropesca, Me.mnu_registropescados, Me.mnu_listadodepesca})
        Me.mnu_archivo.Name = "mnu_archivo"
        Me.mnu_archivo.Size = New System.Drawing.Size(60, 20)
        Me.mnu_archivo.Text = "Archivo"
        '
        'mnu_registropesca
        '
        Me.mnu_registropesca.Name = "mnu_registropesca"
        Me.mnu_registropesca.Size = New System.Drawing.Size(185, 22)
        Me.mnu_registropesca.Text = "Registro de Pesca"
        '
        'mnu_registropescados
        '
        Me.mnu_registropescados.Name = "mnu_registropescados"
        Me.mnu_registropescados.Size = New System.Drawing.Size(185, 22)
        Me.mnu_registropescados.Text = "Registro de Pescados"
        '
        'mnu_listadodepesca
        '
        Me.mnu_listadodepesca.Name = "mnu_listadodepesca"
        Me.mnu_listadodepesca.Size = New System.Drawing.Size(185, 22)
        Me.mnu_listadodepesca.Text = "Listado de Pesca"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 327)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_archivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_registropesca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_registropescados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_listadodepesca As System.Windows.Forms.ToolStripMenuItem
End Class
