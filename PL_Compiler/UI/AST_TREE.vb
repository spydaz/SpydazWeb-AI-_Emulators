Imports System.Text

Public Class AST_TREE
    Private Parser As New TokenizerClass
    Private Sub ButtonParse_Click(sender As Object, e As EventArgs) Handles ButtonParseAST.Click
        Dim Code As String = ProgText()
        Dim output As String = ParseAST(Code)

        InputText.Text &= "(Program Code)" & vbNewLine & Code & vbNewLine & vbNewLine & "(Abstract Syntax Tree)" & vbNewLine & vbNewLine & output
    End Sub

    Public Sub ClearText()
        InputText.Clear()
    End Sub

    Public Function ProgText() As String
        Dim ProgStr As String = InputText.Text
        ClearText()
        Return ProgStr
    End Function

    Private Sub ButtonParseTokens_Click(sender As Object, e As EventArgs) Handles ButtonParseTokens.Click
        Dim Code As String = ProgText()
        Dim output As String = ParseTokens(Code)


        InputText.Text &= "(Program Code)" & vbNewLine & Code & vbNewLine & vbNewLine & "(Token Tree)" & vbNewLine & output
    End Sub

    Public Function ParseTokens(ByRef Code As String) As String 
        Dim output As String = ""
        'Display Output
        For Each item In Parser.Get_Token_TREE(Code)
            output &= "Statement" & vbNewLine
            'InputText.Text &= item.ToJson & vbNewLine
            For Each item2 In item
                output &= item2.ToJson & vbNewLine
            Next
        Next
        Return output
    End Function
    Public Function ParseAST(ByRef Code As String) As String
        Dim output As String = ""
        'Display Output
        For Each item In Parser.Get_Abstract_Syntax_Token_TREE(Code)
            output &= "Statement" & vbNewLine
            output &= FormatJsonOutput(item.ToJson) & vbNewLine
        Next
        Return output
    End Function

    Public Function FormatJsonOutput(ByVal jsonString As String) As String
        Dim stringBuilder = New StringBuilder()
        Dim escaping As Boolean = False
        Dim inQuotes As Boolean = False
        Dim indentation As Integer = 0

        For Each character As Char In jsonString

            If escaping Then
                escaping = False
                stringBuilder.Append(character)
            Else

                If character = "\"c Then
                    escaping = True
                    stringBuilder.Append(character)
                ElseIf character = """"c Then
                    inQuotes = Not inQuotes
                    stringBuilder.Append(character)
                ElseIf Not inQuotes Then

                    If character = ","c Then
                        stringBuilder.Append(character)
                        stringBuilder.Append(vbCrLf)
                        stringBuilder.Append(vbTab, indentation)
                    ElseIf character = "["c OrElse character = "{"c Then
                        stringBuilder.Append(character)
                        stringBuilder.Append(vbCrLf)
                        stringBuilder.Append(vbTab, System.Threading.Interlocked.Increment(indentation))
                    ElseIf character = "]"c OrElse character = "}"c Then
                        stringBuilder.Append(vbCrLf)
                        stringBuilder.Append(vbTab, System.Threading.Interlocked.Decrement(indentation))
                        stringBuilder.Append(character)
                    ElseIf character = ":"c Then
                        stringBuilder.Append(character)
                        stringBuilder.Append(vbTab)
                    ElseIf Not Char.IsWhiteSpace(character) Then
                        stringBuilder.Append(character)
                    End If
                Else
                    stringBuilder.Append(character)
                End If
            End If
        Next

        Return stringBuilder.ToString()
    End Function

    Private Sub ButtonbOTH_Click(sender As Object, e As EventArgs) Handles ButtonbOTH.Click
        Dim Code As String = ProgText()
        Dim tokenTree As String = ParseTokens(Code)
        Dim astTree As String = ParseAST(Code)


        InputText.Text &= "(Program Code)" & vbNewLine & "{ " & Code & " }" & vbNewLine & vbNewLine & "(Token Tree)" & vbNewLine & tokenTree
        InputText.Text &= vbNewLine & "(Abstract Syntax Tree)" & vbNewLine & astTree

    End Sub


End Class
