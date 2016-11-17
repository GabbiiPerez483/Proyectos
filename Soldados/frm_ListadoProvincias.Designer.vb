<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoProvincias
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ListadoProvincias))
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_alta = New System.Windows.Forms.Button
        Me.txt_filtrar = New System.Windows.Forms.TextBox
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgv_prov = New System.Windows.Forms.DataGridView
        Me.ctm_flotante = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AltaDeProvinciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pb_exportar = New System.Windows.Forms.ProgressBar
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.dgv_prov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctm_flotante.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(364, 54)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 8
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_alta
        '
        Me.btn_alta.Location = New System.Drawing.Point(256, 54)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta.TabIndex = 7
        Me.btn_alta.Text = "Alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'txt_filtrar
        '
        Me.txt_filtrar.Location = New System.Drawing.Point(33, 22)
        Me.txt_filtrar.MaxLength = 20
        Me.txt_filtrar.Name = "txt_filtrar"
        Me.txt_filtrar.Size = New System.Drawing.Size(100, 20)
        Me.txt_filtrar.TabIndex = 5
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(148, 22)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 6
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgv_prov
        '
        Me.dgv_prov.AllowUserToAddRows = False
        Me.dgv_prov.AllowUserToDeleteRows = False
        Me.dgv_prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prov.ContextMenuStrip = Me.ctm_flotante
        Me.dgv_prov.Location = New System.Drawing.Point(44, 137)
        Me.dgv_prov.Name = "dgv_prov"
        Me.dgv_prov.Size = New System.Drawing.Size(409, 150)
        Me.dgv_prov.TabIndex = 9
        '
        'ctm_flotante
        '
        Me.ctm_flotante.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeProvinciaToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.ctm_flotante.Name = "ctm_flotante"
        Me.ctm_flotante.Size = New System.Drawing.Size(164, 70)
        '
        'AltaDeProvinciaToolStripMenuItem
        '
        Me.AltaDeProvinciaToolStripMenuItem.Image = CType(resources.GetObject("AltaDeProvinciaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AltaDeProvinciaToolStripMenuItem.Name = "AltaDeProvinciaToolStripMenuItem"
        Me.AltaDeProvinciaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AltaDeProvinciaToolStripMenuItem.Text = "Alta de Provincia"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'pb_exportar
        '
        Me.pb_exportar.Location = New System.Drawing.Point(44, 317)
        Me.pb_exportar.Name = "pb_exportar"
        Me.pb_exportar.Size = New System.Drawing.Size(409, 23)
        Me.pb_exportar.TabIndex = 11
        Me.pb_exportar.Visible = False
        '
        'frm_ListadoProvincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 365)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.pb_exportar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.txt_filtrar)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_prov)
        Me.Name = "frm_ListadoProvincias"
        Me.Text = "frm_ListadoProvincias"
        CType(Me.dgv_prov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctm_flotante.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents txt_filtrar As System.Windows.Forms.TextBox
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgv_prov As System.Windows.Forms.DataGridView
    Friend WithEvents ctm_flotante As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AltaDeProvinciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pb_exportar As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
