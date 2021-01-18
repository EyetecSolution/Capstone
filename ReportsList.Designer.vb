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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfBarangayClearanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCertificateOfIndigencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCertificateOfResidencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCertificateOfNonResidencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSoloParentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfOATHUndertakingCertificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSpesforSchoolYouthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfResidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCovidCASESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.MenuStrip1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1151, 27)
        Me.Guna2Panel2.TabIndex = 34
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1151, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RToolStripMenuItem
        '
        Me.RToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfBarangayClearanceToolStripMenuItem, Me.ListOfToolStripMenuItem, Me.ListOfCertificateOfIndigencyToolStripMenuItem, Me.ListOfCertificateOfResidencyToolStripMenuItem, Me.ListOfCertificateOfNonResidencyToolStripMenuItem, Me.ListOfSoloParentToolStripMenuItem, Me.ListOfOATHUndertakingCertificationToolStripMenuItem, Me.ListOfSpesforSchoolYouthToolStripMenuItem, Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem, Me.ListOfResidentsToolStripMenuItem, Me.ListOfCovidCASESToolStripMenuItem})
        Me.RToolStripMenuItem.Name = "RToolStripMenuItem"
        Me.RToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RToolStripMenuItem.Text = "Reporting"
        '
        'ListOfBarangayClearanceToolStripMenuItem
        '
        Me.ListOfBarangayClearanceToolStripMenuItem.Image = CType(resources.GetObject("ListOfBarangayClearanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfBarangayClearanceToolStripMenuItem.Name = "ListOfBarangayClearanceToolStripMenuItem"
        Me.ListOfBarangayClearanceToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfBarangayClearanceToolStripMenuItem.Text = "List of Barangay Clearance"
        '
        'ListOfToolStripMenuItem
        '
        Me.ListOfToolStripMenuItem.Image = CType(resources.GetObject("ListOfToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfToolStripMenuItem.Name = "ListOfToolStripMenuItem"
        Me.ListOfToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfToolStripMenuItem.Text = "List of Business Clearance"
        '
        'ListOfCertificateOfIndigencyToolStripMenuItem
        '
        Me.ListOfCertificateOfIndigencyToolStripMenuItem.Image = CType(resources.GetObject("ListOfCertificateOfIndigencyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfCertificateOfIndigencyToolStripMenuItem.Name = "ListOfCertificateOfIndigencyToolStripMenuItem"
        Me.ListOfCertificateOfIndigencyToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfCertificateOfIndigencyToolStripMenuItem.Text = "List of Certificate of Indigency"
        '
        'ListOfCertificateOfResidencyToolStripMenuItem
        '
        Me.ListOfCertificateOfResidencyToolStripMenuItem.Image = CType(resources.GetObject("ListOfCertificateOfResidencyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfCertificateOfResidencyToolStripMenuItem.Name = "ListOfCertificateOfResidencyToolStripMenuItem"
        Me.ListOfCertificateOfResidencyToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfCertificateOfResidencyToolStripMenuItem.Text = "List of Certificate of Residency"
        '
        'ListOfCertificateOfNonResidencyToolStripMenuItem
        '
        Me.ListOfCertificateOfNonResidencyToolStripMenuItem.Image = CType(resources.GetObject("ListOfCertificateOfNonResidencyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfCertificateOfNonResidencyToolStripMenuItem.Name = "ListOfCertificateOfNonResidencyToolStripMenuItem"
        Me.ListOfCertificateOfNonResidencyToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfCertificateOfNonResidencyToolStripMenuItem.Text = "List of Certificate of Non Residency"
        '
        'ListOfSoloParentToolStripMenuItem
        '
        Me.ListOfSoloParentToolStripMenuItem.Image = CType(resources.GetObject("ListOfSoloParentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfSoloParentToolStripMenuItem.Name = "ListOfSoloParentToolStripMenuItem"
        Me.ListOfSoloParentToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfSoloParentToolStripMenuItem.Text = "List of Solo Parent"
        '
        'ListOfOATHUndertakingCertificationToolStripMenuItem
        '
        Me.ListOfOATHUndertakingCertificationToolStripMenuItem.Image = CType(resources.GetObject("ListOfOATHUndertakingCertificationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfOATHUndertakingCertificationToolStripMenuItem.Name = "ListOfOATHUndertakingCertificationToolStripMenuItem"
        Me.ListOfOATHUndertakingCertificationToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfOATHUndertakingCertificationToolStripMenuItem.Text = "List of OATH Undertaking/Certification"
        '
        'ListOfSpesforSchoolYouthToolStripMenuItem
        '
        Me.ListOfSpesforSchoolYouthToolStripMenuItem.Image = CType(resources.GetObject("ListOfSpesforSchoolYouthToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfSpesforSchoolYouthToolStripMenuItem.Name = "ListOfSpesforSchoolYouthToolStripMenuItem"
        Me.ListOfSpesforSchoolYouthToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfSpesforSchoolYouthToolStripMenuItem.Text = "List of Spes(for school youth)"
        '
        'ListOfSpesforOutOfSchoolYouthToolStripMenuItem
        '
        Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem.Image = CType(resources.GetObject("ListOfSpesforOutOfSchoolYouthToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem.Name = "ListOfSpesforOutOfSchoolYouthToolStripMenuItem"
        Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfSpesforOutOfSchoolYouthToolStripMenuItem.Text = "List of Spes(for out of school youth)"
        '
        'ListOfResidentsToolStripMenuItem
        '
        Me.ListOfResidentsToolStripMenuItem.Image = CType(resources.GetObject("ListOfResidentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfResidentsToolStripMenuItem.Name = "ListOfResidentsToolStripMenuItem"
        Me.ListOfResidentsToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfResidentsToolStripMenuItem.Text = "List of Residents"
        '
        'ListOfCovidCASESToolStripMenuItem
        '
        Me.ListOfCovidCASESToolStripMenuItem.Image = CType(resources.GetObject("ListOfCovidCASESToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListOfCovidCASESToolStripMenuItem.Name = "ListOfCovidCASESToolStripMenuItem"
        Me.ListOfCovidCASESToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.ListOfCovidCASESToolStripMenuItem.Text = "List of Covid CASES"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.LblTitle)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1151, 38)
        Me.Guna2Panel1.TabIndex = 35
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(927, 6)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(186, 29)
        Me.LblTitle.TabIndex = 56
        Me.LblTitle.Text = "LIST OF REPORT"
        Me.LblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 72)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1151, 449)
        Me.DataGridView1.TabIndex = 57
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1024, 527)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button1.Size = New System.Drawing.Size(115, 25)
        Me.Guna2Button1.TabIndex = 76
        Me.Guna2Button1.Text = "PRINT"
        '
        'ReportsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 562)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "ReportsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfBarangayClearanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfCertificateOfIndigencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfCertificateOfResidencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfCertificateOfNonResidencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSoloParentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfOATHUndertakingCertificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSpesforSchoolYouthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSpesforOutOfSchoolYouthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfResidentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfCovidCASESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
