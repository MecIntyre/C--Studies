/* To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
   When calling a stateless method, you don't need to create a new instance of its class first.
   When calling a stateful method, you need to create an instance of the class, and access the method on the object.
   Use the new operator to create a new instance of a class.
   An instance of a class is called an object. */

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);


/* Methods may accept no parameters or multiple parameters, depending on how they were designed and implemented. 
   When passing in multiple input parameters, separate them with a , symbol.
   Methods may return a value when they complete their task, or they may return nothing (void).
   Overloaded methods support several implementations of the method, each with a unique method signature (the number of input parameters and the data type of each input parameter).
   Intellisense can help write code more quickly. 
   It provides a quick reference to methods, their return values, their overloaded versions, and the types of their input parameters.
   docs.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work. */


// Overload methods
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);


// Different overloads
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");