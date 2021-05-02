Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        Public Class Ast_VariableExpressionStatement
            Inherits AstExpression
            ''' <summary>
            ''' Literal Value
            ''' </summary>
            Public _Expression As Ast_Identifier
            ''' <summary>
            ''' 
            ''' </summary>
            ''' <param name="nValue">Literal Value to be stored </param>
            Public Sub New(ByRef nValue As Ast_Identifier)
                MyBase.New(AST_NODE._ExpressionStatement)
                Me._Expression = nValue
                Me._TypeStr = "_ExpressionStatement"
                Me._Start = _Expression._Start
                Me._End = _Expression._End
                Me._Raw = nValue._Raw
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                lst.AddRange(_Expression.ToArraylist)
                Return lst
            End Function
        End Class
    End Namespace

End Namespace