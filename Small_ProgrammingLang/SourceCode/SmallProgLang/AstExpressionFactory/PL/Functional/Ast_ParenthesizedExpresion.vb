Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' syntax:
        ''' -_ParenthesizedExpresion
        ''' 
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_ParenthesizedExpresion
            Inherits AstExpression
            Public Body As List(Of AstExpression)
            Public Sub New(ByRef iBody As List(Of AstExpression))
                MyBase.New(AST_NODE._ParenthesizedExpresion)
                Me._TypeStr = "_ParenthesizedExpresion"
                Body = iBody
                Me._Start = iBody(0)._Start
                For Each item In iBody
                    Me._Raw &= item._Raw
                Next
                Me._End = iBody(iBody.Count - 1)._End
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace