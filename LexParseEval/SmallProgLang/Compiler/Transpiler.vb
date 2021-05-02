Namespace SmallProgLang
    Namespace Compiler
        ''' <summary>
        ''' Transpiles to S-Expression Code
        ''' Transpiles to VB Code
        ''' Transpiles to SAL Code
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Transpiler
            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class

    End Namespace
End Namespace
