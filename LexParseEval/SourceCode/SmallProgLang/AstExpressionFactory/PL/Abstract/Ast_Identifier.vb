Namespace SmallProgLang

    Namespace Ast_ExpressionFactory

        ''' <summary>
        ''' Syntax:
        ''' 
        ''' Used to hold Varnames or Identifiers
        ''' 
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_Identifier
            Inherits AstNode
            Public _Name As String
            Public Sub New(ByRef nName As String)
                MyBase.New(AST_NODE._variable)
                Me._TypeStr = "Identifier"
                Me._Name = nName
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                lst.Add(_Name)
                Return lst
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace