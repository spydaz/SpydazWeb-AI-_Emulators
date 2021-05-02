<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormREPL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormREPL))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl_REPL_INPUT = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxCodeInput = New System.Windows.Forms.TextBox()
        Me.ToolStripRepl = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxREPL_OUTPUT = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl_Repl_ErrorOutput = New System.Windows.Forms.TabControl()
        Me.TabPageReplErrors = New System.Windows.Forms.TabPage()
        Me.TextboxErrors = New System.Windows.Forms.RichTextBox()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCompileCode = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCompilesTox86 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonRunCode = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.AstTreeView = New System.Windows.Forms.TreeView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl_REPL_INPUT.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStripRepl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl_Repl_ErrorOutput.SuspendLayout()
        Me.TabPageReplErrors.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1660, 684)
        Me.SplitContainer1.SplitterDistance = 390
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1660, 390)
        Me.SplitContainer2.SplitterDistance = 690
        Me.SplitContainer2.SplitterWidth = 7
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.TabControl_REPL_INPUT)
        Me.GroupBox1.Controls.Add(Me.ToolStripRepl)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(690, 390)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPL"
        '
        'TabControl_REPL_INPUT
        '
        Me.TabControl_REPL_INPUT.Controls.Add(Me.TabPage2)
        Me.TabControl_REPL_INPUT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_REPL_INPUT.Location = New System.Drawing.Point(5, 68)
        Me.TabControl_REPL_INPUT.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl_REPL_INPUT.Name = "TabControl_REPL_INPUT"
        Me.TabControl_REPL_INPUT.SelectedIndex = 0
        Me.TabControl_REPL_INPUT.Size = New System.Drawing.Size(680, 317)
        Me.TabControl_REPL_INPUT.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxCodeInput)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage2.Size = New System.Drawing.Size(672, 283)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Program"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxCodeInput
        '
        Me.TextBoxCodeInput.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBoxCodeInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxCodeInput.Font = New System.Drawing.Font("Courier", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodeInput.Location = New System.Drawing.Point(5, 5)
        Me.TextBoxCodeInput.Multiline = True
        Me.TextBoxCodeInput.Name = "TextBoxCodeInput"
        Me.TextBoxCodeInput.Size = New System.Drawing.Size(662, 273)
        Me.TextBoxCodeInput.TabIndex = 0
        '
        'ToolStripRepl
        '
        Me.ToolStripRepl.BackColor = System.Drawing.Color.Silver
        Me.ToolStripRepl.ImageScalingSize = New System.Drawing.Size(35, 35)
        Me.ToolStripRepl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.HelpToolStripButton, Me.ToolStripButtonCompileCode, Me.ToolStripButtonCompilesTox86, Me.ToolStripButtonRunCode})
        Me.ToolStripRepl.Location = New System.Drawing.Point(5, 26)
        Me.ToolStripRepl.Name = "ToolStripRepl"
        Me.ToolStripRepl.Size = New System.Drawing.Size(680, 42)
        Me.ToolStripRepl.TabIndex = 0
        Me.ToolStripRepl.Text = "ToolStrip1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 42)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.TextBoxREPL_OUTPUT)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(963, 390)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Console Output"
        '
        'TextBoxREPL_OUTPUT
        '
        Me.TextBoxREPL_OUTPUT.BackColor = System.Drawing.Color.Black
        Me.TextBoxREPL_OUTPUT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxREPL_OUTPUT.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxREPL_OUTPUT.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxREPL_OUTPUT.Location = New System.Drawing.Point(5, 26)
        Me.TextBoxREPL_OUTPUT.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxREPL_OUTPUT.Multiline = True
        Me.TextBoxREPL_OUTPUT.Name = "TextBoxREPL_OUTPUT"
        Me.TextBoxREPL_OUTPUT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxREPL_OUTPUT.Size = New System.Drawing.Size(953, 359)
        Me.TextBoxREPL_OUTPUT.TabIndex = 0
        Me.TextBoxREPL_OUTPUT.Text = ">"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer3.Size = New System.Drawing.Size(1660, 288)
        Me.SplitContainer3.SplitterDistance = 592
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.TabControl_Repl_ErrorOutput)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(592, 288)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Errors"
        '
        'TabControl_Repl_ErrorOutput
        '
        Me.TabControl_Repl_ErrorOutput.Controls.Add(Me.TabPageReplErrors)
        Me.TabControl_Repl_ErrorOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_Repl_ErrorOutput.Location = New System.Drawing.Point(5, 26)
        Me.TabControl_Repl_ErrorOutput.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl_Repl_ErrorOutput.Name = "TabControl_Repl_ErrorOutput"
        Me.TabControl_Repl_ErrorOutput.SelectedIndex = 0
        Me.TabControl_Repl_ErrorOutput.Size = New System.Drawing.Size(582, 257)
        Me.TabControl_Repl_ErrorOutput.TabIndex = 0
        '
        'TabPageReplErrors
        '
        Me.TabPageReplErrors.Controls.Add(Me.TextboxErrors)
        Me.TabPageReplErrors.Location = New System.Drawing.Point(4, 30)
        Me.TabPageReplErrors.Name = "TabPageReplErrors"
        Me.TabPageReplErrors.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageReplErrors.Size = New System.Drawing.Size(574, 223)
        Me.TabPageReplErrors.TabIndex = 0
        Me.TabPageReplErrors.Text = "Errors"
        Me.TabPageReplErrors.UseVisualStyleBackColor = True
        '
        'TextboxErrors
        '
        Me.TextboxErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextboxErrors.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxErrors.Location = New System.Drawing.Point(3, 3)
        Me.TextboxErrors.Name = "TextboxErrors"
        Me.TextboxErrors.Size = New System.Drawing.Size(568, 217)
        Me.TextboxErrors.TabIndex = 0
        Me.TextboxErrors.Text = ""
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(39, 39)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'ToolStripButtonCompileCode
        '
        Me.ToolStripButtonCompileCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCompileCode.Image = Global.SDK.My.Resources.Resources.Complier_RUN
        Me.ToolStripButtonCompileCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCompileCode.Name = "ToolStripButtonCompileCode"
        Me.ToolStripButtonCompileCode.Size = New System.Drawing.Size(39, 39)
        Me.ToolStripButtonCompileCode.Tag = "Compiles to AST"
        Me.ToolStripButtonCompileCode.Text = "Compile Code"
        '
        'ToolStripButtonCompilesTox86
        '
        Me.ToolStripButtonCompilesTox86.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonCompilesTox86.Image = Global.SDK.My.Resources.Resources.Script
        Me.ToolStripButtonCompilesTox86.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCompilesTox86.Name = "ToolStripButtonCompilesTox86"
        Me.ToolStripButtonCompilesTox86.Size = New System.Drawing.Size(39, 39)
        Me.ToolStripButtonCompilesTox86.Text = "Compile to X86"
        '
        'ToolStripButtonRunCode
        '
        Me.ToolStripButtonRunCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonRunCode.Image = Global.SDK.My.Resources.Resources.Arrow_Right
        Me.ToolStripButtonRunCode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonRunCode.Name = "ToolStripButtonRunCode"
        Me.ToolStripButtonRunCode.Size = New System.Drawing.Size(39, 39)
        Me.ToolStripButtonRunCode.Tag = "Runs Code on VM"
        Me.ToolStripButtonRunCode.Text = "Run"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = Global.SDK.My.Resources.Resources.Console_A
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.AstTreeView)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1064, 288)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'AstTreeView
        '
        Me.AstTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AstTreeView.BackColor = System.Drawing.SystemColors.InfoText
        Me.AstTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AstTreeView.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AstTreeView.ForeColor = System.Drawing.Color.MintCream
        Me.AstTreeView.HotTracking = True
        Me.AstTreeView.Location = New System.Drawing.Point(97, 15)
        Me.AstTreeView.Name = "AstTreeView"
        Me.AstTreeView.ShowNodeToolTips = True
        Me.AstTreeView.Size = New System.Drawing.Size(869, 266)
        Me.AstTreeView.TabIndex = 0
        '
        'FormREPL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1660, 684)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormREPL"
        Me.Text = "SpydazWeb Basic Programming language REPL"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl_REPL_INPUT.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStripRepl.ResumeLayout(False)
        Me.ToolStripRepl.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl_Repl_ErrorOutput.ResumeLayout(False)
        Me.TabPageReplErrors.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxREPL_OUTPUT As TextBox
    Friend WithEvents TabControl_REPL_INPUT As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxCodeInput As TextBox
    Friend WithEvents ToolStripRepl As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButtonCompileCode As ToolStripButton
    Friend WithEvents ToolStripButtonRunCode As ToolStripButton
    Friend WithEvents ToolStripButtonCompilesTox86 As ToolStripButton
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl_Repl_ErrorOutput As TabControl
    Friend WithEvents TabPageReplErrors As TabPage
    Friend WithEvents TextboxErrors As RichTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents AstTreeView As TreeView
End Class
