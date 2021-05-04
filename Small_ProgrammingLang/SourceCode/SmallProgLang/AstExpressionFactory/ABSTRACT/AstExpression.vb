Imports System.Text
Imports System.Text.Json
Imports System.Web.Script.Serialization
Namespace SmallProgLang

    Namespace Ast_ExpressionFactory

        ''' <summary>
        ''' Expression Model Used To Group Expressions
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class AstExpression
            Inherits AstNode
            Public Sub New(ByRef ntype As AST_NODE)
                MyBase.New(ntype)
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace