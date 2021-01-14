<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginFormShadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PanelLogInput = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnLog = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.PanelLogInput.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Guna2PictureBox1.Location = New System.Drawing.Point(14, 145)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.Parent = Guna2PictureBox1
        Guna2PictureBox1.Size = New System.Drawing.Size(254, 200)
        Guna2PictureBox1.TabIndex = 8
        Guna2PictureBox1.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(265, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 29)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(283, 358)
        Me.Guna2Panel1.TabIndex = 7
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(0, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(280, 122)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "INFORMATION MANAGEMENT SYSTEM"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLogInput
        '
        Me.PanelLogInput.Controls.Add(Me.TxtPassword)
        Me.PanelLogInput.Controls.Add(Me.TxtUsername)
        Me.PanelLogInput.Controls.Add(Me.PictureBox2)
        Me.PanelLogInput.Controls.Add(Me.BtnLog)
        Me.PanelLogInput.Controls.Add(Me.BtnClose)
        Me.PanelLogInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogInput.Location = New System.Drawing.Point(283, 0)
        Me.PanelLogInput.Name = "PanelLogInput"
        Me.PanelLogInput.ShadowDecoration.Parent = Me.PanelLogInput
        Me.PanelLogInput.Size = New System.Drawing.Size(299, 358)
        Me.PanelLogInput.TabIndex = 8
        '
        'TxtPassword
        '
        Me.TxtPassword.Animated = True
        Me.TxtPassword.BackColor = System.Drawing.Color.Transparent
        Me.TxtPassword.BorderColor = System.Drawing.Color.Gray
        Me.TxtPassword.BorderThickness = 2
        Me.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPassword.DefaultText = ""
        Me.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.DisabledState.Parent = Me.TxtPassword
        Me.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.TxtPassword.FocusedState.Parent = Me.TxtPassword
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtPassword.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtPassword.HoverState.Parent = Me.TxtPassword
        Me.TxtPassword.IconRight = CType(resources.GetObject("TxtPassword.IconRight"), System.Drawing.Image)
        Me.TxtPassword.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TxtPassword.IconRightSize = New System.Drawing.Size(32, 32)
        Me.TxtPassword.Location = New System.Drawing.Point(20, 213)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtPassword.PlaceholderText = "Enter Password"
        Me.TxtPassword.SelectedText = ""
        Me.TxtPassword.ShadowDecoration.Enabled = True
        Me.TxtPassword.ShadowDecoration.Parent = Me.TxtPassword
        Me.TxtPassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TxtPassword.Size = New System.Drawing.Size(258, 44)
        Me.TxtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtPassword.TabIndex = 8
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Animated = True
        Me.TxtUsername.BackColor = System.Drawing.Color.Transparent
        Me.TxtUsername.BorderColor = System.Drawing.Color.Gray
        Me.TxtUsername.BorderThickness = 2
        Me.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUsername.DefaultText = ""
        Me.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.DisabledState.Parent = Me.TxtUsername
        Me.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.TxtUsername.FocusedState.Parent = Me.TxtUsername
        Me.TxtUsername.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtUsername.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.TxtUsername.HoverState.Parent = Me.TxtUsername
        Me.TxtUsername.IconRight = CType(resources.GetObject("TxtUsername.IconRight"), System.Drawing.Image)
        Me.TxtUsername.IconRightOffset = New System.Drawing.Point(10, 0)
        Me.TxtUsername.IconRightSize = New System.Drawing.Size(32, 32)
        Me.TxtUsername.Location = New System.Drawing.Point(20, 135)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUsername.PlaceholderText = "Enter Username"
        Me.TxtUsername.SelectedText = ""
        Me.TxtUsername.ShadowDecoration.Enabled = True
        Me.TxtUsername.ShadowDecoration.Parent = Me.TxtUsername
        Me.TxtUsername.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.TxtUsername.Size = New System.Drawing.Size(258, 44)
        Me.TxtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.TxtUsername.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(68, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(166, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'BtnLog
        '
        Me.BtnLog.Animated = True
        Me.BtnLog.BackColor = System.Drawing.SystemColors.Window
        Me.BtnLog.CheckedState.Parent = Me.BtnLog
        Me.BtnLog.CustomImages.Parent = Me.BtnLog
        Me.BtnLog.FillColor = System.Drawing.Color.Maroon
        Me.BtnLog.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLog.ForeColor = System.Drawing.Color.White
        Me.BtnLog.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLog.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLog.HoverState.Parent = Me.BtnLog
        Me.BtnLog.Location = New System.Drawing.Point(20, 295)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.PressedDepth = 40
        Me.BtnLog.ShadowDecoration.BorderRadius = 0
        Me.BtnLog.ShadowDecoration.Depth = 16
        Me.BtnLog.ShadowDecoration.Enabled = True
        Me.BtnLog.ShadowDecoration.Parent = Me.BtnLog
        Me.BtnLog.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.BtnLog.Size = New System.Drawing.Size(258, 45)
        Me.BtnLog.TabIndex = 9
        Me.BtnLog.Text = "LOGIN"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 358)
        Me.Controls.Add(Me.PanelLogInput)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.PanelLogInput.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginFormShadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents BtnClose As Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PanelLogInput As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnLog As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class
