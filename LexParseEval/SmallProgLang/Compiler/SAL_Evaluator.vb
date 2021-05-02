Namespace SmallProgLang
    Namespace Compiler

        ''' <summary>
        ''' Evaluates SAL Code Evaluator
        ''' Converts S_Expression Code to Sal_Code
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class SAL_Evaluator
            Public Sub New()
            End Sub

            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace


