<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSal_Repl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSal_Repl))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxDisplayOutput = New System.Windows.Forms.RichTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AST = New System.Windows.Forms.TreeView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxProgram = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxErrorOutput = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TabControl_REPL_INPUT = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxCodeInput = New System.Windows.Forms.TextBox()
        Me.ToolStripRepl = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCompileCode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRunCode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonCompilesTox86 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonOpenVM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl_REPL_INPUT.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStripRepl.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1451, 614)
        Me.SplitContainer1.SplitterDistance = 353
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1451, 353)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SpydazWeb AI Programming Language Editor"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Black
        Me.GroupBox6.BackgroundImage = Global.SDK.My.Resources.Resources.Dell_UltraSharp_27
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.RichTextBoxDisplayOutput)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox6.Location = New System.Drawing.Point(457, 17)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(594, 334)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Program Output"
        '
        'RichTextBoxDisplayOutput
        '
        Me.RichTextBoxDisplayOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxDisplayOutput.BackColor = System.Drawing.Color.Gainsboro
        Me.RichTextBoxDisplayOutput.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxDisplayOutput.Location = New System.Drawing.Point(5, 18)
        Me.RichTextBoxDisplayOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBoxDisplayOutput.Name = "RichTextBoxDisplayOutput"
        Me.RichTextBoxDisplayOutput.Size = New System.Drawing.Size(584, 230)
        Me.RichTextBoxDisplayOutput.TabIndex = 0
        Me.RichTextBoxDisplayOutput.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.Controls.Add(Me.AST)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox5.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox5.Location = New System.Drawing.Point(1051, 17)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(398, 334)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Abstract Syntax Tree"
        '
        'AST
        '
        Me.AST.BackColor = System.Drawing.SystemColors.Info
        Me.AST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AST.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AST.Location = New System.Drawing.Point(2, 17)
        Me.AST.Margin = New System.Windows.Forms.Padding(2)
        Me.AST.Name = "AST"
        Me.AST.Size = New System.Drawing.Size(394, 315)
        Me.AST.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.RichTextBoxProgram)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(2, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(455, 334)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Program"
        '
        'RichTextBoxProgram
        '
        Me.RichTextBoxProgram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxProgram.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxProgram.Location = New System.Drawing.Point(2, 17)
        Me.RichTextBoxProgram.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBoxProgram.Multiline = True
        Me.RichTextBoxProgram.Name = "RichTextBoxProgram"
        Me.RichTextBoxProgram.Size = New System.Drawing.Size(451, 315)
        Me.RichTextBoxProgram.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1451, 257)
        Me.SplitContainer2.SplitterDistance = 458
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.TextBoxErrorOutput)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(458, 257)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Error Output"
        '
        'TextBoxErrorOutput
        '
        Me.TextBoxErrorOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxErrorOutput.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxErrorOutput.Location = New System.Drawing.Point(2, 17)
        Me.TextBoxErrorOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxErrorOutput.Multiline = True
        Me.TextBoxErrorOutput.Name = "TextBoxErrorOutput"
        Me.TextBoxErrorOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxErrorOutput.Size = New System.Drawing.Size(454, 238)
        Me.TextBoxErrorOutput.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Controls.Add(Me.TabControl_REPL_INPUT)
        Me.GroupBox4.Controls.Add(Me.ToolStripRepl)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(989, 257)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "REPL"
        '
        'TabControl_REPL_INPUT
        '
        Me.TabControl_REPL_INPUT.Controls.Add(Me.TabPage2)
        Me.TabControl_REPL_INPUT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_REPL_INPUT.Location = New System.Drawing.Point(5, 75)
        Me.TabControl_REPL_INPUT.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl_REPL_INPUT.Name = "TabControl_REPL_INPUT"
        Me.TabControl_REPL_INPUT.SelectedIndex = 0
        Me.TabControl_REPL_INPUT.Size = New System.Drawing.Size(979, 177)
        Me.TabControl_REPL_INPUT.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxCodeInput)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage2.Size = New System.Drawing.Size(971, 151)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Program"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxCodeInput
        '
        Me.TextBoxCodeInput.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBoxCodeInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCodeInput.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodeInput.Location = New System.Drawing.Point(5, 5)
        Me.TextBoxCodeInput.Multiline = True
        Me.TextBoxCodeInput.Name = "TextBoxCodeInput"
        Me.TextBoxCodeInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxCodeInput.Size = New System.Drawing.Size(961, 141)
        Me.TextBoxCodeInput.TabIndex = 0
        '
        'ToolStripRepl
        '
        Me.ToolStripRepl.BackColor = System.Drawing.Color.Black
        Me.ToolStripRepl.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStripRepl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.ToolStripSeparator7, Me.OpenToolStripButton, Me.ToolStripSeparator6, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.ToolStripSeparator8, Me.CopyToolStripButton, Me.ToolStripSeparator9, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.ToolStripButtonCompileCode, Me.ToolStripButtonRunCode, Me.ToolStripSeparator3, Me.ToolStripButtonCompilesTox86, Me.ToolStripSeparator2, Me.ButtonOpenVM, Me.ToolStripSeparator4, Me.HelpToolStripButton, Me.ToolStripSeparator5})
        Me.ToolStripRepl.Location = New System.Drawing.Point(5, 18)
        Me.ToolStripRepl.Name = "ToolStripRepl"
        Me.ToolStripRepl.Size = New System.Drawing.Size(979, 57)
        Me.ToolStripRepl.TabIndex = 0
        Me.ToolStripRepl.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.NewToolStripButton.Tag = "New Program"
        Me.NewToolStripButton.Text = "&New"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 57)
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.OpenToolStripButton.Tag = "Open Program"
        Me.OpenToolStripButton.Text = "&Open"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 57)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.SaveToolStripButton.Tag = "Save Program"
        Me.SaveToolStripButton.Text = "&Save "
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 57)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 57)
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 57)
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButtonCompileCode
        '
        Me.ToolStripButtonCompileCode.BackColor = System.Drawing.Color.Black
        Me.ToolStripButtonCompileCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCompileCode.Image = Global.SDK.My.Resources.Resources.Complier_RUN
        Me.ToolStripButtonCompileCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCompileCode.Name = "ToolStripButtonCompileCode"
        Me.ToolStripButtonCompileCode.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButtonCompileCode.Tag = "Compiles to AST - If it compiles to AST then it will Evaluate or Generate SAL"
        Me.ToolStripButtonCompileCode.Text = "Compiles Code to AST"
        Me.ToolStripButtonCompileCode.ToolTipText = "Compile Code to AST"
        '
        'ToolStripButtonRunCode
        '
        Me.ToolStripButtonRunCode.BackColor = System.Drawing.Color.Black
        Me.ToolStripButtonRunCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRunCode.Image = Global.SDK.My.Resources.Resources.Arrow_Right
        Me.ToolStripButtonRunCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRunCode.Name = "ToolStripButtonRunCode"
        Me.ToolStripButtonRunCode.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButtonRunCode.Tag = "Evaluate Code (Uses S-Expression)"
        Me.ToolStripButtonRunCode.Text = "Run"
        Me.ToolStripButtonRunCode.ToolTipText = "Runs Code on VM"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'ToolStripButtonCompilesTox86
        '
        Me.ToolStripButtonCompilesTox86.BackColor = System.Drawing.Color.Silver
        Me.ToolStripButtonCompilesTox86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCompilesTox86.Image = Global.SDK.My.Resources.Resources.Script
        Me.ToolStripButtonCompilesTox86.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCompilesTox86.Name = "ToolStripButtonCompilesTox86"
        Me.ToolStripButtonCompilesTox86.Size = New System.Drawing.Size(54, 54)
        Me.ToolStripButtonCompilesTox86.Text = "Transpile to X86 Code"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'ButtonOpenVM
        '
        Me.ButtonOpenVM.BackColor = System.Drawing.Color.Black
        Me.ButtonOpenVM.BackgroundImage = Global.SDK.My.Resources.Resources.EYE_BLUE_
        Me.ButtonOpenVM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButtonOpenVM.Image = Global.SDK.My.Resources.Resources.EYE_BLUE_
        Me.ButtonOpenVM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonOpenVM.Name = "ButtonOpenVM"
        Me.ButtonOpenVM.Size = New System.Drawing.Size(54, 54)
        Me.ButtonOpenVM.Text = "Load SAL"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 57)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.BackColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(54, 54)
        Me.HelpToolStripButton.Text = "He&lp Refference"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 57)
        '
        'FrmSal_Repl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 614)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSal_Repl"
        Me.Text = "Spydaz Assembly Language REPL"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl_REPL_INPUT.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStripRepl.ResumeLayout(False)
        Me.ToolStripRepl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RichTextBoxDisplayOutput As RichTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AST As TreeView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBoxProgram As TextBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxErrorOutput As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TabControl_REPL_INPUT As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxCodeInput As TextBox
    Friend WithEvents ToolStripRepl As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButtonCompileCode As ToolStripButton
    Friend WithEvents ToolStripButtonRunCode As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButtonCompilesTox86 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ButtonOpenVM As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
