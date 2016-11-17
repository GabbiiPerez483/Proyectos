<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmList
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
        Me.lv_clientes = New System.Windows.Forms.ListView
        Me.lbl_tipopescado = New System.Windows.Forms.Label
        Me.cmb_buscartipopez = New System.Windows.Forms.ComboBox
        Me.btn_filtrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lv_clientes
        '
        Me.lv_clientes.Location = New System.Drawing.Point(17, 64)
        Me.lv_clientes.Name = "lv_clientes"
        Me.lv_clientes.Size = New System.Drawing.Size(653, 163)
        Me.lv_clientes.TabIndex = 0
        Me.lv_clientes.UseCompatibleStateImageBehavior = False
        '
        'lbl_tipopescado
        '
        Me.lbl_tipopescado.AutoSize = True
        Me.lbl_tipopescado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipopescado.Location = New System.Drawing.Point(13, 13)
        Me.lbl_tipopescado.Name = "lbl_tipopescado"
        Me.lbl_tipopescado.Size = New System.Drawing.Size(123, 24)
        Me.lbl_tipopescado.TabIndex = 1
        Me.lbl_tipopescado.Text = "Tipo de Pez"
        '
        'cmb_buscartipopez
        '
        Me.cmb_buscartipopez.FormattingEnabled = True
        Me.cmb_buscartipopez.Location = New System.Drawing.Point(156, 13)
        Me.cmb_buscartipopez.Name = "cmb_buscartipopez"
        Me.cmb_buscartipopez.Size = New System.Drawing.Size(147, 21)
        Me.cmb_buscartipopez.TabIndex = 2
        '
        'btn_filtrar
        '
        Me.btn_filtrar.Location = New System.Drawing.Point(335, 11)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_filtrar.TabIndex = 3
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'FrmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 237)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.cmb_buscartipopez)
        Me.Controls.Add(Me.lbl_tipopescado)
        Me.Controls.Add(Me.lv_clientes)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv_clientes As System.Windows.Forms.ListView
    Friend WithEvents lbl_tipopescado As System.Windows.Forms.Label
    Friend WithEvents cmb_buscartipopez As System.Windows.Forms.ComboBox
    Friend WithEvents btn_filtrar As System.Windows.Forms.Button
End Class
