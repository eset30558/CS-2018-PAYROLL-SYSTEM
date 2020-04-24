<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollCompute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayrollCompute))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Gross_Salary = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OT_Hours = New System.Windows.Forms.TextBox()
        Me.Enter_Rate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Work_Hours = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OT_Rate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Work_Days = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New Payroll_Finals.Payroll_GarenaDataSet4TableAdapters.EmployeeTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ID = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.L_name = New System.Windows.Forms.TextBox()
        Me.F_name = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Payroll_GarenaDataSet5 = New Payroll_Finals.Payroll_GarenaDataSet5()
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter1 = New Payroll_Finals.Payroll_GarenaDataSet5TableAdapters.EmployeeTableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Phil_Health = New System.Windows.Forms.TextBox()
        Me.Pag_Ibig = New System.Windows.Forms.TextBox()
        Me.Tax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SSS = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Net_Salary = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Payroll_GarenaDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources.download
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(725, 417)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 48)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources._45feb70ba531e0f07051a8c155b4a1b6
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(790, 417)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Black
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 468)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(858, 22)
        Me.StatusStrip1.TabIndex = 8
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
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(634, 17)
        Me.ToolStripStatusLabel3.Spring = True
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel4.Text = "----------------"
        '
        'Timer1
        '
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(542, 437)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(177, 28)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "MAINMENU"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources._975226
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Gross_Salary)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.OT_Hours)
        Me.GroupBox2.Controls.Add(Me.Enter_Rate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Work_Hours)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.OT_Rate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Work_Days)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 309)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GROSS SALARY"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(143, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 24)
        Me.RadioButton2.TabIndex = 32
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "CASUAL"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(18, 36)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(114, 24)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "REGULAR"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Gross_Salary
        '
        Me.Gross_Salary.AutoSize = True
        Me.Gross_Salary.BackColor = System.Drawing.Color.Transparent
        Me.Gross_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gross_Salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gross_Salary.ForeColor = System.Drawing.Color.White
        Me.Gross_Salary.Location = New System.Drawing.Point(27, 233)
        Me.Gross_Salary.Name = "Gross_Salary"
        Me.Gross_Salary.Size = New System.Drawing.Size(199, 20)
        Me.Gross_Salary.TabIndex = 31
        Me.Gross_Salary.Text = "___________________"
        Me.Gross_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(51, 264)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 31)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "COMPUTE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "OT Hours:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(47, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "GROSS SALARY:"
        '
        'OT_Hours
        '
        Me.OT_Hours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OT_Hours.Location = New System.Drawing.Point(121, 177)
        Me.OT_Hours.Name = "OT_Hours"
        Me.OT_Hours.Size = New System.Drawing.Size(105, 19)
        Me.OT_Hours.TabIndex = 7
        '
        'Enter_Rate
        '
        Me.Enter_Rate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enter_Rate.Location = New System.Drawing.Point(121, 77)
        Me.Enter_Rate.Name = "Enter_Rate"
        Me.Enter_Rate.Size = New System.Drawing.Size(105, 19)
        Me.Enter_Rate.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "OT Rate:"
        '
        'Work_Hours
        '
        Me.Work_Hours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Work_Hours.Location = New System.Drawing.Point(121, 102)
        Me.Work_Hours.Name = "Work_Hours"
        Me.Work_Hours.Size = New System.Drawing.Size(105, 19)
        Me.Work_Hours.TabIndex = 4
        Me.Work_Hours.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Work(Days):"
        '
        'OT_Rate
        '
        Me.OT_Rate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OT_Rate.Location = New System.Drawing.Point(121, 152)
        Me.OT_Rate.Name = "OT_Rate"
        Me.OT_Rate.Size = New System.Drawing.Size(105, 19)
        Me.OT_Rate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Work(Hrs):"
        '
        'Work_Days
        '
        Me.Work_Days.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Work_Days.Location = New System.Drawing.Point(121, 127)
        Me.Work_Days.Name = "Work_Days"
        Me.Work_Days.Size = New System.Drawing.Size(105, 19)
        Me.Work_Days.TabIndex = 5
        Me.Work_Days.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Enter Rate:"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources._975226
        Me.GroupBox3.Controls.Add(Me.ID)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.L_name)
        Me.GroupBox3.Controls.Add(Me.F_name)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(477, 115)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH"
        '
        'ID
        '
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ID.FormattingEnabled = True
        Me.ID.Location = New System.Drawing.Point(56, 50)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(121, 28)
        Me.ID.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(190, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 24)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "LAST NAME:"
        '
        'L_name
        '
        Me.L_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.L_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.L_name.Location = New System.Drawing.Point(335, 67)
        Me.L_name.Multiline = True
        Me.L_name.Name = "L_name"
        Me.L_name.Size = New System.Drawing.Size(136, 32)
        Me.L_name.TabIndex = 15
        '
        'F_name
        '
        Me.F_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.F_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.F_name.Location = New System.Drawing.Point(335, 28)
        Me.F_name.Multiline = True
        Me.F_name.Name = "F_name"
        Me.F_name.Size = New System.Drawing.Size(136, 31)
        Me.F_name.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(15, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 24)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(190, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FIRST NAME:"
        '
        'Payroll_GarenaDataSet5
        '
        Me.Payroll_GarenaDataSet5.DataSetName = "Payroll_GarenaDataSet5"
        Me.Payroll_GarenaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "Employee"
        Me.EmployeeBindingSource1.DataSource = Me.Payroll_GarenaDataSet5
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SSS(%):"
        '
        'Phil_Health
        '
        Me.Phil_Health.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Phil_Health.Location = New System.Drawing.Point(127, 60)
        Me.Phil_Health.Name = "Phil_Health"
        Me.Phil_Health.Size = New System.Drawing.Size(82, 19)
        Me.Phil_Health.TabIndex = 11
        Me.Phil_Health.Text = "0"
        Me.Phil_Health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pag_Ibig
        '
        Me.Pag_Ibig.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pag_Ibig.Location = New System.Drawing.Point(127, 87)
        Me.Pag_Ibig.Name = "Pag_Ibig"
        Me.Pag_Ibig.Size = New System.Drawing.Size(82, 19)
        Me.Pag_Ibig.TabIndex = 12
        Me.Pag_Ibig.Text = "0"
        Me.Pag_Ibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tax
        '
        Me.Tax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tax.Location = New System.Drawing.Point(127, 114)
        Me.Tax.Name = "Tax"
        Me.Tax.Size = New System.Drawing.Size(82, 19)
        Me.Tax.TabIndex = 13
        Me.Tax.Text = "0"
        Me.Tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Pag-ibig(%):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(9, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "TAX (%):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(42, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "NET SALARY:"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(25, 204)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 26)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "ADD"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SSS
        '
        Me.SSS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SSS.Location = New System.Drawing.Point(127, 33)
        Me.SSS.Name = "SSS"
        Me.SSS.Size = New System.Drawing.Size(82, 19)
        Me.SSS.TabIndex = 29
        Me.SSS.Text = "0"
        Me.SSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(25, 235)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 26)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "CLEAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(25, 265)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(177, 28)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "VIEW SALARIES"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Net_Salary
        '
        Me.Net_Salary.AutoSize = True
        Me.Net_Salary.BackColor = System.Drawing.Color.Transparent
        Me.Net_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Net_Salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net_Salary.ForeColor = System.Drawing.Color.White
        Me.Net_Salary.Location = New System.Drawing.Point(21, 176)
        Me.Net_Salary.Name = "Net_Salary"
        Me.Net_Salary.Size = New System.Drawing.Size(199, 20)
        Me.Net_Salary.TabIndex = 30
        Me.Net_Salary.Text = "___________________"
        Me.Net_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources._975226
        Me.GroupBox1.Controls.Add(Me.Net_Salary)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.SSS)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Tax)
        Me.GroupBox1.Controls.Add(Me.Pag_Ibig)
        Me.GroupBox1.Controls.Add(Me.Phil_Health)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(272, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 309)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEDUCTIONS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Phil-Health(%):"
        '
        'PayrollCompute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll_Finals.My.Resources.Resources.received_2715457025236742
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 490)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PayrollCompute"
        Me.Text = "PayrollCompute"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Payroll_GarenaDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OT_Hours As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OT_Rate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Work_Days As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Work_Hours As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Enter_Rate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gross_Salary As System.Windows.Forms.Label
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Payroll_Finals.Payroll_GarenaDataSet4TableAdapters.EmployeeTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents L_name As System.Windows.Forms.TextBox
    Friend WithEvents F_name As System.Windows.Forms.TextBox
    Friend WithEvents Payroll_GarenaDataSet5 As Payroll_Finals.Payroll_GarenaDataSet5
    Friend WithEvents EmployeeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter1 As Payroll_Finals.Payroll_GarenaDataSet5TableAdapters.EmployeeTableAdapter
    Friend WithEvents ID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Phil_Health As System.Windows.Forms.TextBox
    Friend WithEvents Pag_Ibig As System.Windows.Forms.TextBox
    Friend WithEvents Tax As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SSS As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Net_Salary As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
