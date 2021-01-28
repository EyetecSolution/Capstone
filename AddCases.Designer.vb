<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCases))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.TxtDescription)
        Me.Guna2Panel1.Controls.Add(Me.TxtAge)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.BtnSave)
        Me.Guna2Panel1.Controls.Add(Me.CmbGender)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 53)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(501, 356)
        Me.Guna2Panel1.TabIndex = 24
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(18, 256)
        Me.TxtDescription.Name = "TxtDescription"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtDescription, False)
        Me.TxtDescription.Size = New System.Drawing.Size(460, 27)
        Me.TxtDescription.TabIndex = 46
        '
        'TxtAge
        '
        Me.TxtAge.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(438, 196)
        Me.TxtAge.MaxLength = 3
        Me.TxtAge.Name = "TxtAge"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtAge, False)
        Me.TxtAge.Size = New System.Drawing.Size(40, 23)
        Me.TxtAge.TabIndex = 45
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(18, 122)
        Me.TxtAddress.Name = "TxtAddress"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtAddress, False)
        Me.TxtAddress.Size = New System.Drawing.Size(460, 27)
        Me.TxtAddress.TabIndex = 44
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(18, 49)
        Me.TxtName.Name = "TxtName"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtName, False)
        Me.TxtName.Size = New System.Drawing.Size(460, 27)
        Me.TxtName.TabIndex = 43
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PUM(CLEAR)", "PUM(ONGOING)", "PUI", "DEATH", "RECOVERED", "CONFIRMED"})
        Me.ComboBox1.Location = New System.Drawing.Point(227, 196)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 26)
        Me.ComboBox1.TabIndex = 40
        Me.ComboBox1.Text = "--Choose Condition--"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.BorderThickness = 2
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.Maroon
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.BorderColor = System.Drawing.Color.Black
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(329, 306)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnSave.Size = New System.Drawing.Size(149, 27)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "SAVE"
        '
        'CmbGender
        '
        Me.CmbGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CmbGender.Location = New System.Drawing.Point(18, 196)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(187, 26)
        Me.CmbGender.TabIndex = 38
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(18, 242)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(90, 21)
        Me.Guna2HtmlLabel4.TabIndex = 36
        Me.Guna2HtmlLabel4.Text = "SYMPTOMS:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(227, 182)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(95, 21)
        Me.Guna2HtmlLabel3.TabIndex = 35
        Me.Guna2HtmlLabel3.Text = "CONDITION:"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(18, 182)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(68, 21)
        Me.Guna2HtmlLabel6.TabIndex = 32
        Me.Guna2HtmlLabel6.Text = "GENDER:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(438, 182)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(40, 21)
        Me.Guna2HtmlLabel5.TabIndex = 31
        Me.Guna2HtmlLabel5.Text = "AGE:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 108)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(110, 21)
        Me.Guna2HtmlLabel2.TabIndex = 12
        Me.Guna2HtmlLabel2.Text = "FULL ADDRESS:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 35)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 21)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Elephant", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(157, 9)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.NetResize1.SetResizeFont(Me.Guna2HtmlLabel8, False)
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(303, 40)
        Me.Guna2HtmlLabel8.TabIndex = 104
        Me.Guna2HtmlLabel8.Text = "ADD NEW CASES"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(30, 47)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(206, 29)
        Me.Guna2HtmlLabel7.TabIndex = 43
        Me.Guna2HtmlLabel7.Text = "Personal Information"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderThickness = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel3.Location = New System.Drawing.Point(62, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(464, 41)
        Me.Guna2Panel3.TabIndex = 58
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderThickness = 5
        Me.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.CheckedImage = CType(resources.GetObject("Guna2Button4.CustomImages.CheckedImage"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.HoveredImage = CType(resources.GetObject("Guna2Button4.CustomImages.HoveredImage"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.Image = CType(resources.GetObject("Guna2Button4.CustomImages.Image"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button4.CustomImages.ImageOffset = New System.Drawing.Point(4, 0)
        Me.Guna2Button4.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2Button4.Location = New System.Drawing.Point(3, 0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(56, 41)
        Me.Guna2Button4.TabIndex = 105
        '
        'AddCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(527, 422)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCases"
        Me.Text = "AddCases"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CmbGender As ComboBox
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
End Class
