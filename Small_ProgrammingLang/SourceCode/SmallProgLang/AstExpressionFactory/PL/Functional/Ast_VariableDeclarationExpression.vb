Imports SDK.SmallProgLang.Evaluator

Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_VariableDeclarationExpression
            Inherits Ast_VariableExpressionStatement
            Public _LiteralType As AST_NODE = AST_NODE._null
            Public Sub New(ByRef nValue As Ast_Identifier, ByRef iLiteralType As AST_NODE)
                MyBase.New(nValue)
                Me._LiteralType = iLiteralType
                Me._Type = AST_NODE._DeclareVariable
                Me._TypeStr = "_VariableDeclaration"
            End Sub
            Public Overrides Function Evaluate(ByRef ParentEnv As EnvironmentalMemory) As Object
                If ParentEnv.CheckVar(Me._iLiteral._Name) = False Then
                    Select Case _LiteralType
                        Case AST_NODE._null
                            ParentEnv.AssignValue(_iLiteral._Name, Nothing)
                        Case AST_NODE._integer
                            ParentEnv.AssignValue(_iLiteral._Name, 0)
                        Case AST_NODE._string
                            ParentEnv.AssignValue(_iLiteral._Name, "")
                        Case AST_NODE._array
                            ParentEnv.AssignValue(_iLiteral._Name, New List(Of Object))
                    End Select


                End If
                Return _iLiteral.GetValue(ParentEnv)
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace