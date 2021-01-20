<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenQRCODE
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenQRCODE))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.BtnHome)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 346)
        Me.Panel1.TabIndex = 28
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(32, 32)
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 141)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(194, 49)
        Me.Guna2Button1.TabIndex = 32
        Me.Guna2Button1.Text = "Scan QRCode"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(5, 0)
        '
        'BtnHome
        '
        Me.BtnHome.Animated = True
        Me.BtnHome.BackColor = System.Drawing.Color.Maroon
        Me.BtnHome.CheckedState.Parent = Me.BtnHome
        Me.BtnHome.CustomImages.Parent = Me.BtnHome
        Me.BtnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHome.FillColor = System.Drawing.Color.Maroon
        Me.BtnHome.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.HoverState.ForeColor = System.Drawing.Color.White
        Me.BtnHome.HoverState.Parent = Me.BtnHome
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnHome.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnHome.Location = New System.Drawing.Point(0, 92)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.ShadowDecoration.Parent = Me.BtnHome
        Me.BtnHome.Size = New System.Drawing.Size(194, 49)
        Me.BtnHome.TabIndex = 31
        Me.BtnHome.Text = "Generate QRCode"
        Me.BtnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnHome.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(194, 92)
        Me.Panel3.TabIndex = 30
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "PNG Image|*.png"
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(194, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 324)
        Me.Panel4.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(194, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 22)
        Me.Panel2.TabIndex = 29
        '
        'GenQRCODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 346)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GenQRCODE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenQRCODE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
End Class
