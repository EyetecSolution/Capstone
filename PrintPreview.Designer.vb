<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintPreview
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
        Me.DocViewer1 = New Spire.DocViewer.Forms.DocViewer()
        Me.SuspendLayout()
        '
        'DocViewer1
        '
        Me.DocViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocViewer1.IsToolBarVisible = True
        Me.DocViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocViewer1.Name = "DocViewer1"
        Me.DocViewer1.Size = New System.Drawing.Size(833, 489)
        Me.DocViewer1.TabIndex = 0
        Me.DocViewer1.Text = "DocViewer1"
        '
        'PrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 489)
        Me.Controls.Add(Me.DocViewer1)
        Me.Name = "PrintPreview"
        Me.Text = "PrintPreview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocViewer1 As Spire.DocViewer.Forms.DocViewer
End Class
