<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.ProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SoldadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaSoldadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProvinciasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarLocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoProvinciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoLocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvinciasToolStripMenuItem, Me.AdministrarUsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(793, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProvinciasToolStripMenuItem
        '
        Me.ProvinciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoldadosToolStripMenuItem, Me.AltaSoldadoToolStripMenuItem, Me.ProvinciasToolStripMenuItem1, Me.AgregarLocalidadesToolStripMenuItem, Me.ListadoProvinciasToolStripMenuItem, Me.ListadoLocalidadesToolStripMenuItem})
        Me.ProvinciasToolStripMenuItem.Name = "ProvinciasToolStripMenuItem"
        Me.ProvinciasToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ProvinciasToolStripMenuItem.Text = "Archivo"
        '
        'SoldadosToolStripMenuItem
        '
        Me.SoldadosToolStripMenuItem.Name = "SoldadosToolStripMenuItem"
        Me.SoldadosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SoldadosToolStripMenuItem.Text = "Soldados"
        '
        'AltaSoldadoToolStripMenuItem
        '
        Me.AltaSoldadoToolStripMenuItem.Name = "AltaSoldadoToolStripMenuItem"
        Me.AltaSoldadoToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AltaSoldadoToolStripMenuItem.Text = "Alta Soldado"
        '
        'ProvinciasToolStripMenuItem1
        '
        Me.ProvinciasToolStripMenuItem1.Name = "ProvinciasToolStripMenuItem1"
        Me.ProvinciasToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ProvinciasToolStripMenuItem1.Text = "Agregar Provincias"
        '
        'AgregarLocalidadesToolStripMenuItem
        '
        Me.AgregarLocalidadesToolStripMenuItem.Name = "AgregarLocalidadesToolStripMenuItem"
        Me.AgregarLocalidadesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AgregarLocalidadesToolStripMenuItem.Text = "Agregar Localidades"
        '
        'ListadoProvinciasToolStripMenuItem
        '
        Me.ListadoProvinciasToolStripMenuItem.Name = "ListadoProvinciasToolStripMenuItem"
        Me.ListadoProvinciasToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListadoProvinciasToolStripMenuItem.Text = "Listado Provincias"
        '
        'ListadoLocalidadesToolStripMenuItem
        '
        Me.ListadoLocalidadesToolStripMenuItem.Name = "ListadoLocalidadesToolStripMenuItem"
        Me.ListadoLocalidadesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ListadoLocalidadesToolStripMenuItem.Text = "Listado Localidades"
        '
        'AdministrarUsuariosToolStripMenuItem
        '
        Me.AdministrarUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.AdministrarUsuariosToolStripMenuItem.Name = "AdministrarUsuariosToolStripMenuItem"
        Me.AdministrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.AdministrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProvinciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProvinciasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarLocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoProvinciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoLocalidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaSoldadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoldadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
