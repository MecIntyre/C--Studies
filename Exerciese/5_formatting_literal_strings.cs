/* An escape character sequence is a special instruction to the runtime that you want to insert a special character 
   that will affect the output of your string. In C#, 
   the escape character sequences begin with a backslash \ and then include another character. 
   For example, the \n sequence will add a new line, and a \t sequence will add a tab. */

/* Output: Hello
           World!
           Hello   World! */
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");


// Output: Hello "World"!
Console.WriteLine("Hello \"World\"!");


/* What if you need to use the backslash for other purposes, like to display a file path?
   Console.WriteLine("c:\source\repos"); produces an error
   To solve the problem, you use the \\ to display a single backslash. */
Console.WriteLine("c:\\source\\repos");


/* A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. 
   To create a verbatim string, use the @ directive before the literal string.
   Output: c:\source\repos                      
      (this is where your code goes);     */
Console.WriteLine(@"   c:\source\repos   
      (this is where your code goes)");


/* You can also add encoded characters in literal strings using the \u escape sequence, 
   then a four-character code representing some character in Unicode (UTF-16).
   Output: Kon'nichiwa World */
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");