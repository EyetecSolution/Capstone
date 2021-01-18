<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeContent
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
        Dim ContextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeContent))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ImageSlider1 = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.PanelSlide = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CovidPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel10 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblPUMC = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel11 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel12 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblPUMO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel15 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel13 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LblRecovered = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel14 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblDeath = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblPUI = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblConfirmed = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSlide.SuspendLayout()
        Me.CovidPanel.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.Guna2Panel10.SuspendLayout()
        Me.Guna2Panel11.SuspendLayout()
        Me.Guna2Panel12.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel15.SuspendLayout()
        Me.Guna2Panel13.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel14.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'ImageSlider1
        '
        Me.ImageSlider1.AllowLooping = True
        Me.ImageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward
        Me.ImageSlider1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        ContextButton1.AnimationType = DevExpress.Utils.ContextAnimationType.OpacityAnimation
        ContextButton1.AppearanceHover.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ContextButton1.AppearanceHover.Options.UseImage = True
        ContextButton1.AppearanceNormal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ContextButton1.AppearanceNormal.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ContextButton1.AppearanceNormal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContextButton1.AppearanceNormal.Options.UseBackColor = True
        ContextButton1.AppearanceNormal.Options.UseFont = True
        ContextButton1.Id = New System.Guid("51bf049b-76be-4ca8-8bfc-51f71371b2c7")
        ContextButton1.ImageOptions.HoverImage = CType(resources.GetObject("resource.HoverImage"), System.Drawing.Image)
        ContextButton1.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ContextButton1.Name = "AddPhotos"
        ToolTipTitleItem1.Text = "Add Photos"
        ToolTipItem1.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Select folder to load photos in your slider"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        ContextButton1.SuperTip = SuperToolTip1
        Me.ImageSlider1.ContextButtons.Add(ContextButton1)
        Me.ImageSlider1.CurrentImageIndex = 0
        Me.ImageSlider1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageSlider1.Images.Add(CType(resources.GetObject("ImageSlider1.Images"), System.Drawing.Image))
        Me.ImageSlider1.Location = New System.Drawing.Point(0, 0)
        Me.ImageSlider1.Name = "ImageSlider1"
        Me.ImageSlider1.Size = New System.Drawing.Size(1000, 349)
        Me.ImageSlider1.TabIndex = 0
        Me.ImageSlider1.Text = "ImageSlider1"
        '
        'PanelSlide
        '
        Me.PanelSlide.BackColor = System.Drawing.Color.White
        Me.PanelSlide.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.PanelSlide.Controls.Add(Me.ImageSlider1)
        Me.PanelSlide.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSlide.Location = New System.Drawing.Point(0, 0)
        Me.PanelSlide.Name = "PanelSlide"
        Me.PanelSlide.ShadowDecoration.Depth = 40
        Me.PanelSlide.ShadowDecoration.Enabled = True
        Me.PanelSlide.ShadowDecoration.Parent = Me.PanelSlide
        Me.PanelSlide.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 7)
        Me.PanelSlide.Size = New System.Drawing.Size(1000, 349)
        Me.PanelSlide.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(403, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(421, 58)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "COVID-19 UPDATE"
        '
        'CovidPanel
        '
        Me.CovidPanel.BackColor = System.Drawing.Color.White
        Me.CovidPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.CovidPanel.Controls.Add(Me.Guna2Panel2)
        Me.CovidPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CovidPanel.Location = New System.Drawing.Point(0, 349)
        Me.CovidPanel.Name = "CovidPanel"
        Me.CovidPanel.Padding = New System.Windows.Forms.Padding(1, 1, 1, 0)
        Me.CovidPanel.ShadowDecoration.Enabled = True
        Me.CovidPanel.ShadowDecoration.Parent = Me.CovidPanel
        Me.CovidPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.CovidPanel.Size = New System.Drawing.Size(1000, 329)
        Me.CovidPanel.TabIndex = 3
        Me.CovidPanel.Visible = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel8)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Guna2Panel2.Size = New System.Drawing.Size(998, 328)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel8.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Guna2Panel8.Controls.Add(Me.Guna2Panel9)
        Me.Guna2Panel8.Controls.Add(Me.Guna2Panel11)
        Me.Guna2Panel8.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel8.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel8.Location = New System.Drawing.Point(518, 88)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.ShadowDecoration.Parent = Me.Guna2Panel8
        Me.Guna2Panel8.Size = New System.Drawing.Size(215, 223)
        Me.Guna2Panel8.TabIndex = 10
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel12.IsSelectionEnabled = False
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(28, 186)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(158, 25)
        Me.Guna2HtmlLabel12.TabIndex = 16
        Me.Guna2HtmlLabel12.Text = "PUM'S (CLEARED)"
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel9.Controls.Add(Me.Guna2Panel10)
        Me.Guna2Panel9.Controls.Add(Me.LblPUMC)
        Me.Guna2Panel9.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel9.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel9.Location = New System.Drawing.Point(0, 73)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.ShadowDecoration.Parent = Me.Guna2Panel9
        Me.Guna2Panel9.Size = New System.Drawing.Size(215, 105)
        Me.Guna2Panel9.TabIndex = 11
        '
        'Guna2Panel10
        '
        Me.Guna2Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel10.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel10.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel10.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel10.Name = "Guna2Panel10"
        Me.Guna2Panel10.ShadowDecoration.Parent = Me.Guna2Panel10
        Me.Guna2Panel10.Size = New System.Drawing.Size(215, 39)
        Me.Guna2Panel10.TabIndex = 15
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(21, 6)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(174, 25)
        Me.Guna2HtmlLabel6.TabIndex = 12
        Me.Guna2HtmlLabel6.Text = "PUM'S (ONGOING)"
        '
        'LblPUMC
        '
        Me.LblPUMC.BackColor = System.Drawing.Color.Transparent
        Me.LblPUMC.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPUMC.ForeColor = System.Drawing.Color.Black
        Me.LblPUMC.IsSelectionEnabled = False
        Me.LblPUMC.Location = New System.Drawing.Point(92, 44)
        Me.LblPUMC.Name = "LblPUMC"
        Me.LblPUMC.Size = New System.Drawing.Size(30, 58)
        Me.LblPUMC.TabIndex = 14
        Me.LblPUMC.Text = "0"
        '
        'Guna2Panel11
        '
        Me.Guna2Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel11.Controls.Add(Me.Guna2Panel12)
        Me.Guna2Panel11.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel11.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel11.Name = "Guna2Panel11"
        Me.Guna2Panel11.ShadowDecoration.Parent = Me.Guna2Panel11
        Me.Guna2Panel11.Size = New System.Drawing.Size(215, 73)
        Me.Guna2Panel11.TabIndex = 3
        '
        'Guna2Panel12
        '
        Me.Guna2Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel12.Controls.Add(Me.LblPUMO)
        Me.Guna2Panel12.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel12.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel12.Name = "Guna2Panel12"
        Me.Guna2Panel12.ShadowDecoration.Parent = Me.Guna2Panel12
        Me.Guna2Panel12.Size = New System.Drawing.Size(215, 75)
        Me.Guna2Panel12.TabIndex = 6
        '
        'LblPUMO
        '
        Me.LblPUMO.BackColor = System.Drawing.Color.Transparent
        Me.LblPUMO.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPUMO.ForeColor = System.Drawing.Color.Black
        Me.LblPUMO.IsSelectionEnabled = False
        Me.LblPUMO.Location = New System.Drawing.Point(92, 8)
        Me.LblPUMO.Name = "LblPUMO"
        Me.LblPUMO.Size = New System.Drawing.Size(30, 58)
        Me.LblPUMO.TabIndex = 15
        Me.LblPUMO.Text = "0"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel15)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel3.Location = New System.Drawing.Point(762, 88)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(215, 223)
        Me.Guna2Panel3.TabIndex = 4
        '
        'Guna2Panel15
        '
        Me.Guna2Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel15.Controls.Add(Me.Guna2Panel13)
        Me.Guna2Panel15.Controls.Add(Me.LblRecovered)
        Me.Guna2Panel15.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel15.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel15.Location = New System.Drawing.Point(0, 73)
        Me.Guna2Panel15.Name = "Guna2Panel15"
        Me.Guna2Panel15.ShadowDecoration.Parent = Me.Guna2Panel15
        Me.Guna2Panel15.Size = New System.Drawing.Size(215, 105)
        Me.Guna2Panel15.TabIndex = 11
        '
        'Guna2Panel13
        '
        Me.Guna2Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel13.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel13.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel13.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel13.Name = "Guna2Panel13"
        Me.Guna2Panel13.ShadowDecoration.Parent = Me.Guna2Panel13
        Me.Guna2Panel13.Size = New System.Drawing.Size(215, 39)
        Me.Guna2Panel13.TabIndex = 15
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel8.IsSelectionEnabled = False
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(72, 6)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(71, 25)
        Me.Guna2HtmlLabel8.TabIndex = 12
        Me.Guna2HtmlLabel8.Text = "DEATHS"
        '
        'LblRecovered
        '
        Me.LblRecovered.BackColor = System.Drawing.Color.Transparent
        Me.LblRecovered.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecovered.ForeColor = System.Drawing.Color.Black
        Me.LblRecovered.IsSelectionEnabled = False
        Me.LblRecovered.Location = New System.Drawing.Point(92, 44)
        Me.LblRecovered.Name = "LblRecovered"
        Me.LblRecovered.Size = New System.Drawing.Size(30, 58)
        Me.LblRecovered.TabIndex = 14
        Me.LblRecovered.Text = "0"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(54, 184)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(112, 25)
        Me.Guna2HtmlLabel4.TabIndex = 10
        Me.Guna2HtmlLabel4.Text = "RECOVERED"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel14)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel5.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(215, 73)
        Me.Guna2Panel5.TabIndex = 3
        '
        'Guna2Panel14
        '
        Me.Guna2Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel14.Controls.Add(Me.LblDeath)
        Me.Guna2Panel14.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel14.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel14.Name = "Guna2Panel14"
        Me.Guna2Panel14.ShadowDecoration.Parent = Me.Guna2Panel14
        Me.Guna2Panel14.Size = New System.Drawing.Size(215, 75)
        Me.Guna2Panel14.TabIndex = 6
        '
        'LblDeath
        '
        Me.LblDeath.BackColor = System.Drawing.Color.Transparent
        Me.LblDeath.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeath.ForeColor = System.Drawing.Color.Black
        Me.LblDeath.IsSelectionEnabled = False
        Me.LblDeath.Location = New System.Drawing.Point(92, 8)
        Me.LblDeath.Name = "LblDeath"
        Me.LblDeath.Size = New System.Drawing.Size(30, 58)
        Me.LblDeath.TabIndex = 15
        Me.LblDeath.Text = "0"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackgroundImage = CType(resources.GetObject("Guna2PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(740, 14)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(80, 63)
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(185, 14)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(80, 63)
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel6.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel6.Location = New System.Drawing.Point(269, 88)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(215, 211)
        Me.Guna2Panel6.TabIndex = 5
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.AutoSize = False
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(20, 156)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(174, 50)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "PERSON UNDER INVESTIGATION"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel7.Controls.Add(Me.LblPUI)
        Me.Guna2Panel7.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel7.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.ShadowDecoration.Parent = Me.Guna2Panel7
        Me.Guna2Panel7.Size = New System.Drawing.Size(215, 140)
        Me.Guna2Panel7.TabIndex = 3
        '
        'LblPUI
        '
        Me.LblPUI.BackColor = System.Drawing.Color.Transparent
        Me.LblPUI.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPUI.ForeColor = System.Drawing.Color.Black
        Me.LblPUI.IsSelectionEnabled = False
        Me.LblPUI.Location = New System.Drawing.Point(92, 41)
        Me.LblPUI.Name = "LblPUI"
        Me.LblPUI.Size = New System.Drawing.Size(30, 58)
        Me.LblPUI.TabIndex = 14
        Me.LblPUI.Text = "0"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(19, 88)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(215, 211)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel3.IsSelectionEnabled = False
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(20, 167)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(177, 25)
        Me.Guna2HtmlLabel3.TabIndex = 9
        Me.Guna2HtmlLabel3.Text = "CONFIRMED CASES"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel4.Controls.Add(Me.LblConfirmed)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(215, 140)
        Me.Guna2Panel4.TabIndex = 2
        '
        'LblConfirmed
        '
        Me.LblConfirmed.BackColor = System.Drawing.Color.Transparent
        Me.LblConfirmed.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmed.ForeColor = System.Drawing.Color.Black
        Me.LblConfirmed.IsSelectionEnabled = False
        Me.LblConfirmed.Location = New System.Drawing.Point(96, 51)
        Me.LblConfirmed.Name = "LblConfirmed"
        Me.LblConfirmed.Size = New System.Drawing.Size(30, 58)
        Me.LblConfirmed.TabIndex = 13
        Me.LblConfirmed.Text = "0"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Yellow
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(264, 14)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(475, 57)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "COVID-19 UPDATE"
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'HomeContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 678)
        Me.Controls.Add(Me.CovidPanel)
        Me.Controls.Add(Me.PanelSlide)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeContent"
        Me.Text = "HomeContent"
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSlide.ResumeLayout(False)
        Me.CovidPanel.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        Me.Guna2Panel10.ResumeLayout(False)
        Me.Guna2Panel10.PerformLayout()
        Me.Guna2Panel11.ResumeLayout(False)
        Me.Guna2Panel12.ResumeLayout(False)
        Me.Guna2Panel12.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel15.ResumeLayout(False)
        Me.Guna2Panel15.PerformLayout()
        Me.Guna2Panel13.ResumeLayout(False)
        Me.Guna2Panel13.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel14.ResumeLayout(False)
        Me.Guna2Panel14.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ImageSlider1 As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents PanelSlide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CovidPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblPUI As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel15 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblRecovered As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel14 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblDeath As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblConfirmed As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel13 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel10 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblPUMC As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel11 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel12 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblPUMO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
