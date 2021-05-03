Imports SDK.SAL
Imports SDK.SmallProgLang

Public Class FrmSal_Repl
    Private Sub ToolStripButtonCompileCode_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCompileCode.Click
        Dim PROG() As String = Split(TextBoxCodeInput.Text.Replace(vbCrLf, " "), " ")
        RichTextBoxProgram.Text = PROG.ToJson
        Dim InstructionLst As New List(Of String)
        Dim ROOT As New TreeNode
        ROOT.Text = "ASSEMBLY_CODE"
        Dim Count As Integer = 0
        For Each item In PROG
            Count += 1
            If item <> "" Then
                Dim NDE As New TreeNode
                NDE.Text = Count & ": " & item
                ROOT.Nodes.Add(NDE)
                InstructionLst.Add(item)
            End If
        Next
        'cpu - START

        'Dim CPU As ZX81_CPU = New ZX81_CPU(InstructionLst)
        'CPU.Run()
        Dim CPU As ZX81_CPU = New ZX81_CPU("Test", InstructionLst)
        DisplayOutput("CURRENT POINTER = " & CPU.Get_Instruction_Pointer_Position & vbNewLine & "CONTAINED DATA = " & CPU.Peek)
        AST.Nodes.Add(ROOT)
    End Sub
    Public Sub DisplayOutput(ByRef OutputStr As String)
        RichTextBoxDisplayOutput.Text = OutputStr
    End Sub
    Public Sub DisplayError(ByRef ErrorStr As String)
        TextBoxErrorOutput.Text &= ErrorStr
    End Sub
End Class