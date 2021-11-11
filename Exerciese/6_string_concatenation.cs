/* String concatenation allows you to combine smaller literal and variable strings into a single string.
   Avoid creating intermediate variables if adding them doesn't increase readability.
   To concatenate two strings together, you use the string concatenation operator, which is the plus symbol +. */


// Output: Hello Bob
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);


/* Concatenate multiple variables and literal strings.
   Output: Hello Bob! */
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

/* Avoiding intermediate variables.
   Output: Hello Bob! */
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");
