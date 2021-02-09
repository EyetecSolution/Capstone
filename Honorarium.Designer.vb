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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Honorarium))
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Txtnet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtRecieved = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtDeduct = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtHonor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnPreviewa = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSa = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"BRGY.OFFICIAL", "BRGY.STAFF", "TANOD"})
        Me.CmbPurpose.Location = New System.Drawing.Point(32, 245)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(310, 27)
        Me.CmbPurpose.TabIndex = 91
        Me.CmbPurpose.Text = "---SELECT POSITION---"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderThickness = 3
        Me.Guna2Panel2.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(695, 189)
        Me.Guna2Panel2.TabIndex = 94
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(689, 183)
        Me.DataGridView1.TabIndex = 64
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 4
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Txtnet)
        Me.Guna2Panel1.Controls.Add(Me.TxtRecieved)
        Me.Guna2Panel1.Controls.Add(Me.TxtDeduct)
        Me.Guna2Panel1.Controls.Add(Me.TxtHonor)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.CmbPurpose)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(18, 97)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(727, 425)
        Me.Guna2Panel1.TabIndex = 29
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(32, 226)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(71, 18)
        Me.Guna2HtmlLabel6.TabIndex = 109
        Me.Guna2HtmlLabel6.Text = "POSITION :"
        '
        'Txtnet
        '
        Me.Txtnet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txtnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtnet.DefaultText = ""
        Me.Txtnet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txtnet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txtnet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtnet.DisabledState.Parent = Me.Txtnet
        Me.Txtnet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtnet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txtnet.FocusedState.Parent = Me.Txtnet
        Me.Txtnet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnet.ForeColor = System.Drawing.Color.Black
        Me.Txtnet.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Txtnet.HoverState.Parent = Me.Txtnet
        Me.Txtnet.Location = New System.Drawing.Point(387, 361)
        Me.Txtnet.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Txtnet.Name = "Txtnet"
        Me.Txtnet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtnet.PlaceholderText = ""
        Me.Txtnet.ReadOnly = True
        Me.Txtnet.SelectedText = ""
        Me.Txtnet.ShadowDecoration.Parent = Me.Txtnet
        Me.Txtnet.Size = New System.Drawing.Size(309, 30)
        Me.Txtnet.TabIndex = 108
        '
        'TxtRecieved
        '
        Me.TxtRecieved.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRecieved.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecieved.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtRecieved.DefaultText = ""
        Me.TxtRecieved.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtRecieved.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtRecieved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRecieved.DisabledState.Parent = Me.TxtRecieved
        Me.TxtRecieved.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtRecieved.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtRecieved.FocusedState.Parent = Me.TxtRecieved
        Me.TxtRecieved.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecieved.ForeColor = System.Drawing.Color.Black
        Me.TxtRecieved.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtRecieved.HoverState.Parent = Me.TxtRecieved
        Me.TxtRecieved.Location = New System.Drawing.Point(387, 303)
        Me.TxtRecieved.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtRecieved.Name = "TxtRecieved"
        Me.TxtRecieved.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtRecieved.PlaceholderText = ""
        Me.TxtRecieved.SelectedText = ""
        Me.TxtRecieved.ShadowDecoration.Parent = Me.TxtRecieved
        Me.TxtRecieved.Size = New System.Drawing.Size(309, 30)
        Me.TxtRecieved.TabIndex = 107
        '
        'TxtDeduct
        '
        Me.TxtDeduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtDeduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDeduct.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtDeduct.DefaultText = ""
        Me.TxtDeduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtDeduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtDeduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDeduct.DisabledState.Parent = Me.TxtDeduct
        Me.TxtDeduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtDeduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDeduct.FocusedState.Parent = Me.TxtDeduct
        Me.TxtDeduct.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDeduct.ForeColor = System.Drawing.Color.Black
        Me.TxtDeduct.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtDeduct.HoverState.Parent = Me.TxtDeduct
        Me.TxtDeduct.Location = New System.Drawing.Point(386, 245)
        Me.TxtDeduct.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtDeduct.Name = "TxtDeduct"
        Me.TxtDeduct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDeduct.PlaceholderText = ""
        Me.TxtDeduct.SelectedText = ""
        Me.TxtDeduct.ShadowDecoration.Parent = Me.TxtDeduct
        Me.TxtDeduct.Size = New System.Drawing.Size(309, 30)
        Me.TxtDeduct.TabIndex = 106
        '
        'TxtHonor
        '
        Me.TxtHonor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtHonor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtHonor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHonor.DefaultText = ""
        Me.TxtHonor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtHonor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtHonor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHonor.DisabledState.Parent = Me.TxtHonor
        Me.TxtHonor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtHonor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtHonor.FocusedState.Parent = Me.TxtHonor
        Me.TxtHonor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHonor.ForeColor = System.Drawing.Color.Black
        Me.TxtHonor.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtHonor.HoverState.Parent = Me.TxtHonor
        Me.TxtHonor.Location = New System.Drawing.Point(31, 361)
        Me.TxtHonor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtHonor.Name = "TxtHonor"
        Me.TxtHonor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtHonor.PlaceholderText = ""
        Me.TxtHonor.SelectedText = ""
        Me.TxtHonor.ShadowDecoration.Parent = Me.TxtHonor
        Me.TxtHonor.Size = New System.Drawing.Size(309, 30)
        Me.TxtHonor.TabIndex = 105
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
        Me.TxtName.Location = New System.Drawing.Point(32, 303)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.PlaceholderText = ""
        Me.TxtName.SelectedText = ""
        Me.TxtName.ShadowDecoration.Parent = Me.TxtName
        Me.TxtName.Size = New System.Drawing.Size(309, 30)
        Me.TxtName.TabIndex = 104
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(387, 284)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(108, 18)
        Me.Guna2HtmlLabel5.TabIndex = 102
        Me.Guna2HtmlLabel5.Text = "DATE RECEIVED :"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(387, 342)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(63, 18)
        Me.Guna2HtmlLabel4.TabIndex = 99
        Me.Guna2HtmlLabel4.Text = "NET PAY :"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(387, 226)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(85, 18)
        Me.Guna2HtmlLabel3.TabIndex = 97
        Me.Guna2HtmlLabel3.Text = "DEDUCTION :"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(32, 342)
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
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 284)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
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
        Me.TxtSearch.Location = New System.Drawing.Point(12, 7)
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
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(212, 39)
        Me.Guna2HtmlLabel12.TabIndex = 104
        Me.Guna2HtmlLabel12.Text = "PAYROLL"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderThickness = 5
        Me.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.CheckedImage = CType(resources.GetObject("Guna2Button2.CustomImages.CheckedImage"), System.Drawing.Image)
        Me.Guna2Button2.CustomImages.HoveredImage = CType(resources.GetObject("Guna2Button2.CustomImages.HoveredImage"), System.Drawing.Image)
        Me.Guna2Button2.CustomImages.Image = CType(resources.GetObject("Guna2Button2.CustomImages.Image"), System.Drawing.Image)
        Me.Guna2Button2.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button2.CustomImages.ImageOffset = New System.Drawing.Point(4, 0)
        Me.Guna2Button2.CustomImages.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(56, 47)
        Me.Guna2Button2.TabIndex = 112
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
        Me.Guna2Panel3.TabIndex = 113
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.Controls.Add(Me.BtnPreviewa)
        Me.Guna2Panel4.Controls.Add(Me.BtnSa)
        Me.Guna2Panel4.Controls.Add(Me.TxtSearch)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Guna2Panel4.Location = New System.Drawing.Point(18, 59)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(727, 39)
        Me.Guna2Panel4.TabIndex = 117
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
        'Honorarium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 537)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Honorarium"
        Me.Text = "Honorarium"
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnPreviewa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSa As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Txtnet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtRecieved As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtDeduct As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtHonor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
