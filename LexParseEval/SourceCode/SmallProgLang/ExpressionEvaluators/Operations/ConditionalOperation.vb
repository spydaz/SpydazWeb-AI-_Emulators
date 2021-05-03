Imports SDK.SAL

Namespace ExpressionEvaluators
    Namespace Operations
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class ConditionalOperation
            Inherits BinaryExpression
            Private Env As ZX81_RAM
            Public Sub New(ByRef Left As ConstantExpression, iOperator As String, Right As ConstantExpression, ByRef ParentEnv As ZX81_RAM)
                MyBase.New("_OPERATION", "_CONDITIONAL_OPERATION", "", "BOOLEAN", ParentEnv)
                Expr = Left.GetExpr & iOperator & Right.GetExpr
                Env = ParentEnv
            End Sub
            Public Overrides Function GetValue() As String
                Evaluate(Env)
                Return iValue
            End Function
            Public Overrides Function Evaluate(ByRef ParentEnv As ZX81_RAM) As String
                iValue = EvaluateBoolean(Left, iOperator, Right)
                Return GetValue()
            End Function
            ''' <summary>
            ''' Evaluate node values ( imeadiatly invoked expression )
            ''' </summary>
            ''' <param name="Left"></param>
            ''' <param name="iOperator"></param>
            ''' <param name="Right"></param>
            ''' <returns></returns>
            Private Function EvaluateBoolean(ByRef Left As ConstantExpression, ByRef iOperator As String, ByRef Right As ConstantExpression) As String

                If Left.VarType = "INT" And Right.VarType = "INT" Then
                    Select Case iOperator
                        Case ">="
                            Return (Integer.Parse(Left.GetValue) >= Integer.Parse(Left.GetValue)).ToString
                        Case "<="
                            Return (Integer.Parse(Left.GetValue) <= Integer.Parse(Left.GetValue)).ToString
                        Case ">"
                            Return (Integer.Parse(Left.GetValue) > Integer.Parse(Left.GetValue)).ToString
                        Case "<"
                            Return (Integer.Parse(Left.GetValue) < Integer.Parse(Left.GetValue)).ToString
                        Case "="
                            Return (Integer.Parse(Left.GetValue) = Integer.Parse(Left.GetValue)).ToString

                    End Select


                End If
                Return False.ToString
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace
