<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cmb_provincia = New System.Windows.Forms.ComboBox
        Me.lbl_provincia = New System.Windows.Forms.Label
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.txt_cp = New System.Windows.Forms.TextBox
        Me.lbl_cp = New System.Windows.Forms.Label
        Me.txt_localidad = New System.Windows.Forms.TextBox
        Me.lbl_localidad = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmb_provincia
        '
        Me.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(136, 58)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(100, 21)
        Me.cmb_provincia.TabIndex = 8
        '
        'lbl_provincia
        '
        Me.lbl_provincia.AutoSize = True
        Me.lbl_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provincia.Location = New System.Drawing.Point(42, 58)
        Me.lbl_provincia.Name = "lbl_provincia"
        Me.lbl_provincia.Size = New System.Drawing.Size(73, 16)
        Me.lbl_provincia.TabIndex = 7
        Me.lbl_provincia.Text = "Provincia"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Location = New System.Drawing.Point(167, 181)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 13
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'txt_cp
        '
        Me.txt_cp.Location = New System.Drawing.Point(136, 103)
        Me.txt_cp.MaxLength = 10
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(100, 20)
        Me.txt_cp.TabIndex = 10
        '
        'lbl_cp
        '
        Me.lbl_cp.AutoSize = True
        Me.lbl_cp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cp.Location = New System.Drawing.Point(42, 103)
        Me.lbl_cp.Name = "lbl_cp"
        Me.lbl_cp.Size = New System.Drawing.Size(88, 16)
        Me.lbl_cp.TabIndex = 9
        Me.lbl_cp.Text = "Cód. Postal"
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(136, 142)
        Me.txt_localidad.MaxLength = 30
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_localidad.TabIndex = 12
        '
        'lbl_localidad
        '
        Me.lbl_localidad.AutoSize = True
        Me.lbl_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localidad.Location = New System.Drawing.Point(42, 143)
        Me.lbl_localidad.Name = "lbl_localidad"
        Me.lbl_localidad.Size = New System.Drawing.Size(77, 16)
        Me.lbl_localidad.TabIndex = 11
        Me.lbl_localidad.Text = "Localidad"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmb_provincia)
        Me.Controls.Add(Me.lbl_provincia)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_cp)
        Me.Controls.Add(Me.lbl_cp)
        Me.Controls.Add(Me.txt_localidad)
        Me.Controls.Add(Me.lbl_localidad)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_provincia As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents txt_cp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cp As System.Windows.Forms.Label
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_localidad As System.Windows.Forms.Label
End Class
