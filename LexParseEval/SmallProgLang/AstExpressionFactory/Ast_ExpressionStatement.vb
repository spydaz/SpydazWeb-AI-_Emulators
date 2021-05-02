Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Syntax:
        ''' 
        ''' Expression Statement Types
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_ExpressionStatement
            Inherits AstExpression
            ''' <summary>
            ''' Literal Value
            ''' </summary>
            Public _Expression As Ast_Literal
            ''' <summary>
            ''' 
            ''' </summary>
            ''' <param name="nValue">Literal Value to be stored </param>
            Public Sub New(ByRef nValue As Ast_Literal)
                MyBase.New(AST_NODE._ExpressionStatement)
                Me._Expression = nValue
                Me._TypeStr = "_ExpressionStatement"
                Me._Start = _Expression._Start
                Me._End = _Expression._End
                Me._Raw = nValue._Raw
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst As List(Of String) = MyBase.ToArraylist()
                lst.AddRange(_Expression.iLiteral.toarraylist)
                Return lst
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace