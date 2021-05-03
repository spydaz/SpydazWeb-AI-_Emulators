# SpydazWeb-AI-_Emulators
SpydazWeb Program languges and virtual machines, Parser/Compiler/Interpretor. AST Creator... Experiments in developing compilers and programing langugages . Using Mini Basic language to Tokenizer to AST to Assembly code 

https://spydaz.github.io/SpydazWeb-AI-_Emulators/

##Insight
This Present source code has been changed due to leaning new ways in which to create the hierachy for the AST Tree as well as transpile to S-Expression form for Quick evaluation, prompting me to change my model to be more universal. 


## DESCRIPTION:
	A basic programming language designed in stages to be compiled and executed on a virtual machine :
	the language is translated to an assembly code to be executed on a Virtual Stack based CPU
	The process of tokeninzing the input and susequentially into an executable abstract syntax tree
	the tree generates the required assembly code and executes the code in a virtual environment.
	
## Features:
	Currently Creating a REPL to allow for the compiling and executing of the SAL Assembly language; 
	The Basic programming language will also be able to be compiled and executed in the REPL. 
	The Agnostic parser allows for chooseing which language to devlop with by declaring; either lang as the header of the code
### BONUS ABILITYS:
This was not only a to devlop a programming language as this has never been my goal, in fact to parse a syntax tree for gramatical syntax trees is my interest for my artificial inteligence languge components; Initialy i did have this half implemented by obviously my understanding of how to deal with the gramatical trees was not working so AST.... Yep ... its universal ;

 - tokenizer/parser/interpretor ;
 - (lex/ParseEval) ;
 - interpretor Design Pattern 

They are all generally the same in the end; (it is the techniques) (generic is never the way to go!)... 

Second Bonus (the parser will begin to accept other syntaxes) enebaling for anystyle of programming language in the same program (ie C# with VB) ? Em why not as they are both compiling on the same compiler to the same expressions to the same framworks ? why did microsoft not just do this automatically too?.... Lets see how it goes!


#AST Development / Visualization
	This plays a key part in the devlopment of programming languages the ablity to veiw the tree as well as transform the tree ; collecting as much information as possible enabling for error handleing(nightmares) ... and messaging for the UI... 
	
	
AST => TreeView as well as AST => JSON View
	
# sal_lang 	
	sal_lang 
	sal push 45 halt
	
# spl_lang	
	spl_lang
	45+5(+45);
	
	
	
`
# Spydaz Virtual Machine Code Language ;

## Description :
	This assembly language is specific to this virtual processor 
	Enableing for the code to be executed on the cpu: 
	This is a Micro based instruction set (Misc) Uses Reverse Polish Notation
# SAL:
	_PUSH					: Pushes items on to the stack (top)
	_POP					: Pops items off the stack (top)
	_PEEK					: Views items on the stack (top)
	_WAIT					: Pauses execution of code
	_PAUSE					: Pauses execution of code
	_HALT					: HALT execution of code
	_RESUME					: Resumes execution of code
	_DUP					: Duplicates item on the stack (top)
	_JMP					: Jumps to location
	_JIF_T					: Jump if true
	_JIF_F					: Jump if False
	_JIF_EQ					: Jump if Equals
	_JIF_GT					: Jump if Greater than
	_JIF_LT					: Jump if Less than
	_LOAD					: Load Memory Address
	_STORE					: Store at memeory Address
	_REMOVE					: Removes item at memeory address so location can be free for replacement or updated item
	_CALL					: call location in memory
	_RET					: Return to location called
	_PRINT_M				: Prints to TextConsole Display
	_ADD					: Adds last two items on the stack
	_SUB					: subracts last two items on the stack
	_MUL					: multiplys last two items on the stack
	_DIV					: divides last two items on the stack
	_AND					: if both last two items on the stack are true
	_OR					: if either last two items on the stack are true
	_NOT					: if both last two items on the stack are not true
	_IS_EQ					: if both last two items on the stack are Equals
	_IS_GT					: both items are compared 
	_IS_GTE					: both items are compared 
	_IS_LT					: both items are compared 
	_IS_LTE					: both items are compared 
	_TO_POS					: number is sent to negative
	_TO_NEG					: number is sent to positive
	_INCR					: number is incremented by 1
	_DECR 					: number is Decremented by 2
	
The Current instruction Set Will Later include a memory register location system ; (after researching different models and implementations)( a vitual machine model based on this was created using a stack machine style. this will form the basis of my (Virtual Machine) - to be developed over time (maybe even format a virtual disk in the future)

### Small Programming Language

My Personal choice is BASIC as it has always been a favorite of mine ; as the psudeo code is basically the same as the real code which makes it very readable without the flurishing of mulitple brackets. Although there will be brackets for code boundrys as well as semi colons as end markers when required. 
Currently My older versions seem to be a bit more advanced (still primative) but the newest version (lexParseEval) will be a more correct model ; again only having the basics of the basic language; (not highly useful)- but still a learning tool(journey/Experience). 

Again as they are developed the function syntax will be displayed below; Currently the SPL will accept direct machine code instructions by flourishing the statement with a SAL: Tag; 

```
### SPL_LANG
spl_lang
45+5*7;
sal push 43 halt
a=34+5
a>b

At present the SPL can only accept maths (not evaluate) But the evaluate is nearly made ; 
```
### Targets The Current Implementation :
->Focused on implementing Binary Expressions as well as executing them from both languages. 
->The transplier will also transpile all code to be executed on the virtual machine . 
->Code will be able to be executed Statement by statement or as a block of code. 
->mathmatical functions and logic to be imeadiatly evaluated by the interpretor. transpiling sal code which can also be imediatly evealuated by the interpretor to return a result. 

