<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewResident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewResident))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBdate = New System.Windows.Forms.DateTimePicker()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtCitizen = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelAge = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbCivilStat = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtBirth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.LblHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.BtnBack)
        Me.Guna2Panel1.Controls.Add(Me.BtnSave)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.txtid)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.TxtBdate)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2Panel1.Controls.Add(Me.TxtCitizen)
        Me.Guna2Panel1.Controls.Add(Me.LabelAge)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.TxtOccupation)
        Me.Guna2Panel1.Controls.Add(Me.CmbGender)
        Me.Guna2Panel1.Controls.Add(Me.CmbCivilStat)
        Me.Guna2Panel1.Controls.Add(Me.TxtBirth)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Location = New System.Drawing.Point(23, 48)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(718, 482)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.BtnBack.Location = New System.Drawing.Point(525, 430)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.ShadowDecoration.Enabled = True
        Me.BtnBack.ShadowDecoration.Parent = Me.BtnBack
        Me.BtnBack.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnBack.Size = New System.Drawing.Size(158, 32)
        Me.BtnBack.TabIndex = 30
        Me.BtnBack.Text = "BACK"
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
        Me.BtnSave.Location = New System.Drawing.Point(361, 430)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnSave.Size = New System.Drawing.Size(146, 32)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "SAVE"
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
        Me.TxtAddress.Location = New System.Drawing.Point(27, 156)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderText = ""
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.ShadowDecoration.Parent = Me.TxtAddress
        Me.TxtAddress.Size = New System.Drawing.Size(370, 40)
        Me.TxtAddress.TabIndex = 28
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(25, 18)
        Me.txtid.Name = "txtid"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.txtid, False)
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 27
        Me.txtid.Visible = False
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(565, 136)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(56, 21)
        Me.Guna2HtmlLabel9.TabIndex = 25
        Me.Guna2HtmlLabel9.Text = "PHOTO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(527, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Size = New System.Drawing.Size(123, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'TxtBdate
        '
        Me.TxtBdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtBdate.Location = New System.Drawing.Point(27, 313)
        Me.TxtBdate.Name = "TxtBdate"
        Me.TxtBdate.Size = New System.Drawing.Size(241, 27)
        Me.TxtBdate.TabIndex = 23
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(495, 350)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(111, 21)
        Me.Guna2HtmlLabel11.TabIndex = 22
        Me.Guna2HtmlLabel11.Text = "OCCUPATION:"
        '
        'TxtCitizen
        '
        Me.TxtCitizen.BorderColor = System.Drawing.Color.Gray
        Me.TxtCitizen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCitizen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCitizen.DefaultText = ""
        Me.TxtCitizen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCitizen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCitizen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCitizen.DisabledState.Parent = Me.TxtCitizen
        Me.TxtCitizen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCitizen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCitizen.FocusedState.Parent = Me.TxtCitizen
        Me.TxtCitizen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCitizen.ForeColor = System.Drawing.Color.Black
        Me.TxtCitizen.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCitizen.HoverState.Parent = Me.TxtCitizen
        Me.TxtCitizen.Location = New System.Drawing.Point(28, 402)
        Me.TxtCitizen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCitizen.Name = "TxtCitizen"
        Me.TxtCitizen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCitizen.PlaceholderText = ""
        Me.TxtCitizen.SelectedText = ""
        Me.TxtCitizen.ShadowDecoration.Parent = Me.TxtCitizen
        Me.TxtCitizen.Size = New System.Drawing.Size(195, 37)
        Me.TxtCitizen.TabIndex = 21
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = False
        Me.LabelAge.BackColor = System.Drawing.Color.Transparent
        Me.LabelAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelAge.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelAge.Location = New System.Drawing.Point(346, 304)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(40, 27)
        Me.LabelAge.TabIndex = 20
        Me.LabelAge.Text = "0"
        Me.LabelAge.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(495, 266)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(101, 21)
        Me.Guna2HtmlLabel8.TabIndex = 16
        Me.Guna2HtmlLabel8.Text = "CIVIL STATUS:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(28, 373)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(90, 21)
        Me.Guna2HtmlLabel7.TabIndex = 15
        Me.Guna2HtmlLabel7.Text = "CITIZENSHIP"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(498, 189)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(68, 21)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "GENDER:"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(346, 286)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(40, 21)
        Me.Guna2HtmlLabel5.TabIndex = 13
        Me.Guna2HtmlLabel5.Text = "AGE:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(26, 286)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(89, 21)
        Me.Guna2HtmlLabel4.TabIndex = 12
        Me.Guna2HtmlLabel4.Text = "BIRTH DATE:"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(24, 214)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(124, 21)
        Me.Guna2HtmlLabel3.TabIndex = 11
        Me.Guna2HtmlLabel3.Text = "PLACE OF BIRTH:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(26, 127)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(110, 21)
        Me.Guna2HtmlLabel2.TabIndex = 10
        Me.Guna2HtmlLabel2.Text = "FULL ADDRESS:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 44)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 21)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'TxtOccupation
        '
        Me.TxtOccupation.BorderColor = System.Drawing.Color.Gray
        Me.TxtOccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOccupation.DefaultText = ""
        Me.TxtOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOccupation.DisabledState.Parent = Me.TxtOccupation
        Me.TxtOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtOccupation.FocusedState.Parent = Me.TxtOccupation
        Me.TxtOccupation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOccupation.ForeColor = System.Drawing.Color.Black
        Me.TxtOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtOccupation.HoverState.Parent = Me.TxtOccupation
        Me.TxtOccupation.Location = New System.Drawing.Point(493, 379)
        Me.TxtOccupation.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtOccupation.Name = "TxtOccupation"
        Me.TxtOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOccupation.PlaceholderText = ""
        Me.TxtOccupation.SelectedText = ""
        Me.TxtOccupation.ShadowDecoration.Parent = Me.TxtOccupation
        Me.TxtOccupation.Size = New System.Drawing.Size(190, 37)
        Me.TxtOccupation.TabIndex = 8
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
        Me.CmbGender.Location = New System.Drawing.Point(498, 216)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.ShadowDecoration.Parent = Me.CmbGender
        Me.CmbGender.Size = New System.Drawing.Size(185, 36)
        Me.CmbGender.TabIndex = 6
        '
        'CmbCivilStat
        '
        Me.CmbCivilStat.BackColor = System.Drawing.Color.Transparent
        Me.CmbCivilStat.BorderColor = System.Drawing.Color.Gray
        Me.CmbCivilStat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbCivilStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCivilStat.FocusedColor = System.Drawing.Color.Empty
        Me.CmbCivilStat.FocusedState.Parent = Me.CmbCivilStat
        Me.CmbCivilStat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCivilStat.ForeColor = System.Drawing.Color.Black
        Me.CmbCivilStat.FormattingEnabled = True
        Me.CmbCivilStat.HoverState.Parent = Me.CmbCivilStat
        Me.CmbCivilStat.ItemHeight = 30
        Me.CmbCivilStat.Items.AddRange(New Object() {"SINGLE", "MARRIED", "WIDOW", "SEPARATED"})
        Me.CmbCivilStat.ItemsAppearance.Parent = Me.CmbCivilStat
        Me.CmbCivilStat.Location = New System.Drawing.Point(495, 293)
        Me.CmbCivilStat.Name = "CmbCivilStat"
        Me.CmbCivilStat.ShadowDecoration.Parent = Me.CmbCivilStat
        Me.CmbCivilStat.Size = New System.Drawing.Size(188, 36)
        Me.CmbCivilStat.TabIndex = 5
        '
        'TxtBirth
        '
        Me.TxtBirth.BorderColor = System.Drawing.Color.Gray
        Me.TxtBirth.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBirth.DefaultText = ""
        Me.TxtBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBirth.DisabledState.Parent = Me.TxtBirth
        Me.TxtBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBirth.FocusedState.Parent = Me.TxtBirth
        Me.TxtBirth.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBirth.ForeColor = System.Drawing.Color.Black
        Me.TxtBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBirth.HoverState.Parent = Me.TxtBirth
        Me.TxtBirth.Location = New System.Drawing.Point(26, 238)
        Me.TxtBirth.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBirth.Name = "TxtBirth"
        Me.TxtBirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBirth.PlaceholderText = ""
        Me.TxtBirth.SelectedText = ""
        Me.TxtBirth.ShadowDecoration.Parent = Me.TxtBirth
        Me.TxtBirth.Size = New System.Drawing.Size(370, 37)
        Me.TxtBirth.TabIndex = 2
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
        Me.TxtName.Location = New System.Drawing.Point(25, 65)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.PlaceholderText = ""
        Me.TxtName.SelectedText = ""
        Me.TxtName.ShadowDecoration.Parent = Me.TxtName
        Me.TxtName.Size = New System.Drawing.Size(370, 40)
        Me.TxtName.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "jpg"
        '
        'NetResize1
        '
        Me.NetResize1.FormFadeEffect = True
        Me.NetResize1.ParentControl = Me
        '
        'LblHeader
        '
        Me.LblHeader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHeader.BackColor = System.Drawing.Color.Transparent
        Me.LblHeader.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.Yellow
        Me.LblHeader.Location = New System.Drawing.Point(221, 12)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(368, 40)
        Me.LblHeader.TabIndex = 18
        Me.LblHeader.Text = "RESIDENT REGISTRATION"
        Me.LblHeader.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 30)
        Me.Panel1.TabIndex = 21
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(59, 37)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(271, 34)
        Me.Guna2HtmlLabel10.TabIndex = 44
        Me.Guna2HtmlLabel10.Text = "REGISTRATION FORM"
        '
        'AddNewResident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 554)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(400, 100)
        Me.Name = "AddNewResident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Add Resident"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbCivilStat As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtBirth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LabelAge As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtCitizen As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBdate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents LblHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtid As TextBox
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
