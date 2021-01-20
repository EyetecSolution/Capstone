<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateQR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateQR))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnQR = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"BRGY.OFFICIAL", "BRGY.STAFF", "TANOD"})
        Me.CmbPurpose.Location = New System.Drawing.Point(58, 202)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(285, 24)
        Me.CmbPurpose.TabIndex = 92
        Me.CmbPurpose.Text = "SELECT POSITION"
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(58, 251)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(285, 23)
        Me.TxtName.TabIndex = 93
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(58, 232)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel1.TabIndex = 94
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'BtnQR
        '
        Me.BtnQR.Animated = True
        Me.BtnQR.BackColor = System.Drawing.Color.Transparent
        Me.BtnQR.BorderColor = System.Drawing.Color.White
        Me.BtnQR.BorderRadius = 15
        Me.BtnQR.BorderThickness = 1
        Me.BtnQR.CheckedState.Parent = Me.BtnQR
        Me.BtnQR.CustomImages.Parent = Me.BtnQR
        Me.BtnQR.FillColor = System.Drawing.Color.Maroon
        Me.BtnQR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQR.ForeColor = System.Drawing.Color.White
        Me.BtnQR.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnQR.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnQR.HoverState.Parent = Me.BtnQR
        Me.BtnQR.Location = New System.Drawing.Point(132, 283)
        Me.BtnQR.Name = "BtnQR"
        Me.BtnQR.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnQR.ShadowDecoration.Depth = 34
        Me.BtnQR.ShadowDecoration.Enabled = True
        Me.BtnQR.ShadowDecoration.Parent = Me.BtnQR
        Me.BtnQR.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BtnQR.Size = New System.Drawing.Size(131, 32)
        Me.BtnQR.TabIndex = 100
        Me.BtnQR.Text = "SAVE"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Save File|*.png"
        '
        'Timer1
        '
        '
        'GenerateQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 324)
        Me.Controls.Add(Me.BtnQR)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.CmbPurpose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GenerateQR"
        Me.Text = "GenerateQR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnQR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Timer1 As Timer
End Class
