Imports System.Linq.Expressions
Imports System.Text.Json
Imports System.Web.Script.Serialization
Imports SDK.SmallProgLang
Imports SDK.SmallProgLang.Ast_ExpressionFactory
Imports SDK.SmallProgLang.GrammarFactory

'Author : Leroy Samuel Dyer ("Spydaz")
'-------------------------------------
'NOTE: 
'Loosly - Based on DIMTRY (Building a Parser from Scratch)
'This is a test of that style of AST creation _  
'MODEL_
'LEX _ PARSE _ EVAL 

Namespace SmallProgLang
    Namespace Compiler




        ''' <summary>
        ''' Programming Language Parser to AST
        ''' </summary>
        Public Class Parser

#Region "Propertys"
            Public ParserErrors As New List(Of String)
            ''' <summary>
            ''' Currently held script
            ''' </summary>
            Public iScript As String = ""
            ''' <summary>
            ''' To hold the look ahead value without consuming the value
            ''' </summary>
            Public Lookahead As String
            ''' <summary>
            ''' Tokenizer !
            ''' </summary>
            Dim Tokenizer As Lexer
#End Region

#Region "PARSER"
            ''' <summary>
            ''' Main Parser Function  
            ''' Parses whole Script into a AST tree ; 
            ''' Which can be used later for evaluation to be run on a vm 
            ''' or to generate code for a different language (interpretor) 
            ''' or (evaluator - Compiler(Executor)
            ''' </summary>
            ''' <param name="nScript">Script to be compiled </param>
            ''' <returns>AST PROGRAM</returns>
            Public Function Parse(ByRef nScript As String) As AstProgram
                Dim Body As New List(Of Ast_ExpressionStatement)
                iScript = nScript.Replace(vbNewLine, " ")
                'iScript = nScript.Replace(" ", "")
                'iScript = nScript.Replace(";", "")
                Tokenizer = New Lexer(iScript)
                'Dim TokType As GrammarFactory.Grammar.Type_Id
                Lookahead = Tokenizer.ViewNext
                'GetProgram
                Dim prog = _ProgramNode()
                Return prog
            End Function
            ''' <summary>
            ''' Main Parser Function  
            ''' Parses whole Script into a AST tree ; 
            ''' Which can be used later for evaluation to be run on a vm 
            ''' or to generate code for a different language (interpretor) 
            ''' or (evaluator - Compiler(Executor)
            ''' </summary>
            ''' <param name="nScript">Script to be compiled </param>
            ''' <param name="Gramer">Uses Custom Grammar to create tokens</param>
            ''' <returns>AST PROGRAM</returns>
            Public Function Parse(ByRef nScript As String, ByRef Gramer As List(Of GrammarFactory.Grammar)) As AstProgram
                Dim Body As New List(Of Ast_ExpressionStatement)
                iScript = nScript.Replace(vbNewLine, " ")
                Tokenizer = New Lexer(iScript, Gramer)
                'Dim TokType As GrammarFactory.Grammar.Type_Id
                Lookahead = Tokenizer.ViewNext
                Dim prog = _ProgramNode()
                Return prog
            End Function
#End Region


#Region "AstNode Handlers/Generators"
#Region "Main Program"
            ''' <summary>
            ''' Main Entry Point. 
            ''' Syntax:
            ''' 
            ''' Program:
            ''' -Literals
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _ProgramNode() As AstProgram
                Dim nde = New AstProgram(_StatementList)
                nde._Raw = iScript
                nde._Start = 0
                nde._End = iScript.Length
                Return nde
            End Function
            ''' <summary>
            ''' 
            ''' Syntax
            ''' -Statement
            ''' -Statementlist Statement -> Statement Statement Statement
            ''' </summary>
            ''' <returns></returns>
            Public Function _StatementList() As List(Of AstExpression)
                Dim lst As New List(Of AstExpression)

                Do While (Tokenizer.ViewNext <> "EOF")
                    Dim nde = _Statement()
                    If nde IsNot Nothing Then
                        lst.Add(nde)
                    End If
                Loop
                Return lst
            End Function
#End Region
#Region "Literals"
            ''' <summary>
            ''' Syntax
            ''' 
            ''' -Literal => (_PrimaryExpression)
            ''' 
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _PrimaryExpression() As AstExpression
                Dim tok = Tokenizer.IdentifiyToken(Lookahead)
                Select Case tok
                    Case GrammarFactory.Grammar.Type_Id._CONDITIONAL_BEGIN
                        Return _ParenthesizedExpression()
                    Case GrammarFactory.Grammar.Type_Id._VARIABLE
                        Return _VariableExpression()
                    Case Else
                        'Literal - Node!
                        Dim Expr As Ast_ExpressionStatement
                        Dim nde = _literalNode()
                        If nde IsNot Nothing Then
                            Expr = New Ast_ExpressionStatement(nde)
                            'Advances to the next cursor
                            Lookahead = Tokenizer.ViewNext
                            Return Expr
                        Else
                            'Technically badtoken try capture
                            Dim etok = __UnknownStatementNode()
                            ParserErrors.Add(ReplErrorSystem.DisplayError("Unknown Statement/Expression Uncountered", etok))
                            Return New Ast_ExpressionStatement(etok)
                        End If
                        Exit Select
                End Select
            End Function
            ''' <summary>
            ''' -Literals
            ''' Syntax:
            '''     
            '''     -Numeric Literal
            '''     -String Literal
            '''     -Comments
            '''     -Nullable
            ''' </summary>
            ''' <returns></returns>
            Public Function _literalNode() As Ast_Literal
                Dim tok = Tokenizer.IdentifiyToken(Lookahead)
                Select Case tok
                    Case GrammarFactory.Grammar.Type_Id._INTEGER
                        Return _NumericLiteralNode()
                    Case GrammarFactory.Grammar.Type_Id._STRING
                        Return _StringLiteralNode()

                    Case GrammarFactory.Grammar.Type_Id._LIST_BEGIN
                        Exit Select
                    Case GrammarFactory.Grammar.Type_Id._NULL
                        Return _NullableNode()
                    Case GrammarFactory.Grammar.Type_Id._COMMENTS
                        Return _CommentsNode()
                    Case GrammarFactory.Grammar.Type_Id._TRUE
                        Return _BooleanNode()
                    Case GrammarFactory.Grammar.Type_Id._FALSE
                        Return _BooleanNode()
                    Case GrammarFactory.Grammar.Type_Id._WHITESPACE
                        Return _WhitespaceNode()
                    Case GrammarFactory.Grammar.Type_Id._STATEMENT_END
                        Return __EmptyStatementNode()

                    Case Else
                        'Technically badtoken try capture
                        Dim etok = __UnknownStatementNode()
                        ParserErrors.Add(ReplErrorSystem.DisplayError("Unknown Literal Uncountered", etok))
                        Return etok
                End Select
                Return Nothing
            End Function
            ''' <summary>
            ''' Syntax:
            ''' 
            ''' Numeric Literal:
            '''  -Number
            ''' </summary>
            ''' <returns></returns>
            Public Function _NumericLiteralNode() As Ast_Literal
                Dim Str As Integer = 0
                ' Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._INTEGER)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                If Integer.TryParse(tok.Value, Str) = True Then
                    Dim nde = New Ast_Literal(AST_NODE._integer, Str)
                    nde._Start = tok._start
                    nde._End = tok._End
                    nde._Raw = tok.Value
                    nde._TypeStr = "_integer"
                    Lookahead = Tokenizer.ViewNext
                    Return nde
                Else
                    'Unable to parse default 0 to preserve node listeral as integer
                    Dim nde = New Ast_Literal(AST_NODE._integer, 0)
                    nde._Start = tok._start
                    nde._End = tok._End
                    nde._Raw = tok.Value
                    nde._TypeStr = "_integer"
                    Lookahead = Tokenizer.ViewNext
                    Return nde
                End If
            End Function
            ''' <summary>
            ''' Syntax:
            ''' 
            ''' Nullable Literal:
            '''  -Null
            ''' </summary>
            ''' <returns></returns>
            Public Function _NullableNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._null, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_null"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used for end of statement
            ''' </summary>
            ''' <returns></returns>
            Public Function __EmptyStatementNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._EMPTY_STATEMENT)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._emptyStatement, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_emptyStatement"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            Public Function __EndStatementNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._EMPTY_STATEMENT)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._endStatement, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_endStatement"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Collects bad token
            ''' </summary>
            ''' <returns></returns>
            Public Function __UnknownStatementNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._EMPTY_STATEMENT)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._UnknownStatement, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_UnknownStatement"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used when data has already been collected
            ''' </summary>
            ''' <param name="ErrorTok"></param>
            ''' <returns></returns>
            Public Function __UnknownStatementNode(ByRef ErrorTok As Token) As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._EMPTY_STATEMENT)
                Dim tok As Token = ErrorTok
                Dim nde = New Ast_Literal(AST_NODE._UnknownStatement, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_UnknownStatement"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used to denote white space as it is often important later
            ''' Some Parsers ignore this token ; 
            ''' It is thought also; to be prudent to collect all tokens to let the Evaluator deal with this later
            ''' </summary>
            ''' <returns></returns>
            Public Function _WhitespaceNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._WhiteSpace, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_whitespace"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used to Eat Node
            ''' </summary>
            ''' <returns></returns>
            Public Function _CodeBeginNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._Code_Begin, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_Code_Begin"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            Public Function _ConditionalBeginNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._OperationBegin, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_OperationBegin"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used to Eat Node 
            ''' </summary>
            ''' <returns></returns>
            Public Function _CodeEndNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._Code_End, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_Code_End"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            Public Function _ConditionalEndNode() As Ast_Literal
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._OperationEnd, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_OperationEnd"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Used to return boolean literals if badly detected it will return false
            ''' </summary>
            ''' <returns></returns>
            Public Function _BooleanNode() As Ast_Literal
                Dim Str As Boolean = False

                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                If Boolean.TryParse(tok.Value, Str) = True Then
                    Dim nde = New Ast_Literal(AST_NODE._boolean, Str)
                    nde._Start = tok._start
                    nde._End = tok._End
                    nde._Raw = tok.Value
                    nde._TypeStr = "_boolean"
                    Lookahead = Tokenizer.ViewNext
                    Return nde
                Else
                    'Default to false
                    Dim nde = New Ast_Literal(AST_NODE._boolean, False)
                    nde._Start = tok._start
                    nde._End = tok._End
                    nde._Raw = tok.Value
                    nde._TypeStr = "_boolean"
                    Lookahead = Tokenizer.ViewNext
                    Return nde
                End If
            End Function
            ''' <summary>
            ''' Syntax:
            ''' 
            ''' Comments Literal:
            '''  -Comments
            ''' </summary>
            ''' <returns></returns>
            Public Function _CommentsNode() As Ast_Literal
                ' Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._COMMENTS)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Literal(AST_NODE._comments, tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_comments"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            ''' <summary>
            ''' Syntax:
            ''' "hjk"
            ''' String Literal:
            '''  -String
            ''' </summary>
            ''' <returns></returns>
            Public Function _StringLiteralNode() As Ast_Literal
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)

                Dim str As String = ""
                If tok.Value.Contains("'") Then
                    str = tok.Value.Replace("'", "")
                Else
                End If
                If tok.Value.Contains(Chr(34)) Then
                    str = tok.Value.Replace(Chr(34), "")
                End If

                Dim nde = New Ast_Literal(AST_NODE._string, str)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_string"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function
            Public Function _IdentifierLiteralNode() As Ast_Identifier
                '   Dim tok As Token = Tokenizer.Eat(GrammarFactory.Grammar.Type_Id._NULL)
                Dim tok As Token = Tokenizer.GetIdentifiedToken(Lookahead)
                Dim nde = New Ast_Identifier(tok.Value)
                nde._Start = tok._start
                nde._End = tok._End
                nde._Raw = tok.Value
                nde._TypeStr = "_variable"
                Lookahead = Tokenizer.ViewNext
                Return nde
            End Function


