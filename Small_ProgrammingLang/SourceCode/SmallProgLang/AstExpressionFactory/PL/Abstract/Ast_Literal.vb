Namespace SmallProgLang

    Namespace Ast_ExpressionFactory

        ''' <summary>
        ''' 
        ''' Syntax: 
        ''' 
        ''' Used to hold Literals and values
        ''' 
        ''' 
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class Ast_Literal
            Inherits AstNode
            ''' <summary>
            ''' Holds value (in its type)
            ''' </summary>
            Public iLiteral As Object
            Public Sub New(ByRef ntype As AST_NODE)
                MyBase.New(ntype)
            End Sub
            Public Sub New(ByRef ntype As AST_NODE, ByRef nValue As Object)
                MyBase.New(ntype)
                iLiteral = nValue
            End Sub
            Public Overrides Function ToArraylist() As List(Of String)
                Dim lst = MyBase.ToArraylist()
                lst.Add(iLiteral.ToString)
                Return lst
            End Function
            Public Function GetValue() As Object

                Select Case Me._Type
                    Case AST_NODE._integer
                        Return Integer.Parse(iLiteral)
                    Case AST_NODE._string
                        Return iLiteral.ToString
                    Case AST_NODE._array
                        Return iLiteral
                    Case AST_NODE._boolean
                        Return Boolean.Parse(iLiteral)
                    Case Else
                        Return iLiteral
                End Select
            End Function
            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function
        End Class
    End Namespace

End Namespace