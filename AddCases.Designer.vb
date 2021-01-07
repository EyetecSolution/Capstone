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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblHeader2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.ID = New System.Windows.Forms.TextBox()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.LblHeader2)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 41)
        Me.Panel1.TabIndex = 23
        '
        'LblHeader2
        '
        Me.LblHeader2.BackColor = System.Drawing.Color.Maroon
        Me.LblHeader2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHeader2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader2.ForeColor = System.Drawing.SystemColors.Info
        Me.LblHeader2.Location = New System.Drawing.Point(244, 7)
        Me.LblHeader2.Name = "LblHeader2"
        Me.LblHeader2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblHeader2.Size = New System.Drawing.Size(230, 36)
        Me.LblHeader2.TabIndex = 0
        Me.LblHeader2.Text = "ADD NEW CASES"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.TxtDescription)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.CmbCategory)
        Me.Guna2Panel1.Controls.Add(Me.TxtAge)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.CmbGender)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(29, 70)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(613, 357)
        Me.Guna2Panel1.TabIndex = 24
        '
        'TxtDescription
        '
        Me.TxtDescription.BorderColor = System.Drawing.Color.Gray
        Me.TxtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDescription.DefaultText = ""
        Me.TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDescription.DisabledState.Parent = Me.TxtDescription
        Me.TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtDescription.FocusedState.Parent = Me.TxtDescription
        Me.TxtDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.ForeColor = System.Drawing.Color.Black
        Me.TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDescription.HoverState.Parent = Me.TxtDescription
        Me.TxtDescription.Location = New System.Drawing.Point(18, 293)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDescription.PlaceholderText = ""
        Me.TxtDescription.SelectedText = ""
        Me.TxtDescription.ShadowDecoration.Parent = Me.TxtDescription
        Me.TxtDescription.Size = New System.Drawing.Size(573, 47)
        Me.TxtDescription.TabIndex = 37
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(18, 264)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(90, 21)
        Me.Guna2HtmlLabel4.TabIndex = 36
        Me.Guna2HtmlLabel4.Text = "SYMPTOMS:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(496, 196)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(95, 21)
        Me.Guna2HtmlLabel3.TabIndex = 35
        Me.Guna2HtmlLabel3.Text = "CONDITION:"
        '
        'CmbCategory
        '
        Me.CmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.CmbCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmbCategory.FocusedColor = System.Drawing.Color.Empty
        Me.CmbCategory.FocusedState.Parent = Me.CmbCategory
        Me.CmbCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.HoverState.Parent = Me.CmbCategory
        Me.CmbCategory.ItemHeight = 30
        Me.CmbCategory.Items.AddRange(New Object() {"PUM(CLEAR)", "PUM(ONGOING)", "PUI", "DEATH", "RECOVERED", "CONFIRMED"})
        Me.CmbCategory.ItemsAppearance.Parent = Me.CmbCategory
        Me.CmbCategory.Location = New System.Drawing.Point(350, 223)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.ShadowDecoration.Parent = Me.CmbCategory
        Me.CmbCategory.Size = New System.Drawing.Size(241, 36)
        Me.CmbCategory.TabIndex = 34
        '
        'TxtAge
        '
        Me.TxtAge.BorderColor = System.Drawing.Color.Gray
        Me.TxtAge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAge.DefaultText = ""
        Me.TxtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAge.DisabledState.Parent = Me.TxtAge
        Me.TxtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAge.FocusedState.Parent = Me.TxtAge
        Me.TxtAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.ForeColor = System.Drawing.Color.Black
        Me.TxtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAge.HoverState.Parent = Me.TxtAge
        Me.TxtAge.Location = New System.Drawing.Point(236, 222)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAge.PlaceholderText = ""
        Me.TxtAge.SelectedText = ""
        Me.TxtAge.ShadowDecoration.Parent = Me.TxtAge
        Me.TxtAge.Size = New System.Drawing.Size(57, 28)
        Me.TxtAge.TabIndex = 33
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(18, 196)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(68, 21)
        Me.Guna2HtmlLabel6.TabIndex = 32
        Me.Guna2HtmlLabel6.Text = "GENDER:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(242, 196)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(40, 21)
        Me.Guna2HtmlLabel5.TabIndex = 31
        Me.Guna2HtmlLabel5.Text = "AGE:"
        '
        'CmbGender
        '
        Me.CmbGender.BackColor = System.Drawing.Color.Transparent
        Me.CmbGender.BorderColor = System.Drawing.Color.Gray
        Me.CmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.CmbGender.FocusedState.Parent = Me.CmbGender
        Me.CmbGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGender.ForeColor = System.Drawing.Color.Black
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.HoverState.Parent = Me.CmbGender
        Me.CmbGender.ItemHeight = 30
        Me.CmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CmbGender.ItemsAppearance.Parent = Me.CmbGender
        Me.CmbGender.Location = New System.Drawing.Point(18, 222)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.ShadowDecoration.Parent = Me.CmbGender
        Me.CmbGender.Size = New System.Drawing.Size(185, 36)
        Me.CmbGender.TabIndex = 30
        '
        'TxtAddress
        '
        Me.TxtAddress.BorderColor = System.Drawing.Color.Gray
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.DefaultText = ""
        Me.TxtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.DisabledState.Parent = Me.TxtAddress
        Me.TxtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAddress.FocusedState.Parent = Me.TxtAddress
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.ForeColor = System.Drawing.Color.Black
        Me.TxtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAddress.HoverState.Parent = Me.TxtAddress
        Me.TxtAddress.Location = New System.Drawing.Point(18, 140)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderText = ""
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.ShadowDecoration.Parent = Me.TxtAddress
        Me.TxtAddress.Size = New System.Drawing.Size(573, 40)
        Me.TxtAddress.TabIndex = 29
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(18, 115)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(110, 21)
        Me.Guna2HtmlLabel2.TabIndex = 12
        Me.Guna2HtmlLabel2.Text = "FULL ADDRESS:"
        '
        'TxtName
        '
        Me.TxtName.BorderColor = System.Drawing.Color.Gray
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.DefaultText = ""
        Me.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtName.DisabledState.Parent = Me.TxtName
        Me.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtName.FocusedState.Parent = Me.TxtName
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.Color.Black
        Me.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtName.HoverState.Parent = Me.TxtName
        Me.TxtName.Location = New System.Drawing.Point(18, 50)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.PlaceholderText = ""
        Me.TxtName.SelectedText = ""
        Me.TxtName.ShadowDecoration.Parent = Me.TxtName
        Me.TxtName.Size = New System.Drawing.Size(573, 40)
        Me.TxtName.TabIndex = 11
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(18, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 21)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(29, 45)
        Me.ID.Name = "ID"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.ID, False)
        Me.ID.Size = New System.Drawing.Size(100, 20)
        Me.ID.TabIndex = 29
        Me.ID.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.Maroon
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(324, 445)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnSave.Size = New System.Drawing.Size(146, 32)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "SAVE"
        '
        'BtnBack
        '
        Me.BtnBack.CheckedState.Parent = Me.BtnBack
        Me.BtnBack.CustomImages.Parent = Me.BtnBack
        Me.BtnBack.FillColor = System.Drawing.Color.Maroon
        Me.BtnBack.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.Color.White
        Me.BtnBack.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBack.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBack.HoverState.Parent = Me.BtnBack
        Me.BtnBack.Location = New System.Drawing.Point(484, 445)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.ShadowDecoration.Enabled = True
        Me.BtnBack.ShadowDecoration.Parent = Me.BtnBack
        Me.BtnBack.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnBack.Size = New System.Drawing.Size(158, 32)
        Me.BtnBack.TabIndex = 28
        Me.BtnBack.Text = "BACK"
        '
        'AddCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 519)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddCases"
        Me.Text = "AddCases"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblHeader2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ID As TextBox
End Class
