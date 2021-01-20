<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Honorarium
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Honorarium))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtRecieved = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txtnet = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtDeduct = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtHonor = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Guna2Button4)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 32)
        Me.Panel1.TabIndex = 28
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(28, 41)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(114, 29)
        Me.LblTitle.TabIndex = 56
        Me.LblTitle.Text = "PAYROLL"
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(13, 67)
        Me.TxtName.Name = "TxtName"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtName, False)
        Me.TxtName.Size = New System.Drawing.Size(349, 23)
        Me.TxtName.TabIndex = 1
        '
        'BtnSave
        '
        Me.BtnSave.Animated = True
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderColor = System.Drawing.Color.White
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.BorderThickness = 1
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.Maroon
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Location = New System.Drawing.Point(468, 43)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BtnSave.Size = New System.Drawing.Size(165, 25)
        Me.BtnSave.TabIndex = 74
        Me.BtnSave.Text = "SAVE"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.White
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(468, 18)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button1.Size = New System.Drawing.Size(165, 25)
        Me.Guna2Button1.TabIndex = 75
        Me.Guna2Button1.Text = "PRINT PAYSLIP"
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"BRGY.OFFICIAL", "BRGY.STAFF", "TANOD"})
        Me.CmbPurpose.Location = New System.Drawing.Point(13, 25)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(215, 24)
        Me.CmbPurpose.TabIndex = 91
        Me.CmbPurpose.Text = "SELECT POSITION"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Maroon
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(13, 222)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(621, 177)
        Me.Guna2Panel2.TabIndex = 94
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(610, 168)
        Me.DataGridView1.TabIndex = 64
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.TxtRecieved)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.TxtSearch)
        Me.Guna2Panel1.Controls.Add(Me.Txtnet)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.TxtDeduct)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.TxtHonor)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.CmbPurpose)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.BtnSave)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(4, 50)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(646, 411)
        Me.Guna2Panel1.TabIndex = 29
        '
        'TxtRecieved
        '
        Me.TxtRecieved.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecieved.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecieved.HideSelection = False
        Me.TxtRecieved.Location = New System.Drawing.Point(419, 106)
        Me.TxtRecieved.Name = "TxtRecieved"
        Me.TxtRecieved.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtRecieved, False)
        Me.TxtRecieved.Size = New System.Drawing.Size(215, 23)
        Me.TxtRecieved.TabIndex = 103
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(419, 90)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(108, 18)
        Me.Guna2HtmlLabel5.TabIndex = 102
        Me.Guna2HtmlLabel5.Text = "DATE RECEIVED :"
        '
        'TxtSearch
        '
        Me.TxtSearch.Animated = True
        Me.TxtSearch.BackColor = System.Drawing.Color.Transparent
        Me.TxtSearch.BorderColor = System.Drawing.Color.Maroon
        Me.TxtSearch.BorderRadius = 10
        Me.TxtSearch.BorderThickness = 2
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.Parent = Me.TxtSearch
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSearch.FocusedState.Parent = Me.TxtSearch
        Me.TxtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.Silver
        Me.TxtSearch.HoverState.Parent = Me.TxtSearch
        Me.TxtSearch.IconLeftOffset = New System.Drawing.Point(30, 0)
        Me.TxtSearch.IconRight = CType(resources.GetObject("TxtSearch.IconRight"), System.Drawing.Image)
        Me.TxtSearch.IconRightOffset = New System.Drawing.Point(15, 0)
        Me.TxtSearch.Location = New System.Drawing.Point(13, 185)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtSearch.PlaceholderText = "Search..."
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.ShadowDecoration.Depth = 18
        Me.TxtSearch.ShadowDecoration.Enabled = True
        Me.TxtSearch.ShadowDecoration.Parent = Me.TxtSearch
        Me.TxtSearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.TxtSearch.Size = New System.Drawing.Size(252, 29)
        Me.TxtSearch.TabIndex = 101
        '
        'Txtnet
        '
        Me.Txtnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnet.HideSelection = False
        Me.Txtnet.Location = New System.Drawing.Point(419, 145)
        Me.Txtnet.Name = "Txtnet"
        Me.Txtnet.ReadOnly = True
        Me.NetResize1.SetResizeTextBoxMultiline(Me.Txtnet, False)
        Me.Txtnet.Size = New System.Drawing.Size(215, 23)
        Me.Txtnet.TabIndex = 100
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(419, 129)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(63, 18)
        Me.Guna2HtmlLabel4.TabIndex = 99
        Me.Guna2HtmlLabel4.Text = "NET PAY :"
        '
        'TxtDeduct
        '
        Me.TxtDeduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeduct.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeduct.Location = New System.Drawing.Point(13, 145)
        Me.TxtDeduct.Name = "TxtDeduct"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtDeduct, False)
        Me.TxtDeduct.Size = New System.Drawing.Size(215, 23)
        Me.TxtDeduct.TabIndex = 3
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(13, 129)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(85, 18)
        Me.Guna2HtmlLabel3.TabIndex = 97
        Me.Guna2HtmlLabel3.Text = "DEDUCTION :"
        '
        'TxtHonor
        '
        Me.TxtHonor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtHonor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHonor.Location = New System.Drawing.Point(13, 106)
        Me.TxtHonor.Name = "TxtHonor"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtHonor, False)
        Me.TxtHonor.Size = New System.Drawing.Size(215, 23)
        Me.TxtHonor.TabIndex = 2
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 90)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(94, 18)
        Me.Guna2HtmlLabel2.TabIndex = 95
        Me.Guna2HtmlLabel2.Text = "HONORARIUM"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(21, 201)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel7.TabIndex = 56
        Me.Guna2HtmlLabel7.Text = Nothing
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 51)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'Guna2Button4
        '
        Me.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.CheckedImage = CType(resources.GetObject("Guna2Button4.CustomImages.CheckedImage"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.HoveredImage = CType(resources.GetObject("Guna2Button4.CustomImages.HoveredImage"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.Image = CType(resources.GetObject("Guna2Button4.CustomImages.Image"), System.Drawing.Image)
        Me.Guna2Button4.CustomImages.ImageOffset = New System.Drawing.Point(4, 0)
        Me.Guna2Button4.CustomImages.ImageSize = New System.Drawing.Size(24, 24)
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Button4.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(47, 32)
        Me.Guna2Button4.TabIndex = 103
        '
        'Honorarium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 480)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Honorarium"
        Me.Text = "Honorarium"
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Txtnet As TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents TxtRecieved As TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtDeduct As TextBox
    Friend WithEvents TxtHonor As TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
End Class
