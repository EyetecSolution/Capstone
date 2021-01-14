<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsList
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.RdSpes1 = New System.Windows.Forms.RadioButton()
        Me.RdSpes = New System.Windows.Forms.RadioButton()
        Me.RdOATH = New System.Windows.Forms.RadioButton()
        Me.RdSoloParent = New System.Windows.Forms.RadioButton()
        Me.RdNonRes = New System.Windows.Forms.RadioButton()
        Me.RdResidency = New System.Windows.Forms.RadioButton()
        Me.RdIndigency = New System.Windows.Forms.RadioButton()
        Me.RdBusinessC = New System.Windows.Forms.RadioButton()
        Me.RdBClearance = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPrint2 = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbStreet = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnShowAll = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnGo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.BtnShow)
        Me.GroupBox1.Controls.Add(Me.RdSpes1)
        Me.GroupBox1.Controls.Add(Me.RdSpes)
        Me.GroupBox1.Controls.Add(Me.RdOATH)
        Me.GroupBox1.Controls.Add(Me.RdSoloParent)
        Me.GroupBox1.Controls.Add(Me.RdNonRes)
        Me.GroupBox1.Controls.Add(Me.RdResidency)
        Me.GroupBox1.Controls.Add(Me.RdIndigency)
        Me.GroupBox1.Controls.Add(Me.RdBusinessC)
        Me.GroupBox1.Controls.Add(Me.RdBClearance)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 367)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPORT FILTER"
        '
        'BtnPrint
        '
        Me.BtnPrint.BorderColor = System.Drawing.Color.White
        Me.BtnPrint.BorderThickness = 1
        Me.BtnPrint.CheckedState.Parent = Me.BtnPrint
        Me.BtnPrint.CustomImages.Parent = Me.BtnPrint
        Me.BtnPrint.FillColor = System.Drawing.Color.Maroon
        Me.BtnPrint.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrint.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint.HoverState.Parent = Me.BtnPrint
        Me.BtnPrint.Location = New System.Drawing.Point(7, 332)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.ShadowDecoration.Enabled = True
        Me.BtnPrint.ShadowDecoration.Parent = Me.BtnPrint
        Me.BtnPrint.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnPrint.Size = New System.Drawing.Size(333, 27)
        Me.BtnPrint.TabIndex = 29
        Me.BtnPrint.Text = "PRINT RECORD'S"
        '
        'BtnShow
        '
        Me.BtnShow.BorderColor = System.Drawing.Color.White
        Me.BtnShow.BorderThickness = 1
        Me.BtnShow.CheckedState.Parent = Me.BtnShow
        Me.BtnShow.CustomImages.Parent = Me.BtnShow
        Me.BtnShow.FillColor = System.Drawing.Color.Maroon
        Me.BtnShow.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnShow.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnShow.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnShow.HoverState.Parent = Me.BtnShow
        Me.BtnShow.Location = New System.Drawing.Point(7, 301)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.ShadowDecoration.Enabled = True
        Me.BtnShow.ShadowDecoration.Parent = Me.BtnShow
        Me.BtnShow.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnShow.Size = New System.Drawing.Size(333, 27)
        Me.BtnShow.TabIndex = 28
        Me.BtnShow.Text = "SHOW RECORD'S"
        '
        'RdSpes1
        '
        Me.RdSpes1.AutoSize = True
        Me.RdSpes1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdSpes1.Location = New System.Drawing.Point(6, 274)
        Me.RdSpes1.Name = "RdSpes1"
        Me.RdSpes1.Size = New System.Drawing.Size(290, 21)
        Me.RdSpes1.TabIndex = 8
        Me.RdSpes1.TabStop = True
        Me.RdSpes1.Text = "List of Certificate of SPES (for school yout)"
        Me.RdSpes1.UseVisualStyleBackColor = True
        '
        'RdSpes
        '
        Me.RdSpes.AutoSize = True
        Me.RdSpes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdSpes.Location = New System.Drawing.Point(7, 243)
        Me.RdSpes.Name = "RdSpes"
        Me.RdSpes.Size = New System.Drawing.Size(333, 21)
        Me.RdSpes.TabIndex = 7
        Me.RdSpes.TabStop = True
        Me.RdSpes.Text = "List of Certificate of SPES (for out of school yout)"
        Me.RdSpes.UseVisualStyleBackColor = True
        '
        'RdOATH
        '
        Me.RdOATH.AutoSize = True
        Me.RdOATH.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdOATH.Location = New System.Drawing.Point(7, 212)
        Me.RdOATH.Name = "RdOATH"
        Me.RdOATH.Size = New System.Drawing.Size(271, 21)
        Me.RdOATH.TabIndex = 6
        Me.RdOATH.TabStop = True
        Me.RdOATH.Text = "List of Certificate of OATH Undertaking"
        Me.RdOATH.UseVisualStyleBackColor = True
        '
        'RdSoloParent
        '
        Me.RdSoloParent.AutoSize = True
        Me.RdSoloParent.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdSoloParent.Location = New System.Drawing.Point(6, 181)
        Me.RdSoloParent.Name = "RdSoloParent"
        Me.RdSoloParent.Size = New System.Drawing.Size(228, 21)
        Me.RdSoloParent.TabIndex = 5
        Me.RdSoloParent.TabStop = True
        Me.RdSoloParent.Text = "List of Certificate of Solo Parent"
        Me.RdSoloParent.UseVisualStyleBackColor = True
        '
        'RdNonRes
        '
        Me.RdNonRes.AutoSize = True
        Me.RdNonRes.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdNonRes.Location = New System.Drawing.Point(7, 150)
        Me.RdNonRes.Name = "RdNonRes"
        Me.RdNonRes.Size = New System.Drawing.Size(249, 21)
        Me.RdNonRes.TabIndex = 4
        Me.RdNonRes.TabStop = True
        Me.RdNonRes.Text = "List of Certificate of Non Residency"
        Me.RdNonRes.UseVisualStyleBackColor = True
        '
        'RdResidency
        '
        Me.RdResidency.AutoSize = True
        Me.RdResidency.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdResidency.Location = New System.Drawing.Point(6, 119)
        Me.RdResidency.Name = "RdResidency"
        Me.RdResidency.Size = New System.Drawing.Size(218, 21)
        Me.RdResidency.TabIndex = 3
        Me.RdResidency.TabStop = True
        Me.RdResidency.Text = "List of Certificate of Residency"
        Me.RdResidency.UseVisualStyleBackColor = True
        '
        'RdIndigency
        '
        Me.RdIndigency.AutoSize = True
        Me.RdIndigency.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdIndigency.Location = New System.Drawing.Point(7, 88)
        Me.RdIndigency.Name = "RdIndigency"
        Me.RdIndigency.Size = New System.Drawing.Size(217, 21)
        Me.RdIndigency.TabIndex = 2
        Me.RdIndigency.TabStop = True
        Me.RdIndigency.Text = "List of Certificate of Indigency"
        Me.RdIndigency.UseVisualStyleBackColor = True
        '
        'RdBusinessC
        '
        Me.RdBusinessC.AutoSize = True
        Me.RdBusinessC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBusinessC.Location = New System.Drawing.Point(7, 57)
        Me.RdBusinessC.Name = "RdBusinessC"
        Me.RdBusinessC.Size = New System.Drawing.Size(187, 21)
        Me.RdBusinessC.TabIndex = 1
        Me.RdBusinessC.TabStop = True
        Me.RdBusinessC.Text = "List of Business Clearance"
        Me.RdBusinessC.UseVisualStyleBackColor = True
        '
        'RdBClearance
        '
        Me.RdBClearance.AutoSize = True
        Me.RdBClearance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdBClearance.Location = New System.Drawing.Point(7, 26)
        Me.RdBClearance.Name = "RdBClearance"
        Me.RdBClearance.Size = New System.Drawing.Size(199, 21)
        Me.RdBClearance.TabIndex = 0
        Me.RdBClearance.TabStop = True
        Me.RdBClearance.Text = "List of Barangay Clearance"
        Me.RdBClearance.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Controls.Add(Me.BtnPrint2)
        Me.GroupBox2.Controls.Add(Me.CmbStreet)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnShowAll)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 152)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESIDENT'S"
        '
        'BtnPrint2
        '
        Me.BtnPrint2.BorderColor = System.Drawing.Color.White
        Me.BtnPrint2.BorderThickness = 1
        Me.BtnPrint2.CheckedState.Parent = Me.BtnPrint2
        Me.BtnPrint2.CustomImages.Parent = Me.BtnPrint2
        Me.BtnPrint2.FillColor = System.Drawing.Color.Maroon
        Me.BtnPrint2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint2.ForeColor = System.Drawing.Color.White
        Me.BtnPrint2.HoverState.BorderColor = System.Drawing.Color.White
        Me.BtnPrint2.HoverState.CustomBorderColor = System.Drawing.Color.White
        Me.BtnPrint2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrint2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPrint2.HoverState.Parent = Me.BtnPrint2
        Me.BtnPrint2.Location = New System.Drawing.Point(23, 113)
        Me.BtnPrint2.Name = "BtnPrint2"
        Me.BtnPrint2.ShadowDecoration.Enabled = True
        Me.BtnPrint2.ShadowDecoration.Parent = Me.BtnPrint2
        Me.BtnPrint2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnPrint2.Size = New System.Drawing.Size(304, 27)
        Me.BtnPrint2.TabIndex = 33
        Me.BtnPrint2.Text = "PRINT"
        '
        'CmbStreet
        '
        Me.CmbStreet.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStreet.FormattingEnabled = True
        Me.CmbStreet.Items.AddRange(New Object() {"CONCEPTION", "EVANGELISTA", "MABINI", "PINUGAY", "RIZAL", "SAN JOSE", "SAN JUAN", "SAN SALVADOR", "KATIPUNAN-BAYAN", "PLAZA ALDEA"})
        Me.CmbStreet.Location = New System.Drawing.Point(23, 82)
        Me.CmbStreet.Name = "CmbStreet"
        Me.CmbStreet.Size = New System.Drawing.Size(250, 25)
        Me.CmbStreet.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "SELECT BY STREET"
        '
        'BtnShowAll
        '
        Me.BtnShowAll.BorderColor = System.Drawing.Color.White
        Me.BtnShowAll.BorderThickness = 1
        Me.BtnShowAll.CheckedState.Parent = Me.BtnShowAll
        Me.BtnShowAll.CustomBorderColor = System.Drawing.Color.White
        Me.BtnShowAll.CustomImages.Parent = Me.BtnShowAll
        Me.BtnShowAll.FillColor = System.Drawing.Color.Maroon
        Me.BtnShowAll.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowAll.ForeColor = System.Drawing.Color.White
        Me.BtnShowAll.HoverState.BorderColor = System.Drawing.Color.White
        Me.BtnShowAll.HoverState.CustomBorderColor = System.Drawing.Color.White
        Me.BtnShowAll.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnShowAll.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnShowAll.HoverState.Parent = Me.BtnShowAll
        Me.BtnShowAll.Location = New System.Drawing.Point(23, 24)
        Me.BtnShowAll.Name = "BtnShowAll"
        Me.BtnShowAll.ShadowDecoration.Enabled = True
        Me.BtnShowAll.ShadowDecoration.Parent = Me.BtnShowAll
        Me.BtnShowAll.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnShowAll.Size = New System.Drawing.Size(304, 27)
        Me.BtnShowAll.TabIndex = 29
        Me.BtnShowAll.Text = "SHOW ALL RESIDENT'S"
        '
        'BtnGo
        '
        Me.BtnGo.BorderColor = System.Drawing.Color.White
        Me.BtnGo.BorderThickness = 1
        Me.BtnGo.CheckedState.Parent = Me.BtnGo
        Me.BtnGo.CustomBorderColor = System.Drawing.Color.White
        Me.BtnGo.CustomImages.Parent = Me.BtnGo
        Me.BtnGo.FillColor = System.Drawing.Color.Maroon
        Me.BtnGo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGo.ForeColor = System.Drawing.Color.White
        Me.BtnGo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnGo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGo.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnGo.HoverState.Parent = Me.BtnGo
        Me.BtnGo.Location = New System.Drawing.Point(290, 489)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.ShadowDecoration.Enabled = True
        Me.BtnGo.ShadowDecoration.Parent = Me.BtnGo
        Me.BtnGo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnGo.Size = New System.Drawing.Size(49, 24)
        Me.BtnGo.TabIndex = 32
        Me.BtnGo.Text = "GO"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.Panel1)
        Me.Guna2Panel1.Controls.Add(Me.DataGridView1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(366, 36)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(544, 522)
        Me.Guna2Panel1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.LblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 33)
        Me.Panel1.TabIndex = 21
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Maroon
        Me.LblTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(6, 3)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(163, 27)
        Me.LblTitle.TabIndex = 46
        Me.LblTitle.Text = "LIST OF REPORTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(531, 475)
        Me.DataGridView1.TabIndex = 2
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'ReportsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 562)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdIndigency As RadioButton
    Friend WithEvents RdBusinessC As RadioButton
    Friend WithEvents RdBClearance As RadioButton
    Friend WithEvents RdResidency As RadioButton
    Friend WithEvents RdNonRes As RadioButton
    Friend WithEvents RdOATH As RadioButton
    Friend WithEvents RdSoloParent As RadioButton
    Friend WithEvents RdSpes As RadioButton
    Friend WithEvents RdSpes1 As RadioButton
    Friend WithEvents BtnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnShowAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPrint2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CmbStreet As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
