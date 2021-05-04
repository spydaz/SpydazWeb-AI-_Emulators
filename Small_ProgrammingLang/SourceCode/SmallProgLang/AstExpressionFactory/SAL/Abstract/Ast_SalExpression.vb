Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        Public Class Ast_SalExpression
            Inherits AstExpression
            Public Program As List(Of Ast_Literal)
            Public Sub New(ByRef nProgram As List(Of Ast_Literal))
                MyBase.New(AST_NODE._SAL_Expression)
                Me._TypeStr = "_SAL_Expression"
                Me.Program = nProgram
            End Sub
        End Class
    End Namespace
End Namespace
