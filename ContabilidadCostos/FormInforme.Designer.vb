<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInforme
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInforme))
        Me.rtbInforme = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtbInforme
        '
        Me.rtbInforme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbInforme.EnableAutoDragDrop = True
        Me.rtbInforme.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInforme.Location = New System.Drawing.Point(0, 0)
        Me.rtbInforme.Name = "rtbInforme"
        Me.rtbInforme.Size = New System.Drawing.Size(732, 1055)
        Me.rtbInforme.TabIndex = 0
        Me.rtbInforme.Text = ""
        '
        'FormInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 1055)
        Me.Controls.Add(Me.rtbInforme)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInforme"
        Me.Text = "Informe:  Texto seleccionable, editable y copiable."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbInforme As RichTextBox
End Class
