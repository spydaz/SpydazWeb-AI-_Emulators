Module Examples
    '    Function BinaryExpression(_left, _operator, _right)

    '        Dim str =
    '"Type: 'BinaryExpression'," & vbNewLine &
    '"Operator," & _operator & vbNewLine &
    '"Left," & _left & vbNewLine &
    '"Right" & _right & vbNewLine

    '        Return str
    '    End Function
    '    Function UnaryExpression(_operator, argument)
    '        Dim str =
    '    "Type: 'UnaryExpression'," & vbNewLine &
    '    "Operator," & _operator & vbNewLine &
    '    "argument," & argument & vbNewLine
    '        Return str
    '    End Function
    '    Function IfStatement(test, consequent, alternate)

    '        Dim str =
    '"Type 'IfStatement'," & vbNewLine &
    '"test," & test & vbNewLine &
    '"consequent," & consequent & vbNewLine &
    '"alternate, " & alternate & vbNewLine

    '        Return str
    '    End Function

    '    ' IterationStatement
    '    'Do Statement WHILE ( Expression ) ;
    '    'WHILE LPAREN Expression RPAREN Statement
    '    '  FunctionDeclaration
    '    ': FN Identifier LPAREN OptFormalParameterList RPAREN BlockStatement
    '    VariableInitializer
    '  : SIMPLE_ASSIGN AssignmentExpression
    '    VariableDeclarator
    '  : Identifier VariableInitializer
    '    VariableDeclarationList
    '   VariableDeclarator
    '   VariableDeclarationListInit
    '   LET VariableDeclarationList
    '    { $$ = {
    '        type 'VariableDeclaration',
    '        declarations: $2,
    'VariableDeclaration
    '  : VariableDeclarationListInit SEMICOLON { $$ = $1 }
    '        ArrayLiteral
    '  : LBRACKET OptElementList RBRACKET
    '         * x = y
    ' * x *= y
    ' * x /= y
    ' * x += y
    ' * x -= y
    ' */
    ''AssignmentExpression
    '   LogicalORExpression
    '  | LeftHandSideExpression AssignmentOperator AssignmentExpression
    '    LogicalORExpression
    '   LogicalANDExpression
    '  | LogicalORExpression LOGICAL_OR LogicalANDExpression
    '  /**
    ' * Equality expressions.
    ' *
    ' * EQUALITY_OPERATOR:==, !=
    ' *
    ' * x == y
    ' * x != y
    '  * x == y
    ' * x != y
    ' */
    'EqualityExpression
    '   RelationalExpression
    '  | EqualityExpression EQUALITY_OPERATOR RelationalExpression
    'RelationalExpression
    '   AdditiveExpression
    '  | RelationalExpression RELATIONAL_OPERATOR AdditiveExpression

    '    UnaryExpression
    '   PrimaryExpression
    '  | CallExpression
    '  | ADDITIVE_OPERATOR UnaryExpression
End Module

