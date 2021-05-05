// JavaScript source code
module.exports = test => {
	// Simple variable declaration:
	test(`dim foo=43; dim foo=43+2;`, {
		"Body": [
			{
				"_LiteralType": "NULL",
				"_Expression": {
					"_Value": {
						"_Expression": {
							"iLiteral": 43,
							"_Type": 4,
							"_TypeStr": "_integer",
							"_Start": 8,
							"_End": 10,
							"_Raw": "43"
						},
						"_Type": 26,
						"_TypeStr": "_ExpressionStatement",
						"_Start": 8,
						"_End": 10,
						"_Raw": "43"
					},
					"_Name": "foo",
					"_Type": 5,
					"_TypeStr": "_VariableInitializer",
					"_Start": 0,
					"_End": 0,
					"_Raw": null
				},
				"_Type": 26,
				"_TypeStr": "_VariableDeclaration",
				"_Start": 0,
				"_End": 0,
				"_Raw": null
			},
			{
				"_LiteralType": "NULL",
				"_Expression": {
					"_Value": {
						"_Left": {
							"_Expression": {
								"iLiteral": 43,
								"_Type": 4,
								"_TypeStr": "_integer",
								"_Start": 20,
								"_End": 22,
								"_Raw": "43"
							},
							"_Type": 26,
							"_TypeStr": "_ExpressionStatement",
							"_Start": 20,
							"_End": 22,
							"_Raw": "43"
						},
						"_Right": {
							"_Expression": {
								"iLiteral": 2,
								"_Type": 4,
								"_TypeStr": "_integer",
								"_Start": 23,
								"_End": 24,
								"_Raw": "2"
							},
							"_Type": 26,
							"_TypeStr": "_ExpressionStatement",
							"_Start": 23,
							"_End": 24,
							"_Raw": "2"
						},
						"_Operator": "+",
						"_Type": 12,
						"_TypeStr": "_AddativeExpression",
						"_Start": 20,
						"_End": 24,
						"_Raw": "43+2"
					},
					"_Name": "foo",
					"_Type": 5,
					"_TypeStr": "_VariableInitializer",
					"_Start": 0,
					"_End": 0,
					"_Raw": null
				},
				"_Type": 26,
				"_TypeStr": "_VariableDeclaration",
				"_Start": 0,
				"_End": 0,
				"_Raw": null
			}
		],
		"_Type": 24,
		"_TypeStr": "PL PROGRAM",
		"_Start": 0,
		"_End": 25,
		"_Raw": "dim foo=43; dim foo=43+2;"
	})
};