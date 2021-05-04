# Small Programming Language

https://spydaz.github.io/SpydazWeb-AI-_Emulators/


This basic programming language is a project to learn how to build and design a programming  language from scratch.

**The Focus is on a type of Basic programming language format;**
### Small Programming Language

My Personal choice is BASIC as it has always been a favorite of mine ; as the psudeo code is basically the same as the real code which makes it very readable without the flourishing of multiple brackets. Although there will be brackets for code boundary as well as semi colons as end markers when required. 
Currently My older versions seem to be a bit more advanced (still primitive) but the newest version (lexParseEval) will be a more correct model ; again only having the basics of the basic language; (not highly useful)- but still a learning tool(journey/Experience). 

Again as they are developed the function syntax will be displayed below; Currently the SPL will accept direct machine code instructions by flourishing the statement with a SAL: Tag; 

## DESCRIPTION:
The program has been designed in stages ;

# The Lexer 
    This is a tokenizer which basically takes each token by using a grammar model to be used by the RegEx Searcher; These token produced give the position and the string that they have defined. 
    A lookAhead Function has been added to preview the token to be consumed next.  A record of tokens collected is also stored enabling for look back as well as Stepping backwards if required.
    
# The Parser
    This Parser consumes the tokens produced by the tokenizer and attempts to construct Abstract Syntax Tokens Which enable for the Interpreter to Evaluate or Transpile the code to another Programming language such as Assembly language to be run on a virtual CPU. 
    
# The Interpreter
    This component Takes the Abstract Syntax tokens produced and evaluates(Executes) the Code. Here the decision is made to execute on the virtual hardware or evaluate in memory to produce a result.





