Module Temp_Mde
	'This is for Keeping the
	'known Structures that will be needed along the way!

	Public Sub _For()
		Dim Str As String = ""

		' "description": "For Next Loop"
		Str =
		"prefix:" & "for" & vbNewLine &
		"body:" & vbNewLine &
		"For ${1:index} As ${2:ObjectType} = ${3:lower} To ${4:Upper}" & vbNewLine &
		"<CodeBlock>" & vbNewLine & "Next"

		'	"description" "For Each...Next"
		Dim Str2 =
		"prefix:" & "foreach" & vbNewLine &
		"body" & vbNewLine &
		"For Each ${1:Variable} As ${2:ObjectType} In ${3:Collection}" & vbNewLine &
		"<CodeBlock>" & vbNewLine & "Next"

	End Sub
	Public Sub _IF()
		'"description": "If..."
		Dim Str As String = ""
		Str =
		"prefix" & "if" & vbNewLine &
		"body" & vbNewLine &
		"If ${1:Boolean} Then" & vbNewLine &
		"<codeBlock>" & vbNewLine & "End If\n"

		'"description": "Function..."
		Dim Str2 =
		"prefix" & "function" & vbNewLine &
		"body" & vbNewLine &
		"Function ${1:FunctionName}(${2:ParameterList}) As ${3:ReturnType}" & vbNewLine &
		"<codeBlock>" & vbNewLine & "End Function\n"

	End Sub
	Public Sub _DO()
		'	"description": "Do While ... Loop"
		Dim Str As String = ""
		Str =
		"prefix" & "dowhile" & vbNewLine &
		"body" & vbNewLine &
		"Do While ${1:Boolean}" & vbNewLine &
		"<codeBlock>" & vbNewLine & "Loop\n"

		' "description" "Do Until ... Loop"
		Dim Str2 =
		"prefix" & "dountil" & vbNewLine &
		"body" & vbNewLine &
		"Do Until ${1:Boolean}" & vbNewLine &
		"<codeBlock>" & vbNewLine & "Loop\n"

	End Sub

	Public Sub _Dim()
		' "description": "Dim ... As"
		Dim Str As String = ""
		Str =
		"prefix" & "dim" & vbNewLine &
		"body" & vbNewLine &
		"Dim ${1:Name} As ${2:Type}"

	End Sub

	Public Sub _Declare()
		'	"description": "Declare Function ..."
		Dim str As String = ""
		str =
		"prefix" & "Declare" & vbNewLine &
		"body" & vbNewLine &
		"Declare Function ${1:Name}" & " (${3:ParameterList}) As ${4:Type} " & vbNewLine &
	"<codeBlock>" & vbNewLine & "End Function\n"

	End Sub

	Public Sub _ClassModuleFunction()
		'	"description": "Module..."
		Dim Str2 =
		"prefix:" & "Module" & vbNewLine &
		"body" & vbNewLine &
			"Module ${1:Name}" & vbNewLine &
			"<codeBlock>" & vbNewLine & "End Module\n"


		' "description": "Class..."
		Dim Str3 =
	"prefix:" & "Class" & vbNewLine &
	"body:" & vbNewLine &
	"Class ${1:Name}" & vbNewLine &
	"<codeBlock>" & vbNewLine & "End Class\n"

	End Sub
End Module
