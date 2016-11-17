<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListProd
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
        Me.txt_nomb_prod = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_sucursal = New System.Windows.Forms.ComboBox
        Me.dgv_prod = New System.Windows.Forms.DataGridView
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dgv_mov = New System.Windows.Forms.DataGridView
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.dgv_mov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nomb_prod
        '
        Me.txt_nomb_prod.Location = New System.Drawing.Point(108, 10)
        Me.txt_nomb_prod.MaxLength = 30
        Me.txt_nomb_prod.Name = "txt_nomb_prod"
        Me.txt_nomb_prod.Size = New System.Drawing.Size(100, 20)
        Me.txt_nomb_prod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sucursal:"
        '
        'cmb_sucursal
        '
        Me.cmb_sucursal.FormattingEnabled = True
        Me.cmb_sucursal.Location = New System.Drawing.Point(286, 10)
        Me.cmb_sucursal.Name = "cmb_sucursal"
        Me.cmb_sucursal.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sucursal.TabIndex = 3
        '
        'dgv_prod
        '
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prod.Location = New System.Drawing.Point(12, 46)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.Size = New System.Drawing.Size(489, 270)
        Me.dgv_prod.TabIndex = 5
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(426, 8)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 4
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProductoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 70)
        '
        'NuevoProductoToolStripMenuItem
        '
        Me.NuevoProductoToolStripMenuItem.Name = "NuevoProductoToolStripMenuItem"
        Me.NuevoProductoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.NuevoProductoToolStripMenuItem.Text = "Nuevo Producto"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'dgv_mov
        '
        Me.dgv_mov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mov.Location = New System.Drawing.Point(12, 351)
        Me.dgv_mov.Name = "dgv_mov"
        Me.dgv_mov.Size = New System.Drawing.Size(268, 260)
        Me.dgv_mov.TabIndex = 6
        '
        'ListProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 623)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_mov)
        Me.Controls.Add(Me.dgv_prod)
        Me.Controls.Add(Me.cmb_sucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nomb_prod)
        Me.Name = "ListProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListProd"
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgv_mov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nomb_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_prod As System.Windows.Forms.DataGridView
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuevoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgv_mov As System.Windows.Forms.DataGridView
End Class
