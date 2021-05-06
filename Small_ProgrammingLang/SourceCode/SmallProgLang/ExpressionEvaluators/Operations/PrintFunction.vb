Imports SDK.SAL
Namespace SmallProgLang
    Namespace ExpressionEvaluators
        Namespace Operations
            <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
            Public Class PrintFunction
                Inherits Expression
                Public ToPrint As UnaryExpression
                Public ParentEnv As ZX81_RAM
                Public Sub New(ByRef ToPrint As UnaryExpression, ByRef ParentEnv As ZX81_RAM)
                    MyBase.New("PRINT_FUNCTION")
                    Me.ToPrint = ToPrint
                    Expr = "PRINT" & ToPrint.GetValue
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                End Sub
                Public Sub New(ByRef ToPrint As ConstantExpression, ByRef ParentEnv As ZX81_RAM)
                    MyBase.New("PrintFunction")
                    Me.ToPrint.VarType = ToPrint.VarType
                    Me.ToPrint.Expr = ToPrint.Expr
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                    Expr = "PRINT" & ToPrint.GetValue
                End Sub
                Public Sub New(ByRef ToPrint As BinaryExpression)
                    MyBase.New("PrintFunction")
                    Me.ToPrint.Expr = ToPrint.Expr
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                    Expr = "PRINT" & ToPrint.GetValue
                End Sub
                Public Sub New(ByRef ToPrint As ConditionalOperation, ByRef ParentEnv As ZX81_RAM)
                    MyBase.New("PrintFunction")
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                    Me.ToPrint.Expr = ToPrint.Expr

                    Expr = "PRINT" & ToPrint.GetValue
                End Sub
                Public Sub New(ByRef ToPrint As MultiplicativeOperation, ByRef ParentEnv As ZX81_RAM)
                    MyBase.New("PrintFunction")

                    Me.ToPrint.Expr = ToPrint.Expr
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                    Expr = "PRINT" & ToPrint.GetValue
                End Sub
                Public Sub New(ByRef ToPrint As AddativeOperation, ByRef ParentEnv As ZX81_RAM)
                    MyBase.New("PrintFunction")

                    Me.ToPrint.Expr = ToPrint.Expr
                    Me.ParentEnv = ParentEnv
                    Me.ToPrint.iValue = ToPrint.Evaluate(ParentEnv)
                    Expr = "PRINT" & ToPrint.GetValue
                End Sub
                Public Overrides Function Evaluate(ByRef ParentEnV As ZX81_RAM) As String
                    Return ToPrint.GetValue
                End Function

                Private Function GetDebuggerDisplay() As String
                    Return ToString()
                End Function
            End Class
        End Namespace
    End Namespace
End Namespace

