Imports SDK

Public Class FormREPL


    Private Sub ToolStripButtonCompile_Click(sender As Object, e As EventArgs) Handles ToolStripButtonCompileCode.Click
        Dim InputCode As String = TextBoxCodeInput.Text

        Dim PSER As New Parser
        Dim outputStr = PSER.Parse(InputCode)



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
                TextBoxErrors.ForeColor = Color.Green
                TextBoxErrors.Text = "all Passed sucessfully"
            End If
        End If
        'Dim lxr As New Lexer(InputCode)
        'Dim toks As List(Of Token) = lxr.TokenizeScript
        'For Each item In toks
        '    TextBoxREPL_OUTPUT.Text = item.ToJson
        'Next
    End Sub
End Class