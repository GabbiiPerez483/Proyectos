<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_altasoldados
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_apellido = New System.Windows.Forms.TextBox
        Me.txt_telefono = New System.Windows.Forms.TextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.chk_activo = New System.Windows.Forms.CheckBox
        Me.cmb_provnac = New System.Windows.Forms.ComboBox
        Me.cmb_locnac = New System.Windows.Forms.ComboBox
        Me.cmb_locres = New System.Windows.Forms.ComboBox
        Me.cmb_provres = New System.Windows.Forms.ComboBox
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker
        Me.msk_legajo = New System.Windows.Forms.MaskedTextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Legajo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prov Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Loc Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Nac"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(391, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Activo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(389, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Prov Residencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(391, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Loc residencia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(389, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Telefono"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(177, 82)
        Me.txt_apellido.MaxLength = 20
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(514, 246)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(100, 20)
        Me.txt_telefono.TabIndex = 10
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(177, 133)
        Me.txt_nombre.MaxLength = 20
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(514, 189)
        Me.txt_direccion.MaxLength = 40
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(100, 20)
        Me.txt_direccion.TabIndex = 9
        '
        'chk_activo
        '
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Location = New System.Drawing.Point(434, 36)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(15, 14)
        Me.chk_activo.TabIndex = 6
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'cmb_provnac
        '
        Me.cmb_provnac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_provnac.FormattingEnabled = True
        Me.cmb_provnac.Location = New System.Drawing.Point(177, 188)
        Me.cmb_provnac.Name = "cmb_provnac"
        Me.cmb_provnac.Size = New System.Drawing.Size(121, 21)
        Me.cmb_provnac.TabIndex = 3
        '
        'cmb_locnac
        '
        Me.cmb_locnac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_locnac.FormattingEnabled = True
        Me.cmb_locnac.Location = New System.Drawing.Point(177, 245)
        Me.cmb_locnac.Name = "cmb_locnac"
        Me.cmb_locnac.Size = New System.Drawing.Size(121, 21)
        Me.cmb_locnac.TabIndex = 4
        '
        'cmb_locres
        '
        Me.cmb_locres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_locres.FormattingEnabled = True
        Me.cmb_locres.Location = New System.Drawing.Point(514, 132)
        Me.cmb_locres.Name = "cmb_locres"
        Me.cmb_locres.Size = New System.Drawing.Size(121, 21)
        Me.cmb_locres.TabIndex = 8
        '
        'cmb_provres
        '
        Me.cmb_provres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_provres.FormattingEnabled = True
        Me.cmb_provres.Location = New System.Drawing.Point(514, 77)
        Me.cmb_provres.Name = "cmb_provres"
        Me.cmb_provres.Size = New System.Drawing.Size(121, 21)
        Me.cmb_provres.TabIndex = 7
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(177, 303)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(121, 20)
        Me.dtp_fecha.TabIndex = 5
        '
        'msk_legajo
        '
        Me.msk_legajo.Location = New System.Drawing.Point(177, 30)
        Me.msk_legajo.Mask = "L-000"
        Me.msk_legajo.Name = "msk_legajo"
        Me.msk_legajo.Size = New System.Drawing.Size(100, 20)
        Me.msk_legajo.TabIndex = 0
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(476, 317)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 11
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(603, 317)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_altasoldados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 352)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.msk_legajo)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.cmb_provres)
        Me.Controls.Add(Me.cmb_locres)
        Me.Controls.Add(Me.cmb_locnac)
        Me.Controls.Add(Me.cmb_provnac)
        Me.Controls.Add(Me.chk_activo)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_altasoldados"
        Me.Text = "Soldados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_provnac As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_locnac As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_locres As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_provres As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents msk_legajo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
End Class
