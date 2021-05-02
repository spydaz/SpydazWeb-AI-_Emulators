Imports System.Text
Imports System.Text.Json
Imports System.Web.Script.Serialization

Public Module Ast_ExpressionFactory
    ''' <summary>
    ''' Ast NodeTypes Used to Describe AST Node 
    ''' </summary>
    Public Enum AST_NODE
        _array = 1
        _boolean = 2
        _string = 3
        _integer = 4
        _variable = 5
        _null = 6
        _endStatement = 7
        _blockCode = 8
        _binaryExpression = 9
        _OperationalExpression = 10
        _MultiplicativeExpression = 11
        _AddativeExpression = 12
        _assignExpression = 13
        _Dim = 14
        _For = 15
        _If = 16
        _function = 17
        _sub = 18
        _class = 19
        _else = 20
        _then = 21
        _Do_while = 22
        _Do_until = 23
        _Program = 24
        _comments = 25
        _ExpressionStatement = 26
        _WhiteSpace = 27
        _UnknownStatement = 28
        _Code_Begin = 29
        _Code_End = 30
        _emptyStatement = 31
        _OperationBegin = 32
        _OperationEnd = 33
        _ConditionalExpression = 34
    End Enum
    ''' <summary>
    ''' Syntax:
    ''' 
    ''' Used to hold Varnames or Identifiers
    ''' 
    ''' 
    ''' </summary>
    Public Class Ast_Identifier
        Inherits AstNode
        Public _Name As String
        Public Sub New(ByRef nName As String)
            MyBase.New(AST_NODE._variable)
            Me._TypeStr = "Identifier"
            Me._Name = nName
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst = MyBase.ToArraylist()
            lst.Add(_Name)
            Return lst
        End Function
    End Class
    ''' <summary>
    ''' 
    ''' Syntax: 
    ''' 
    ''' Used to hold Literals and values
    ''' 
    ''' 
    ''' </summary>
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
    End Class
    ''' <summary>
    ''' Syntax: 
    ''' 
    ''' Root Ast node Type
    ''' 
    ''' </summary>
    Public Class AstNode
        ''' <summary>
        ''' Type Of Node
        ''' </summary>
        Public _Type As AST_NODE
        ''' <summary>
        '''  String version of the Type due to not being printed
        ''' </summary>
        Public _TypeStr As String
        ''' <summary>
        ''' Start Position
        ''' </summary>
        Public _Start As Integer
        ''' <summary>
        ''' End Position
        ''' </summary>
        Public _End As Integer
        ''' <summary>
        ''' Raw data of token
        ''' </summary>
        Public _Raw As String
        ''' <summary>
        ''' Instanciate
        ''' </summary>
        ''' <param name="ntype">Type of Node</param>
        Public Sub New(ByRef ntype As AST_NODE)
            Me._Type = ntype
        End Sub
        Public Overridable Function ToArraylist() As List(Of String)
            Dim lst As New List(Of String)
            lst.Add(_TypeStr)
            Return lst
        End Function


    End Class
    ''' <summary>
    ''' Expression Model Used To Group Expressions
    ''' </summary>
    Public Class AstExpression
        Inherits AstNode
        Public Sub New(ByRef ntype As AST_NODE)
            MyBase.New(ntype)
        End Sub
    End Class
    ''' <summary>
    ''' Syntax:
    ''' 
    ''' Expression Statement Types
    ''' 
    ''' </summary>
    Public Class Ast_ExpressionStatement
        Inherits AstExpression
        ''' <summary>
        ''' Literal Value
        ''' </summary>
        Public _Expression As Ast_Literal
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nValue">Literal Value to be stored </param>
        Public Sub New(ByRef nValue As Ast_Literal)
            MyBase.New(AST_NODE._ExpressionStatement)
            Me._Expression = nValue
            Me._TypeStr = "_ExpressionStatement"
            Me._Start = _Expression._Start
            Me._End = _Expression._End
            Me._Raw = nValue._Raw
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst As List(Of String) = MyBase.ToArraylist()
            lst.AddRange(_Expression.iLiteral.toarraylist)
            Return lst
        End Function
    End Class
    Public Class Ast_VariableExpressionStatement
        Inherits AstExpression
        ''' <summary>
        ''' Literal Value
        ''' </summary>
        Public _Expression As Ast_Identifier
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="nValue">Literal Value to be stored </param>
        Public Sub New(ByRef nValue As Ast_Identifier)
            MyBase.New(AST_NODE._ExpressionStatement)
            Me._Expression = nValue
            Me._TypeStr = "_ExpressionStatement"
            Me._Start = _Expression._Start
            Me._End = _Expression._End
            Me._Raw = nValue._Raw
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst = MyBase.ToArraylist()
            lst.AddRange(_Expression.ToArraylist)
            Return lst
        End Function
    End Class
    ''' <summary>
    ''' 
    ''' 
    ''' Syntax : 
    ''' Based on AST Explorer output
    '''{
    '''  "type": "Program",
    '''  "start": 0,
    '''  "end": 2,
    '''  "body": [
    '''    {
    '''      "type": "ExpressionStatement",
    '''      "start": 0,
    '''      "end": 2,
    '''      "expression": {
    '''        "type": "Literal",
    '''        "start": 0,
    '''        "end": 2,
    '''        "value": 42,
    '''        "raw": "42"
    '''      }
    '''    }
    '''  ],
    '''}
    ''' 
    ''' </summary>
    Public Class AstProgram
        Inherits AstNode
        ''' <summary>
        ''' Expression List
        ''' </summary>
        Public Body As List(Of AstExpression)
        ''' <summary>
        ''' Instanciate Expression
        ''' </summary>
        ''' <param name="nBody">Expressions</param>
        Public Sub New(ByRef nBody As List(Of AstExpression))
            MyBase.New(AST_NODE._Program)
            Me.Body = nBody
            Me._TypeStr = "_Program"
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst = MyBase.ToArraylist()
            For Each item In Body
                lst.AddRange(item.ToArraylist)
            Next
            Return lst
        End Function
    End Class
    ''' <summary>
    ''' Used for Binary Operations
    ''' </summary>
    Public Class AstBinaryExpression
        Inherits AstExpression
        Public _Left As AstExpression
        Public _Right As AstExpression
        Public _Operator As String
        Public Sub New(ByRef nType As AST_NODE, ByRef nLeft As AstExpression, ByRef nOperator As String, ByRef nRight As AstExpression)
            MyBase.New(nType)
            Me._Left = nLeft
            Me._Right = nRight
            Me._Operator = nOperator
            Me._Raw = nLeft._Raw & nOperator & nRight._Raw
            Me._Start = nLeft._Start
            Me._End = nRight._End
            Me._TypeStr = "BinaryExpression"
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst = MyBase.ToArraylist()
            lst.Add(_Operator)
            lst.AddRange(_Left.ToArraylist)
            lst.AddRange(_Right.ToArraylist)
            Return lst
        End Function

    End Class
    Public Class Ast_AssignmentExpression
        Inherits AstExpression
        ''' <summary>
        ''' Must be var literal type
        ''' </summary>
        Public _Left As Ast_Identifier
        Public _Right As AstExpression
        Public _Operator As String
        Public Sub New(ByRef nLeft As Ast_Identifier, ByRef nOperator As String, ByRef nRight As AstExpression)
            MyBase.New(AST_NODE._assignExpression)
            Me._Left = nLeft
            Me._Right = nRight
            Me._Operator = nOperator
            Me._Raw = nLeft._Raw & nOperator & nRight._Raw
            Me._Start = nLeft._Start
            Me._End = nRight._End
            Me._TypeStr = "_assignExpression"
        End Sub

        Public Overrides Function ToArrayList() As List(Of String)

            Dim lst As List(Of String) = MyBase.ToArraylist
            lst.Add(_Operator)
            lst.Add(_Left._Name.ToString)
            lst.AddRange(_Right.ToArraylist)
            Return lst
        End Function

    End Class
    ''' <summary>
    ''' Used for CodeBlocks
    ''' </summary>
    Public Class Ast_BlockExpression
        Inherits AstExpression
        Public Body As List(Of Ast_ExpressionStatement)
        Public Sub New(ByRef iBody As List(Of Ast_ExpressionStatement))
            MyBase.New(AST_NODE._blockCode)
            Me._TypeStr = "_blockCode"
            Body = iBody
            Me._Start = iBody(0)._Start
            For Each item In iBody
                Me._Raw &= item._Raw
            Next
            Me._End = iBody(iBody.Count - 1)._End
        End Sub
        Public Overrides Function ToArraylist() As List(Of String)
            Dim lst = MyBase.ToArraylist()
            For Each item In Body
                lst.AddRange(item.ToArraylist)
            Next
            Return lst
        End Function
    End Class
    ''' <summary>
    ''' Used for Operational Expression
    ''' </summary>
    Public Class Ast_ParenthesizedExpresion
        Inherits AstExpression
        Public Body As List(Of AstExpression)
        Public Sub New(ByRef iBody As List(Of AstExpression))
            MyBase.New(AST_NODE._OperationalExpression)
            Me._TypeStr = "_OperationalExpression"
            Body = iBody
            Me._Start = iBody(0)._Start
            For Each item In iBody
                Me._Raw &= item._Raw
            Next
            Me._End = iBody(iBody.Count - 1)._End
        End Sub
    End Class
End Module



