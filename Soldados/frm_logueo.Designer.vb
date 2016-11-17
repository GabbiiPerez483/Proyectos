<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logueo
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
        Me.btn_ingresar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_usuario = New System.Windows.Forms.TextBox
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_modificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(33, 242)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ingresar.TabIndex = 5
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(108, 47)
        Me.txt_usuario.MaxLength = 10
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 3
        Me.txt_usuario.Text = "admin"
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(108, 107)
        Me.txt_clave.MaxLength = 10
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(100, 20)
        Me.txt_clave.TabIndex = 4
        Me.txt_clave.Text = "admin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_modificar
        '
        Me.txt_modificar.Location = New System.Drawing.Point(226, 242)
        Me.txt_modificar.Name = "txt_modificar"
        Me.txt_modificar.Size = New System.Drawing.Size(119, 23)
        Me.txt_modificar.TabIndex = 7
        Me.txt_modificar.Text = "Modificar Contraseña"
        Me.txt_modificar.UseVisualStyleBackColor = True
        '
        'frm_logueo
        '
        Me.AcceptButton = Me.btn_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 277)
        Me.Controls.Add(Me.txt_modificar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Name = "frm_logueo"
        Me.Text = "Ingreso al Sistema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_modificar As System.Windows.Forms.Button
End Class
