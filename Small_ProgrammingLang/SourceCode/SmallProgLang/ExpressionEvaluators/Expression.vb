Imports SDK.SAL

Namespace ExpressionEvaluators
    ''' <summary>
    ''' To be Used as a Node in a Syntax Tree
    ''' </summary>
    <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
    Public MustInherit Class Expression
        Public Expr As String
        Public MustOverride Function Evaluate(ByRef ParentEnvironment As ZX81_RAM) As String
        Public Function GetExpr() As String
            Return Expr
        End Function
        ''' <summary>
        ''' Type = "Parameter" / "Variable Assignment"
        ''' </summary>
        Public NodeType As String
        Public Sub New(ByRef NodeType As String)
            Me.NodeType = NodeType
        End Sub

        Private Function GetDebuggerDisplay() As String
            Return ToString()
        End Function
    End Class
End Namespace
