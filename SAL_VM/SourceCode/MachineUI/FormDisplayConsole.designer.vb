<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDisplayConsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDisplayConsole))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Zx81_DisplayScreen = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Zx81_DisplayScreen)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 474)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Zx81_DisplayScreen
        '
        Me.Zx81_DisplayScreen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Zx81_DisplayScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Zx81_DisplayScreen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Zx81_DisplayScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Zx81_DisplayScreen.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zx81_DisplayScreen.Location = New System.Drawing.Point(3, 16)
        Me.Zx81_DisplayScreen.Name = "Zx81_DisplayScreen"
        Me.Zx81_DisplayScreen.Size = New System.Drawing.Size(664, 455)
        Me.Zx81_DisplayScreen.TabIndex = 0
        Me.Zx81_DisplayScreen.Text = "SpydazWeb AI ZX81 Copyright © 2020" & Global.Microsoft.VisualBasic.ChrW(10) & "Ready." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormDisplayConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAL_VM.My.Resources.Resources.Dell_UltraSharp_27
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(670, 672)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(938, 711)
        Me.MinimumSize = New System.Drawing.Size(680, 711)
        Me.Name = "FormDisplayConsole"
        Me.Text = "SpydazWeb AI ZX2020"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Zx81_DisplayScreen As RichTextBox
End Class
