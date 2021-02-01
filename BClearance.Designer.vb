<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BClearance))
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TxtCtc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtOR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txtissued = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtValidity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnPreviewa = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSa = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Engravers MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(20, 10)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.NetResize1.SetResizeFont(Me.Guna2HtmlLabel12, False)
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(521, 39)
        Me.Guna2HtmlLabel12.TabIndex = 104
        Me.Guna2HtmlLabel12.Text = "BARANGAY CLEARANCE"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.BorderThickness = 2
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.Maroon
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.BorderColor = System.Drawing.Color.Black
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(535, 43)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnSave.Size = New System.Drawing.Size(103, 30)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "SEARCH"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CustomFormat = "MMMM d      yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(444, 177)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(235, 26)
        Me.DateTimePicker2.TabIndex = 30
        '
        'TxtCtc
        '
        Me.TxtCtc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtCtc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCtc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCtc.DefaultText = ""
        Me.TxtCtc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCtc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCtc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCtc.DisabledState.Parent = Me.TxtCtc
        Me.TxtCtc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCtc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCtc.FocusedState.Parent = Me.TxtCtc
        Me.TxtCtc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCtc.ForeColor = System.Drawing.Color.Black
        Me.TxtCtc.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtCtc.HoverState.Parent = Me.TxtCtc
        Me.TxtCtc.Location = New System.Drawing.Point(23, 247)
        Me.TxtCtc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCtc.Name = "TxtCtc"
        Me.TxtCtc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCtc.PlaceholderText = ""
        Me.TxtCtc.SelectedText = ""
        Me.TxtCtc.ShadowDecoration.Parent = Me.TxtCtc
        Me.TxtCtc.Size = New System.Drawing.Size(201, 30)
        Me.TxtCtc.TabIndex = 32
        '
        'TxtOR
        '
        Me.TxtOR.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOR.DefaultText = ""
        Me.TxtOR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOR.DisabledState.Parent = Me.TxtOR
        Me.TxtOR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOR.FocusedState.Parent = Me.TxtOR
        Me.TxtOR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOR.ForeColor = System.Drawing.Color.Black
        Me.TxtOR.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtOR.HoverState.Parent = Me.TxtOR
        Me.TxtOR.Location = New System.Drawing.Point(258, 247)
        Me.TxtOR.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtOR.Name = "TxtOR"
        Me.TxtOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOR.PlaceholderText = ""
        Me.TxtOR.SelectedText = ""
        Me.TxtOR.ShadowDecoration.Parent = Me.TxtOR
        Me.TxtOR.Size = New System.Drawing.Size(201, 30)
        Me.TxtOR.TabIndex = 35
        '
        'TxtFees
        '
        Me.TxtFees.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtFees.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtFees.DefaultText = "0"
        Me.TxtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFees.DisabledState.Parent = Me.TxtFees
        Me.TxtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFees.FocusedState.Parent = Me.TxtFees
        Me.TxtFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFees.ForeColor = System.Drawing.Color.Black
        Me.TxtFees.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtFees.HoverState.Parent = Me.TxtFees
        Me.TxtFees.Location = New System.Drawing.Point(515, 247)
        Me.TxtFees.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtFees.Name = "TxtFees"
        Me.TxtFees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFees.PlaceholderText = ""
        Me.TxtFees.SelectedText = ""
        Me.TxtFees.SelectionStart = 1
        Me.TxtFees.ShadowDecoration.Parent = Me.TxtFees
        Me.TxtFees.Size = New System.Drawing.Size(98, 30)
        Me.TxtFees.TabIndex = 37
        Me.TxtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtissued
        '
        Me.Txtissued.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txtissued.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtissued.DefaultText = "BARAS RIZAL"
        Me.Txtissued.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txtissued.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txtissued.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtissued.DisabledState.Parent = Me.Txtissued
        Me.Txtissued.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtissued.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txtissued.FocusedState.Parent = Me.Txtissued
        Me.Txtissued.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtissued.ForeColor = System.Drawing.Color.Black
        Me.Txtissued.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Txtissued.HoverState.Parent = Me.Txtissued
        Me.Txtissued.Location = New System.Drawing.Point(23, 315)
        Me.Txtissued.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Txtissued.Name = "Txtissued"
        Me.Txtissued.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtissued.PlaceholderText = ""
        Me.Txtissued.SelectedText = ""
        Me.Txtissued.SelectionStart = 11
        Me.Txtissued.ShadowDecoration.Parent = Me.Txtissued
        Me.Txtissued.Size = New System.Drawing.Size(201, 30)
        Me.Txtissued.TabIndex = 39
        '
        'TxtValidity
        '
        Me.TxtValidity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtValidity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValidity.DefaultText = "3 Months"
        Me.TxtValidity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtValidity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtValidity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValidity.DisabledState.Parent = Me.TxtValidity
        Me.TxtValidity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValidity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValidity.FocusedState.Parent = Me.TxtValidity
        Me.TxtValidity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValidity.ForeColor = System.Drawing.Color.Black
        Me.TxtValidity.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtValidity.HoverState.Parent = Me.TxtValidity
        Me.TxtValidity.Location = New System.Drawing.Point(260, 315)
        Me.TxtValidity.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtValidity.Name = "TxtValidity"
        Me.TxtValidity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtValidity.PlaceholderText = ""
        Me.TxtValidity.SelectedText = ""
        Me.TxtValidity.SelectionStart = 8
        Me.TxtValidity.ShadowDecoration.Parent = Me.TxtValidity
        Me.TxtValidity.Size = New System.Drawing.Size(199, 30)
        Me.TxtValidity.TabIndex = 40
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.CmbPurpose)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel1.Controls.Add(Me.TxtValidity)
        Me.Guna2Panel1.Controls.Add(Me.Txtissued)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.TxtFees)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.TxtOR)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.TxtCtc)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Guna2Panel1.Controls.Add(Me.BtnSave)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(18, 97)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(727, 382)
        Me.Guna2Panel1.TabIndex = 26
        '
        'TxtAddress
        '
        Me.TxtAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAddress.DefaultText = ""
        Me.TxtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.DisabledState.Parent = Me.TxtAddress
        Me.TxtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAddress.FocusedState.Parent = Me.TxtAddress
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.ForeColor = System.Drawing.Color.Black
        Me.TxtAddress.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtAddress.HoverState.Parent = Me.TxtAddress
        Me.TxtAddress.Location = New System.Drawing.Point(23, 107)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderText = ""
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.ShadowDecoration.Parent = Me.TxtAddress
        Me.TxtAddress.Size = New System.Drawing.Size(504, 30)
        Me.TxtAddress.TabIndex = 50
        '
        'TxtName
        '
        Me.TxtName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtName.DefaultText = ""
        Me.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtName.DisabledState.Parent = Me.TxtName
        Me.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtName.FocusedState.Parent = Me.TxtName
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.ForeColor = System.Drawing.Color.Black
        Me.TxtName.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtName.HoverState.Parent = Me.TxtName
        Me.TxtName.Location = New System.Drawing.Point(23, 43)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.PlaceholderText = ""
        Me.TxtName.SelectedText = ""
        Me.TxtName.ShadowDecoration.Parent = Me.TxtName
        Me.TxtName.Size = New System.Drawing.Size(504, 30)
        Me.TxtName.TabIndex = 49
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"EMPLOYMENT LOCAL/ABROAD", "ELECTRICAL PERMIT", "BUILDING/FENCING/RENOVATION PERMIT", "DIGGING/EXCAVATION PERMIT", "BUSINESS PERMIT", "VEHICLE REGISTRATION(CAR/TRUCK/TRICYCLE ETC)", "MARRIAGE", "GOOD MORAL CHARACTER"})
        Me.CmbPurpose.Location = New System.Drawing.Point(23, 177)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(382, 29)
        Me.CmbPurpose.TabIndex = 46
        Me.CmbPurpose.Text = "--Choose Purpose--"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(260, 298)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel9.TabIndex = 41
        Me.Guna2HtmlLabel9.Text = "VALIDITY:"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(23, 298)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(79, 21)
        Me.Guna2HtmlLabel8.TabIndex = 38
        Me.Guna2HtmlLabel8.Text = "ISSUED AT:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(515, 230)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(75, 21)
        Me.Guna2HtmlLabel7.TabIndex = 36
        Me.Guna2HtmlLabel7.Text = "AMOUNT:"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(260, 230)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(62, 21)
        Me.Guna2HtmlLabel6.TabIndex = 34
        Me.Guna2HtmlLabel6.Text = "O.R NO."
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(23, 230)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(67, 21)
        Me.Guna2HtmlLabel5.TabIndex = 33
        Me.Guna2HtmlLabel5.Text = "CTC NO."
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(444, 160)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(98, 21)
        Me.Guna2HtmlLabel3.TabIndex = 31
        Me.Guna2HtmlLabel3.Text = "DATE ISSUED:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(23, 160)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel4.TabIndex = 17
        Me.Guna2HtmlLabel4.Text = "PURPOSE:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(23, 90)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(114, 21)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "FULL ADDRESS :"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(23, 26)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 21)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderThickness = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel3.Location = New System.Drawing.Point(58, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(705, 47)
        Me.Guna2Panel3.TabIndex = 109
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Controls.Add(Me.BtnPreviewa)
        Me.Guna2Panel2.Controls.Add(Me.BtnSa)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 59)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(727, 39)
        Me.Guna2Panel2.TabIndex = 116
        '
        'BtnPreviewa
        '
        Me.BtnPreviewa.Animated = True
        Me.BtnPreviewa.BackColor = System.Drawing.Color.Transparent
        Me.BtnPreviewa.BorderColor = System.Drawing.Color.White
        Me.BtnPreviewa.BorderRadius = 5
        Me.BtnPreviewa.CheckedState.Parent = Me.BtnPreviewa
        Me.BtnPreviewa.CustomImages.Parent = Me.BtnPreviewa
        Me.BtnPreviewa.FillColor = System.Drawing.Color.White
        Me.BtnPreviewa.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreviewa.ForeColor = System.Drawing.Color.White
        Me.BtnPreviewa.HoverState.BorderColor = System.Drawing.Color.White
        Me.BtnPreviewa.HoverState.FillColor = System.Drawing.Color.White
        Me.BtnPreviewa.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnPreviewa.HoverState.Parent = Me.BtnPreviewa
        Me.BtnPreviewa.Image = CType(resources.GetObject("BtnPreviewa.Image"), System.Drawing.Image)
        Me.BtnPreviewa.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnPreviewa.Location = New System.Drawing.Point(685, 4)
        Me.BtnPreviewa.Name = "BtnPreviewa"
        Me.BtnPreviewa.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnPreviewa.ShadowDecoration.Enabled = True
        Me.BtnPreviewa.ShadowDecoration.Parent = Me.BtnPreviewa
        Me.BtnPreviewa.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BtnPreviewa.Size = New System.Drawing.Size(38, 34)
        Me.BtnPreviewa.TabIndex = 110
        '
        'BtnSa
        '
        Me.BtnSa.Animated = True
        Me.BtnSa.BackColor = System.Drawing.Color.Transparent
        Me.BtnSa.BorderRadius = 5
        Me.BtnSa.CheckedState.Parent = Me.BtnSa
        Me.BtnSa.CustomImages.Parent = Me.BtnSa
        Me.BtnSa.FillColor = System.Drawing.Color.White
        Me.BtnSa.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSa.ForeColor = System.Drawing.Color.White
        Me.BtnSa.HoverState.FillColor = System.Drawing.Color.White
        Me.BtnSa.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnSa.HoverState.Parent = Me.BtnSa
        Me.BtnSa.Image = CType(resources.GetObject("BtnSa.Image"), System.Drawing.Image)
        Me.BtnSa.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnSa.Location = New System.Drawing.Point(646, 4)
        Me.BtnSa.Name = "BtnSa"
        Me.BtnSa.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnSa.ShadowDecoration.Enabled = True
        Me.BtnSa.ShadowDecoration.Parent = Me.BtnSa
        Me.BtnSa.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BtnSa.Size = New System.Drawing.Size(38, 34)
        Me.BtnSa.TabIndex = 74
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(16, 11)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(269, 31)
        Me.Guna2HtmlLabel11.TabIndex = 114
        Me.Guna2HtmlLabel11.Text = "TRANSACTION FORM"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderThickness = 5
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.CheckedImage = CType(resources.GetObject("Guna2Button1.CustomImages.CheckedImage"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.HoveredImage = CType(resources.GetObject("Guna2Button1.CustomImages.HoveredImage"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.Image = CType(resources.GetObject("Guna2Button1.CustomImages.Image"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button1.CustomImages.ImageOffset = New System.Drawing.Point(4, 0)
        Me.Guna2Button1.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(56, 47)
        Me.Guna2Button1.TabIndex = 109
        '
        'BClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 496)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BClearance"
        Me.ShowInTaskbar = False
        Me.Text = "BClearance"
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtValidity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txtissued As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtFees As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtOR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtCtc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnPreviewa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
