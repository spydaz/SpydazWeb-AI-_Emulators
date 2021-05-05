Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_UnaryExpression
            Inherits AstExpression
            Public _Value As Ast_Literal
            Public _name As Ast_Identifier
            ' Public _Value As AstExpression
            Public Sub New(ByRef nName As Ast_Identifier, ByRef nValue As Ast_Literal)
                MyBase.New(AST_NODE._ExpressionStatement)
                Me._Value = nValue
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace