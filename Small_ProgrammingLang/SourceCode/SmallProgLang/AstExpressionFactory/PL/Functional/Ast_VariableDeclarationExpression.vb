Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_VariableDeclarationExpression
            Inherits Ast_VariableExpressionStatement
            Public _LiteralType As String = "NULL"
            Public Sub New(ByRef nValue As Ast_Identifier, ByRef iLiteralType As String)
                MyBase.New(nValue)
                Me._LiteralType = iLiteralType
                Me._Type = AST_NODE._DeclareVariable
                Me._TypeStr = "_VariableDeclaration"
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace