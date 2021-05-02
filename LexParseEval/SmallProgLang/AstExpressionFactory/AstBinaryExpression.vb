Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Used for Binary Operations
        ''' </summary>
        Public Class AstBinaryExpression
            Inherits AstExpression
            Public _Left As AstExpression
            Public _Right As AstExpression
            Public _Operator As String
            Public Sub New(ByRef nType As AST_NODE, ByRef nLeft As AstExpression, ByRef nOperator As String, ByRef nRight As AstExpression)
                MyBase.New(nType)
                Me._Left = nLeft
                Me._Right = nRight
                Me._Operator = nOperator
                Me._Raw = nLeft._Raw & nOperator & nRight._Raw
                Me._Start = nLeft._Start
                Me._End = nRight._End
                Me._TypeStr = "BinaryExpression"
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                lst.Add(_Operator)
                lst.AddRange(_Left.ToArraylist)
                lst.AddRange(_Right.ToArraylist)
                Return lst
            End Function

        End Class
    End Namespace

End Namespace