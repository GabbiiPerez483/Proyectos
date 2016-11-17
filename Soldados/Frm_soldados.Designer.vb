<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_soldados
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
        Me.dgv_soldados = New System.Windows.Forms.DataGridView
        Me.ctm_soldados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txt_filtrar = New System.Windows.Forms.TextBox
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.dgv_habilidades = New System.Windows.Forms.DataGridView
        Me.btn_mision = New System.Windows.Forms.Button
        CType(Me.dgv_soldados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctm_soldados.SuspendLayout()
        CType(Me.dgv_habilidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_soldados
        '
        Me.dgv_soldados.AllowUserToAddRows = False
        Me.dgv_soldados.AllowUserToDeleteRows = False
        Me.dgv_soldados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_soldados.ContextMenuStrip = Me.ctm_soldados
        Me.dgv_soldados.Location = New System.Drawing.Point(12, 85)
        Me.dgv_soldados.Name = "dgv_soldados"
        Me.dgv_soldados.ReadOnly = True
        Me.dgv_soldados.Size = New System.Drawing.Size(728, 155)
        Me.dgv_soldados.TabIndex = 0
        '
        'ctm_soldados
        '
        Me.ctm_soldados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.ctm_soldados.Name = "ContextMenuStrip1"
        Me.ctm_soldados.Size = New System.Drawing.Size(154, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ModificarToolStripMenuItem.Text = "Asignar Mision"
        '
        'txt_filtrar
        '
        Me.txt_filtrar.Location = New System.Drawing.Point(36, 36)
        Me.txt_filtrar.Name = "txt_filtrar"
        Me.txt_filtrar.Size = New System.Drawing.Size(106, 20)
        Me.txt_filtrar.TabIndex = 1
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(163, 36)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 2
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgv_habilidades
        '
        Me.dgv_habilidades.AllowUserToAddRows = False
        Me.dgv_habilidades.AllowUserToDeleteRows = False
        Me.dgv_habilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_habilidades.Location = New System.Drawing.Point(12, 273)
        Me.dgv_habilidades.Name = "dgv_habilidades"
        Me.dgv_habilidades.ReadOnly = True
        Me.dgv_habilidades.Size = New System.Drawing.Size(208, 119)
        Me.dgv_habilidades.TabIndex = 3
        '
        'btn_mision
        '
        Me.btn_mision.Location = New System.Drawing.Point(353, 273)
        Me.btn_mision.Name = "btn_mision"
        Me.btn_mision.Size = New System.Drawing.Size(75, 23)
        Me.btn_mision.TabIndex = 4
        Me.btn_mision.Text = "Asignar Mision"
        Me.btn_mision.UseVisualStyleBackColor = True
        '
        'Frm_soldados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 417)
        Me.Controls.Add(Me.btn_mision)
        Me.Controls.Add(Me.dgv_habilidades)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.txt_filtrar)
        Me.Controls.Add(Me.dgv_soldados)
        Me.Name = "Frm_soldados"
        Me.Text = "Frm_soldados"
        CType(Me.dgv_soldados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctm_soldados.ResumeLayout(False)
        CType(Me.dgv_habilidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_soldados As System.Windows.Forms.DataGridView
    Friend WithEvents txt_filtrar As System.Windows.Forms.TextBox
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents dgv_habilidades As System.Windows.Forms.DataGridView
    Friend WithEvents btn_mision As System.Windows.Forms.Button
    Friend WithEvents ctm_soldados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
