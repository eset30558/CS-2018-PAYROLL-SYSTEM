<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salaries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salaries))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PayrollBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payroll_GarenaDataSet7 = New Payroll_Finals.Payroll_GarenaDataSet7()
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Payroll_GarenaDataSet2 = New Payroll_Finals.Payroll_GarenaDataSet2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PayrollTableAdapter = New Payroll_Finals.Payroll_GarenaDataSet2TableAdapters.PayrollTableAdapter()
        Me.PayrollTableAdapter1 = New Payroll_Finals.Payroll_GarenaDataSet7TableAdapters.PayrollTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_GarenaDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Payroll_GarenaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(744, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'PayrollBindingSource1
        '
        Me.PayrollBindingSource1.DataMember = "Payroll"
        Me.PayrollBindingSource1.DataSource = Me.Payroll_GarenaDataSet7
        '
        'Payroll_GarenaDataSet7
        '
        Me.Payroll_GarenaDataSet7.DataSetName = "Payroll_GarenaDataSet7"
        Me.Payroll_GarenaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "Payroll"
        Me.PayrollBindingSource.DataSource = Me.Payroll_GarenaDataSet2
        '
        'Payroll_GarenaDataSet2
        '
        Me.Payroll_GarenaDataSet2.DataSetName = "Payroll_GarenaDataSet2"
        Me.Payroll_GarenaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(824, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "Login as:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel2.Image = Global.Payroll_Finals.My.Resources.Resources._45feb70ba531e0f07051a8c155b4a1b6
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel2.Text = "---------"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(600, 17)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel4.Text = "----------------"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources._975226
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(41, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 94)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SALARY ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 20)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(65, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(60, 393)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 30)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "VIEW PAYROLL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(184, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "PRINT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(617, 393)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(152, 30)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "MAINMENU"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources.download
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(677, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 94)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources.Garena_PH_Logo_Header_Image_750x400
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(499, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(172, 94)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'PayrollTableAdapter1
        '
        Me.PayrollTableAdapter1.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(353, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "GET DATA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Salaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources.received_5937158848122781
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(824, 461)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Salaries"
        Me.Text = "Salaries"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_GarenaDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Payroll_GarenaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Payroll_GarenaDataSet2 As Payroll_Finals.Payroll_GarenaDataSet2
    Friend WithEvents PayrollBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PayrollTableAdapter As Payroll_Finals.Payroll_GarenaDataSet2TableAdapters.PayrollTableAdapter
    Friend WithEvents Payroll_GarenaDataSet7 As Payroll_Finals.Payroll_GarenaDataSet7
    Friend WithEvents PayrollBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PayrollTableAdapter1 As Payroll_Finals.Payroll_GarenaDataSet7TableAdapters.PayrollTableAdapter
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
