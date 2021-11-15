/* You can perform mathematical-like addition operations on numbers.
   Both string concatenation and addition use the plus + symbol. 
   This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
   When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying 
   to concatenate the string representation of a number for presentation purposes.
   Use parentheses to define an order of operations to explicitly 
   tell the compiler that we want to perform certain operations before other operations. */

// Output: 19
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);


/* Mix data types to force implicit type conversions
   Output: Bob sold 7 widgets. */
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");


/* Attempt a more advanced case of adding numbers and concatenating strings
   Output: Bob sold 77 widgets. */
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");


/* Add parentheses to make our intention clear to the compiler
   Bob sold 14 widgets. */
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");