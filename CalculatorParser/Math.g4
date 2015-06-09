grammar Math;

/*
 * Parser Rules
 */

compileUnit : expression EOF;

expression :
	LPAREN expression RPAREN #Parenthesized
	|expression EXPONENT expression #Exponent
    | expression operatorToken=(MULTIPLY | DIVIDE) expression #Multiplicative
	| expression operatorToken=(ADD | SUBTRACT) expression #Additive
	| NUMBER #Number
	; 

/*
 * Lexer Rules
 */

NUMBER : INT ('.' INT)?; 

INT : ('0'..'9')+;

EXPONENT : '^';
MULTIPLY : '*';
DIVIDE : '/';
SUBTRACT : '-';
ADD : '+';
LPAREN : '(';
RPAREN : ')';

WS : [ \t\r\n] -> channel(HIDDEN);