﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BClearance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.LblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TxtCtc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtOR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtFees = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txtissued = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtValidity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnS = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnPreview = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(-12, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 32)
        Me.Panel1.TabIndex = 25
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(13, 63)
        Me.TxtName.Name = "TxtName"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtName, False)
        Me.TxtName.Size = New System.Drawing.Size(529, 27)
        Me.TxtName.TabIndex = 47
        '
        'TxtAddress
        '
        Me.TxtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(13, 122)
        Me.TxtAddress.Name = "TxtAddress"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.TxtAddress, False)
        Me.TxtAddress.Size = New System.Drawing.Size(529, 27)
        Me.TxtAddress.TabIndex = 48
        '
        'LblTitle
        '
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(33, 45)
        Me.LblTitle.Name = "LblTitle"
        Me.NetResize1.SetResizeFont(Me.LblTitle, False)
        Me.LblTitle.Size = New System.Drawing.Size(360, 29)
        Me.LblTitle.TabIndex = 53
        Me.LblTitle.Text = "BARANGAY CLEARANCE FORM"
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
        Me.BtnSave.Location = New System.Drawing.Point(548, 63)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnSave.Size = New System.Drawing.Size(86, 27)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "SEARCH"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CustomFormat = "MMMM d      yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(401, 174)
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
        Me.TxtCtc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCtc.HoverState.Parent = Me.TxtCtc
        Me.TxtCtc.Location = New System.Drawing.Point(13, 234)
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
        Me.TxtOR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtOR.HoverState.Parent = Me.TxtOR
        Me.TxtOR.Location = New System.Drawing.Point(224, 234)
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
        Me.TxtFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFees.ForeColor = System.Drawing.Color.Black
        Me.TxtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtFees.HoverState.Parent = Me.TxtFees
        Me.TxtFees.Location = New System.Drawing.Point(477, 234)
        Me.TxtFees.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TxtFees.Name = "TxtFees"
        Me.TxtFees.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtFees.PlaceholderText = ""
        Me.TxtFees.SelectedText = ""
        Me.TxtFees.SelectionStart = 1
        Me.TxtFees.ShadowDecoration.Parent = Me.TxtFees
        Me.TxtFees.Size = New System.Drawing.Size(98, 30)
        Me.TxtFees.TabIndex = 37
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
        Me.Txtissued.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txtissued.HoverState.Parent = Me.Txtissued
        Me.Txtissued.Location = New System.Drawing.Point(13, 286)
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
        Me.TxtValidity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValidity.HoverState.Parent = Me.TxtValidity
        Me.TxtValidity.Location = New System.Drawing.Point(222, 287)
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
        'BtnS
        '
        Me.BtnS.CheckedState.Parent = Me.BtnS
        Me.BtnS.CustomImages.Parent = Me.BtnS
        Me.BtnS.FillColor = System.Drawing.Color.Maroon
        Me.BtnS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnS.ForeColor = System.Drawing.Color.White
        Me.BtnS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnS.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnS.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnS.HoverState.Parent = Me.BtnS
        Me.BtnS.Location = New System.Drawing.Point(116, 17)
        Me.BtnS.Name = "BtnS"
        Me.BtnS.ShadowDecoration.Enabled = True
        Me.BtnS.ShadowDecoration.Parent = Me.BtnS
        Me.BtnS.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnS.Size = New System.Drawing.Size(78, 23)
        Me.BtnS.TabIndex = 42
        Me.BtnS.Text = "SAVE"
        '
        'BtnPreview
        '
        Me.BtnPreview.CheckedState.Parent = Me.BtnPreview
        Me.BtnPreview.CustomBorderColor = System.Drawing.Color.Transparent
        Me.BtnPreview.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.BtnPreview.CustomImages.Parent = Me.BtnPreview
        Me.BtnPreview.FillColor = System.Drawing.Color.Maroon
        Me.BtnPreview.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPreview.ForeColor = System.Drawing.Color.White
        Me.BtnPreview.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreview.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPreview.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnPreview.HoverState.Parent = Me.BtnPreview
        Me.BtnPreview.Location = New System.Drawing.Point(6, 17)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.ShadowDecoration.Enabled = True
        Me.BtnPreview.ShadowDecoration.Parent = Me.BtnPreview
        Me.BtnPreview.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BtnPreview.Size = New System.Drawing.Size(104, 23)
        Me.BtnPreview.TabIndex = 43
        Me.BtnPreview.Text = "PREVIEW"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Maroon
        Me.Guna2Button3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(200, 17)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Enabled = True
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Guna2Button3.Size = New System.Drawing.Size(75, 23)
        Me.Guna2Button3.TabIndex = 44
        Me.Guna2Button3.Text = "BACK"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Panel1.BorderThickness = 5
        Me.Guna2Panel1.Controls.Add(Me.GroupBox1)
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(4, 50)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(646, 397)
        Me.Guna2Panel1.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnPreview)
        Me.GroupBox1.Controls.Add(Me.BtnS)
        Me.GroupBox1.Controls.Add(Me.Guna2Button3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(356, 339)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 49)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"EMPLOYMENT LOCAL/ABROAD", "ELECTRICAL PERMIT", "BUILDING/FENCING/RENOVATION PERMIT", "DIGGING/EXCAVATION PERMIT", "BUSINESS PERMIT", "VEHICLE REGISTRATION(CAR/TRUCK/TRICYCLE ETC)", "MARRIAGE", "GOOD MORAL CHARACTER"})
        Me.CmbPurpose.Location = New System.Drawing.Point(13, 174)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(382, 29)
        Me.CmbPurpose.TabIndex = 46
        Me.CmbPurpose.Text = "--Choose Purpose--"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(222, 266)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel9.TabIndex = 41
        Me.Guna2HtmlLabel9.Text = "VALIDITY:"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(13, 265)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(79, 21)
        Me.Guna2HtmlLabel8.TabIndex = 38
        Me.Guna2HtmlLabel8.Text = "ISSUED AT:"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(477, 212)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(75, 21)
        Me.Guna2HtmlLabel7.TabIndex = 36
        Me.Guna2HtmlLabel7.Text = "AMOUNT:"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(224, 212)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(62, 21)
        Me.Guna2HtmlLabel6.TabIndex = 34
        Me.Guna2HtmlLabel6.Text = "O.R NO."
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(13, 212)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(67, 21)
        Me.Guna2HtmlLabel5.TabIndex = 33
        Me.Guna2HtmlLabel5.Text = "CTC NO."
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(401, 154)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(98, 21)
        Me.Guna2HtmlLabel3.TabIndex = 31
        Me.Guna2HtmlLabel3.Text = "DATE ISSUED:"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 155)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(73, 21)
        Me.Guna2HtmlLabel4.TabIndex = 17
        Me.Guna2HtmlLabel4.Text = "PURPOSE:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 97)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(114, 21)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "FULL ADDRESS :"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 45)
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
        'BClearance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(654, 480)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BClearance"
        Me.ShowInTaskbar = False
        Me.Text = "BClearance"
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnPreview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnS As Guna.UI2.WinForms.Guna2Button
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
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
