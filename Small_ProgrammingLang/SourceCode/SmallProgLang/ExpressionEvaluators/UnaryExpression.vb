Imports SDK.SAL

Namespace ExpressionEvaluators
    <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
    Public MustInherit Class UnaryExpression
        Inherits ConstantExpression
        Public Identifier As String
        Public ParentEnv As ZX81_RAM
        Public Sub New(ByRef NodeType As String, ByRef iName As String, ByRef Value As String, ByRef Type As String, ByRef Env As ZX81_RAM)
            MyBase.New(NodeType, Value, Type)
            Me.iValue = Value
            Me.Identifier = iName
            Me.VarType = Type
            Me.ParentEnv = Env


        End Sub

        Public Overrides Function Evaluate(ByRef ParentEnvironment As ZX81_RAM) As String
            If ParentEnvironment.CheckVar(GetName) = True Then
                Me.iValue = ParentEnvironment.GetVar(Me.GetName)
                Return GetValue()
            End If
            Return MyBase.Evaluate(ParentEnvironment)
        End Function

        Public Overrides Function GetValue() As String
            Return MyBase.GetValue()
        End Function
        Public Function GetName() As String
            Return Identifier
        End Function

        Private Function GetDebuggerDisplay() As String
            Return ToString()
        End Function
    End Class
End Namespace
