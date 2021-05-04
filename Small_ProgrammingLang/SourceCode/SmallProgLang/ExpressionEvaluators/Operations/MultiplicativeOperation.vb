Imports SDK.SAL

Namespace ExpressionEvaluators
    Namespace Operations
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class MultiplicativeOperation
            Inherits BinaryExpression
            Private env As ZX81_RAM
            Public Sub New(ByRef Left As ConstantExpression, iOperator As String, Right As ConstantExpression, ByRef ParentEnv As ZX81_RAM)
                MyBase.New("_OPERATION", "MULTIPLICAIVE_OPERATION", "", "INT", ParentEnv)
                Expr = (Left.GetExpr & iOperator & Right.GetExpr)
            End Sub

            Public Overrides Function GetValue() As String
                Evaluate(env)
                Return iValue
            End Function
            Public Overrides Function Evaluate(ByRef ParentEnv As ZX81_RAM) As String
                iValue = EvaluateMultiplicative(Left, iOperator, Right)
                Return GetValue()
            End Function
            ''' <summary>
            ''' Allows for evaluation of the node : Imeadialty invoked expression
            ''' </summary>
            ''' <param name="Left"></param>
            ''' <param name="iOperator"></param>
            ''' <param name="Right"></param>
            ''' <returns></returns>
            Private Function EvaluateMultiplicative(ByRef Left As ConstantExpression, ByRef iOperator As String, ByRef Right As ConstantExpression) As String

                If Left.VarType = "INT" And Right.VarType = "INT" Then
                    Select Case iOperator
                        Case "*"
                            Return (Integer.Parse(Left.GetValue) * Integer.Parse(Right.GetValue)).ToString
                        Case "/"
                            Return (Integer.Parse(Left.GetValue) / Integer.Parse(Right.GetValue)).ToString
                    End Select


                End If
                Return 0
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace
