<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
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
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView
        Me.ctm_usuarios = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloquearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.txt_filtrar = New System.Windows.Forms.TextBox
        Me.CambiarContraseñaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctm_usuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AllowUserToAddRows = False
        Me.dgv_usuarios.AllowUserToDeleteRows = False
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.ContextMenuStrip = Me.ctm_usuarios
        Me.dgv_usuarios.Location = New System.Drawing.Point(12, 64)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.ReadOnly = True
        Me.dgv_usuarios.Size = New System.Drawing.Size(538, 129)
        Me.dgv_usuarios.TabIndex = 4
        '
        'ctm_usuarios
        '
        Me.ctm_usuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.BloquearToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem1})
        Me.ctm_usuarios.Name = "ctm_usuarios"
        Me.ctm_usuarios.Size = New System.Drawing.Size(205, 136)
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'BloquearToolStripMenuItem
        '
        Me.BloquearToolStripMenuItem.Name = "BloquearToolStripMenuItem"
        Me.BloquearToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.BloquearToolStripMenuItem.Text = "Bloquear"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Administrar Contraseñas"
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(166, 13)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(55, 23)
        Me.btn_filtrar.TabIndex = 5
        Me.btn_filtrar.Text = "Buscar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'txt_filtrar
        '
        Me.txt_filtrar.Location = New System.Drawing.Point(45, 15)
        Me.txt_filtrar.Name = "txt_filtrar"
        Me.txt_filtrar.Size = New System.Drawing.Size(100, 20)
        Me.txt_filtrar.TabIndex = 6
        '
        'CambiarContraseñaToolStripMenuItem1
        '
        Me.CambiarContraseñaToolStripMenuItem1.Name = "CambiarContraseñaToolStripMenuItem1"
        Me.CambiarContraseñaToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.CambiarContraseñaToolStripMenuItem1.Text = "Cambiar Contraseña"
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 250)
        Me.Controls.Add(Me.txt_filtrar)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Name = "frm_usuarios"
        Me.Text = "frm_usuarios"
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctm_usuarios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
    Friend WithEvents txt_filtrar As System.Windows.Forms.TextBox
    Friend WithEvents ctm_usuarios As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloquearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