#End Region
#Region "STATEMENTS"
            ''' <summary>
            ''' 
            ''' Syntax
            ''' -ExpressionStatement
            ''' -BlockStatement
            ''' -IterationStatement
            ''' </summary>
            ''' <returns></returns>
            Public Function _Statement() As AstExpression
                Dim tok = Tokenizer.IdentifiyToken(Lookahead)
                Select Case tok
            'Begin Block
                    Case GrammarFactory.Grammar.Type_Id._CODE_BEGIN
                        Return _BlockStatement()
            'Iteration Statments
                    Case GrammarFactory.Grammar.Type_Id._UNTIL
                        Return _IterationStatment()
                    Case GrammarFactory.Grammar.Type_Id._WHILE
                        Return _IterationStatment()
                    Case GrammarFactory.Grammar.Type_Id._FOR
                        Return _IterationStatment()
                        'Standard Expression
                    Case Else
                        Return _ExpressionStatement()
                End Select
                'Technically badtoken try capture
                Dim etok = __UnknownStatementNode()
                ParserErrors.Add(ReplErrorSystem.DisplayError("Unknown Statement Uncountered", etok))
                Return New Ast_ExpressionStatement(etok)
            End Function
            ''' <summary>
            ''' Gets Expression Statement
            ''' Syntax
            ''' -Expression ";"
            ''' 
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _ExpressionStatement() As AstExpression
                Return _Expression()
            End Function
            ''' <summary>
            ''' 
            ''' Syntax:
            '''  -_PrimaryExpression(literal)
            '''  -_MultiplicativeExpression
            '''  -_AddativeExpression
            ''' 
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _Expression() As AstExpression

                Return _BinaryExpression()


            End Function
            ''' <summary>
            ''' 
            ''' Syntax: 
            ''' Could be Empty list So Prefix Optional
            ''' { OptionalStatmentList } 
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _BlockStatement() As Ast_BlockExpression
                Dim toktype As GrammarFactory.Grammar.Type_Id
                Dim Body As New List(Of Ast_ExpressionStatement)
                _CodeBeginNode()

                toktype = Tokenizer.IdentifiyToken(Lookahead)
                'Detect Empty List
                If toktype = GrammarFactory.Grammar.Type_Id._CODE_END Then

                    Body.Add(New Ast_ExpressionStatement(__EmptyStatementNode))
                    _CodeEndNode()

                Else
                    Do Until ((toktype) = GrammarFactory.Grammar.Type_Id._CODE_END)
                        toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Body.Add(_ExpressionStatement)
                    Loop
                    _CodeEndNode()
                End If
                Return New Ast_BlockExpression(Body)
            End Function
#End Region
#Region "Expressions"
            ''' <summary>
            ''' Syntax:
            ''' Variable: -Identifier as expression
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _VariableExpression() As AstExpression

                Return New Ast_VariableExpressionStatement(_IdentifierLiteralNode())
            End Function

            ''' <summary>
            ''' 
            ''' Syntax: 
            ''' 
            ''' ( OptionalStatmentList; )
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _ParenthesizedExpression() As Ast_ParenthesizedExpresion
                Dim toktype As GrammarFactory.Grammar.Type_Id
                Dim Body As New List(Of AstExpression)
                _ConditionalBeginNode()
                toktype = Tokenizer.IdentifiyToken(Lookahead)
                'Detect Empty List
                If toktype = GrammarFactory.Grammar.Type_Id._CONDITIONAL_END Then

                    Body.Add(New Ast_ExpressionStatement(__EmptyStatementNode))
                    _ConditionalEndNode()
                Else
                    Do Until ((toktype) = GrammarFactory.Grammar.Type_Id._CONDITIONAL_END)
                        Body.Add(_ExpressionStatement)
                        Lookahead = Tokenizer.ViewNext
                        toktype = Tokenizer.IdentifiyToken(Lookahead)
                    Loop
                    _ConditionalEndNode()
                End If
                Return New Ast_ParenthesizedExpresion(Body)
            End Function

#Region "Binary Operations/Expressions"


            ''' <summary>
            ''' Syntax:
            '''      -Multiplicative Expression
            ''' Literal */ Literal
            ''' </summary>
            ''' <returns></returns>
            Public Function _MultiplicativeExpression() As AstExpression
                Return _BinaryExpression(GrammarFactory.Grammar.Type_Id._MULTIPLICATIVE_OPERATOR, AST_NODE._MultiplicativeExpression, "_MultiplicativeExpression")
            End Function
            ''' <summary>
            ''' Syntax:
            '''      -Addative Expression
            ''' Literal +- Literal
            ''' </summary>
            ''' <returns></returns>
            Public Function _AddativeExpression() As AstExpression
                Return _BinaryExpression(GrammarFactory.Grammar.Type_Id._ADDITIVE_OPERATOR, AST_NODE._AddativeExpression, "_AddativeExpression")
            End Function
            ''' <summary>
            ''' Syntax: 
            ''' Literal Operator Literal
            ''' 
            ''' _BinaryExpression RelationalOperator _BinaryExpression .. 
            ''' </summary>
            ''' <returns></returns>
            Public Function _RelationalExpression()

                Return _BinaryExpression(GrammarFactory.Grammar.Type_Id._RELATIONAL_OPERATOR, AST_NODE._ConditionalExpression, "_ConditionalExpression")
            End Function
            ''' <summary>
            ''' syntax:
            ''' 
            ''' 
            ''' -Literal(Primary Expression)
            ''' -Multiplicative Expression
            ''' -Addative Expression
            ''' -ConditionalExpression(OperationalExpression)
            ''' -Assignment Expression
            ''' 
            ''' </summary>
            ''' <param name="NType"></param>
            ''' <param name="AstType"></param>
            ''' <param name="AstTypeStr"></param>
            ''' <returns></returns>
            ''' 
            Public Function _BinaryExpression(ByRef NType As GrammarFactory.Grammar.Type_Id, AstType As AST_NODE, AstTypeStr As String) As AstExpression
                Dim _left As AstExpression
                Dim _Operator As String = ""
                Dim _Right As AstExpression
                _left = _PrimaryExpression()
                Lookahead = Tokenizer.ViewNext
                Dim toktype As GrammarFactory.Grammar.Type_Id
                toktype = Tokenizer.IdentifiyToken(Lookahead)
                Select Case toktype
                    Case GrammarFactory.Grammar.Type_Id._ADDITIVE_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._ADDITIVE_OPERATOR)

                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._AddativeExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_AddativeExpression"
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._MULTIPLICATIVE_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._MULTIPLICATIVE_OPERATOR)
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value

                            'NOTE: When adding further binary expressions maybe trickle down with this side
                            'the final level will need to be primary expression? 
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._MultiplicativeExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_MultiplicativeExpression"
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._RELATIONAL_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._RELATIONAL_OPERATOR)

                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            'NOTE: When adding further binary expressions maybe trickle down with this side
                            'the final level will need to be primary expression? 
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._ConditionalExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_ConditionalExpression"
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._SIMPLE_ASSIGN
                        ''Check if last token was variabe(look back parser)
                        If Tokenizer.GetLastToken.ID = GrammarFactory.Grammar.Type_Id._VARIABLE Then
                            'collect it (do not step back just take it)
                            Dim ident = New Ast_Identifier(Tokenizer.GetLastToken.Value)
                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            'create expression (replacing previosuly parsed primary expression
                            '(collects variable_expression) = pain later (for functions etc)
                            _left = New Ast_AssignmentExpression(ident, _Operator, _Right)
                        Else
                            'Do normal-(old way make binary expression sort out later in eval)
                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            _left = New AstBinaryExpression(AST_NODE._assignExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_assignExpression"
                        End If


                    Case GrammarFactory.Grammar.Type_Id._COMPLEX_ASSIGN
                        ''Check if last token was variable (look back parser)
                        If Tokenizer.GetLastToken.ID = GrammarFactory.Grammar.Type_Id._VARIABLE Then
                            'collect it (do not step back just take it)
                            Dim ident = New Ast_Identifier(Tokenizer.GetLastToken.Value)
                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            'create expression (replacing previouly parsed primary expression
                            '(collects variable_expression) = pain later (for functions etc)
                            _left = New Ast_AssignmentExpression(ident, _Operator, _Right)
                        Else
                            'Do normal-(old way make binary expression sort out later in eval)
                            _Operator = Tokenizer.GetIdentifiedToken(Lookahead).Value
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            _left = New AstBinaryExpression(AST_NODE._assignExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_assignExpression"
                        End If


                End Select
                Return _left
            End Function
            Public Function _BinaryExpression() As AstExpression
                Dim _left As AstExpression
                Dim _Operator As String = ""
                Dim _Right As AstExpression
                _left = _PrimaryExpression()
                Lookahead = Tokenizer.ViewNext
                Dim toktype As GrammarFactory.Grammar.Type_Id
                toktype = Tokenizer.IdentifiyToken(Lookahead)
                Select Case toktype
                    Case GrammarFactory.Grammar.Type_Id._ADDITIVE_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._ADDITIVE_OPERATOR)

                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._AddativeExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_AddativeExpression"
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._MULTIPLICATIVE_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._MULTIPLICATIVE_OPERATOR)

                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            'NOTE: When adding further binary expressions maybe trickle down with this side
                            'the final level will need to be primary expression? 
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._MultiplicativeExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_MultiplicativeExpression"
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._RELATIONAL_OPERATOR
                        Do While ((toktype) = GrammarFactory.Grammar.Type_Id._RELATIONAL_OPERATOR)
                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            'NOTE: When adding further binary expressions maybe trickle down with this side
                            'the final level will need to be primary expression? 
                            _Right = _BinaryExpression()

                            _left = New AstBinaryExpression(AST_NODE._ConditionalExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_ConditionalExpression"
                            toktype = Tokenizer.IdentifiyToken(Lookahead)
                        Loop
                    Case GrammarFactory.Grammar.Type_Id._SIMPLE_ASSIGN
                        ''Check if last token was variabe(look back parser)
                        If Tokenizer.GetLastToken.ID = GrammarFactory.Grammar.Type_Id._VARIABLE Then
                            'collect it (do not step back just take it)
                            Dim ident = New Ast_Identifier(Tokenizer.GetLastToken.Value)
                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            'create expression (replacing previosuly parsed primary expression
                            '(collects variable_expression) = pain later (for functions etc)
                            _left = New Ast_AssignmentExpression(ident, _Operator, _Right)
                        Else
                            'Do normal-(old way make binary expression sort out later in eval)
                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            _left = New AstBinaryExpression(AST_NODE._assignExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_assignExpression"
                        End If


                    Case GrammarFactory.Grammar.Type_Id._COMPLEX_ASSIGN
                        ''Check if last token was variable (look back parser)
                        If Tokenizer.GetLastToken.ID = GrammarFactory.Grammar.Type_Id._VARIABLE Then
                            'collect it (do not step back just take it)
                            Dim ident = New Ast_Identifier(Tokenizer.GetLastToken.Value)
                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            'create expression (replacing previouly parsed primary expression
                            '(collects variable_expression) = pain later (for functions etc)
                            _left = New Ast_AssignmentExpression(ident, _Operator, _Right)
                        Else
                            'Do normal-(old way make binary expression sort out later in eval)
                            _Operator = _GetAssignmentOperator()
                            Lookahead = Tokenizer.ViewNext
                            _Right = _BinaryExpression()
                            _left = New AstBinaryExpression(AST_NODE._assignExpression, _left, _Operator, _Right)
                            _left._TypeStr = "_assignExpression"
                        End If


                End Select
                Return _left
            End Function

#End Region

#End Region
            Public Function _GetAssignmentOperator() As String
                Dim str = Tokenizer.GetIdentifiedToken(Lookahead).Value
                str = str.Replace("\U003c", "<")
                str = str.Replace("\U003e", ">")
                ' \U003c < Less-than sign
                ' \U003e > Greater-than sign


                Return str
            End Function
#End Region

            ''' <summary>
            ''' Syntax 
            ''' -DoWhile
            ''' -DoUntil
            ''' _ForNext
            ''' 
            ''' </summary>
            ''' <returns></returns>
            Public Function _IterationStatment() As AstExpression
                Dim toktype As GrammarFactory.Grammar.Type_Id
                toktype = Tokenizer.IdentifiyToken(Lookahead)
                Select Case toktype
                    Case GrammarFactory.Grammar.Type_Id._WHILE
                        Exit Select
                    Case GrammarFactory.Grammar.Type_Id._UNTIL
                        Exit Select
                    Case GrammarFactory.Grammar.Type_Id._FOR
                        Exit Select
                    Case Else
                        Exit Select
                End Select
                Return Nothing
            End Function






        End Class

    End Namespace
End Namespace