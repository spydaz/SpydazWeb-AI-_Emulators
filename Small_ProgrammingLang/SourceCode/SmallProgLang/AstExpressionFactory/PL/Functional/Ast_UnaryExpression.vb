Imports SDK.SAL
Imports SDK.SmallProgLang.Evaluator

Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_UnaryExpression
            Inherits AstExpression
            Public _Value As Ast_Literal
            Public _name As Ast_Identifier
            ' Public _Value As AstExpression
            Public Sub New(ByRef nName As Ast_Identifier, ByRef nValue As Ast_Literal)
                MyBase.New(AST_NODE._ExpressionStatement)
                Me._Value = nValue
            End Sub

            Public Overrides Function Evaluate(ByRef ParentEnv As EnvironmentalMemory) As Object
                Throw New NotImplementedException()
            End Function
            Public Function GetVar(ByRef ParentEnv As EnvironmentalMemory) As EnvironmentalMemory.Variable
                LocalEnvironmentMemory = ParentEnv
                Dim nvar As New EnvironmentalMemory.Variable
                nvar.Value = _Value
                nvar.Name = _name.GetValue
                nvar.Type = Me._Type
                Return nvar
            End Function
            Public Overrides Function GetValue(ByRef ParentEnv As EnvironmentalMemory) As Object
                Return _Value.GetValue
            End Function

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace