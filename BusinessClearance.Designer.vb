<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusinessClearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusinessClearance))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtAmount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCtc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtOr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBusinessname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtBusinesslocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.TxtAmount)
        Me.Guna2Panel1.Controls.Add(Me.TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.TxtCtc)
        Me.Guna2Panel1.Controls.Add(Me.TxtOr)
        Me.Guna2Panel1.Controls.Add(Me.TxtBusinessname)
        Me.Guna2Panel1.Controls.Add(Me.TxtBusinesslocation)
        Me.Guna2Panel1.Controls.Add(Me.TxtAddress)
        Me.Guna2Panel1.Controls.Add(Me.TxtName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(18, 97)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(727, 382)
        Me.Guna2Panel1.TabIndex = 30
        '
        'TxtAmount
        '
        Me.TxtAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAmount.DefaultText = "350.00"
        Me.TxtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAmount.DisabledState.Parent = Me.TxtAmount
        Me.TxtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtAmount.FocusedState.Parent = Me.TxtAmount
        Me.TxtAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.ForeColor = System.Drawing.Color.Black
        Me.TxtAmount.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtAmount.HoverState.Parent = Me.TxtAmount
        Me.TxtAmount.Location = New System.Drawing.Point(463, 166)
        Me.TxtAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAmount.PlaceholderText = ""
        Me.TxtAmount.SelectedText = ""
        Me.TxtAmount.SelectionStart = 6
        Me.TxtAmount.ShadowDecoration.Parent = Me.TxtAmount
        Me.TxtAmount.Size = New System.Drawing.Size(174, 30)
        Me.TxtAmount.TabIndex = 123
        Me.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = "3 MONTHS"
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.Parent = Me.TextBox1
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.FocusedState.Parent = Me.TextBox1
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TextBox1.HoverState.Parent = Me.TextBox1
        Me.TextBox1.Location = New System.Drawing.Point(463, 233)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = ""
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionStart = 8
        Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
        Me.TextBox1.Size = New System.Drawing.Size(174, 30)
        Me.TextBox1.TabIndex = 122
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
        Me.TxtCtc.Location = New System.Drawing.Point(226, 309)
        Me.TxtCtc.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtCtc.Name = "TxtCtc"
        Me.TxtCtc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCtc.PlaceholderText = ""
        Me.TxtCtc.SelectedText = ""
        Me.TxtCtc.ShadowDecoration.Parent = Me.TxtCtc
        Me.TxtCtc.Size = New System.Drawing.Size(147, 30)
        Me.TxtCtc.TabIndex = 121
        '
        'TxtOr
        '
        Me.TxtOr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtOr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtOr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtOr.DefaultText = ""
        Me.TxtOr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtOr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtOr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOr.DisabledState.Parent = Me.TxtOr
        Me.TxtOr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtOr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOr.FocusedState.Parent = Me.TxtOr
        Me.TxtOr.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOr.ForeColor = System.Drawing.Color.Black
        Me.TxtOr.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtOr.HoverState.Parent = Me.TxtOr
        Me.TxtOr.Location = New System.Drawing.Point(29, 309)
        Me.TxtOr.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtOr.Name = "TxtOr"
        Me.TxtOr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtOr.PlaceholderText = ""
        Me.TxtOr.SelectedText = ""
        Me.TxtOr.ShadowDecoration.Parent = Me.TxtOr
        Me.TxtOr.Size = New System.Drawing.Size(147, 30)
        Me.TxtOr.TabIndex = 120
        '
        'TxtBusinessname
        '
        Me.TxtBusinessname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBusinessname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusinessname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBusinessname.DefaultText = ""
        Me.TxtBusinessname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBusinessname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBusinessname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBusinessname.DisabledState.Parent = Me.TxtBusinessname
        Me.TxtBusinessname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBusinessname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBusinessname.FocusedState.Parent = Me.TxtBusinessname
        Me.TxtBusinessname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinessname.ForeColor = System.Drawing.Color.Black
        Me.TxtBusinessname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtBusinessname.HoverState.Parent = Me.TxtBusinessname
        Me.TxtBusinessname.Location = New System.Drawing.Point(29, 166)
        Me.TxtBusinessname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBusinessname.Name = "TxtBusinessname"
        Me.TxtBusinessname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBusinessname.PlaceholderText = ""
        Me.TxtBusinessname.SelectedText = ""
        Me.TxtBusinessname.ShadowDecoration.Parent = Me.TxtBusinessname
        Me.TxtBusinessname.Size = New System.Drawing.Size(344, 30)
        Me.TxtBusinessname.TabIndex = 119
        '
        'TxtBusinesslocation
        '
        Me.TxtBusinesslocation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtBusinesslocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBusinesslocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBusinesslocation.DefaultText = "BARAS, RIZAL"
        Me.TxtBusinesslocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBusinesslocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBusinesslocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBusinesslocation.DisabledState.Parent = Me.TxtBusinesslocation
        Me.TxtBusinesslocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBusinesslocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBusinesslocation.FocusedState.Parent = Me.TxtBusinesslocation
        Me.TxtBusinesslocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusinesslocation.ForeColor = System.Drawing.Color.Black
        Me.TxtBusinesslocation.HoverState.BorderColor = System.Drawing.Color.Black
        Me.TxtBusinesslocation.HoverState.Parent = Me.TxtBusinesslocation
        Me.TxtBusinesslocation.Location = New System.Drawing.Point(29, 230)
        Me.TxtBusinesslocation.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtBusinesslocation.Name = "TxtBusinesslocation"
        Me.TxtBusinesslocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtBusinesslocation.PlaceholderText = ""
        Me.TxtBusinesslocation.SelectedText = ""
        Me.TxtBusinesslocation.SelectionStart = 12
        Me.TxtBusinesslocation.ShadowDecoration.Parent = Me.TxtBusinesslocation
        Me.TxtBusinesslocation.Size = New System.Drawing.Size(344, 30)
        Me.TxtBusinesslocation.TabIndex = 118
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
        Me.TxtAddress.Location = New System.Drawing.Point(27, 103)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtAddress.PlaceholderText = ""
        Me.TxtAddress.SelectedText = ""
        Me.TxtAddress.ShadowDecoration.Parent = Me.TxtAddress
        Me.TxtAddress.Size = New System.Drawing.Size(504, 30)
        Me.TxtAddress.TabIndex = 117
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
        Me.TxtName.Location = New System.Drawing.Point(29, 46)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtName.PlaceholderText = ""
        Me.TxtName.SelectedText = ""
        Me.TxtName.ShadowDecoration.Parent = Me.TxtName
        Me.TxtName.Size = New System.Drawing.Size(504, 30)
        Me.TxtName.TabIndex = 116
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 5
        Me.Guna2Button3.BorderThickness = 2
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(541, 46)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Enabled = True
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button3.Size = New System.Drawing.Size(103, 30)
        Me.Guna2Button3.TabIndex = 114
        Me.Guna2Button3.Text = "SEARCH"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(27, 84)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(78, 21)
        Me.Guna2HtmlLabel10.TabIndex = 112
        Me.Guna2HtmlLabel10.Text = "ADDRESS :"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(463, 147)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(79, 21)
        Me.Guna2HtmlLabel9.TabIndex = 108
        Me.Guna2HtmlLabel9.Text = "AMOUNT :"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(463, 214)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(77, 21)
        Me.Guna2HtmlLabel8.TabIndex = 106
        Me.Guna2HtmlLabel8.Text = "VALIDITY :"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(463, 287)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(102, 21)
        Me.Guna2HtmlLabel6.TabIndex = 105
        Me.Guna2HtmlLabel6.Text = "DATE ISSUED :"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CustomFormat = "MMMM d      yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(463, 305)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(222, 27)
        Me.DateTimePicker2.TabIndex = 104
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(29, 287)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(66, 21)
        Me.Guna2HtmlLabel5.TabIndex = 102
        Me.Guna2HtmlLabel5.Text = "O.R NO :"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(226, 287)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(71, 21)
        Me.Guna2HtmlLabel4.TabIndex = 99
        Me.Guna2HtmlLabel4.Text = "CTC NO :"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(27, 210)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(162, 21)
        Me.Guna2HtmlLabel3.TabIndex = 97
        Me.Guna2HtmlLabel3.Text = "BUSINESS LOCATION :"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(27, 147)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(128, 21)
        Me.Guna2HtmlLabel2.TabIndex = 95
        Me.Guna2HtmlLabel2.Text = "BUSINESS NAME :"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(42, 284)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel7.TabIndex = 56
        Me.Guna2HtmlLabel7.Text = Nothing
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 27)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 21)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "FULL NAME :"
        '
        'BtnSave
        '
        Me.BtnSave.Animated = True
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.BorderRadius = 5
        Me.BtnSave.CheckedState.Parent = Me.BtnSave
        Me.BtnSave.CustomImages.Parent = Me.BtnSave
        Me.BtnSave.FillColor = System.Drawing.Color.White
        Me.BtnSave.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.FillColor = System.Drawing.Color.White
        Me.BtnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnSave.HoverState.Parent = Me.BtnSave
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnSave.Location = New System.Drawing.Point(646, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BtnSave.Size = New System.Drawing.Size(38, 34)
        Me.BtnSave.TabIndex = 74
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button2.Location = New System.Drawing.Point(685, 4)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button2.ShadowDecoration.Enabled = True
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Guna2Button2.Size = New System.Drawing.Size(38, 34)
        Me.Guna2Button2.TabIndex = 110
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
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(491, 39)
        Me.Guna2HtmlLabel12.TabIndex = 104
        Me.Guna2HtmlLabel12.Text = "BUSINESS CLEARANCE"
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
        Me.Guna2Panel3.TabIndex = 113
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.BtnSave)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 59)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(727, 39)
        Me.Guna2Panel2.TabIndex = 115
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
        Me.Guna2Button1.TabIndex = 124
        '
        'BusinessClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 496)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BusinessClearance"
        Me.Text = "BusinessClearance"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtAmount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCtc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtOr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBusinessname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtBusinesslocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
