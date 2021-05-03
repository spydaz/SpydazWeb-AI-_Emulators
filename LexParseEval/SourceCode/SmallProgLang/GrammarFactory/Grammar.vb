Imports System.Text.Json

Namespace SmallProgLang
    Namespace GrammarFactory


        ''' <summary>
        ''' Simple Gramar object (Expected token Shape or from)
        ''' </summary>
        Public Structure Grammar
            ''' <summary>
            ''' GRAMMAR OBJECT ID
            ''' </summary>
            Public Enum Type_Id
                ''' <summary>
                ''' Literal
                ''' </summary>
                _INTEGER
                ''' <summary>
                ''' Literal
                ''' </summary>
                _STRING
                ''' <summary>
                ''' Literal
                ''' </summary>
                _VARIABLE
                _WHITESPACE
                _COMMENTS
                ''' <summary>
                ''' Print Literal/Value/String
                ''' </summary>
                _PRINT
                ''' <summary>
                ''' Declare Var
                ''' </summary>
                _DIM
                ''' <summary>
                ''' Begin Iteration of list
                ''' For (Iterator = (Increment to Completion)
                ''' </summary>
                _FOR
                ''' <summary>
                ''' Additional = Step +1
                ''' </summary>
                _EACH
                ''' <summary>
                ''' From item in list
                ''' </summary>
                _IN
                ''' <summary>
                ''' End of iteration marker
                ''' </summary>
                _TO
                ''' <summary>
                ''' Increment Iterator
                ''' </summary>
                _NEXT
                ''' <summary>
                ''' If Condition = Outcome Then (code) Else (code)
                ''' </summary>
                _IF
                ''' <summary>
                ''' Then (block)
                ''' </summary>
                _THEN
                ''' <summary>
                ''' Else (Block)
                ''' </summary>
                _ELSE
                ''' <summary>
                ''' Until Condition = true
                ''' </summary>
                _UNTIL
                ''' <summary>
                ''' While Condition = true
                ''' </summary>
                _WHILE
                ''' <summary>
                ''' Signify begining of Do...While/Until
                ''' </summary>
                _DO
                _RETURN
                _FUNCTION
                _SUB
                _CLASS
                _NEW
                ''' <summary>
                ''' Used in Declaration Assignment
                ''' Left (var) assign as (LiteralType)
                ''' </summary>
                _AS
                ''' <summary>
                ''' End of While loop (marker)(check expression Condition)
                ''' </summary>
                _LOOP
                ''' <summary>
                ''' xLeft = output of right (9+4) (+= 9) (-=2) (3) (true)
                ''' </summary>
                _SIMPLE_ASSIGN
                ''' <summary>
                ''' xLeft assigns output of right -=(9+4) (+= 9) (-=2) (3) (true)
                ''' Complex assign ... x=x+(ouput)x=x-(ouput) etc
                ''' </summary>
                _COMPLEX_ASSIGN
                ''' <summary>
                ''' Boolean Literal Env Variable
                ''' </summary>
                _TRUE
                ''' <summary>
                ''' Boolean Literal - Env Variable
                ''' </summary>
                _FALSE
                ''' <summary>
                ''' Boolean literal -Env Variable
                ''' </summary>
                _NULL
                ''' <summary>
                ''' Used for Args List (Lists) = Arrays
                ''' Args are lists of Vars (function Environment Vars)
                ''' </summary>
                _LIST_BEGIN
                ''' <summary>
                ''' End of List
                ''' </summary>
                _LIST_END
                ''' <summary>
                ''' Used for Blocks of code
                ''' </summary>
                _CODE_BEGIN
                ''' <summary>
                ''' End of Code block
                ''' </summary>
                _CODE_END
                ''' <summary>
                ''' Used for operation blocks as well as 
                ''' ordering prioritizing evals
                ''' Begin
                ''' </summary>
                _CONDITIONAL_BEGIN
                ''' <summary>
                ''' End of Condition
                ''' </summary>
                _CONDITIONAL_END
                ''' <summary>
                '''  - AND
                ''' </summary>
                _LOGICAL_AND
                ''' <summary>
                '''  | OR
                ''' </summary>
                _LOGICAL_OR
                ''' <summary>
                ''' ! NOT
                ''' </summary>
                _LOGICAL_NOT
                ''' <summary>
                ''' Greater than / Less Than
                ''' </summary>
                _RELATIONAL_OPERATOR
                ''' <summary>
                ''' +-
                ''' </summary>
                _ADDITIVE_OPERATOR
                ''' <summary>
                ''' */
                ''' </summary>
                _MULTIPLICATIVE_OPERATOR
                ''' <summary>
                ''' ;
                ''' </summary>
                _STATEMENT_END
                ''' <summary>
                ''' end of file
                ''' </summary>
                _EOF
                ''' <summary>
                ''' Bad / Unrecognized token
                ''' </summary>
                _BAD_TOKEN
                ''' <summary>
                ''' Seperates items in list
                ''' </summary>
                _LIST_SEPERATOR
                ''' <summary>
                ''' !=
                ''' </summary>
                _NOT_EQUALS
                ''' <summary>
                ''' DECLARE VAR 
                ''' </summary>
                _VARIABLE_DECLARE
                'Sal token_IDs
                SAL_NULL
                SAL_REMOVE
                SAL_RESUME
                SAL_PUSH
                SAL_PULL
                SAL_PEEK
                SAL_WAIT
                SAL_PAUSE
                SAL_HALT
                SAL_DUP
                SAL_JMP
                SAL_JIF_T
                SAL_JIF_F
                SAL_JIF_EQ
                SAL_JIF_GT
                SAL_JIF_LT
                SAL_LOAD
                SAL_STORE
                SAL_CALL
                SAL_RET
                SAL_PRINT_M
                SAL_PRINT_C
                SAL_ADD
                SAL_SUB
                SAL_MUL
                SAL_DIV
                SAL_AND
                SAL_OR
                SAL_NOT
                SAL_IS_EQ
                SAL_IS_GT
                SAL_IS_GTE
                SAL_IS_LT
                SAL_IS_LTE
                SAL_TO_POS
                SAL_TO_NEG
                SAL_INCR
                SAL_DECR

            End Enum
            ''' <summary>
            ''' Identifier
            ''' </summary>
            Public ID As Type_Id
            ''' <summary>
            ''' RegEx Expression to search
            ''' </summary>
            Public Exp As String
            ''' <summary>
            ''' Set OF KeyWords for Language with RegEx Search Expressions
            ''' Based on basic programming languge keywords and symbols /Literals
            ''' This is a preloaded Grammar (list of Grammar objects)
            ''' </summary>
            ''' <returns></returns>
            Public Shared Function GetPLGrammar() As List(Of Grammar)
                Dim iSpec As New List(Of Grammar)
                Dim NewGram As New Grammar


                'Literals
                NewGram.ID = Type_Id._INTEGER
                NewGram.Exp = "^\d+"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STRING
                NewGram.Exp = "^" & Chr(34) & "[^" & Chr(34) & "]*" & Chr(34)
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STRING
                NewGram.Exp = "^'[^']*'"
                iSpec.Add(NewGram)

                NewGram = New Grammar
                NewGram.ID = Type_Id._WHITESPACE
                NewGram.Exp = "^\s"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._COMMENTS
                NewGram.Exp = "^\/\/.*"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._COMMENTS
                NewGram.Exp = "^\/\*[\s\S]*?\*\/"
                iSpec.Add(NewGram)

                'Prints
                NewGram = New Grammar
                NewGram.ID = Type_Id._PRINT
                NewGram.Exp = "^\bprint\b"
                iSpec.Add(NewGram)

                'Functions/Classes
                NewGram = New Grammar
                NewGram.ID = Type_Id._RETURN
                NewGram.Exp = "^\breturn\b"
                iSpec.Add(NewGram)
                'NewGram = New Grammar
                'NewGram.ID = "DEF"
                'NewGram.Exp = "\bdef\b"
                'iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._FUNCTION
                NewGram.Exp = "^\bfunction\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._CLASS
                NewGram.Exp = "^\bclass\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._NEW
                NewGram.Exp = "^\bnew\b"
                iSpec.Add(NewGram)

                'IF/THEN
                NewGram = New Grammar
                NewGram.ID = Type_Id._IF
                NewGram.Exp = "^\bif\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._ELSE
                NewGram.Exp = "^\belse\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._THEN
                NewGram.Exp = "^\bthen\b"
                iSpec.Add(NewGram)

                'ASSIGNMENT : Syntax  _Variable _AS 
                'Reconsidered Using Dim (Could Still Implement by changing Assignment handler/Generator)
                'NewGram = New Grammar
                'NewGram.ID = Type_Id._DIM
                'NewGram.Exp = "^\bdim\b"
                'iSpec.Add(NewGram)
                'Assignment operators: xLeft assigns output of right (9+4) (+= 9) (-=2) (3) (true)
                NewGram = New Grammar
                ''=
                NewGram.ID = Type_Id._SIMPLE_ASSIGN
                NewGram.Exp = "^\="
                iSpec.Add(NewGram)
                NewGram = New Grammar
                '*=, /=, +=, -=,
                NewGram.ID = Type_Id._COMPLEX_ASSIGN
                NewGram.Exp = "^[*/\+\-]\="
                iSpec.Add(NewGram)

                'DO WHILE/UNTIL
                NewGram = New Grammar
                NewGram.ID = Type_Id._WHILE
                NewGram.Exp = "^\bwhile\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._VARIABLE_DECLARE
                NewGram.Exp = "^\bas\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._UNTIL
                NewGram.Exp = "^\buntil\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOOP
                NewGram.Exp = "^\bloop\b"
                iSpec.Add(NewGram)


                'For/To  For/Each/in /Next
                NewGram = New Grammar
                NewGram.ID = Type_Id._FOR
                NewGram.Exp = "^\bfor\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._EACH
                NewGram.Exp = "^\beach\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._TO
                NewGram.Exp = "^\bto\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._NEXT
                NewGram.Exp = "^\bnext\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._IN
                NewGram.Exp = "^\bin\b"
                iSpec.Add(NewGram)



                'Logical Operators:  &&, ||
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOGICAL_AND
                NewGram.Exp = "^\band\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOGICAL_AND
                NewGram.Exp = "^\&\& "
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOGICAL_OR
                NewGram.Exp = "^\bor\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOGICAL_OR
                NewGram.Exp = "^\|\|"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LOGICAL_NOT
                NewGram.Exp = "^\bnot\b"
                iSpec.Add(NewGram)

                'logical(boolean) - Literal
                NewGram = New Grammar
                NewGram.ID = Type_Id._TRUE
                NewGram.Exp = "^\btrue\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._FALSE
                NewGram.Exp = "^\bfalse\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._NULL
                NewGram.Exp = "^\bnull\b"
                iSpec.Add(NewGram)


                'Equality operators: ==, !=
                NewGram = New Grammar
                NewGram.ID = Type_Id._NOT_EQUALS
                NewGram.Exp = "^[\=!]"
                iSpec.Add(NewGram)
                'Relational operators: >, >=, <, <=
                NewGram = New Grammar
                NewGram.ID = Type_Id._RELATIONAL_OPERATOR
                NewGram.Exp = "^[><]\=?"
                iSpec.Add(NewGram)
                'Math operators: +, -, *, /
                NewGram = New Grammar
                NewGram.ID = Type_Id._ADDITIVE_OPERATOR
                NewGram.Exp = "^[+\-]"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._MULTIPLICATIVE_OPERATOR
                NewGram.Exp = "^[*/]"
                iSpec.Add(NewGram)
                'Conditional BLOCK CODE: LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CONDITIONAL_BEGIN
                NewGram.Exp = "^\("
                iSpec.Add(NewGram)
                'Conditional BLOCK CODE: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CONDITIONAL_END
                NewGram.Exp = "^\)"
                iSpec.Add(NewGram)
                'BLOCK CODE: LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CODE_BEGIN
                NewGram.Exp = "^\{"
                iSpec.Add(NewGram)
                'BLOCK CODE: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CODE_END
                NewGram.Exp = "^\}"
                iSpec.Add(NewGram)
                'END STATEMENT or EMPTY STATEMENT
                'EMPTY CODE BLOCKS CONTAIN (1 EMPTY STATEMENT)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STATEMENT_END
                NewGram.Exp = "^\;"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_SEPERATOR
                NewGram.Exp = "^\,"
                iSpec.Add(NewGram)
                'ARGS LIST : LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_BEGIN
                NewGram.Exp = "^\["
                iSpec.Add(NewGram)
                'ARGS LIST: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_END
                NewGram.Exp = "^\]"
                iSpec.Add(NewGram)

                'Variable
                NewGram = New Grammar
                NewGram.ID = Type_Id._VARIABLE
                NewGram.Exp = "^[a-z][a-z0-9]+"
                iSpec.Add(NewGram)

                'ARGS LIST: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._EOF
                NewGram.Exp = "EOF"
                iSpec.Add(NewGram)
                Return iSpec
            End Function
            Public Shared Function GetSALGrammar() As List(Of Grammar)
                Dim iSpec As New List(Of Grammar)
                Dim NewGram As New Grammar


                'Literals
                NewGram.ID = Type_Id._INTEGER
                NewGram.Exp = "^\d+"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STRING
                NewGram.Exp = "^" & Chr(34) & "[^" & Chr(34) & "]*" & Chr(34)
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STRING
                NewGram.Exp = "^'[^']*'"
                iSpec.Add(NewGram)

                NewGram = New Grammar
                NewGram.ID = Type_Id._WHITESPACE
                NewGram.Exp = "^\s"
                iSpec.Add(NewGram)


                'Sal_Cmds
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_NULL
                NewGram.Exp = "^\bnull\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_REMOVE
                NewGram.Exp = "^\bremove\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_RESUME
                NewGram.Exp = "^\bresume\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PUSH
                NewGram.Exp = "^\bpush\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PULL
                NewGram.Exp = "^\bpull\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PEEK
                NewGram.Exp = "^\bpeek\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_WAIT
                NewGram.Exp = "^\bwait\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PAUSE
                NewGram.Exp = "^\bpause\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_HALT
                NewGram.Exp = "^\bhalt\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_DUP
                NewGram.Exp = "^\bdup\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JMP
                NewGram.Exp = "^\bjmp\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_T
                NewGram.Exp = "^\bjif_t\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_F
                NewGram.Exp = "^\bjif_f\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_EQ
                NewGram.Exp = "^\bjif_eq\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_GT
                NewGram.Exp = "^\bjif_gt\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_LT
                NewGram.Exp = "^\bjif_lt\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_LOAD
                NewGram.Exp = "^\bload\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_STORE
                NewGram.Exp = "^\bstore\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_CALL
                NewGram.Exp = "^\bcall\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_RET
                NewGram.Exp = "^\bret\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PRINT_M
                NewGram.Exp = "^\bprint_m\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_PRINT_C
                NewGram.Exp = "^\bprint_c\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_ADD
                NewGram.Exp = "^\badd\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_SUB
                NewGram.Exp = "^\bsub\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_MUL
                NewGram.Exp = "^\bmul\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_DIV
                NewGram.Exp = "^\bdiv\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_ADD
                NewGram.Exp = "^\band\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_OR
                NewGram.Exp = "^\bor\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_NOT
                NewGram.Exp = "^\bnot\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_JIF_LT
                NewGram.Exp = "^\bis_eq\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_IS_GT
                NewGram.Exp = "^\bis_gt\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_IS_GTE
                NewGram.Exp = "^\bis_gte\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_IS_LT
                NewGram.Exp = "^\bis_lt\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_IS_LT
                NewGram.Exp = "^\bis_lte\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_TO_POS
                NewGram.Exp = "^\bto_pos\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_TO_NEG
                NewGram.Exp = "^\bto_neg\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_INCR
                NewGram.Exp = "^\bincr\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id.SAL_DECR
                NewGram.Exp = "^\bdecr\b"
                iSpec.Add(NewGram)
                'logical(boolean) - Literal
                NewGram = New Grammar
                NewGram.ID = Type_Id._TRUE
                NewGram.Exp = "^\btrue\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._FALSE
                NewGram.Exp = "^\bfalse\b"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._NULL
                NewGram.Exp = "^\bnull\b"
                iSpec.Add(NewGram)


                'Equality operators: ==, !=
                NewGram = New Grammar
                NewGram.ID = Type_Id._NOT_EQUALS
                NewGram.Exp = "^[\=!]"
                iSpec.Add(NewGram)
                'Relational operators: >, >=, <, <=
                NewGram = New Grammar
                NewGram.ID = Type_Id._RELATIONAL_OPERATOR
                NewGram.Exp = "^[><]\=?"
                iSpec.Add(NewGram)
                'Math operators: +, -, *, /
                NewGram = New Grammar
                NewGram.ID = Type_Id._ADDITIVE_OPERATOR
                NewGram.Exp = "^[+\-]"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._MULTIPLICATIVE_OPERATOR
                NewGram.Exp = "^[*/]"
                iSpec.Add(NewGram)
                'Conditional BLOCK CODE: LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CONDITIONAL_BEGIN
                NewGram.Exp = "^\("
                iSpec.Add(NewGram)
                'Conditional BLOCK CODE: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CONDITIONAL_END
                NewGram.Exp = "^\)"
                iSpec.Add(NewGram)
                'BLOCK CODE: LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CODE_BEGIN
                NewGram.Exp = "^\{"
                iSpec.Add(NewGram)
                'BLOCK CODE: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._CODE_END
                NewGram.Exp = "^\}"
                iSpec.Add(NewGram)
                'END STATEMENT or EMPTY STATEMENT
                'EMPTY CODE BLOCKS CONTAIN (1 EMPTY STATEMENT)
                NewGram = New Grammar
                NewGram.ID = Type_Id._STATEMENT_END
                NewGram.Exp = "^\;"
                iSpec.Add(NewGram)
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_SEPERATOR
                NewGram.Exp = "^\,"
                iSpec.Add(NewGram)
                'ARGS LIST : LEFT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_BEGIN
                NewGram.Exp = "^\["
                iSpec.Add(NewGram)
                'ARGS LIST: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._LIST_END
                NewGram.Exp = "^\]"
                iSpec.Add(NewGram)

                'ARGS LIST: RIGHT BOUNDRY
                NewGram = New Grammar
                NewGram.ID = Type_Id._EOF
                NewGram.Exp = "EOF"
                iSpec.Add(NewGram)
                Return iSpec
            End Function

        End Structure
    End Namespace
End Namespace
