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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.LblTo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblFrom = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DTFrom = New System.Windows.Forms.DateTimePicker()
        Me.DTTo = New System.Windows.Forms.DateTimePicker()
        Me.CmbStreets = New System.Windows.Forms.ComboBox()
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
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
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.LblTo)
        Me.Guna2Panel2.Controls.Add(Me.LblFrom)
        Me.Guna2Panel2.Controls.Add(Me.DTFrom)
        Me.Guna2Panel2.Controls.Add(Me.DTTo)
        Me.Guna2Panel2.Controls.Add(Me.CmbStreets)
        Me.Guna2Panel2.Controls.Add(Me.CmbPurpose)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(1364, 40)
        Me.Guna2Panel2.TabIndex = 34
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(1116, 9)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button2.ShadowDecoration.Enabled = True
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button2.Size = New System.Drawing.Size(115, 24)
        Me.Guna2Button2.TabIndex = 98
        Me.Guna2Button2.Text = "ENABLE QUERY"
        '
        'LblTo
        '
        Me.LblTo.BackColor = System.Drawing.Color.Transparent
        Me.LblTo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.Location = New System.Drawing.Point(513, 16)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(28, 18)
        Me.LblTo.TabIndex = 97
        Me.LblTo.Text = "TO :"
        '
        'LblFrom
        '
        Me.LblFrom.BackColor = System.Drawing.Color.Transparent
        Me.LblFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.Location = New System.Drawing.Point(353, 16)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(48, 18)
        Me.LblFrom.TabIndex = 96
        Me.LblFrom.Text = "FROM :"
        '
        'DTFrom
        '
        Me.DTFrom.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFrom.Location = New System.Drawing.Point(407, 9)
        Me.DTFrom.Name = "DTFrom"
        Me.DTFrom.Size = New System.Drawing.Size(98, 26)
        Me.DTFrom.TabIndex = 95
        '
        'DTTo
        '
        Me.DTTo.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTo.Location = New System.Drawing.Point(546, 9)
        Me.DTTo.Name = "DTTo"
        Me.DTTo.Size = New System.Drawing.Size(98, 26)
        Me.DTTo.TabIndex = 94
        '
        'CmbStreets
        '
        Me.CmbStreets.Enabled = False
        Me.CmbStreets.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbStreets.FormattingEnabled = True
        Me.CmbStreets.Items.AddRange(New Object() {"LIST OF RESIDENTS", "BARANGAY CLEARANCE", "BUSINESS CLEARANCE", "CERTIFICATE OF INDIGENCY", "CERTIFICATE OF NON-RESIDENCY", "CERTIFICATE OF RESIDENCY", "CERTIFICATE OF SOLO PARENT", "OATH UNDERTAKING/CERTIFICATION", "SPES(For Out of School Youth)", "SPES(For School Youth)"})
        Me.CmbStreets.Location = New System.Drawing.Point(664, 10)
        Me.CmbStreets.Name = "CmbStreets"
        Me.CmbStreets.Size = New System.Drawing.Size(244, 24)
        Me.CmbStreets.TabIndex = 93
        Me.CmbStreets.Text = "STREETS"
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"LIST OF RESIDENTS", "BARANGAY CLEARANCE", "BUSINESS CLEARANCE", "CERTIFICATE OF INDIGENCY", "CERTIFICATE OF NON-RESIDENCY", "CERTIFICATE OF RESIDENCY", "CERTIFICATE OF SOLO PARENT", "OATH UNDERTAKING/CERTIFICATION", "SPES(For School Youth)", "SPES(For Out School Youth)"})
        Me.CmbPurpose.Location = New System.Drawing.Point(7, 10)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(333, 24)
        Me.CmbPurpose.TabIndex = 92
        Me.CmbPurpose.Text = "SELECT REPORT"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1237, 8)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button1.Size = New System.Drawing.Size(115, 25)
        Me.Guna2Button1.TabIndex = 76
        Me.Guna2Button1.Text = "PRINT PREVIEW"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
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
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 40)
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
        Me.DataGridView1.Size = New System.Drawing.Size(1364, 522)
        Me.DataGridView1.TabIndex = 57
        '
        'ReportsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 562)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "ReportsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CmbStreets As ComboBox
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents DTFrom As DateTimePicker
    Friend WithEvents DTTo As DateTimePicker
    Friend WithEvents LblFrom As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblTo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
