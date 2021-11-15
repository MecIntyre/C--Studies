/* There are many different kinds of expressions that evaluate to either true or false.
   Evaluate equality using the == operator.
   Evaluating equality of strings requires you consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
   Evaluate inequality using the != operator.
   Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
   If a method returns a bool, it can be used as a Boolean expression.
   Use the logical negation operator ! to evaluate the opposite of a given expression. */


// Output: True False False False True
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);
Console.WriteLine("a" == "a ");
string myValue = "a";
Console.WriteLine(myValue == "a");


/* Improve the check for string equality using the string's built-in helper methods
   Output: True */
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


/* Inequality operator
   Output: False True True False */
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);
string myValue = "a";
Console.WriteLine(myValue != "a");


/* Comparison operators
   Output: False True True True */
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


/* Method invocation expression
   Output: True False*/
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));


/* Logical Negation operator
   These two lines of code do the same thing: */
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));


//Output: False True
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));


/* Use the conditional operator when you need to add branching logic inline.
   Use the conditional operator when you need to return a value based on a binary condition ... 
   return this when true, return that when false.

   Basic of the ternary conditional operator (?:):
   <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

   Suppose you need to quickly determine if a customer's purchase is eligible for a promotional discount. 
   If the amount of the sale is greater than 1000, then discount the purchase by 100 dollars. 
   If the amount is 1000 or less, only discount the sale by 50 dollars.


   Output: Discount 100*/
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");


/* Conditional operator inline
   Output: Discount 100*/
int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

