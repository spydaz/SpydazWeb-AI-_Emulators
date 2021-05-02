Namespace SmallProgLang

    Namespace Ast_ExpressionFactory
        ''' <summary>
        ''' Used To Remove Erronious Tokens Such as 
        ''' 
        ''' _WhiteSpace
        ''' _EmptyStatment
        ''' 
        ''' Unwanted tokens Are useful to be collected in the parser Stage 
        ''' to give the user a richer experience as well as help with debuggin. 
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class AST_Cleaner
            Private _Program As AstProgram
            ''' <summary>
            ''' Removed Nodes are Preserved
            ''' </summary>
            Public RemovedNodes As List(Of AstNode)
            Private iCleanedProgram As AstProgram
            ''' <summary>
            ''' Cleaned !
            ''' </summary>
            ''' <returns></returns>
            Public ReadOnly Property CleanedProgram As AstProgram
                Get
                    Return iCleanedProgram
                End Get
            End Property
            ''' <summary>
            ''' Cleans unwanted tokens from Program
            ''' The final Output program should be a clean ordered set of Expressions
            ''' Each Expression Should have an Arraylist function,
            ''' A final output of  List/OfLists (Tree) can be returned
            ''' Or the Cleaned Program
            ''' </summary>
            ''' <param name="Program"></param>
            Public Sub New(ByRef Program As AstProgram)
                _Program = Program
                iCleanedProgram = _CleanAST(Program)
            End Sub

            ''' <summary>
            ''' 
            '''-RemoveWhiteSpace Tokens
            '''-RemoveEmptyStatments Tokens
            '''
            ''' </summary>
            ''' <param name="Program"></param>
            ''' <returns></returns>
            Public Function _CleanAST(ByRef Program As AstProgram) As AstProgram
                Dim nProgram As AstProgram = Program
                'RemoveWhiteSpace Tokens
                nProgram = _RemoveWhiteSpace(nProgram)
                'RemoveEmptyStatments Tokens
                nProgram = RemoveEmptyStatments(nProgram)
                Return Nothing
            End Function

            Public Function _RemoveWhiteSpace(ByRef Program As AstProgram)

                Return Nothing
            End Function
            Public Function RemoveEmptyStatments(ByRef Program As AstProgram)

                Return Nothing
            End Function
            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace
End Namespace

