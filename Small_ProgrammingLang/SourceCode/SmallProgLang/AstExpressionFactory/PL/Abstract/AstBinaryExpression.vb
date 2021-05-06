Imports SDK.SAL
Imports SDK.SmallProgLang.Evaluator

Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Used for Binary Operations
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class AstBinaryExpression
            Inherits AstExpression
            Public _Left As AstExpression
            Public _Right As AstExpression
            Public _Operator As String
            Public LocalEnvironment As New EnvironmentalMemory
            Public Sub New(ByRef nType As AST_NODE, ByRef nLeft As AstExpression, ByRef nOperator As String, ByRef nRight As AstExpression)
                MyBase.New(nType)
                Me._Left = nLeft
                Me._Right = nRight
                Me._Operator = nOperator
                Me._Raw = nLeft._Raw & nOperator & nRight._Raw
                Me._Start = nLeft._Start
                Me._End = nRight._End
                Me._TypeStr = "BinaryExpression"
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                lst.Add(_Operator)
                lst.AddRange(_Left.ToArraylist)
                lst.AddRange(_Right.ToArraylist)
                Return lst
            End Function


            Public Overrides Function GetValue(ByRef ParentEnv As EnvironmentalMemory) As Object
                Throw New NotImplementedException()
            End Function

            Public Overrides Function Evaluate(ByRef ParentEnv As EnvironmentalMemory) As Object
                Me.LocalEnvironment = ParentEnv
                Return Me.LocalEnvironment
            End Function
            ''' <summary>
            ''' Allows for evaluation of the node : Imeadialty invoked expression
            ''' </summary>
            ''' <param name="Left"></param>
            ''' <param name="iOperator"></param>
            ''' <param name="Right"></param>
            ''' <returns></returns>
            Private Function EvaluateMultiplicative(ByRef Left As Ast_Literal, ByRef iOperator As String, ByRef Right As Ast_Literal) As Integer

                If Left._Type = AST_NODE._integer And Right._Type = AST_NODE._integer Then
                    Select Case iOperator
                        Case "*"
                            Return (Integer.Parse(Left.iLiteral) * Integer.Parse(Right.iLiteral)).ToString
                        Case "/"
                            Return (Integer.Parse(Left.iLiteral) / Integer.Parse(Right.iLiteral)).ToString
                    End Select


                End If
                Return 0
            End Function
            Private Function EvaluateAddative(ByRef Left As Ast_Literal, ByRef iOperator As String, ByRef Right As Ast_Literal) As Integer

                If Left._Type = AST_NODE._integer And Right._Type = AST_NODE._integer Then
                    Select Case iOperator
                        Case "+"
                            Return (Integer.Parse(Left.iLiteral) * Integer.Parse(Right.iLiteral))
                        Case "-"
                            Return (Integer.Parse(Left.iLiteral) / Integer.Parse(Right.iLiteral))
                    End Select


                End If
                Return 0
            End Function
            ''' <summary>
            ''' Evaluate node values ( imeadiatly invoked expression )
            ''' </summary>
            ''' <param name="Left"></param>
            ''' <param name="iOperator"></param>
            ''' <param name="Right"></param>
            ''' <returns></returns>
            Private Function EvaluateBoolean(ByRef Left As Ast_Literal, ByRef iOperator As String, ByRef Right As Ast_Literal) As Boolean

                If Left._Type = AST_NODE._integer And Right._Type = AST_NODE._integer Then
                    Select Case iOperator
                        Case ">="
                            Return (Integer.Parse(Left.iLiteral) >= Integer.Parse(Left.iLiteral))
                        Case "<="
                            Return (Integer.Parse(Left.iLiteral) <= Integer.Parse(Left.iLiteral))
                        Case ">"
                            Return (Integer.Parse(Left.iLiteral) > Integer.Parse(Left.iLiteral))
                        Case "<"
                            Return (Integer.Parse(Left.iLiteral) < Integer.Parse(Left.iLiteral))
                        Case "="
                            Return (Integer.Parse(Left.iLiteral) = Integer.Parse(Left.iLiteral))

                    End Select


                End If
                Return False
            End Function
            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace