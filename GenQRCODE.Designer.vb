<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenQRCODE
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
        Me.NetResize1 = New Softgroup.NetResize.NetResize(Me.components)
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.imageBox1 = New Emgu.CV.UI.ImageBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.imageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NetResize1
        '
        Me.NetResize1.ParentControl = Me
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(67, 170)
        Me.textBox1.Name = "textBox1"
        Me.NetResize1.SetResizeTextBoxMultiline(Me.textBox1, False)
        Me.textBox1.Size = New System.Drawing.Size(107, 20)
        Me.textBox1.TabIndex = 7
        Me.textBox1.Text = "---"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "PNG Image|*.png"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.groupBox2)
        Me.Panel4.Controls.Add(Me.groupBox1)
        Me.Panel4.Controls.Add(Me.imageBoxFrameGrabber)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 22)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(531, 383)
        Me.Panel4.TabIndex = 30
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.button1)
        Me.groupBox2.Location = New System.Drawing.Point(12, 266)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(510, 109)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Results: "
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(9, 23)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(197, 15)
        Me.label5.TabIndex = 17
        Me.label5.Text = "Persons present in the scene:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(9, 53)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 19)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Nobody"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(195, 81)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(16, 16)
        Me.label3.TabIndex = 15
        Me.label3.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(10, 80)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(179, 15)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Number of faces detected: "
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(284, 65)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(216, 36)
        Me.button1.TabIndex = 2
        Me.button1.Text = "1. Detect and recognize"
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.imageBox1)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Location = New System.Drawing.Point(338, 16)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(184, 242)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Training: "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 173)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Name: "
        '
        'imageBox1
        '
        Me.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox1.Location = New System.Drawing.Point(11, 18)
        Me.imageBox1.Name = "imageBox1"
        Me.imageBox1.Size = New System.Drawing.Size(163, 134)
        Me.imageBox1.TabIndex = 5
        Me.imageBox1.TabStop = False
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(87, 201)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(87, 31)
        Me.button2.TabIndex = 3
        Me.button2.Text = "2. Add face"
        Me.button2.UseVisualStyleBackColor = True
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(12, 18)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(320, 240)
        Me.imageBoxFrameGrabber.TabIndex = 5
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(531, 22)
        Me.Panel2.TabIndex = 29
        '
        'GenQRCODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 405)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "GenQRCODE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenQRCODE"
        CType(Me.NetResize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.imageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NetResize1 As Softgroup.NetResize.NetResize
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents imageBox1 As Emgu.CV.UI.ImageBox
    Private WithEvents button2 As Button
End Class
