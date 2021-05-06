Namespace SmallProgLang
    Namespace ExpressionEvaluators
        ''' <summary>
        ''' A body is a list of statements
        ''' Which is a list of Binary Expressions. 
        ''' Essentially Each Binary Expression is a single Segment of Code
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public MustInherit Class Body
            Inherits Expression
            Public Statements As New List(Of Expression)

            Public Sub New(ByRef Nodetype As String, ByRef Statment As Expression)
                MyBase.New(Nodetype)
                Statements.Add(Statment)
            End Sub
            Public Sub New(ByRef Nodetype As String, ByRef Program As List(Of Expression))
                MyBase.New(Nodetype)
                Statements = Program
                Dim i As String = ""
                For Each item In Statements
                    i &= item.GetExpr & vbNewLine
                Next
                Expr = i
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace

