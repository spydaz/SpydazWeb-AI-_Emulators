Namespace SmallProgLang
    Namespace Compiler

        ''' <summary>
        ''' Evaluates SAL Code Evaluator
        ''' Converts S_Expression Code to Sal_Code
        ''' </summary>
        <DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
        Public Class SAL_Evaluator
            Private GlobalEnvironment As EnvironmentalMemory
            ''' <summary>
            ''' Create a new instance of the PROGRAMMING Interpretor
            ''' </summary>
            ''' <param name="iGlobal">Used to provide preloaded environment</param>
            Public Sub New(ByRef iGlobal As EnvironmentalMemory)
                GlobalEnvironment = iGlobal
                LineNumber = 0
            End Sub
            ''' <summary>
            ''' Line number counter
            ''' </summary>
            Private LineNumber As Integer
            ''' <summary>
            ''' Increases the current line number to track the line number in the program
            ''' </summary>
            Private Sub IncrLineNumber()
                LineNumber += 1
            End Sub
            Private Function GetDebuggerDisplay() As String
                Return ToString()
            End Function



            Public Function Eval(ByRef Expr As Object, Optional Env As EnvironmentalMemory = Nothing) As Object
                'Created for tracking 
                IncrLineNumber()
                If Env Is Nothing Then
                    Env = GlobalEnvironment
                End If
#Region "Literals"
                '[Literals]
                '- 3 0r 5.6 [integer]
                If IsNumberInt(Expr) = True Then
                    Dim num As Integer = Integer.Parse(Expr)
                    Return num
                End If
                '- "CAT"[String]
                If IsString(Expr) = True Then
                    Return Expr.ToString
                End If
                ' - $VAR$
                If IsVariableName(Expr) = True Then
                    Return Env.GetVar(Expr(0))
                End If
                ' - "TRUE" "FALSE"
                If IsBoolean(Expr) = True Then
                    If Expr = "TRUE" Then
                        Return True
                    Else
                        Return False
                    End If
                End If
#End Region

                Return "Not Implemented Bad Expression Syntax =" & Expr & vbNewLine & "LineNumber =" & LineNumber
            End Function

            Private Function _Binary_op(ByRef Left As Integer, ByRef Right As Integer, ByRef iOperator As String) As List(Of String)

                Dim PROGRAM As New List(Of String)
                Select Case iOperator
                    Case "-"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("SUB")
                        PROGRAM.Add("PRINT_M")

                    Case "+"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("ADD")
                        PROGRAM.Add("PRINT_M")

                    Case "/"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("DIV")
                        PROGRAM.Add("PRINT_M")

                    Case "*"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("MUL")
                        PROGRAM.Add("PRINT_M")
                    Case ">"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("IS_GT")
                        PROGRAM.Add("PRINT_M")

                    Case "<"
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("IS_LT")
                        PROGRAM.Add("PRINT_M")

                    Case ">="
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("IS_GTE")
                        PROGRAM.Add("PRINT_M")

                    Case "<="
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("IS_LTE")
                        PROGRAM.Add("PRINT_M")

                    Case "="
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Left.ToString)
                        PROGRAM.Add("PUSH")
                        PROGRAM.Add(Right.ToString)
                        PROGRAM.Add("IS_EQ")
                        PROGRAM.Add("PRINT_M")

                End Select
                Return PROGRAM
            End Function
            ''' <summary>
            ''' Evaluates a block of code returning the Global Environment the block environment is disposed of
            ''' </summary>
            ''' <param name="Expr"></param>
            ''' <param name="Env"></param>
            ''' <returns></returns>
            Public Function EvalBlock(ByRef Expr As Object, Optional Env As EnvironmentalMemory = Nothing) As EnvironmentalMemory
                If Env Is Nothing Then
                    Env = GlobalEnvironment
                End If
                For Each item In Expr
                    Eval(Expr, Env)
                Next
                ' CHanges to the global memory enviroment need to be made? 
                Return Env.GlobalMemory
            End Function

#Region "Literals"
            ''' <summary>
            ''' Checks if expr is a number, Returning number
            ''' </summary>
            ''' <param name="Expr"></param>
            ''' <returns></returns>
            Function IsNumberInt(ByRef Expr As Object) As Boolean
                Try
                    If TypeOf Expr Is Integer Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try
            End Function
            ''' <summary>
            ''' Checks if Expr is string returning the string
            ''' </summary>
            ''' <param name="Expr"></param>
            ''' <returns></returns>
            Function IsString(ByRef Expr As Object) As Boolean
                '########## ############# ######
                'Align with front and back char "


                Try
                    If TypeOf Expr Is String Then
                        If Expr.contains(Chr(34)) Then
                            If Expr.contains(Chr(36)) Then
                                Return False
                            Else
                                Return True
                            End If
                        Else
                        End If

                    Else
                        Return False
                    End If

                Catch ex As Exception
                    Return False
                End Try
                Return False
            End Function
            ''' <summary>
            ''' If Epr token is variable ake then it can be handled correctlly
            ''' </summary>
            ''' <param name="Expr"></param>
            ''' <returns></returns>
            Function IsVariableName(ByRef Expr As Object) As Boolean

                '# ########################################## ##
                '#Align with front and back char $

                Try
                    If TypeOf Expr Is String Then
                        If Expr.contains(Chr(36)) Then
                            If Expr.contains(Chr(34)) Then
                                Return False
                            Else
                            End If
                            Return True
                        Else
                            Return False
                        End If

                    End If

                Catch ex As Exception
                    Return False
                End Try
                Return False
            End Function
            Function IsBoolean(ByRef Expr As Object) As Boolean
                IsBoolean = False
                If Expr = "TRUE" Or Expr = "FALSE" Then
                    Return True
                End If
            End Function
            ''' <summary>
            ''' if token is an array then it contains an expression
            ''' </summary>
            ''' <param name="Expr"></param>
            ''' <returns></returns>
            Function IsArray(ByRef Expr As Object) As Boolean
                Try
                    If TypeOf Expr Is Array Then
                        Return True
                    Else
                        Return False
                    End If

                Catch ex As Exception
                    Return False
                End Try
            End Function
#End Region
        End Class
    End Namespace
End Namespace


