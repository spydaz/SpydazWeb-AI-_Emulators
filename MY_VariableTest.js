// JavaScript source code
module.exports = test => {
	// Simple variable declaration:
	test(`dim foo=43`, `foo=42` {
		"Body": [
			{
				"_Left": {
					"_Expression": {
						"_Name": "foo",
						"_Type": 5,
						"_TypeStr": "_variable",
						"_Start": 4,
						"_End": 6,
						"_Raw": "fo"
					},
					"_Type": 26,
					"_TypeStr": "_VariableExpression",
					"_Start": 4,
					"_End": 6,
					"_Raw": "fo"
				},
				"_Right": {
					"_Expression": {
						"iLiteral": 43,
						"_Type": 4,
						"_TypeStr": "_integer"
						"_Start": 7,
						"_End": 9,
						"_Raw": "43"
					},
					"_Type": 26,
					"_TypeStr": "_ExpressionStatement",
					"_Start": 7,
					"_End": 9,
					"_Raw": "43"
				},
				"_Operator": "=",
				"_Type": 78,
				"_TypeStr": "_DeclareVariable",
				"_Start": 0,
				"_End": 3,
				"_Raw": "fo=43"
			}
		],
		"_Type": 24,
		"_TypeStr": "PL PROGRAM",
		"_Start": 0,
		"_End": 9,
		"_Raw": "dim fo=43"
	}, {
		"Body": [
			{
				"_Left": {
					"_Expression": {
						"_Name": "foo",
						"_Type": 5,
						"_TypeStr": "_variable",
						"_Start": 0,
						"_End": 3,
						"_Raw": "foo"
					},
					"_Type": 26,
					"_TypeStr": "_VariableExpression",
					"_Start": 0,
					"_End": 3,
					"_Raw": "foo"
				},
				"_Right": {
					"_Expression": {
						"iLiteral": 42,
						"_Type": 4,
						"_TypeStr": "_integer",
						"_Start": 4,
						"_End": 6,
						"_Raw": "42"
					},
					"_Type": 26,
					"_TypeStr": "_ExpressionStatement",
					"_Start": 4,
					"_End": 6,
					"_Raw": "42"
				},
				"_Operator": "=",
				"_Type": 13,
				"_TypeStr": "_SIMPLE_ASSIGN",
				"_Start": 0,
				"_End": 6,
				"_Raw": "foo=42"
			}
		],
		"_Type": 24,
		"_TypeStr": "PL PROGRAM",
		"_Start": 0,
		"_End": 6,
		"_Raw": "foo=42"
	})};