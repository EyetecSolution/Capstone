﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FaceRecognition
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
        Me.ImageBox1 = New Emgu.CV.UI.ImageBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbPurpose = New System.Windows.Forms.ComboBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ImageBox2 = New Emgu.CV.UI.ImageBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ImageBox3 = New Emgu.CV.UI.ImageBox()
        Me.button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnTimeOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTimeIN = New Guna.UI2.WinForms.Guna2Button()
        Me.button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.label3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.label4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageBox1
        '
        Me.ImageBox1.Location = New System.Drawing.Point(12, 33)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(307, 247)
        Me.ImageBox1.TabIndex = 2
        Me.ImageBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbPurpose)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.GroupBox1.Controls.Add(Me.ImageBox2)
        Me.GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(325, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 254)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Training"
        '
        'CmbPurpose
        '
        Me.CmbPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPurpose.FormattingEnabled = True
        Me.CmbPurpose.Items.AddRange(New Object() {"BRGY.OFFICIAL", "BRGY.STAFF", "TANOD"})
        Me.CmbPurpose.Location = New System.Drawing.Point(6, 183)
        Me.CmbPurpose.Name = "CmbPurpose"
        Me.CmbPurpose.Size = New System.Drawing.Size(290, 24)
        Me.CmbPurpose.TabIndex = 92
        Me.CmbPurpose.Text = "SELECT POSITION"
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(6, 154)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(290, 23)
        Me.TxtName.TabIndex = 77
        Me.TxtName.Text = "UNKNOWN"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(6, 138)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.Text = "FULL NAME :"
        '
        'ImageBox2
        '
        Me.ImageBox2.Location = New System.Drawing.Point(80, 17)
        Me.ImageBox2.Name = "ImageBox2"
        Me.ImageBox2.Size = New System.Drawing.Size(143, 108)
        Me.ImageBox2.TabIndex = 30
        Me.ImageBox2.TabStop = False
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
        Me.Guna2Button1.Location = New System.Drawing.Point(6, 215)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Button1.ShadowDecoration.Enabled = True
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.Guna2Button1.Size = New System.Drawing.Size(290, 33)
        Me.Guna2Button1.TabIndex = 76
        Me.Guna2Button1.Text = "1. Detect and Recognize"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GroupBox2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 286)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 113)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results :"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(197, 73)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(14, 25)
        Me.Guna2HtmlLabel4.TabIndex = 80
        Me.Guna2HtmlLabel4.Text = "0"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(6, 78)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(180, 18)
        Me.Guna2HtmlLabel3.TabIndex = 79
        Me.Guna2HtmlLabel3.Text = "Number of faces detected :"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(6, 47)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(83, 25)
        Me.Guna2HtmlLabel2.TabIndex = 78
        Me.Guna2HtmlLabel2.Text = "Nobody,"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(6, 22)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(196, 18)
        Me.Guna2HtmlLabel1.TabIndex = 77
        Me.Guna2HtmlLabel1.Text = "Person present on the screen :"
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
        Me.BtnSave.Location = New System.Drawing.Point(388, 63)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BtnSave.ShadowDecoration.Enabled = True
        Me.BtnSave.ShadowDecoration.Parent = Me.BtnSave
        Me.BtnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.BtnSave.Size = New System.Drawing.Size(216, 33)
        Me.BtnSave.TabIndex = 75
        Me.BtnSave.Text = "2. Add Faces"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Location = New System.Drawing.Point(-5, -6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 31)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(648, 32)
        Me.Panel2.TabIndex = 29
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(12, 50)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(311, 267)
        Me.imageBoxFrameGrabber.TabIndex = 2
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ImageBox3)
        Me.GroupBox3.Controls.Add(Me.button1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Guna2HtmlLabel6)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(329, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 269)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Training : "
        '
        'ImageBox3
        '
        Me.ImageBox3.Location = New System.Drawing.Point(68, 22)
        Me.ImageBox3.Name = "ImageBox3"
        Me.ImageBox3.Size = New System.Drawing.Size(164, 114)
        Me.ImageBox3.TabIndex = 31
        Me.ImageBox3.TabStop = False
        '
        'button1
        '
        Me.button1.Animated = True
        Me.button1.BackColor = System.Drawing.Color.Transparent
        Me.button1.BorderColor = System.Drawing.Color.White
        Me.button1.BorderRadius = 5
        Me.button1.BorderThickness = 1
        Me.button1.CheckedState.Parent = Me.button1
        Me.button1.CustomImages.Parent = Me.button1
        Me.button1.FillColor = System.Drawing.Color.Maroon
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.button1.HoverState.Parent = Me.button1
        Me.button1.Location = New System.Drawing.Point(10, 217)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.button1.ShadowDecoration.Enabled = True
        Me.button1.ShadowDecoration.Parent = Me.button1
        Me.button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.button1.Size = New System.Drawing.Size(279, 34)
        Me.button1.TabIndex = 95
        Me.button1.Text = "1. Detect and Recognize"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(10, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 23)
        Me.TextBox1.TabIndex = 92
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(10, 168)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(80, 18)
        Me.Guna2HtmlLabel6.TabIndex = 93
        Me.Guna2HtmlLabel6.Text = "FULL NAME :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnTimeOut)
        Me.GroupBox4.Controls.Add(Me.btnTimeIN)
        Me.GroupBox4.Controls.Add(Me.button2)
        Me.GroupBox4.Controls.Add(Me.label3)
        Me.GroupBox4.Controls.Add(Me.Guna2HtmlLabel9)
        Me.GroupBox4.Controls.Add(Me.label4)
        Me.GroupBox4.Controls.Add(Me.Guna2HtmlLabel7)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 323)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(618, 109)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Results"
        '
        'btnTimeOut
        '
        Me.btnTimeOut.Animated = True
        Me.btnTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeOut.BorderColor = System.Drawing.Color.White
        Me.btnTimeOut.BorderRadius = 5
        Me.btnTimeOut.BorderThickness = 1
        Me.btnTimeOut.CheckedState.Parent = Me.btnTimeOut
        Me.btnTimeOut.CustomImages.Parent = Me.btnTimeOut
        Me.btnTimeOut.FillColor = System.Drawing.Color.Maroon
        Me.btnTimeOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.ForeColor = System.Drawing.Color.White
        Me.btnTimeOut.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTimeOut.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTimeOut.HoverState.Parent = Me.btnTimeOut
        Me.btnTimeOut.Location = New System.Drawing.Point(471, 22)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnTimeOut.ShadowDecoration.Enabled = True
        Me.btnTimeOut.ShadowDecoration.Parent = Me.btnTimeOut
        Me.btnTimeOut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnTimeOut.Size = New System.Drawing.Size(135, 34)
        Me.btnTimeOut.TabIndex = 98
        Me.btnTimeOut.Text = "TimeOut"
        '
        'btnTimeIN
        '
        Me.btnTimeIN.Animated = True
        Me.btnTimeIN.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeIN.BorderColor = System.Drawing.Color.White
        Me.btnTimeIN.BorderRadius = 5
        Me.btnTimeIN.BorderThickness = 1
        Me.btnTimeIN.CheckedState.Parent = Me.btnTimeIN
        Me.btnTimeIN.CustomImages.Parent = Me.btnTimeIN
        Me.btnTimeIN.FillColor = System.Drawing.Color.Maroon
        Me.btnTimeIN.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIN.ForeColor = System.Drawing.Color.White
        Me.btnTimeIN.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTimeIN.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTimeIN.HoverState.Parent = Me.btnTimeIN
        Me.btnTimeIN.Location = New System.Drawing.Point(327, 22)
        Me.btnTimeIN.Name = "btnTimeIN"
        Me.btnTimeIN.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnTimeIN.ShadowDecoration.Enabled = True
        Me.btnTimeIN.ShadowDecoration.Parent = Me.btnTimeIN
        Me.btnTimeIN.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.btnTimeIN.Size = New System.Drawing.Size(141, 34)
        Me.btnTimeIN.TabIndex = 97
        Me.btnTimeIN.Text = "TimeIN"
        '
        'button2
        '
        Me.button2.Animated = True
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.BorderColor = System.Drawing.Color.White
        Me.button2.BorderRadius = 5
        Me.button2.BorderThickness = 1
        Me.button2.CheckedState.Parent = Me.button2
        Me.button2.CustomImages.Parent = Me.button2
        Me.button2.Enabled = False
        Me.button2.FillColor = System.Drawing.Color.Maroon
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.button2.HoverState.Parent = Me.button2
        Me.button2.Location = New System.Drawing.Point(327, 63)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.button2.ShadowDecoration.Enabled = True
        Me.button2.ShadowDecoration.Parent = Me.button2
        Me.button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.button2.Size = New System.Drawing.Size(279, 34)
        Me.button2.TabIndex = 96
        Me.button2.Text = "2. Register face"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(194, 70)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(12, 21)
        Me.label3.TabIndex = 15
        Me.label3.Text = "0"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(6, 73)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(176, 18)
        Me.Guna2HtmlLabel9.TabIndex = 14
        Me.Guna2HtmlLabel9.Text = "Number of faces Detected: "
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Navy
        Me.label4.Location = New System.Drawing.Point(6, 46)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(70, 21)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Nobody,"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(6, 22)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(196, 18)
        Me.Guna2HtmlLabel7.TabIndex = 12
        Me.Guna2HtmlLabel7.Text = "Person present on the screen :"
        '
        'Timer1
        '
        '
        'FaceRecognition
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 444)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.imageBoxFrameGrabber)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FaceRecognition"
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageBox1 As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageBox2 As Emgu.CV.UI.ImageBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CmbPurpose As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ImageBox3 As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents label3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents label4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTimeIN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTimeOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class