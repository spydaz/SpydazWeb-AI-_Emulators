Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Used for CodeBlocks
        ''' </summary>
        Public Class Ast_BlockExpression
            Inherits AstExpression
            Public Body As List(Of Ast_ExpressionStatement)
            Public Sub New(ByRef iBody As List(Of Ast_ExpressionStatement))
                MyBase.New(AST_NODE._blockCode)
                Me._TypeStr = "_blockCode"
                Body = iBody
                Me._Start = iBody(0)._Start
                For Each item In iBody
                    Me._Raw &= item._Raw
                Next
                Me._End = iBody(iBody.Count - 1)._End
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                For Each item In Body
                    lst.AddRange(item.ToArraylist)
                Next
                Return lst
            End Function
        End Class
    End Namespace

End Namespace