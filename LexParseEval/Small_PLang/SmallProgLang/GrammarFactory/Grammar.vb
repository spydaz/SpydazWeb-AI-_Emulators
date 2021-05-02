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
            Public Shared Function GetGrammar() As List(Of Grammar)
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
        End Structure
    End Namespace
End Namespace
