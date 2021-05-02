Imports SDK.SmallProgLang.Ast_ExpressionFactory
Imports SDK.SmallProgLang
Public Class ReplErrorSystem


    ''' <summary>
    ''' Creates an Error Message to be displayed
    ''' </summary>
    ''' <param name="ErrorStr"></param>
    ''' <param name="Errtok"></param>
    ''' <returns></returns>
    Public Shared Function DisplayError(ByRef ErrorStr As String, ByRef Errtok As Ast_Literal) As String
        Dim str As String = ErrorStr & vbNewLine & Errtok.ToJson.FormatJsonOutput
        Return str
    End Function
End Class
