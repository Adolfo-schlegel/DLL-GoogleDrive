<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestGDrive
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmd_subir = New System.Windows.Forms.Button()
        Me.cmd_subir_cnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_subir
        '
        Me.cmd_subir.Location = New System.Drawing.Point(334, 387)
        Me.cmd_subir.Name = "cmd_subir"
        Me.cmd_subir.Size = New System.Drawing.Size(124, 36)
        Me.cmd_subir.TabIndex = 0
        Me.cmd_subir.Text = "Subir GDrive"
        Me.cmd_subir.UseVisualStyleBackColor = True
        '
        'cmd_subir_cnt
        '
        Me.cmd_subir_cnt.Location = New System.Drawing.Point(294, 317)
        Me.cmd_subir_cnt.Name = "cmd_subir_cnt"
        Me.cmd_subir_cnt.Size = New System.Drawing.Size(197, 37)
        Me.cmd_subir_cnt.TabIndex = 1
        Me.cmd_subir_cnt.Text = "Subir GDrive desde CNT"
        Me.cmd_subir_cnt.UseVisualStyleBackColor = True
        '
        'frmTestGDrive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmd_subir_cnt)
        Me.Controls.Add(Me.cmd_subir)
        Me.Name = "frmTestGDrive"
        Me.Text = "Test GDrive"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_subir As Button
    Friend WithEvents cmd_subir_cnt As Button
End Class
