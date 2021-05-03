Imports SDK.SAL

Namespace ExpressionEvaluators
    ''' <summary>
    ''' Used For values ie:Integers
    ''' </summary>
    <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
    Public MustInherit Class ConstantExpression
        Inherits Expression
        ''' <summary>
        ''' Used as a literal for the final data item
        ''' Value Held ie: 5 or CAT
        ''' </summary>
        Public iValue As String
        ''' <summary>
        ''' ie: Integer / String
        ''' </summary>
        Public VarType As String

        Public Overridable Function GetValue() As String
            Return iValue

        End Function

        Public Overrides Function Evaluate(ByRef ParentEnvironment As ZX81_RAM) As String
            Return GetValue()
        End Function

        Public Sub New(ByRef NodeType As String, ByRef Value As String, ByRef Type As String)
            MyBase.New(NodeType)
            iValue = Value
            VarType = Type
            Expr = iValue
        End Sub
        Public Sub New(ByRef NodeType As String)
            MyBase.New(NodeType)
        End Sub

        Private Function GetDebuggerDisplay() As String
            Return ToString()
        End Function
    End Class
End Namespace
