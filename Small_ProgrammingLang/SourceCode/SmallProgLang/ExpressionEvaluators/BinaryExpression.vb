Imports SDK.SAL
Namespace SmallProgLang
    Namespace ExpressionEvaluators
        ''' <summary>
        ''' The Binary Expression is a function,
        ''' the execution of the node structure is performed by the get data functions
        ''' This class must be inherited and its Get Data function Implemented With its custom
        ''' Used for Functions A+1 = iOperator = "+" Nodetype = "ADD"  
        ''' (LeftNode = ParameterExpression(Parameter/5/a/int)) 
        ''' (RightNode = ConstantExpression (number/1/int/))
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public MustInherit Class BinaryExpression
            Inherits UnaryExpression
            ''' <summary>
            ''' Operator such as "+" or "DIM" 
            ''' </summary>
            Public iOperator As String
            ''' <summary>
            ''' (LeftNode = ParameterExpression(Parameter/5/a/int))  
            ''' </summary>
            Public Left As Expression
            ''' <summary>
            ''' (RightNode = ConstantExpression (number/1/int/))
            ''' </summary>
            Public Right As Expression


            Protected Sub New(ByRef NodeType As String, ByRef iName As String, ByRef Value As String, ByRef Type As String, ByRef Env As ZX81_RAM)
                MyBase.New(NodeType, iName, Value, Type, Env)

            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace
