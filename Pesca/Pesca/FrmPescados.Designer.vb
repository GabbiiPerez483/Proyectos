<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPescados
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
        Me.txt_altapescados = New System.Windows.Forms.TextBox
        Me.btn_registrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt_altapescados
        '
        Me.txt_altapescados.Location = New System.Drawing.Point(12, 12)
        Me.txt_altapescados.MaxLength = 30
        Me.txt_altapescados.Name = "txt_altapescados"
        Me.txt_altapescados.Size = New System.Drawing.Size(260, 20)
        Me.txt_altapescados.TabIndex = 0
        '
        'btn_registrar
        '
        Me.btn_registrar.Location = New System.Drawing.Point(100, 56)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_registrar.TabIndex = 1
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'FrmPescados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 97)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.txt_altapescados)
        Me.Name = "FrmPescados"
        Me.Text = "FrmPescados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_altapescados As System.Windows.Forms.TextBox
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
End Class
