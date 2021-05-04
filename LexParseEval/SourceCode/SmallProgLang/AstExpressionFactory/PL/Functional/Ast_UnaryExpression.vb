﻿Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_UnaryExpression
            Inherits Ast_Identifier
            Public _Value As AstBinaryExpression
            Public Sub New(ByRef nName As String, ByRef nValue As AstBinaryExpression)
                MyBase.New(nName)
                Me._Value = nValue
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace