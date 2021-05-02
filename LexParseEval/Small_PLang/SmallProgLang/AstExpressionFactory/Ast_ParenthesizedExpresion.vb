Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Used for Operational Expression
        ''' </summary>
        Public Class Ast_ParenthesizedExpresion
            Inherits AstExpression
            Public Body As List(Of AstExpression)
            Public Sub New(ByRef iBody As List(Of AstExpression))
                MyBase.New(AST_NODE._OperationalExpression)
                Me._TypeStr = "_OperationalExpression"
                Body = iBody
                Me._Start = iBody(0)._Start
                For Each item In iBody
                    Me._Raw &= item._Raw
                Next
                Me._End = iBody(iBody.Count - 1)._End
            End Sub
        End Class
    End Namespace

End Namespace