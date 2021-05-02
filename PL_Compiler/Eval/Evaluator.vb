Public Class Evaluator
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Expr">Single Literal (String Format)/ Array of Literals (String Format)</param>
    ''' <param name="Env">Defaulted to the Global Environment; 
    ''' If an environment is created then it will have the global as its parent environment; 
    ''' This will not be required to be instantiated if only the global Envrionment is in use;
    ''' Environments should be disposed of Correctly; </param>
    ''' <returns></returns>
    Public Function Eval(ByRef Expr As Object, Optional Env As EnvironmentalMemory = Nothing) As Object
        If Env Is Nothing Then
            Env = GlobalEnvironment
        End If
        IncrLineNumber()
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
        '[Binary Comand]
        'Object is array then its a command (binary comand)
        If IsArray(Expr) = True And Expr.count = 3 Then
            'BINARY COMMAND
            'Basic Arithmatic + 4 6
            Select Case Expr(0)
'Maths Expressions
                ' + 3 5
                ' + $VAR$ $VAR$
                ' + $VAR$ 3

                Case "+"
                    Return Eval(Expr(1)) + Eval(Expr(2))
                Case "-"
                    Return Eval(Expr(1)) - Eval(Expr(2))
                Case "*"
                    Return Eval(Expr(1)) * Eval(Expr(2))
                Case "/"
                    Return Eval(Expr(1)) / Eval(Expr(2))
'Variables
                    'DIM $VAR$ as "STRING"
                Case "DIM"
                    Env.Define(Expr(1), Expr(3))
                    Return True
                    '$VAR$ = 20 - 
                    '$VAR$ = "STRING" - 
                    '$VAR$ = "TRUE" or "FALSE"
                    'Syntax : = $VAR$ 20
                Case "="
                    Env.AssignValue(Expr(1), Eval(Expr(2)))
                    Return True
            End Select
        End If
        'while command
        If IsArray(Expr) = True And Expr.count = 7 Then
            Select Case Expr(0)
                Case "WHILE"
                    ' #while Op var1 var2 EQVAR Codeblock #loop
                    Env.Define("WHILE", "BOOLEAN")
                    'Get Result expression (conditional) or (maths)
                    Dim Result() As String = ({Eval(Expr(1)), Eval(Expr(2)), Eval(Expr(3))})
                    'WhileCmd
                    Do While (Eval(Result) = Eval(Expr(4)))
                        Dim WhileEnv As New EnvironmentalMemory(Env)
                        'RETURN ENVIRONEMT? (TEST) PERHAPS NOTHING NEEDED TO BE RETURNED
                        Env = EvalBlock(Expr(5), WhileEnv)
                    Loop
                    ' #expr(6) = "Loop" (Signify End of Loop)
                    Return True
            End Select
        End If
        If Expr = "LOOP" Then
            Return True   'Do Nothing
        End If
        Return "Not Implemented Bad Expression Syntax =" & Expr & vbNewLine & "LineNumber =" & LineNumber
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
End Class
