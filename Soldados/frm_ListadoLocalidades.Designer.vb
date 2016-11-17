<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ListadoLocalidades
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
        Me.btn_modificar = New System.Windows.Forms.Button
        Me.btn_alta = New System.Windows.Forms.Button
        Me.txt_filtrar = New System.Windows.Forms.TextBox
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgv_localidades = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgv_localidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(371, 61)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 13
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_alta
        '
        Me.btn_alta.Location = New System.Drawing.Point(263, 61)
        Me.btn_alta.Name = "btn_alta"
        Me.btn_alta.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta.TabIndex = 12
        Me.btn_alta.Text = "Alta"
        Me.btn_alta.UseVisualStyleBackColor = True
        '
        'txt_filtrar
        '
        Me.txt_filtrar.Location = New System.Drawing.Point(40, 29)
        Me.txt_filtrar.MaxLength = 20
        Me.txt_filtrar.Name = "txt_filtrar"
        Me.txt_filtrar.Size = New System.Drawing.Size(100, 20)
        Me.txt_filtrar.TabIndex = 10
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(155, 29)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 11
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgv_localidades
        '
        Me.dgv_localidades.AllowUserToAddRows = False
        Me.dgv_localidades.AllowUserToDeleteRows = False
        Me.dgv_localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_localidades.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv_localidades.Location = New System.Drawing.Point(51, 144)
        Me.dgv_localidades.Name = "dgv_localidades"
        Me.dgv_localidades.ReadOnly = True
        Me.dgv_localidades.Size = New System.Drawing.Size(409, 150)
        Me.dgv_localidades.TabIndex = 14
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frm_ListadoLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 342)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_alta)
        Me.Controls.Add(Me.txt_filtrar)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_localidades)
        Me.Name = "frm_ListadoLocalidades"
        Me.Text = "frm_ListadoLocalidades"
        CType(Me.dgv_localidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_alta As System.Windows.Forms.Button
    Friend WithEvents txt_filtrar As System.Windows.Forms.TextBox
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgv_localidades As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
