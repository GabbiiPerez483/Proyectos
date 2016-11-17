<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AltaVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AltaVenta))
        Me.lbl_nombre = New System.Windows.Forms.Label
        Me.lbl_cod_prod = New System.Windows.Forms.Label
        Me.lbl_cant = New System.Windows.Forms.Label
        Me.lbl_precio_total = New System.Windows.Forms.Label
        Me.txt_cliente = New System.Windows.Forms.TextBox
        Me.cmb_cant = New System.Windows.Forms.ComboBox
        Me.txt_precio = New System.Windows.Forms.TextBox
        Me.mtb_cod_prod = New System.Windows.Forms.MaskedTextBox
        Me.lbl_etiqueta = New System.Windows.Forms.Label
        Me.lbl_nuevaventa = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(16, 58)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(69, 23)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Cliente:"
        '
        'lbl_cod_prod
        '
        Me.lbl_cod_prod.AutoSize = True
        Me.lbl_cod_prod.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cod_prod.Location = New System.Drawing.Point(16, 100)
        Me.lbl_cod_prod.Name = "lbl_cod_prod"
        Me.lbl_cod_prod.Size = New System.Drawing.Size(124, 23)
        Me.lbl_cod_prod.TabIndex = 1
        Me.lbl_cod_prod.Text = "Cód. Producto:"
        '
        'lbl_cant
        '
        Me.lbl_cant.AutoSize = True
        Me.lbl_cant.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cant.Location = New System.Drawing.Point(16, 141)
        Me.lbl_cant.Name = "lbl_cant"
        Me.lbl_cant.Size = New System.Drawing.Size(83, 23)
        Me.lbl_cant.TabIndex = 2
        Me.lbl_cant.Text = "Cantidad:"
        '
        'lbl_precio_total
        '
        Me.lbl_precio_total.AutoSize = True
        Me.lbl_precio_total.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_total.Location = New System.Drawing.Point(16, 180)
        Me.lbl_precio_total.Name = "lbl_precio_total"
        Me.lbl_precio_total.Size = New System.Drawing.Size(110, 23)
        Me.lbl_precio_total.TabIndex = 3
        Me.lbl_precio_total.Text = "Precio Total:"
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(91, 62)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(156, 20)
        Me.txt_cliente.TabIndex = 4
        '
        'cmb_cant
        '
        Me.cmb_cant.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_cant.FormattingEnabled = True
        Me.cmb_cant.Location = New System.Drawing.Point(105, 145)
        Me.cmb_cant.MaxLength = 4
        Me.cmb_cant.Name = "cmb_cant"
        Me.cmb_cant.Size = New System.Drawing.Size(53, 21)
        Me.cmb_cant.TabIndex = 5
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(132, 184)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(115, 20)
        Me.txt_precio.TabIndex = 6
        '
        'mtb_cod_prod
        '
        Me.mtb_cod_prod.BackColor = System.Drawing.SystemColors.Info
        Me.mtb_cod_prod.Location = New System.Drawing.Point(146, 104)
        Me.mtb_cod_prod.Mask = "A0000"
        Me.mtb_cod_prod.Name = "mtb_cod_prod"
        Me.mtb_cod_prod.Size = New System.Drawing.Size(37, 20)
        Me.mtb_cod_prod.TabIndex = 7
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Mistral", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_etiqueta.Location = New System.Drawing.Point(195, 252)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(56, 19)
        Me.lbl_etiqueta.TabIndex = 8
        Me.lbl_etiqueta.Text = "Bijouterie"
        '
        'lbl_nuevaventa
        '
        Me.lbl_nuevaventa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nuevaventa.AutoSize = True
        Me.lbl_nuevaventa.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nuevaventa.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_nuevaventa.Location = New System.Drawing.Point(66, 9)
        Me.lbl_nuevaventa.Name = "lbl_nuevaventa"
        Me.lbl_nuevaventa.Size = New System.Drawing.Size(130, 27)
        Me.lbl_nuevaventa.TabIndex = 9
        Me.lbl_nuevaventa.Text = "Nueva Venta"
        '
        'Frm_AltaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 280)
        Me.Controls.Add(Me.lbl_nuevaventa)
        Me.Controls.Add(Me.lbl_etiqueta)
        Me.Controls.Add(Me.mtb_cod_prod)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.cmb_cant)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.lbl_precio_total)
        Me.Controls.Add(Me.lbl_cant)
        Me.Controls.Add(Me.lbl_cod_prod)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_AltaVenta"
        Me.Text = "Frm_AltaVenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_cod_prod As System.Windows.Forms.Label
    Friend WithEvents lbl_cant As System.Windows.Forms.Label
    Friend WithEvents lbl_precio_total As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cant As System.Windows.Forms.ComboBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents mtb_cod_prod As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_etiqueta As System.Windows.Forms.Label
    Friend WithEvents lbl_nuevaventa As System.Windows.Forms.Label
End Class
