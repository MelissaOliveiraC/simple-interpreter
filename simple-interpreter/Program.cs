using VerySimpleInterpreter.Lexer;
using VerySimpleInterpreter;
using VerySimpleInterpreter.Parser;

var st = new SymbolTable();
var basicLexer = new BasicLexer("C:\\Users\\melis\\Documents\\GitHub\\Compiladores\\simple-interpreter\\docs\\example.lang", st);

var basicParser = new BasicParser(basicLexer, st);

Console.WriteLine("\n\n[Simple-Interpreter]\n\n>Output\n");
basicParser.Prog();

Console.WriteLine("\n___________________________________\nSymbol Table: \n\n");
Console.WriteLine(st);
Console.WriteLine("___________________________________\n");