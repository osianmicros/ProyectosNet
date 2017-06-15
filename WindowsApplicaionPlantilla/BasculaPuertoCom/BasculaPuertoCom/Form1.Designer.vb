<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.BtnCapturarPeso = New System.Windows.Forms.Button()
        Me.TbPeso = New System.Windows.Forms.TextBox()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnConectar = New System.Windows.Forms.Button()
        Me.TbPuerto = New System.Windows.Forms.TextBox()
        Me.LabelPuerto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCapturarPeso
        '
        Me.BtnCapturarPeso.Location = New System.Drawing.Point(477, 35)
        Me.BtnCapturarPeso.Name = "BtnCapturarPeso"
        Me.BtnCapturarPeso.Size = New System.Drawing.Size(194, 21)
        Me.BtnCapturarPeso.TabIndex = 0
        Me.BtnCapturarPeso.Text = "CAPTURAR PESO"
        Me.BtnCapturarPeso.UseVisualStyleBackColor = True
        '
        'TbPeso
        '
        Me.TbPeso.Location = New System.Drawing.Point(12, 36)
        Me.TbPeso.Name = "TbPeso"
        Me.TbPeso.Size = New System.Drawing.Size(456, 20)
        Me.TbPeso.TabIndex = 1
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(12, 12)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(189, 13)
        Me.LabelInfo.TabIndex = 2
        Me.LabelInfo.Text = "Dispositivo conectado correctamente !"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(527, 118)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(144, 29)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnConectar
        '
        Me.BtnConectar.Location = New System.Drawing.Point(477, 8)
        Me.BtnConectar.Name = "BtnConectar"
        Me.BtnConectar.Size = New System.Drawing.Size(94, 21)
        Me.BtnConectar.TabIndex = 4
        Me.BtnConectar.Text = "Conectar"
        Me.BtnConectar.UseVisualStyleBackColor = True
        '
        'TbPuerto
        '
        Me.TbPuerto.Location = New System.Drawing.Point(621, 9)
        Me.TbPuerto.Name = "TbPuerto"
        Me.TbPuerto.Size = New System.Drawing.Size(49, 20)
        Me.TbPuerto.TabIndex = 5
        '
        'LabelPuerto
        '
        Me.LabelPuerto.AutoSize = True
        Me.LabelPuerto.Location = New System.Drawing.Point(577, 12)
        Me.LabelPuerto.Name = "LabelPuerto"
        Me.LabelPuerto.Size = New System.Drawing.Size(38, 13)
        Me.LabelPuerto.TabIndex = 6
        Me.LabelPuerto.Text = "Puerto"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 161)
        Me.Controls.Add(Me.LabelPuerto)
        Me.Controls.Add(Me.TbPuerto)
        Me.Controls.Add(Me.BtnConectar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.TbPeso)
        Me.Controls.Add(Me.BtnCapturarPeso)
        Me.Name = "FormPrincipal"
        Me.Text = "Capturar Peso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCapturarPeso As System.Windows.Forms.Button
    Friend WithEvents TbPeso As System.Windows.Forms.TextBox
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnConectar As System.Windows.Forms.Button
    Friend WithEvents TbPuerto As System.Windows.Forms.TextBox
    Friend WithEvents LabelPuerto As System.Windows.Forms.Label

End Class
