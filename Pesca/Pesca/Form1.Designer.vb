<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_pescador = New System.Windows.Forms.Label
        Me.lbl_pez = New System.Windows.Forms.Label
        Me.lbl_hora = New System.Windows.Forms.Label
        Me.lbl_devolvio = New System.Windows.Forms.Label
        Me.txt_pescador = New System.Windows.Forms.TextBox
        Me.cmb_pez = New System.Windows.Forms.ComboBox
        Me.rb_mañana = New System.Windows.Forms.RadioButton
        Me.rb_tarde = New System.Windows.Forms.RadioButton
        Me.rb_noche = New System.Windows.Forms.RadioButton
        Me.chk_si = New System.Windows.Forms.CheckBox
        Me.txt_kg = New System.Windows.Forms.TextBox
        Me.btn_registrar = New System.Windows.Forms.Button
        Me.chk_no = New System.Windows.Forms.CheckBox
        Me.lbl_kg = New System.Windows.Forms.Label
        Me.lbl_autor = New System.Windows.Forms.Label
        Me.dtm_fechapesca = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_pescador
        '
        Me.lbl_pescador.AutoSize = True
        Me.lbl_pescador.Location = New System.Drawing.Point(12, 21)
        Me.lbl_pescador.Name = "lbl_pescador"
        Me.lbl_pescador.Size = New System.Drawing.Size(52, 13)
        Me.lbl_pescador.TabIndex = 0
        Me.lbl_pescador.Text = "Pescador"
        '
        'lbl_pez
        '
        Me.lbl_pez.AutoSize = True
        Me.lbl_pez.Location = New System.Drawing.Point(12, 54)
        Me.lbl_pez.Name = "lbl_pez"
        Me.lbl_pez.Size = New System.Drawing.Size(25, 13)
        Me.lbl_pez.TabIndex = 2
        Me.lbl_pez.Text = "Pez"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(12, 85)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(41, 13)
        Me.lbl_hora.TabIndex = 4
        Me.lbl_hora.Text = "Horario"
        '
        'lbl_devolvio
        '
        Me.lbl_devolvio.AutoSize = True
        Me.lbl_devolvio.Location = New System.Drawing.Point(12, 127)
        Me.lbl_devolvio.Name = "lbl_devolvio"
        Me.lbl_devolvio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_devolvio.TabIndex = 8
        Me.lbl_devolvio.Text = "Devolvió"
        '
        'txt_pescador
        '
        Me.txt_pescador.Location = New System.Drawing.Point(87, 21)
        Me.txt_pescador.MaxLength = 50
        Me.txt_pescador.Name = "txt_pescador"
        Me.txt_pescador.Size = New System.Drawing.Size(100, 20)
        Me.txt_pescador.TabIndex = 1
        '
        'cmb_pez
        '
        Me.cmb_pez.FormattingEnabled = True
        Me.cmb_pez.Location = New System.Drawing.Point(87, 51)
        Me.cmb_pez.Name = "cmb_pez"
        Me.cmb_pez.Size = New System.Drawing.Size(121, 21)
        Me.cmb_pez.TabIndex = 3
        '
        'rb_mañana
        '
        Me.rb_mañana.AutoSize = True
        Me.rb_mañana.Location = New System.Drawing.Point(72, 83)
        Me.rb_mañana.Name = "rb_mañana"
        Me.rb_mañana.Size = New System.Drawing.Size(64, 17)
        Me.rb_mañana.TabIndex = 5
        Me.rb_mañana.TabStop = True
        Me.rb_mañana.Text = "Mañana"
        Me.rb_mañana.UseVisualStyleBackColor = True
        '
        'rb_tarde
        '
        Me.rb_tarde.AutoSize = True
        Me.rb_tarde.Location = New System.Drawing.Point(142, 83)
        Me.rb_tarde.Name = "rb_tarde"
        Me.rb_tarde.Size = New System.Drawing.Size(53, 17)
        Me.rb_tarde.TabIndex = 6
        Me.rb_tarde.TabStop = True
        Me.rb_tarde.Text = "Tarde"
        Me.rb_tarde.UseVisualStyleBackColor = True
        '
        'rb_noche
        '
        Me.rb_noche.AutoSize = True
        Me.rb_noche.Location = New System.Drawing.Point(201, 83)
        Me.rb_noche.Name = "rb_noche"
        Me.rb_noche.Size = New System.Drawing.Size(57, 17)
        Me.rb_noche.TabIndex = 7
        Me.rb_noche.TabStop = True
        Me.rb_noche.Text = "Noche"
        Me.rb_noche.UseVisualStyleBackColor = True
        '
        'chk_si
        '
        Me.chk_si.AutoSize = True
        Me.chk_si.Location = New System.Drawing.Point(87, 127)
        Me.chk_si.Name = "chk_si"
        Me.chk_si.Size = New System.Drawing.Size(35, 17)
        Me.chk_si.TabIndex = 9
        Me.chk_si.Text = "Si"
        Me.chk_si.UseVisualStyleBackColor = True
        '
        'txt_kg
        '
        Me.txt_kg.Location = New System.Drawing.Point(87, 161)
        Me.txt_kg.Name = "txt_kg"
        Me.txt_kg.Size = New System.Drawing.Size(100, 20)
        Me.txt_kg.TabIndex = 12
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(96, 253)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 13
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'chk_no
        '
        Me.chk_no.AutoSize = True
        Me.chk_no.Location = New System.Drawing.Point(142, 127)
        Me.chk_no.Name = "chk_no"
        Me.chk_no.Size = New System.Drawing.Size(40, 17)
        Me.chk_no.TabIndex = 10
        Me.chk_no.Text = "No"
        Me.chk_no.UseVisualStyleBackColor = True
        '
        'lbl_kg
        '
        Me.lbl_kg.AutoSize = True
        Me.lbl_kg.Location = New System.Drawing.Point(12, 161)
        Me.lbl_kg.Name = "lbl_kg"
        Me.lbl_kg.Size = New System.Drawing.Size(20, 13)
        Me.lbl_kg.TabIndex = 11
        Me.lbl_kg.Text = "Kg"
        '
        'lbl_autor
        '
        Me.lbl_autor.AutoSize = True
        Me.lbl_autor.Location = New System.Drawing.Point(230, 280)
        Me.lbl_autor.Name = "lbl_autor"
        Me.lbl_autor.Size = New System.Drawing.Size(39, 13)
        Me.lbl_autor.TabIndex = 14
        Me.lbl_autor.Text = "Label1"
        '
        'dtm_fechapesca
        '
        Me.dtm_fechapesca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_fechapesca.Location = New System.Drawing.Point(87, 198)
        Me.dtm_fechapesca.Name = "dtm_fechapesca"
        Me.dtm_fechapesca.Size = New System.Drawing.Size(95, 20)
        Me.dtm_fechapesca.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Pesca"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtm_fechapesca)
        Me.Controls.Add(Me.lbl_autor)
        Me.Controls.Add(Me.lbl_kg)
        Me.Controls.Add(Me.chk_no)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_kg)
        Me.Controls.Add(Me.chk_si)
        Me.Controls.Add(Me.rb_noche)
        Me.Controls.Add(Me.rb_tarde)
        Me.Controls.Add(Me.rb_mañana)
        Me.Controls.Add(Me.cmb_pez)
        Me.Controls.Add(Me.txt_pescador)
        Me.Controls.Add(Me.lbl_devolvio)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_pez)
        Me.Controls.Add(Me.lbl_pescador)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_pescador As System.Windows.Forms.Label
    Friend WithEvents lbl_pez As System.Windows.Forms.Label
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents lbl_devolvio As System.Windows.Forms.Label
    Friend WithEvents txt_pescador As System.Windows.Forms.TextBox
    Friend WithEvents cmb_pez As System.Windows.Forms.ComboBox
    Friend WithEvents rb_mañana As System.Windows.Forms.RadioButton
    Friend WithEvents rb_tarde As System.Windows.Forms.RadioButton
    Friend WithEvents rb_noche As System.Windows.Forms.RadioButton
    Friend WithEvents chk_si As System.Windows.Forms.CheckBox
    Friend WithEvents txt_kg As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents chk_no As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_kg As System.Windows.Forms.Label
    Friend WithEvents lbl_autor As System.Windows.Forms.Label
    Friend WithEvents dtm_fechapesca As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
