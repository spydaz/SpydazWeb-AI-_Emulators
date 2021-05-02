Imports SDK
Imports SDK.SmallProgLang
Imports SDK.SmallProgLang.Ast_ExpressionFactory
Imports SDK.SmallProgLang.Compiler

Public Class FormREPL

    Dim PSER As New Parser
    Private Sub ToolStripButtonCompile_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCompileCode.Click
        Dim InputCode As String = TextBoxCodeInput.Text


        Dim outputStr = PSER.Parse(InputCode)

        loadTree(outputStr)

        TextBoxREPL_OUTPUT.Text = FormatJsonOutput(outputStr.ToJson)
        If PSER.ParserErrors IsNot Nothing Then
            If PSER.ParserErrors.Count > 0 Then
                For Each item In PSER.ParserErrors

                    TextboxErrors.Text &= item & vbNewLine
                Next
                If outputStr.Body IsNot Nothing Then
                    For Each item In outputStr.Body
                        TextboxErrors.ForeColor = Color.Red

                        TextboxErrors.Text &= vbNewLine & item.ToJson & vbNewLine
                    Next
                Else
                End If
            Else
                TextboxErrors.ForeColor = Color.Green
                TextboxErrors.Text = "all Passed sucessfully"
            End If
        End If
        'Dim lxr As New Lexer(InputCode)
        'Dim toks As List(Of Token) = lxr.TokenizeScript
        'For Each item In toks
        '    TextBoxREPL_OUTPUT.Text = item.ToJson
        'Next
    End Sub

    Public Sub loadTree(ByRef Prog As AstProgram)
        AstTreeView.Nodes.Clear()
        Dim root As New TreeNode
        If PSER.ParserErrors.Count > 0 Then
            root.ForeColor = Color.Red
        Else
            root.ForeColor = Color.GreenYellow
        End If

        root.Text = Prog._TypeStr & vbNewLine
        root.Tag = FormatJsonOutput(Prog.ToJson)
        Dim Body As New TreeNode
        Body.Text = "Body"
        Body.Tag = FormatJsonOutput(Prog.ToJson)
        For Each item In Prog.Body
            Dim MainNode As New TreeNode
            MainNode.Text = FormatJsonOutput(item.ToJson)
            MainNode.Tag = FormatJsonOutput(item.ToJson)
            Dim RawNode As New TreeNode
            If PSER.ParserErrors.Count > 0 Then
                RawNode.ForeColor = Color.Red
            Else
                RawNode.ForeColor = Color.GreenYellow
            End If
            RawNode.Text = "_Raw :" & item._Raw
            RawNode.Tag = "_raw"
            MainNode.Nodes.Add(RawNode)
            Dim _StartNode As New TreeNode
            _StartNode.Text = "_Start :" & item._Start
            _StartNode.Tag = "_Start"
            MainNode.Nodes.Add(_StartNode)
            Dim _EndNode As New TreeNode
            _EndNode.Text = "_End :" & item._End
            _EndNode.Tag = "_End"
            MainNode.Nodes.Add(_EndNode)
            Dim _TypeNode As New TreeNode
            If PSER.ParserErrors.Count > 0 Then
                _TypeNode.ForeColor = Color.Red
            Else
                _TypeNode.ForeColor = Color.GreenYellow
            End If
            _TypeNode.Text = "_Type :" & item._TypeStr
            _TypeNode.Tag = "_Type"
            MainNode.Nodes.Add(_TypeNode)





            Body.Nodes.Add(MainNode)
        Next
        root.Nodes.Add(Body)
        AstTreeView.Nodes.Add(root)
    End Sub
End Class