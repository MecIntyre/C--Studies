// String interpolation combines multiple values into a single literal string by using a "template" 
// and one or more interpolation expressions. 
// An interpolation expression is a variable surrounded by an opening and closing curly brace symbol { }. 
// The literal string becomes a template when it's prefixed by the $ character.


// instead of:
string message = greeting + " " + firstName + "!";

// interpolation
string message = $"{greeting} {firstName}!";


// Use string interpolation to combine a literal string and a variable value
// Output: Hello Bob!
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);


// Use string interpolation with multiple variables and literal strings
// Output: Hello Bob!
string firstName = "Bob";
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);


// Avoid intermediate variables
// Output: Hello Bob!
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");


// Combine verbatim literals and string interpolation
// Output: C:\Output\First-Project\Data
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");